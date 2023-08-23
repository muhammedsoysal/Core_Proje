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
    public class AnnouncementManager : IAnnouncementDal
    {
        IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void Delete(Announcement t)
        {
            _announcementDal.Delete(t);
        }

        public List<Announcement> GetByFilter(Expression<Func<Announcement, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Announcement GetByID(int id)
        {
            return _announcementDal.GetByID(id);
        }

        public List<Announcement> Getlist()
        {
            return _announcementDal.Getlist();
        }

        public void Insert(Announcement t)
        {
            _announcementDal.Insert(t);
        }

        public void Update(Announcement t)
        {
            _announcementDal.Update(t);
        }
    }
}
