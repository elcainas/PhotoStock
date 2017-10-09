using PhotoStock.BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoStock.DataAccess.Interface
{
    public interface IAlbumDA
    {
        List<Album> Get(int? id);
    }
}
