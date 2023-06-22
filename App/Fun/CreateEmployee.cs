
using EMS.Core.Models;
using System;

namespace EMS.App.Fun
{
    
public class CreateEmployee {

    public static Employee Create()
    {
        string name;
        string email;
        string role;

        // Prompt the user for employee details in French
        Console.WriteLine("Ajouter les détails de l'employé :");
        Console.Write("Nom : ");
        name = Console.ReadLine()!;
        Console.Write("Email : ");
        email = Console.ReadLine()!;
        Console.Write("Rôle : ");
        role = Console.ReadLine()!;

        return new Employee
        {
            Name = name,
            Email = email,
            Role = role
        };
    }

}
}