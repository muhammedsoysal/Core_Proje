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
    public class WriterUserManager : IWriterUserDal
    {
        IWriterUserDal _writerUserDal;

        public WriterUserManager(IWriterUserDal writerUserDal)
        {
            _writerUserDal = writerUserDal;
        }

        public void Delete(WriterUser t)
        {
            throw new NotImplementedException();
        }

        public List<WriterUser> GetByFilter(Expression<Func<WriterUser, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public WriterUser GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<WriterUser> Getlist()
        {
            return _writerUserDal.Getlist();
        }

        public void Insert(WriterUser t)
        {
            throw new NotImplementedException();
        }

        public void Update(WriterUser t)
        {
            throw new NotImplementedException();
        }

    }
}
