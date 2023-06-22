1. Single Responsibility Principle (SRP):

The Employee class in the EmployeeManagementSystem.Core project has a single responsibility, which is to represent an employee with its properties.
The EmployeeService class in the EmployeeManagementSystem.Services project has the responsibility of handling employee-related business logic, such as adding an employee.
The EmailService class in the EmployeeManagementSystem.Services project has the responsibility of sending emails.
The EmployeeRepository class in the EmployeeManagementSystem.DataAccess project has the responsibility of data access for employees.

2. Open-Closed Principle (OCP):

The project demonstrates the Open-Closed Principle by using interfaces (IEmployeeService, IEmailService, IEmployeeRepository) and allowing for extension and customization through implementations (EmployeeService, EmailService, EmployeeRepository).
Adding new functionality or modifying existing behavior can be done by creating new classes that implement the corresponding interfaces without modifying the existing classes.

3. Liskov Substitution Principle (LSP):

The Liskov Substitution Principle states that objects of a superclass should be replaceable with objects of its subclasses without breaking the system's functionality.
The project adheres to this principle by using interfaces (IEmployeeService, IEmailService, IEmployeeRepository) to define contracts and allowing different implementations to be used interchangeably.

4. Interface Segregation Principle (ISP):

The interfaces (IEmployeeService, IEmailService, IEmployeeRepository) in the EmployeeManagementSystem.Core project are designed to follow the Interface Segregation Principle.
Each interface declares only the methods relevant to its specific responsibility, avoiding unnecessary dependencies on methods that are not needed.

5. Dependency Inversion Principle (DIP):

The EmployeeManagementSystem class in the EmployeeManagementSystem.Core project depends on abstractions (IEmployeeService and IEmailService) rather than concrete implementations.
The high-level module (EmployeeManagementSystem) is decoupled from the low-level modules (EmployeeService and EmailService), both of which depend on abstractions (IEmployeeRepository and IEmailRepository).
The dependency inversion is achieved through constructor injection, where the dependencies are passed to the class through its constructor.

6. DIP : 
Regarding the "High-level DIP," it refers to the fact that the high-level module (e.g., EmployeeManagementSystem) depends on abstractions (interfaces) rather than concrete implementations. In this project, the EmployeeManagementSystem class depends on the IEmployeeService and IEmailService interfaces, which are high-level abstractions.