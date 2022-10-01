using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPVG;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Empleado empleado1 = new Empleado();    
            
            Cargo cargo1 = new Cargo();
           
            Departamento departamento1=new Departamento();
            
            Jefe jefe1=new Jefe();
            

            empleado1.asignaCargo(cargo1);
            empleado1.asignaDepartamento(departamento1);
            empleado1.asignaJefe(jefe1);


      

            Console.WriteLine("---INGRESO DE DATOS DE UN EMPLEADO---");
            Console.WriteLine("RUT:");
            empleado1.rut = Console.ReadLine();

            Console.WriteLine("Nombres:");
            empleado1.nombre = Console.ReadLine();

            Console.WriteLine("Apellidos:");
            empleado1.apellidos = Console.ReadLine();

            Console.WriteLine("Cargo:");
            cargo1.nombre = Console.ReadLine();

            Console.WriteLine("Departamento:");
            departamento1.nombre = Console.ReadLine();

            Console.WriteLine("Jefe:");
            jefe1.nombre = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("---DATOS DEL EMPLEADO INGRESADO---");
            Console.WriteLine("RUT:" + empleado1.rut+ ", NOMBRES:" + empleado1.nombre + ", APELLIDOS: " + empleado1.apellidos+ "\nSU CARGO ES:" + cargo1.nombre+ ", PERTENECE AL DEPARTAMENTO DE:" + departamento1.nombre+ ", SU JEFE DIRECTO ES:"+jefe1.nombre );

            Console.ReadKey();
    }
    
    
       
    
    }
}

