using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoStock.BusinessLogic.Entities
{
    public class Photo
    {
        public int AlbumId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        public string Url { get; set; }
        public string ThumbnailUrl { get; set; }
    }
}
