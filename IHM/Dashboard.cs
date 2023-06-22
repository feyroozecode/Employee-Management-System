
using EMS.DataAccess.Repository;
using EMS.App;

using EMS.Services;
using EMS.Services.EmailService;
using EMS.Services.ConsoleLogger;

namespace EMS.IHM
{
    public class IMH {

        // Dependency Inversion Principle (DIP): High-level modules should not depend on low-level modules; both should depend on abstractions.        
        public static void LaunchApp(){

            // Create instances of required classes
            var employeeRepository = new EmployeeRepository();
            var employeeService = new EmployeeService(employeeRepository);
            var emailService = new EmailService(new ConsoleLogger());

            // Create EmployeeManagementSystem instance
            var employeeManagementSystem = new EmployeeManagementSystem(employeeService, emailService);

            // Run the employee management system
            employeeManagementSystem.Run();
        }

    }
}