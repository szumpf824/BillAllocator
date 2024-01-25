using BillScheduler.Domain.Entities;
using BillScheduler.Domain.Interfaces.Application;
using BillScheduler.Domain.Interfaces.Common;
using BillScheduler.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Logging;

namespace BillScheduler.Application.Services
{
    //Add, remove, edit or view all bills in a repository
    //notify/raise new ActivityChange Event (TBD), which will update all needed things/objects if the status is scheduled
    public class BillService : IBillService, IBaseService<Bill>
    {
        private ILogger<BillService> logger;
        private IBillRepository _billRepository;

        public BillService(IBillRepository billRepository, ILogger<BillService> log)
        {
            _billRepository = billRepository;
            logger = log;
        }

        public void Add<T>(T billToAdd)
        {
            //first validate that the bill does not exist, then add/save it
        }

        public void Delete(string billName)
        {
        }

        public void Edit<T>(T billToEdit)
        {
            //make sure it exists first
        }

        public List<Bill> View()
        {
            return null;
        }
    }
}