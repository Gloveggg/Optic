//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Optic.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int Id { get; set; }
        public Nullable<int> IdUsers { get; set; }
        public Nullable<int> IdGlasses { get; set; }
        public Nullable<int> IdDiopterLeftEyes { get; set; }
        public Nullable<int> IdDiopterRightEyes { get; set; }
        public string Phone { get; set; }
        public string Comment { get; set; }
    
        public virtual Glasses Glasses { get; set; }
        public virtual Users Users { get; set; }
    }
}
