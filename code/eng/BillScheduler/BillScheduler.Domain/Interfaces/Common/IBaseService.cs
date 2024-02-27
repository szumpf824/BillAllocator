using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillScheduler.Domain.Interfaces.Common
{
    //Interface to use for the services that perform the same functions
    public interface IBaseService<T> where T: IDomainEntity
    {
        void Add<T>(T item);
        void Edit<T>(T item);
        void Delete(string name);
        List<T> View();
    }
}
