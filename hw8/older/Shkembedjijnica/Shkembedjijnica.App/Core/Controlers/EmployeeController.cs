using System;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Shkembedjijnica.App.Core.Contracts;
using Shkembedjijnica.App.Core.DTOs;
using Shkembedjijnica.Data;
using Shkembedjijnica.Models;

namespace Shkembedjijnica.App.Core.Controlers
{
    public class EmployeeController : IEmployeeController
    {
        private readonly ShkembedjijnicaContext _context;
        private readonly IMapper _mapper;
        public EmployeeController(ShkembedjijnicaContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        } 

        public void AddEmployee(EmployeeDto employeeDto)
        {
            var employee = _mapper.Map<Employee>(employeeDto);
            _context.Employees.Add(employee);
            this._context.SaveChanges();
        }

        public void SetBirthday(int employeeId, DateTime birthdate)
        {
            var employee = _context.Employees.Find(employeeId);
            if (employee == null)
            {
                throw new ArgumentException();
            }

            employee.Birthdate = birthdate;
            this._context.SaveChanges();
        }

        public void SetAddress(int employeeId, string address)
        {
            var employee = _context.Employees.Find(employeeId);
            if (employee == null)
            {
                throw new ArgumentException(Messages.InvalidId);
            }

            employee.Address = address;
            this._context.SaveChanges();
        }

        public EmployeeDto GetEmployeeInfo(int employeeId)
        {
            var employee = _context.Employees
                .Where(x => x.EmployeeId == employeeId)
                .ProjectTo<EmployeeDto>()
                .SingleOrDefault();
            if (employee == null)
            {
                throw new ArgumentException(Messages.InvalidId);
            }
            return employee;
        }

        public EmployeeFullInfoDto GetEmployeePersonalInfo(int employeeId)
        {
            var employee = _context.Employees
                .Where(x => x.EmployeeId == employeeId)
                .ProjectTo<EmployeeFullInfoDto>()
                .SingleOrDefault();
            if (employee == null)
            {
                throw new ArgumentException(Messages.InvalidId);
            }
            return employee;
        }

        public void Exit()
        {
            Console.WriteLine("Are You sure ?(Y/N)");
            var answer = Console.ReadLine();
            if (answer == "Y" || answer == "y")
            {
                Environment.Exit(0);
                
            }
            
        }

        public string ListEmployeesOlderThan(int age)
        {
            //var employees = _context.Employees.Where(x => DateTime.Now - x.Birthdate.Value > age)
            return null;
        }
    }
}
