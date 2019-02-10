using Pro.Repo.RepoBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace Pro.Repo.RepoBase
{
    public abstract class RepoBase<T> : IRepo<T> where T:class
    {
        public virtual void delete()
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> get()
        {
            throw new NotImplementedException();
        }

        public virtual void save(T obj)
        {
            throw new NotImplementedException();
        }

        internal IDbConnection Connection{

            get{
                SqlConnection con = new SqlConnection(
        WebConfigurationManager.ConnectionStrings["ConnStringDb1"].ConnectionString);
                return con;
            }
          
        }
    }
}
