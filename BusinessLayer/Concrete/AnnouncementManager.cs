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
    public class AnnouncementManager : IAnnouncementService
    {

        IAnnouncementDal _announcement;

        public AnnouncementManager(IAnnouncementDal announcement)
        {
            _announcement = announcement;
        }

        public void TAdd(Announcement t)
        {
            _announcement.Insert(t);
        }

        public void TDelete(Announcement t)
        {
            _announcement.Delete(t);
        }

       
        public Announcement TGetById(int id)
        {
            return _announcement.GetByID(id);
        }

        public List<Announcement> TGetList()
        {
            return _announcement.GetList();
        }

        public List<Announcement> TGetListByFilter(string p)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Announcement t)
        {
            _announcement.Update(t);

        }
    }
}
