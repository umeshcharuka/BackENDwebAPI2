using Dapper;
using Pro.domain.Pro.Domain;
using Pro.Repo.RepoBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro.Repo.Pro.Repo
{
  public class CustomerRepo: RepoBase<Customer>
    {

        public override IEnumerable<Customer> get()
        {

            try {
                using (IDbConnection cn=Connection) {

                    return cn.Query<Customer>("SP_Getallcustomers",commandType:CommandType.StoredProcedure);



                }

            }


            catch (Exception e)
            {

                throw e;


            }

        }

        public int saveCus(Customer Data) {


            try

            {

                using (IDbConnection cn=Connection) {

                return cn.Execute("SP_SaveALLCustomers", new { id = Data.Id, name = Data.name, Gender = Data.Gender, address = Data.address, Email = Data.Email }, commandType: CommandType.StoredProcedure);

       
                }



            }



            catch(Exception e)

            {
                throw e;

            }






        }


    }
}
