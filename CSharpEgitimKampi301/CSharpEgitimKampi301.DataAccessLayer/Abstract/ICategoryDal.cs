using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampi301.EntityLayer.Concrete;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>  // Bu benim artık Category sınıfı için ekleme, silme, güncelleme ve listeleme işlemlerini hazır hale getirmiş olduğum anlamına geliyor.
    {
    }
}
