using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Shkembedjijnica.App.Core.Contracts;
using Shkembedjijnica.App.Core.DTOs;
using Shkembedjijnica.Data;

namespace Shkembedjijnica.App.Core.Controlers
{
    public class ManagerController : IManagerController
    {
        private readonly ShkembedjijnicaContext _context;

        public ManagerController(ShkembedjijnicaContext context)
        {
            this._context = context;
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
            manager.Employees.Add(employee);
            this._context.SaveChanges();
        }

        public ManagerDto GetManagerInfo(int employeeId)
        {
            var employee = this._context.Employees
                .Include(x => x.Employees)
                .Where(x => x.EmployeeId == employeeId)
                .ProjectTo<ManagerDto>()
                .SingleOrDefault();
            if (employee == null)
            {
                throw  new ArgumentException(Messages.InvalidId);
            }
            return employee;
        }
    }
}
