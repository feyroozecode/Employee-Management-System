
using EMS.Core.Models;
using EMS.Core.Interfaces;

using System;

namespace EMS.App.Fun
{
    
public class SendEmailNotification {

    public static void SendEmail(Employee employee, IEmailService _emailService)
    {
        Console.WriteLine("Envoyer une notification par e-mail :");
        Console.Write("Sujet de l'e-mail : ");
        string subject = Console.ReadLine()!;

        string message = $"Bienvenue, {employee.Name} ! Vous avez été ajouté au système de gestion des employés.";
        _emailService.SendEmail(employee.Email, subject, message);
    }

}
}