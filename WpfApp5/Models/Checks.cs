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
    
    public partial class Checks
    {
        public int Id { get; set; }
        public int RecordId { get; set; }
        public decimal GuestBill { get; set; }
        public int PaymentMethodId { get; set; }
        public int StatusId { get; set; }
        public decimal BonusesReceived { get; set; }
    
        public virtual PaymentMethods PaymentMethods { get; set; }
        public virtual Records Records { get; set; }
        public virtual Statuses Statuses { get; set; }
    }
}
