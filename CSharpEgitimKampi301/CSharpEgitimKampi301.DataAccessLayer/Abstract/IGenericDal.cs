using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class  // Sen dışarıdan bir T değeri alacaksın ve bu T değeri mutlaka bir class olmalı. Böylece buraya dışarıdan harici bir interface, method vs gelemeyecek sadece class'lar ile çalışmış olacağız.
    {   // Buradaki T değeri sırasıyla bizim bütün entity'lerimiz olacak. Customer, Order, Product...
        void Insert(T entity);
        void update(T entity);
        void Delete(int id);
        List<T> GetAll();
        T GetById(int id);
    }
}
