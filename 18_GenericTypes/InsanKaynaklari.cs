using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _18_GenericTypes
{
    //default Internal Erişim belirteci alır
    internal class InsanKaynaklari : Personel,IPersonel<InsanKaynaklari>
    {
        public int PersonelSayisi { get; set; }

        public void Delete(InsanKaynaklari entity)
        {
            throw new NotImplementedException();
        }

        public InsanKaynaklari Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(InsanKaynaklari entity)
        {
            throw new NotImplementedException();
        }

        public List<InsanKaynaklari> List(Expression<Func<InsanKaynaklari, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(InsanKaynaklari entity)
        {
            throw new NotImplementedException();
        }

        List<InsanKaynaklari> IPersonel<InsanKaynaklari>.List()
        {
            throw new NotImplementedException();
        }
    }
}
