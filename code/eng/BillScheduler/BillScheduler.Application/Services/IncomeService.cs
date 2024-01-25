using BillScheduler.Domain.Entities;
using BillScheduler.Domain.Interfaces.Application;
using BillScheduler.Domain.Interfaces.Common;
using BillScheduler.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Logging;

namespace BillScheduler.Application.Services
{
    public class IncomeService : IIncomeService, IBaseService<Income>
    {
        private ILogger<IncomeService> logger;
        private IIncomeRepository _incomeRepository;

        public IncomeService(IIncomeRepository incomeRepository, ILogger<IncomeService> log)
        {
            _incomeRepository = incomeRepository;
            logger = log;
        }

        public void Add<T>(T item)
        {
            var income = item as Income;
        }

        public void Delete(string name)
        {
            throw new NotImplementedException();
        }

        public void Edit<T>(T item)
        {
            var income = item as Income;
        }

        public List<Income> View()
        {
            throw new NotImplementedException();
        }
    }
}