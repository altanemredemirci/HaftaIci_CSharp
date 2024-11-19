using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _18_GenericTypes
{
    internal class BilgiIslem : Personel,IPersonel<BilgiIslem>
    {
        public int ProgramSayisi { get; set; }

        public void Delete(BilgiIslem entity)
        {
            throw new NotImplementedException();
        }

        public BilgiIslem Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(BilgiIslem entity)
        {
            throw new NotImplementedException();
        }

        public List<BilgiIslem> List(Expression<Func<BilgiIslem, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public List<BilgiIslem> List()
        {
            throw new NotImplementedException();
        }

        public void Update(BilgiIslem entity)
        {
            throw new NotImplementedException();
        }

        
    }
}
