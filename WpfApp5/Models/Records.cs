//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Records
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Records()
        {
            this.Checks = new HashSet<Checks>();
        }
    
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int TableId { get; set; }
        public System.TimeSpan VisitTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Checks> Checks { get; set; }
        public virtual Clients Clients { get; set; }
        public virtual Tables Tables { get; set; }
    }
}