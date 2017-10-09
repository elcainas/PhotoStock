using PhotoStock.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoStock.BusinessLogic.Entities;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace PhotoStock.DataAccess
{
    public class AlbumDA : IAlbumDA
    {
        readonly string url = "https://jsonplaceholder.typicode.com/albums";
        public List<Album> Get(int? id)
        {
            var list = ReadJson<Album>.GetObjects(url);
            return id == null ? list : list.Where(x => x.Id == id).ToList();
        }
    }
}
