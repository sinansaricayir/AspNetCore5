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
    public class SocialMediaManager : ISocialMediaService
    {

        ISocialMediaDal _socialMedia;

        public SocialMediaManager(ISocialMediaDal socialMedia)
        {
            _socialMedia = socialMedia;
        }

        public void TAdd(SocialMedia t)
        {
            _socialMedia.Insert(t);
        }

        public void TDelete(SocialMedia t)
        {
            _socialMedia.Delete(t);
        }

        

        public SocialMedia TGetById(int id)
        {
            return _socialMedia.GetByID(id);
        }

        public List<SocialMedia> TGetList()
        {
            return _socialMedia.GetList();
        }

        public List<SocialMedia> TGetListByFilter(string p)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SocialMedia t)
        {
            _socialMedia.Update(t);
        }
    }
}
