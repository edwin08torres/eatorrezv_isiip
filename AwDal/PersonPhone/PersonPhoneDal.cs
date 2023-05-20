using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entiies.PersonPhone;
using System.Data.SqlClient;
using System.Data;
using Common.RunTime;


using AwDal.Common;

namespace AwDal.PersonPhone
{
    public class PersonPhoneDal: AwBaseDal
    {
        public PersonPhoneDal(string connectionString) : base(connectionString)
        {
        }

        public List<PersonPhoneCl> GetAll()
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            SqlCommand command = new()
            {
                Connection = conn,
                CommandText = "Person.uspGetPersonPhone",
                CommandType = CommandType.StoredProcedure
            };

            DataTable dt = new();
            SqlDataAdapter adapter = new(command);
            adapter.Fill(dt);

            var query = dt.AsEnumerable().Select(x => new ProductCategory
            {
                ProductCategoryID = Convert.ToInt32(x["ProductCategoryID"]),
                Name = Convert.ToString(x["Name"]),
                rowguid = new Guid(Convert.ToString(x["rowguid"])),
                ModifiedDate = Convert.ToDateTime(x["ModifiedDate"])
            });

            return query.ToList();
        }
    }
}
