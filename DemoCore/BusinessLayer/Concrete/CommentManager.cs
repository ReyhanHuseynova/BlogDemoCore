using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CommentManager : ICommentService
	{
		ICommentDal _comdal;
        public CommentManager(ICommentDal comdal)
        {
            _comdal = comdal;
        }
        public void CommentAdd(Comment comment)
		{
			_comdal.Insert(comment);
		}

		public List<Comment> GetList(int id)
		{
			return _comdal.GetListAll(x=>x.BlogID==id);
		}
	}
}
