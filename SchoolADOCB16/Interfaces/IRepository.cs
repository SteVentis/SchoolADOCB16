using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.RepositoryServices
{
    interface IRepository<T>
    {
        void Create();
        T Read(int id);
        List<T> GetListOf();
        void Update(int id);
        void Delete(int id);
    }
}
