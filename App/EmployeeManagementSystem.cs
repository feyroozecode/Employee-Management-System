
using EMS.Core.Interfaces;
using EMS.Core.Models;
using EMS.App.Fun;

/**
    DIP : Principe d'Inversion de Dépendance (DIP)
    Decouplage des modules de bas Niveau 
    Dépend des abstractions (interfaces) plutôt que des implémentations concrètes.
    (`EmployeeService` et `EmailService`), qui dépendent tous deux des abstractions 
    (`IEmployeeRepository` et `IEmailRepository`).
*/
namespace EMS.App
{
    
    class  EmployeeManagementSystem {
        private readonly IEmployeeService _employeeService;
        private readonly IEmailService _emailService;

        public EmployeeManagementSystem(IEmployeeService employeeService, IEmailService emailService){
            _employeeService = employeeService;
            _emailService = emailService;
        }

        public void Run()
        {
            bool continueAddingEmployees = true;
            while (continueAddingEmployees)
            {
                Employee employee = CreateEmployee.Create();
                _employeeService.AddEmployee(employee);
                SendEmailNotification.SendEmail(employee, _emailService);
                // Display a message in the console
                Console.WriteLine("Employee added successfully.");

                Console.Write("Voulez-vous ajouter un autre employé ? (Oui/Non) : ");
                string userInput = Console.ReadLine()!;
                continueAddingEmployees = userInput.ToLower() == "oui";
            }
        }
       

    }
}