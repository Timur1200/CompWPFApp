//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComputerWPFApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Видеокарта
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Видеокарта()
        {
            this.Компьютер = new HashSet<Компьютер>();
        }
    
        public int Код { get; set; }
        public string Модель { get; set; }
        public Nullable<int> ОбъемВидеопамяти { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Компьютер> Компьютер { get; set; }
    }
}
