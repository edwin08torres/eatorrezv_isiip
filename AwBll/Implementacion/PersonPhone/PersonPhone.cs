using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AwBll.Interfaces.PersonPhone;
using Entiies.PersonPhone;

using Microsoft.Extensions.Configuration;


namespace AwBll.Implementacion.PersonPhone
{
    public class PersonPhone : IPersonPhone
    {
        private readonly IConfiguration 

        public Task<List<PersonPhoneCl>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> Create(string categoryName)
        {
            throw new NotImplementedException();
        }

        public Task<PersonPhoneCl> GetById(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<PersonPhoneCl> Save(string categoryName)
        {
            throw new NotImplementedException();
        }
    }
}
