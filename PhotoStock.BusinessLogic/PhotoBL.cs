using PhotoStock.BusinessLogic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoStock.BusinessLogic.Entities;
using PhotoStock.DataAccess;

namespace PhotoStock.BusinessLogic
{
    public class PhotoBL : IPhotoBL
    {
        private PhotoDA PhotoDA { get; set; }
        public PhotoBL()
        {
            PhotoDA = new PhotoDA();
        }
        public Photo Get(int id)
        {
            return PhotoDA.Get(id);
        }

        public List<Photo> GetPhotoByAlbumId(int albumId)
        {
            return PhotoDA.GetPhotoByAlbumId(albumId);
        }
    }
}
