using PhotoStock.BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoStock.BusinessLogic.Interface
{
    public interface IPhotoBL
    {
        Photo Get(int id);
        List<Photo> GetPhotoByAlbumId(int albumId);
    }
}
