using PhotoStock.BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoStock.Web.Models
{
    public class AlbumViewModel
    {
        public Album Album { get; set; }
        public List<Photo> Photos { get; set; }
    }
}