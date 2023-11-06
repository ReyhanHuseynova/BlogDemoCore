using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMesssageDal _messsageDal;
        public MessageManager(IMesssageDal messsageDal)
        {
            _messsageDal= messsageDal;  
        }
        public List<Message> GetList()
        {
            return _messsageDal.GetListAll();
        }

        public List<Message> GetInboxListByWriter(string p)
        {
            return _messsageDal.GetListAll(x=>x.Receiver==p);
        }

        public void TAdd(Message t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Message t)
        {
            throw new NotImplementedException();
        }

        public Message TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
