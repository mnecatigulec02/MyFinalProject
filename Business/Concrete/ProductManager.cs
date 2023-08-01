using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _iProductDal;

        public ProductManager(IProductDal iProductDal)
        {
            _iProductDal = iProductDal;
        }

        public List<Product> GetAll()
        {
           return _iProductDal.GetAll();
        }

        public List<Product> GetAllByCategoryID(int id)
        {
            return _iProductDal.GetAll(p=>p.CategoryID == id);
        }

        public List<Product> GetAllByUnitPrice(decimal min, decimal max)
        {
            return _iProductDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
    }
}
