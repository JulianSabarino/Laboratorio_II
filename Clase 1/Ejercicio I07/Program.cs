using System;
using System.Text;

namespace Ejercicio_I07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int canEmpleados;
            StringBuilder employees = new StringBuilder();

            Console.WriteLine("Ingrese una cantidad de empleados");
            do
            {
                canEmpleados = int.Parse(Console.ReadLine());
                if (canEmpleados < 1)
                    Console.WriteLine("Cantidad invalida");
            } while (canEmpleados < 1);
        
            for (int i = 0; i < canEmpleados; i++)
            {
                FillEmployees(employees);
            }
            Console.WriteLine(employees.ToString());

        }

        static void FillEmployees(StringBuilder employees)
        {
            int valPerHour;
            int hoursWorked;
            int antique;
            int total;

            Console.WriteLine("Ingrese nombre");
            employees.Append(Console.ReadLine());
            employees.Append(";");

            Console.WriteLine("Ingrese valor por hora");
            do
            {
                valPerHour = int.Parse(Console.ReadLine());
            }while(valPerHour < 1);
            
            employees.Append(valPerHour);
            employees.Append(";");

            //////////////////////////////////////////////////////////////////

            Console.WriteLine("Ingrese cantidad de horas trabajadas por mes");
            do
            {
                hoursWorked = int.Parse(Console.ReadLine());
            }while (hoursWorked < 1);
            
            employees.Append(hoursWorked);
            employees.Append(";");

            //////////////////////////////////////////////////////////////////

            Console.WriteLine("Ingrese antiguedad (en años)");
            do
            {
                antique = int.Parse(Console.ReadLine());
            } while (antique < 1);
            
            employees.Append(antique);
            employees.Append(";");

            //////////////////////////////////////////////////////////////////

            total = valPerHour * hoursWorked + 150 * antique;
            total = total - (13 * total / 100);

            employees.Append(total);
            employees.Append(Environment.NewLine);
        }

    }
}
