using PhotoStock.BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoStock.DataAccess.Interface
{
    public interface ICommentDA
    {
        Comment Get(int id);
        List<Comment> GetCommentByPhotoId(int photoId);
    }
}
