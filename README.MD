#FRENCH 

Le système de gestion des employés est une application console développée en utilisant C# et .NET qui vous permet de gérer les enregistrements des employés et d'effectuer diverses opérations liées aux employés. Il illustre les principes de conception SOLID et suit une architecture en couches.

# Utilisation du PRINCIP SOLID dans ce Project #

1. Principe de Responsabilité Unique (SRP) :

La classe Employee du projet EmployeeManagementSystem.Core a une seule responsabilité, qui est de représenter un employé avec ses propriétés.
La classe `EmployeeService` du projet `EMS.Services` a la responsabilité de gérer la logique métier liée aux employés, telle que l'ajout d'un employé.

La classe `EmailService` du projet `EMS.Services` a la responsabilité d'envoyer des e-mails.
La classe EmployeeRepository du projet EmployeeManagementSystem.DataAccess a la responsabilité de l'accès aux données des employés.

..
2. Principe Ouvert/Fermé (OCP) :

Le projet démontre le principe Ouvert/Fermé en utilisant des interfaces (`IEmployeeService`, `IEmailService`, `IEmployeeRepository`) et en permettant l'extension et la personnalisation à travers les implémentations (`EmployeeService`, `EmailService`, `EmployeeRepository`).
L'ajout d'une nouvelle fonctionnalité ou la modification d'un comportement existant peut être effectué en créant de nouvelles classes qui implémentent les interfaces correspondantes, sans modifier les classes existantes.

..
3. Principe de Substitution de Liskov (LSP) :

Le principe de Substitution de Liskov stipule que les objets d'une superclasse doivent pouvoir être remplacés par des objets de ses sous-classes sans compromettre la fonctionnalité du système.
Le projet respecte ce principe en utilisant des interfaces (`IEmployeeService`, `IEmailService`, `IEmployeeRepository`) pour définir les contrats et permettre l'utilisation interchangeables de différentes implémentations.

..
4. Principe de Ségrégation de l'Interface (ISP) :

Les interfaces (`IEmployeeService`, `IEmailService`, `IEmployeeRepository`) du projet `EMS.Core` sont conçues pour suivre le principe de Ségrégation de l'Interface.
Chaque interface ne déclare que les méthodes pertinentes à sa responsabilité spécifique, évitant les dépendances inutiles à des méthodes non nécessaires.

..
5. Principe d'Inversion de Dépendance (DIP) :

La classe EmployeeManagementSystem du projet EMS.App dépend des abstractions (interfaces) plutôt que des implémentations concrètes.
Le module de haut niveau (EmployeeManagementSystem) est découplé des modules de bas niveau (`EmployeeService` et `EmailService`), qui dépendent tous deux des abstractions (`IEmployeeRepository` et `IEmailRepository`).

L'inversion de dépendance est réalisée via l'injection de dépendances dans le constructeur, où les dépendances sont transmises à la classe via son constructeur.

En ce qui concerne le "DIP de haut niveau" (High-level DIP), cela fait référence au fait que le module de haut niveau (par exemple, EmployeeManagementSystem) dépend des abstractions (interfaces) plutôt que des implémentations concrètes. Dans ce projet, la classe EmployeeManagementSystem dépend des interfaces IEmployeeService et `IEmailService`, qui sont des abstractions de haut niveau.


#ENGLISH 

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



By Ibrahim Ahmad , Gabera Softwqre Solution 
Github : https://github.com/ibrahmad18

Feel free to update the README file with any additional details or customizations based on your specific project requirements.
