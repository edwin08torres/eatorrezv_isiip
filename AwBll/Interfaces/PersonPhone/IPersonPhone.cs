using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entiies.PersonPhone;

namespace AwBll.Interfaces.PersonPhone
{
    public interface IPersonPhone
    {
        Task<List<PersonPhoneCl>> GetAll();
        Task<int> Create(string categoryName);
        Task<PersonPhoneCl> GetById(int categoryId);
        Task<PersonPhoneCl> Save(string categoryName);
    }
}
