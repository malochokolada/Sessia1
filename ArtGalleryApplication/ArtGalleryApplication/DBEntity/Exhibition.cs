//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArtGalleryApplication.DBEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exhibition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exhibition()
        {
            this.Exposition = new HashSet<Exposition>();
        }
    
        public int ID { get; set; }
        public string ExhibitionName { get; set; }
        public string Place { get; set; }
        public System.DateTime Date { get; set; }
        public string Category { get; set; }
        public int Age_limit { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exposition> Exposition { get; set; }
    }
}
