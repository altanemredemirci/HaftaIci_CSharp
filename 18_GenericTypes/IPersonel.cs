using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _18_GenericTypes
{
    internal interface IPersonel<T> where T : class 
    {
        // T : Generic Type => Veri tiplerinin hepsini kapsayan anlamına gelir.Yani Kayit methodu parametre olarak veritipi InsanKaynaklari,BilgiIslem,Pazarlama,Muhasebe vb yapıları alabilir.

        // where T : class  => T type nın class olma zorunluluğu tanımlandı.

        public void Insert(T entity); 
        public void Update(T entity); 
        public void Delete(T entity); 
        public List<T> List();
        public List<T> List(Expression<Func<T,bool>> expression);
        public T Find(int id);
    }
}
