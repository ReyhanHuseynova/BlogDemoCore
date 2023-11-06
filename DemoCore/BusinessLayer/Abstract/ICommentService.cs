using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ICommentService
	{
		void CommentAdd(Comment comment);
		//void Delete(Comment c);
		//void Update(Comment c);
		List<Comment> GetList(int id);
		//Comment GetById(int id);
	}
}
