//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinanceSystem.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int ID { get; set; }
        public System.DateTime DateTransaction { get; set; }
        public int IDStudent { get; set; }
        public decimal Scholarship { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
