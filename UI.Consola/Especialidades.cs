using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using Business.Logic;
using Data.Database;
using System.Data;
using System.Data.SqlClient;

namespace UI.Consola
{
    public class Especialidades
    {
        public Especialidades()
        {
            this.EspecialidadNegocio = new EspecialidadLogic();
        }
        private EspecialidadLogic _EspecialidadNegocio;
        public EspecialidadLogic EspecialidadNegocio
        {
            get { return _EspecialidadNegocio; }
            set { _EspecialidadNegocio = value; }
        }
        public void Menu()
        {
            int op = this.MostrarMenu();
            while (op != 6)
            {
                switch (op)
                {
                    case 1:
                        this.ListadoGeneral();
                        break;
                    case 2:
                        this.Consultar();
                        break;
                    case 3:
                        this.Agregar();
                        break;
                    case 4:
                        this.Modificar();
                        break;
                    case 5:
                        this.Eliminar();
                        break;
                    case 6:
                        Console.WriteLine("Adios!!");
                        break;
                }
                op = this.MostrarMenu();

            }
        }
        public int MostrarMenu()
        {
            Console.WriteLine("Que desea hacer?\n");
            Console.WriteLine("1– Listado General\n2– Consulta\n3– Agregar\n4- Modificar\n5- Eliminar\n6- Salir");
            int op = int.Parse(Console.ReadLine());
            while (op != 1 && op != 2 && op != 3 && op != 4 && op != 5 && op != 6)
            {
                Console.WriteLine("Por favor, ingrese una opción valida\n");
                Console.WriteLine("1– Listado General\n2– Consulta\n3– Agregar\n4- Modificar\n5- Eliminar\n6- Salir");
                op = int.Parse(Console.ReadLine());
            }
            return op;
        }
        public void ListadoGeneral()
        {
            Console.Clear();
            foreach (Especialidad e in EspecialidadNegocio.GetAll())
            {
                MostrarDatos(e);
            }

        }
        public void MostrarDatos(Especialidad esp)
        {
            Console.WriteLine($"ID: {esp.ID}");
            Console.WriteLine($"\t\tDescripcion: {esp.Descripcion}");
            Console.WriteLine();
        }
        public void Consultar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID de la especialidad a consultar: ");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(EspecialidadNegocio.GetOne(ID));
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine(fe.Message);
                Console.WriteLine("La ID ingresada debe ser un numero entero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }
        public void Agregar()
        {
            try
            {
                Especialidad especialidad = new Especialidad();

                Console.Clear();
                Console.WriteLine("Ingrese Descripcion: ");
                especialidad.Descripcion = Console.ReadLine();
                especialidad.State = BusinessEntity.States.New;
                EspecialidadNegocio.Save(especialidad);
                Console.WriteLine();
                Console.WriteLine($"ID: {especialidad.ID}");
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine(fe.Message);
                Console.WriteLine("La ID ingresada debe ser un numero entero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }
        public void Modificar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID de la especialidad a modificar: ");
                int ID = int.Parse(Console.ReadLine());
                Especialidad especialidad = EspecialidadNegocio.GetOne(ID);
                Console.WriteLine("Ingrese Descripcion: ");
                especialidad.Descripcion = Console.ReadLine();
                especialidad.State = BusinessEntity.States.Modified;
                EspecialidadNegocio.Save(especialidad);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine(fe.Message);
                Console.WriteLine("La ID ingresada debe ser un numero entero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }
        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el id de la especialidad a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                EspecialidadNegocio.Delete(ID);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine(fe.Message);
                Console.WriteLine("La ID ingresada debe ser un numero entero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }
    }
}
