//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------

namespace QLKS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTinhTrangPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTinhTrangPhong()
        {
            this.tblPhongs = new HashSet<tblPhong>();
        }
    
        public int ma_tinh_trang { get; set; }
        public string mo_ta { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPhong> tblPhongs { get; set; }
    }
}
