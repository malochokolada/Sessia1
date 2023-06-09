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
    
    public partial class PieceOfArt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PieceOfArt()
        {
            this.Exposition = new HashSet<Exposition>();
            this.PieceOfArtHasMaterial = new HashSet<PieceOfArtHasMaterial>();
            this.PieceOfArtHasGenre = new HashSet<PieceOfArtHasGenre>();
            this.PieceOfArtHasTechnique = new HashSet<PieceOfArtHasTechnique>();
            this.PieceOfArtHasStile = new HashSet<PieceOfArtHasStile>();
        }
    
        public int ID { get; set; }
        public int Picture { get; set; }
        public string NameOfArt { get; set; }
        public Nullable<int> Years { get; set; }
        public int Artist { get; set; }
        public string Description { get; set; }
    
        public virtual Artist Artist1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exposition> Exposition { get; set; }
        public virtual Picture Picture1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PieceOfArtHasMaterial> PieceOfArtHasMaterial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PieceOfArtHasGenre> PieceOfArtHasGenre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PieceOfArtHasTechnique> PieceOfArtHasTechnique { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PieceOfArtHasStile> PieceOfArtHasStile { get; set; }
    }
}
