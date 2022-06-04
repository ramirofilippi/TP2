using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Usuarios
    {
        public Usuarios()
        {
            this.UsuarioNegocio = new UsuarioLogic();
        }
        private UsuarioLogic _UsuarioNegocio;
        public UsuarioLogic UsuarioNegocio
        {
            get { return _UsuarioNegocio; }
            set { _UsuarioNegocio = value; }
        }
        public void Menu()
        {
            int op = this.MostrarMenu();
            while(op != 6)
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
            foreach(Usuario u in UsuarioNegocio.GetAll())
            {
                MostrarDatos(u);
            }

        }
        public void MostrarDatos(Usuario usr)
        {
            Console.WriteLine($"Usuario: {usr.ID}");
            Console.WriteLine($"\t\tNombre: {usr.Nombre}");
            Console.WriteLine($"\t\tApellido: {usr.Apellido}");
            Console.WriteLine($"\t\tNombre de Usuario: {usr.NombreUsuario}");
            Console.WriteLine($"\t\tClave: {usr.Clave}");
            Console.WriteLine($"\t\tEmail: {usr.EMail}");
            Console.WriteLine($"\t\tHabilitado: {usr.Habilitado}");
            Console.WriteLine();
        }
        public void Consultar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID del usuario a consultar: ");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(UsuarioNegocio.GetOne(ID));
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
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
                Usuario usuario = new Usuario();

                Console.Clear();
                Console.WriteLine("Ingrese Nombre: ");
                usuario.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Apellido: ");
                usuario.Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese Nombre de Usuario: ");
                usuario.NombreUsuario = Console.ReadLine();
                Console.WriteLine("Ingrese Clave: ");
                usuario.Clave = Console.ReadLine();
                Console.WriteLine("Ingrese EMail: ");
                usuario.EMail = Console.ReadLine();
                Console.WriteLine("Ingrese habilitacion de Usuario (1-Si/otro-No): ");
                usuario.Habilitado = (Console.ReadLine() == "1");
                usuario.State = BusinessEntity.States.New;
                UsuarioNegocio.Save(usuario);
                Console.WriteLine();
                Console.WriteLine($"ID: {usuario.ID}");
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
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
                Console.WriteLine("Ingrese el ID del usuario a modificar: ");
                int ID = int.Parse(Console.ReadLine());
                Usuario usuario = UsuarioNegocio.GetOne(ID);
                Console.WriteLine("Ingrese Nombre: ");
                usuario.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Apellido: ");
                usuario.Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese Nombre de Usuario: ");
                usuario.NombreUsuario = Console.ReadLine();
                Console.WriteLine("Ingrese Clave: ");
                usuario.Clave = Console.ReadLine();
                Console.WriteLine("Ingrese EMail: ");
                usuario.EMail = Console.ReadLine();
                Console.WriteLine("Ingrese habilitacion de Usuario (1-Si/otro-No): ");
                usuario.Habilitado = (Console.ReadLine() == "1");
                usuario.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(usuario);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
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
                Console.WriteLine("Ingrese el id del usuario a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                UsuarioNegocio.Delete(ID);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
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
