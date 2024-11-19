using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _18_GenericTypes
{
    internal class Pazarlama : Personel, IPersonel<Pazarlama>
    {
        public int TeklifSayisi { get; set; }


        public void Delete(Pazarlama entity)
        {
            throw new NotImplementedException();
        }

        public Pazarlama Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pazarlama> List(Expression<Func<Pazarlama, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(Pazarlama entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(Pazarlama entity)
        {
            throw new NotImplementedException();
        }

        public List<Pazarlama> List()
        {
            throw new NotImplementedException();
        }
    }
}
