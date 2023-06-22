Employee Management System
The Employee Management System is a console application built using C# and .NET that allows you to manage employee records and perform various operations related to employees. It demonstrates the principles of SOLID design and follows a layered architecture.

Features
Add new employees with their name and email.
Store employee data using a data access layer.
Apply business logic and validation when adding employees.
Send email notifications using a separate service.
Console-based user interface for interaction.
Project Structure
The project is organized into the following components:

EmployeeManagementSystem.Core: Contains the core entities and interfaces.
EmployeeManagementSystem.DataAccess: Implements the data access layer for storing employee data.
EmployeeManagementSystem.Services: Implements the business logic layer and email service.
EmployeeManagementSystem.IHM: Contains the console application for the user interface.
Prerequisites Interface Machine 
.NET 5 SDK or later
Getting Started
Clone the repository or download the source code.
Open the solution in Visual Studio or your preferred IDE.
Build the solution to restore dependencies.
Set the EmployeeManagementSystem.Views project as the startup project.
Run the application.
Usage
The console application provides a simple menu-driven interface to perform various operations:

Add Employee: Allows you to add a new employee by entering their name and email.
Exit: Terminates the application.
Contributing
Contributions to the project are welcome. You can fork the repository, make improvements, and submit a pull request.

License
The Employee Management System is open source and released under the MIT License.

Feel free to update the README file with any additional details or customizations based on your specific project requirements.