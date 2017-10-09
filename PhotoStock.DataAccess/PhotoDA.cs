using PhotoStock.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoStock.BusinessLogic.Entities;

namespace PhotoStock.DataAccess
{
    public class PhotoDA : IPhotoDA
    {
        readonly string url = "https://jsonplaceholder.typicode.com/photos";
        public Photo Get(int id)
        {
            var list = ReadJson<Photo>.GetObjects(url);
            return list.FirstOrDefault(x => x.Id == id);
        }

        public List<Photo> GetPhotoByAlbumId(int albumId)
        {
            var list = ReadJson<Photo>.GetObjects(url);
            return list.Where(x => x.AlbumId == albumId).ToList();
        }
    }
}
