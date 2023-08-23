using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PortfolioManager : IPortfolioService
    {
        EfPortfolioDal _portfoliDal;

        public PortfolioManager(EfPortfolioDal portfoliDal)
        {
            _portfoliDal = portfoliDal;
        }

        public void TAdd(Portfolio t)
        {
            _portfoliDal.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
            _portfoliDal.Delete(t);
        }

        public Portfolio TGetByID(int id)
        {
            return _portfoliDal.GetByID(id);
        }

        public List<Portfolio> TGetList()
        {
            return _portfoliDal.Getlist();
        }

        public List<Portfolio> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Portfolio t)
        {
            _portfoliDal.Update(t);
        }
    }
}
