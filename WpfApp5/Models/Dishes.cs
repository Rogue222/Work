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
    
    public partial class Dishes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dishes()
        {
            this.Orders = new HashSet<Orders>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int Gramming { get; set; }
        public decimal Price { get; set; }
        public string Сomposition { get; set; }
        public int DishTypeId { get; set; }
    
        public virtual DishTypes DishTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
