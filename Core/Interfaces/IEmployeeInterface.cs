

using EMS.Core.Models;

namespace EMS.Core.Interfaces
{

// EmployeeRepository est responsable des opérations d'accès aux données liées aux employés.
public interface IEmployeeService {
    void AddEmployee(Employee employee);
}

}