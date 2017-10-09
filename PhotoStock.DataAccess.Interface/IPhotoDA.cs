using PhotoStock.BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoStock.DataAccess.Interface
{
    public interface IPhotoDA
    {
        Photo Get(int id);
        List<Photo> GetPhotoByAlbumId(int albumId);
    }
}
