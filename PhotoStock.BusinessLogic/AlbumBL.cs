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
    public class AlbumBL : IAlbumBL
    {
        private AlbumDA AlbumDA { get; set; }
        public AlbumBL()
        {
            AlbumDA = new AlbumDA();
        }
        public List<Album> Get(int? id = null)
        {
            return AlbumDA.Get(id);
        }
    }
}
