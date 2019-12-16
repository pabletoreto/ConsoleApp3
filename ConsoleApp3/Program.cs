using System;

namespace ConsoleApp3
{
    class Program
    {

        public class Ejemplo1
        {

            public virtual string mensajeCorto()
            {
                return "MensajeCorto_1";
            }

            public string MostrarMensaje()
            {
                return "Hola desde la clase base";
            }
        }
            public class Ejemplo2:Ejemplo1
            {
            public override string mensajeCorto()
            {
                return "MensajeCorto_2";
            }

            public new string MostrarMensaje()
                {
                    return "Hola desde la clase derivada";
                }

            }

        

        static void Main(string[] args)
        {
            Ejemplo1 clase = new Ejemplo2();
            Console.WriteLine(clase.mensajeCorto());
            Console.WriteLine("espero MensajeCorto_2");
            //Console.WriteLine("se muestra el mensaje directamente desde la clase Ejemplo1 aunque mezcle las clases");
            //Console.WriteLine(clase.MostrarMensaje());

            Ejemplo1 clase1 = new Ejemplo1();
            Console.WriteLine("espero MensajeCorto_1");
            Console.WriteLine(clase1.mensajeCorto());
            //Console.WriteLine("se muestra el mensaje directamente desde la clase Ejemplo1");
            //Console.WriteLine(clase1.MostrarMensaje());

            Ejemplo2 clase2 = new Ejemplo2();
            Console.WriteLine(clase2.mensajeCorto());
            Console.WriteLine("espero MensajeCorto_2");
            //Console.WriteLine("se muestra el mensaje directamente desde la clase Ejemplo2");
            //Console.WriteLine(clase2.MostrarMensaje());


            Console.ReadLine();


        }
    }
}
