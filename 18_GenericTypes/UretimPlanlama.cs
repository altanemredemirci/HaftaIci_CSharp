using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _18_GenericTypes
{
    internal class UretimPlanlama : Personel, IPersonel<UretimPlanlama>
    {
        public int UretimSuresi { get; set; }

        public void Delete(UretimPlanlama entity)
        {
            throw new NotImplementedException();
        }

        public UretimPlanlama Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(UretimPlanlama entity)
        {
            throw new NotImplementedException();
        }

        public List<UretimPlanlama> List()
        {
            throw new NotImplementedException();
        }

        public List<UretimPlanlama> List(Expression<Func<UretimPlanlama, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(UretimPlanlama entity)
        {
            throw new NotImplementedException();
        }
    }
}
