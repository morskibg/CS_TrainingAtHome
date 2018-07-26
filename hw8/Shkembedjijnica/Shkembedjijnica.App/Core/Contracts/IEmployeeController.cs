using System;
using System.Collections.Generic;
using Shkembedjijnica.App.Core.DTOs;

namespace Shkembedjijnica.App.Core.Contracts
{
    public interface IEmployeeController    
    {
        void AddEmployee(EmployeeDto employeeDto);
        void SetBirthday(int employeeId, DateTime birthdate);
        void SetAddress(int employeeId, string address);
        EmployeeDto GetEmployeeInfo(int employeeId);
        EmployeeFullInfoDto GetEmployeePersonalInfo(int employeeId);
        void Exit();
        ICollection<AgeComparingEmployeeDto> GetListEmployeesOlderThan(int age);
    }
}
