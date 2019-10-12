using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for RentView.xaml
    /// </summary>
    public partial class RentView : UserControl
    {
        //DiaBdDataContext db = new DiaBdDataContext();
        List<KhachHang> KhachHangs = new List<KhachHang>();
        public List<KhachHang> ListCus { get; set; }
        public List<PhiTre> ListPhiTre { get; set; }

        QLDiaEntities _db = new QLDiaEntities();

        public RentView()
        {
            InitialCustomer();
            InitializeComponent();
        }

        void InitialCustomer()
        {
            ListCus = _db.KhachHang.Where(x => x.maKhachHang != 0).ToList();
        }

    }
}
