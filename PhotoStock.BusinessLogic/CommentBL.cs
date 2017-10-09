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
    public class CommentBL : ICommentBL
    {
       private CommentDA CommentDA { get; set; }
        public CommentBL()
        {
            CommentDA = new CommentDA();
        }
       
        public Comment Get(int id)
        {
            return CommentDA.Get(id);
        }

        public List<Comment> GetCommentByPhotoId(int photoId)
        {
            return CommentDA.GetCommentByPhotoId(photoId);
        }
    }
}
