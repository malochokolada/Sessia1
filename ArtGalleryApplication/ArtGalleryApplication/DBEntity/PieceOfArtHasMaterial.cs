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
    
    public partial class PieceOfArtHasMaterial
    {
        public int ID { get; set; }
        public Nullable<int> PieceOfArt { get; set; }
        public Nullable<int> Material { get; set; }
    
        public virtual Material Material1 { get; set; }
        public virtual PieceOfArt PieceOfArt1 { get; set; }
    }
}
