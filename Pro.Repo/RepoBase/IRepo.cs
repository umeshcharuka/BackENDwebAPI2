using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro.Repo.RepoBase
{
    interface IRepo<T>where T:class
    {
        IEnumerable<T> get();
        void save(T obj);

        void delete();

    }
}
