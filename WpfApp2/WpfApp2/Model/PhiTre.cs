//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp2.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhiTre
    {
        public int maPhiTre { get; set; }
        public int maPhieuTra { get; set; }
        public Nullable<double> tongTien { get; set; }
        public Nullable<bool> tinhTrangThanhToan { get; set; }
    
        public virtual PhieuTra PhieuTra { get; set; }
    }
}
