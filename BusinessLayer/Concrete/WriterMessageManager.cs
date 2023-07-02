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
    public class WriterMessageManager : IWriterMessageService
    {

        IWriterMessageDal _writerMessageDal;

        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _writerMessageDal = writerMessageDal;
        }

        public List<WriterMessage> GetListReceiverMessage(string p)
        {
            return _writerMessageDal.GetListByFilter(x => x.Reciever == p);
        }

        public List<WriterMessage> GetListSenderMessage(string p)
        {
            return _writerMessageDal.GetListByFilter(x => x.Sender == p);
        }

        public void TAdd(WriterMessage t)
        {
            _writerMessageDal.Insert(t);
        }

        public void TDelete(WriterMessage t)
        {
            _writerMessageDal.Delete(t);
        }

        public WriterMessage TGetById(int id)
        {
            return _writerMessageDal.GetByID(id);
        }

        public List<WriterMessage> TGetList()
        {
            return _writerMessageDal.GetList();
        }

        public List<WriterMessage> TGetListByFilter(string p)
        {
            throw new NotImplementedException();
        }

        //public List<WriterMessage> TGetListByFilter(string p)
        //{
        //    return _writerMessageDal.GetListByFilter(x => x.Reciever == p);
        //}

        public void TUpdate(WriterMessage t)
        {
            _writerMessageDal.Update(t);
        }
    }
}
