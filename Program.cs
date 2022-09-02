using System;

namespace parcial_parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            int validador = 0;
            do
            {


                Console.WriteLine("ingrese el numero de estudiantes a evaluar");
                int numEstudia = int.Parse(Console.ReadLine());
                int contador = 0;
                ArrayList lista = new ArrayList();
                string nombre;
                double lab1;
                double lab2:
                double parc;
            }
               while (contador < numEstudia)
               { 
            {
                 Console.WriteLine("ingrese el nombre completo dle estudiante");
                 nombre = Console.ReadLine());
                 Console.WriteLine("ingrese la nota del laboratorio 1");
                 lab1 = double.Parse(Console.ReadLine());
                 Console.WriteLine("ingrese la nota del laboratorio 2");
                 lab2 = double.Parse(Console.ReadLine());
                 Console.WriteLine("ingrese la nota del  examen parcial");
                 parc = double.Parse(Console.ReadLine());

                double notafinal = notafinal(lab1, lab2, parc);
                string apr = Aprob(notafinal);


                Estudiantes estudiantes = new Estudiantes { nombre = nombre, notafinal = notafinal, aprob = apr };
                lista.Add(estudiantes)

                        contador++;
            }
               }
            foreach (estudiantes st in lista)

            {
                Console.WriteLine(st.getData());
            }

            Console.WriteLine("");
            Console.WriteLine("si desea ingresar nuevos datos de estudiantes digite cero ");
            validador = int.Parse(Console.ReadLine());
        }    while (validador == 0);

         // funciones 
            static double notafinal(double lab1, double lab2, double parc)
            {
               double notafinal = (lab1 * 0.3) + (lab2 * 0.3) + (parc * 0.4);
                return notafinal
            }

        static string Aprob(double notafinal)
        {
            if (notafinal > 6)
            {
                return "aprobado"
            }
            else
            {
                return "aprobado"
            }

        }
    }
}



3 referencias
public class Estudiantes
{

    private string _nombre;
    private double _notafinal;
    private string _aprobo;

    1 referencia
    public string Nombre
    {
        get => _nombre;
        set =< _notafinal = Value;
    }

    1 referencias
    public double _NotaFinal
    {
        get => _notafinal;
        set = c _notafinal = value;
        }
    
    2 referencias
    public string Aprob
    {
        get => _aprobo;
        set => _aprobo = value;
    }
    1 referencias
    public string getData()
    {
        return "El nombre es:" + _nombre + " ,la nota final es + _notafinal +  " ,por lo tanto el estudiante aprobado
    }



}
