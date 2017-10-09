using PhotoStock.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoStock.BusinessLogic.Entities;

namespace PhotoStock.DataAccess
{
    public class CommentDA : ICommentDA
    {
        readonly string url = "https://jsonplaceholder.typicode.com/comments";

        public Comment Get(int id)
        {
            var list = ReadJson<Comment>.GetObjects(url);
            return list.FirstOrDefault(x => x.Id == id);
        }

        public List<Comment> GetCommentByPhotoId(int photoId)
        {
            var list = ReadJson<Comment>.GetObjects(url);
            return list.Where(x => x.PostId == photoId).ToList();
        }
    }
}
