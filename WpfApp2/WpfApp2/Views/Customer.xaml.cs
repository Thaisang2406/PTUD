using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp2.Model;

namespace WpfApp2.Views
{
    /// <summary>
    /// Interaction logic for Customer.xaml
    /// </summary>
    public partial class Customer : UserControl
    {
        RegExr re = new RegExr();
        QLDiaEntities _db = new QLDiaEntities();

        public List<KhachHang> KhachHangs { get; set; }


        public Customer()
        {
            KhachHangs = _db.KhachHang.ToList();
            DataContext = this;

            InitializeComponent();
        }
        void isReadOnly(bool e)
        {

            txtSDT.IsReadOnly =
            txtTen.IsReadOnly =
            txtCMND.IsReadOnly =
            txtDiaChi.IsReadOnly = e;
        }

        void Clear()
        {
            txtTen.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtMaKH.Text = "";
            txtCMND.Text = "";

            btnCancel.Visibility = Visibility.Hidden;
            btnSave.Visibility = Visibility.Hidden;
            btnAddCustomer.Visibility = Visibility.Visible;
        }

        private void BtnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            isReadOnly(false);
            btnAddCustomer.Visibility = Visibility.Collapsed;

            btnSave.Visibility = Visibility.Visible;
            btnCancel.Visibility = Visibility.Visible;
            int index = 0;
            try
            {
                index = int.Parse(((Button)e.Source).Uid);
            }
            catch (Exception)
            {
                //index = int.Parse(((PackIcon)e.Source).Uid);
            }

            switch (index)
            {
                case 0:
                    Application.Current.Resources["isAddKh"] = Visibility.Visible;
                    break;
            }


        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Regex regex = new Regex(@"^0{1}\d{9}$");
                Regex regexName = new Regex(@"(^(\w){2,8}\s+(\w){1,8})$");

                if (!re.SoDienThoai(txtSDT.Text.Trim()))
                {
                    MessageBox.Show("SDT không hợp lệ");
                    txtSDT.Clear();
                    txtSDT.Focus();
                    return;
                }
                if (!re.HoTen(txtTen.Text.TrimEnd()))
                {
                    MessageBox.Show("Tên không hợp lệ");
                    txtTen.Focus();
                    return;
                }

                if (txtMaKH.Text == "")
                {
                    if (_db.KhachHang.Any(x => x.soDienThoai == txtSDT.Text.Trim()))
                    {
                        MessageBox.Show("SDT đã tồn tại");
                        txtSDT.Clear();
                        txtSDT.Focus();
                        return;
                    }

                    KhachHang cus = new KhachHang();
                    cus.hoTen = txtTen.Text;
                    cus.soDienThoai = txtSDT.Text;
                    cus.diaChi = txtDiaChi.Text;
                    cus.soCMND = txtCMND.Text;

                    _db.KhachHang.Add(cus);
                    _db.SaveChanges();

                    KhachHangs = _db.KhachHang.ToList();
                    grvCustomer.ItemsSource = KhachHangs;
                    isReadOnly(true);
                    Clear();
                }
                else
                {
                    if (int.TryParse(txtMaKH.Text.Trim(), out int idKH))
                    {
                        var khachhang = _db.KhachHang.FirstOrDefault(x => x.maKhachHang == idKH);

                        khachhang.diaChi = txtDiaChi.Text.Trim();
                        khachhang.soDienThoai = txtSDT.Text.Trim();
                        khachhang.hoTen = txtTen.Text.Trim();
                        khachhang.soCMND = txtCMND.Text.Trim();

                        _db.Entry(khachhang).State = System.Data.Entity.EntityState.Modified;
                        _db.SaveChanges();

                        KhachHangs = _db.KhachHang.ToList();
                        grvCustomer.ItemsSource = KhachHangs;
                        isReadOnly(true);
                        Clear();
                        btnSave.Visibility = Visibility.Hidden;
                        btnCancel.Visibility = Visibility.Hidden;
                        btnAddCustomer.Visibility = Visibility.Visible;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            isReadOnly(true);
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {

            btnAddCustomer.Visibility = Visibility.Hidden;
            btnSave.Visibility = Visibility.Visible;
            btnCancel.Visibility = Visibility.Visible;

            isReadOnly(false);
            txtTen.Focus();

        }

        private void GrvCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //btnAddCustomer.Visibility = Visibility.Hidden;
            //btnSave.Visibility = Visibility.Visible;
            //btnCancel.Visibility = Visibility.Visible;

            if (grvCustomer.SelectedItem is KhachHang)
            {
                var cus = grvCustomer.SelectedItem as KhachHang;

                txtMaKH.Text = cus.maKhachHang.ToString();
                txtSDT.Text = cus.soDienThoai;
                txtDiaChi.Text = cus.diaChi;
                txtCMND.Text = cus.soCMND;
                txtTen.Text = cus.hoTen;
                txtSearch.Text = "";
            }

           
        }
    }
}
