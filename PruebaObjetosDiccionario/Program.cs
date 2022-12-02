using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaObjetosDiccionario
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Coche coche1 = new Coche("Ferrari", 1234, 120, "Rosa", false, 1);
            Coche coche2 = new Coche("Alpine", 7436, 130, "Azul", true, 2);
            Coche coche3 = new Coche("Mclaren", 8473, 110, "Verde", true, 3);
            Coche coche4 = new Coche("Mercedes", 0294, 100, "Amarillo", false, 1);

            List<Coche> coches = new List<Coche>();
            coches.Add(coche1);
            coches.Add(coche2);
            coches.Add(coche3);
            coches.Add(coche4);
            ///coches.Add(null);
            
            try
            {
                Dictionary<int, Coche> carList = new Dictionary<int, Coche>();
                for(int i = 0; i < coches.Count; i++)
                {
                    carList.Add(coches[i].getMatricula(), coches[i]);
                }
                int miClave = (int)carList.Keys.ElementAt(0);

                Console.WriteLine(miClave);
                Coche miCoche = carList[miClave];
                miCoche.getColor();
                int opcion = 0;
                string colorCoche;
                string marcaCoche;
                string colorFinal;
                Console.WriteLine("1.Buscar coche por color");
                Console.WriteLine("2.Buscar coche por marca");
                Console.WriteLine("3.Cambiar color");
                Console.WriteLine("4.Salir");
                while (opcion != 4)
                {
                    switch (opcion)
                    {
                        case 1:
                            colorCoche = Console.ReadLine();
                            if (miCoche.getColor().Equals(colorCoche))
                            {
                                Console.WriteLine(miCoche.getMatricula());
                            }
                            else
                            {
                                Console.WriteLine("No hay coches con este color");
                            }
                            break;
                        case 2:
                            marcaCoche = Console.ReadLine();
                            if (miCoche.getColor().Equals(marcaCoche))
                            {
                                Console.WriteLine(miCoche.getMatricula());
                            }
                            else
                            {
                                Console.WriteLine("No hay coches de esta marca");
                            }
                            break;
                        case 3:
                            colorCoche = Console.ReadLine();
                            Console.WriteLine("A que color lo quieres cambiar?");
                            colorFinal = Console.ReadLine();
                            if (miCoche.getColor().Equals(colorCoche))
                            {
                                miCoche.setColor(colorFinal);
                            }
                            else
                            {
                                Console.WriteLine("No hay coches con este color");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Saliendo de las opciones");
                            break;
                        default:
                            Console.WriteLine("No es una opcion valida");
                            break;
                    }
                }  
            }
            catch(ArgumentNullException e)///no tiene ningun valor
            {
                Console.WriteLine(e.Message);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(NullReferenceException exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally { Console.WriteLine("Cerrar recuperar un coche"); }
        }
    }
}
