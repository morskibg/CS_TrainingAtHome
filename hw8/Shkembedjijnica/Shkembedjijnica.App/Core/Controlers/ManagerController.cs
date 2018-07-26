using System;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Shkembedjijnica.App.Core.Contracts;
using Shkembedjijnica.App.Core.DTOs;
using Shkembedjijnica.Data;


namespace Shkembedjijnica.App.Core.Controlers
{
    public class ManagerController : IManagerController
    {
        private readonly ShkembedjijnicaContext _context;
        private readonly IMapper _mapper;
        public ManagerController(ShkembedjijnicaContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
        public void AddManager(int employeeId, int managerId)
        {
            var manager = this._context.Employees.Find(managerId);
            var employee = this._context.Employees.Find(employeeId);
            if (manager == null || employee == null)
            {
                throw new ArgumentException(Messages.InvalidId);
            }
            employee.ManagerId = managerId;
            manager.EmployeesManager.Add(employee);
            this._context.SaveChanges();
        }

        public ManagerDto GetManagerInfo(int employeeId)
        {
            //var employee = this._context.EmployeesManager
            //    .Include(x => x.EmployeesManager)
            //    .Where(x => x.EmployeeId == employeeId)
            //    .ProjectTo<ManagerDto>()
            //    .SingleOrDefault();
            var manager = this._context
                .Employees
                .Include(x => x.EmployeesManager)
                .FirstOrDefault(x => x.EmployeeId == employeeId);
            if (manager == null)
            {
                throw  new ArgumentException(Messages.InvalidId);
            }

            var managerDto = this._mapper.Map<ManagerDto>(manager);
            return managerDto;
        }
    }
}
