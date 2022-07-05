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
    public class Materias
    {
        public Materias()
        {
            this.MateriaNegocio = new MateriaLogic();
        }
        private MateriaLogic _MateriaNegocio;
        public MateriaLogic MateriaNegocio
        {
            get { return _MateriaNegocio; }
            set { _MateriaNegocio = value; }
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
            foreach (Materia m in MateriaNegocio.GetAll())
            {
                MostrarDatos(m);
            }

        }
        public void MostrarDatos(Materia mat)
        {
            Console.WriteLine($"Materia: {mat.ID}");
            Console.WriteLine($"\t\tDescripcion: {mat.Descripcion}");
            Console.WriteLine($"\t\tHoras Semanales: {mat.HSSemanales}");
            Console.WriteLine($"\t\tHoras Totales: {mat.HSTotales}");
            Console.WriteLine($"\t\tID Plan: {mat.IDPlan}");
            Console.WriteLine();
        }
        public void Consultar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID de la Materia a consultar: ");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(MateriaNegocio.GetOne(ID));
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
                Materia materia = new Materia();

                Console.Clear();
                Console.WriteLine("Ingrese Descripción: ");
                materia.Descripcion = Console.ReadLine();
                Console.WriteLine("Ingrese Cant Horas Semanales: ");
                materia.HSSemanales = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Cant Horas Totales: ");
                materia.HSTotales = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el ID del Plan: ");
                materia.IDPlan = int.Parse(Console.ReadLine());
                materia.State = BusinessEntity.States.New;
                MateriaNegocio.Save(materia);
                Console.WriteLine();
                Console.WriteLine($"ID: {materia.ID}");
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
                Console.WriteLine("Ingrese el ID de la Materia a modificar: ");
                int ID = int.Parse(Console.ReadLine());
                Materia materia = MateriaNegocio.GetOne(ID);
                Console.WriteLine("Ingrese Descripción: ");
                materia.Descripcion = Console.ReadLine();
                Console.WriteLine("Ingrese Cant Horas Semanales: ");
                materia.HSSemanales = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Cant Horas Totales: ");
                materia.HSTotales = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el ID del Plan: ");
                materia.IDPlan = int.Parse(Console.ReadLine());
                materia.State = BusinessEntity.States.Modified;
                MateriaNegocio.Save(materia);
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
                Console.WriteLine("Ingrese el id de la materia a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                MateriaNegocio.Delete(ID);
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
