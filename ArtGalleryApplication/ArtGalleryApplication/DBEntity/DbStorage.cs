using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGalleryApplication.DBEntity
{
    public static class DbStorage
    {
        public static ArtGalleryEntities DB_s { get; set; } = new ArtGalleryEntities();
    }
}
