﻿using SampleApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SampleApp.Repository
{
    public interface IEmployeeRepository
    {
        Task<List<EmployeeModel>> GetAllEmployees(EmployeeQueryParameters parameters);
        Task<EmployeeModel> GetEmployeeById(Guid id);
        Task<EmployeeModel> AddEmployee(EmployeeModel employeeModel);
        Task<EmployeeModel> UpdateEmployee(EmployeeModel employeeModel);
        Task<bool> RemoveEmployee(EmployeeModel employee);
    }
}
