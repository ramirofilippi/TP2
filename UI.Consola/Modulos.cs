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
    public class Modulos
    {
        public Modulos()
        {
            this.ModuloNegocio = new ModuloLogic();
        }
        private ModuloLogic _ModuloNegocio;
        public ModuloLogic ModuloNegocio
        {
            get { return _ModuloNegocio; }
            set { _ModuloNegocio = value; }
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
            foreach (Modulo m in ModuloNegocio.GetAll())
            {
                MostrarDatos(m);
            }

        }
        public void MostrarDatos(Modulo mod)
        {
            Console.WriteLine($"ID: {mod.ID}");
            Console.WriteLine($"\t\tDescripcion: {mod.Descripcion}");
            Console.WriteLine();
        }
        public void Consultar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID del modulo a consultar: ");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(ModuloNegocio.GetOne(ID));
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
                Modulo modulo = new Modulo();

                Console.Clear();
                Console.WriteLine("Ingrese Descripcion: ");
                modulo.Descripcion = Console.ReadLine();
                modulo.State = BusinessEntity.States.New;
                ModuloNegocio.Save(modulo);
                Console.WriteLine();
                Console.WriteLine($"ID: {modulo.ID}");
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
                Console.WriteLine("Ingrese el ID del modulo a modificar: ");
                int ID = int.Parse(Console.ReadLine());
                Modulo modulo = ModuloNegocio.GetOne(ID);
                Console.WriteLine("Ingrese Descripcion: ");
                modulo.Descripcion = Console.ReadLine();
                modulo.State = BusinessEntity.States.Modified;
                ModuloNegocio.Save(modulo);
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
                Console.WriteLine("Ingrese el id del modulo a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                ModuloNegocio.Delete(ID);
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
