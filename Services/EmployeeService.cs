
using EMS.Core.Models;
using EMS.Core.Interfaces;

namespace EMS.Services
{
    public class EmployeeService: IEmployeeService
    {
        private readonly IEmployeeService _employeeRepository;

        public EmployeeService(IEmployeeService employeeRepository){
            _employeeRepository = employeeRepository;
        }

        public void AddEmployee(Employee employee) {

            // appliquer une validation ou une logique supplementaire avant d'ajouter l'employee
            _employeeRepository.AddEmployee(employee);
        }

    }
}