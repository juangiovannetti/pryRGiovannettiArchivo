using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
namespace pryRGiovannettiArchivo
{
    internal class clsArchivo
    {
        Decimal Total = 0;
        Int32 c = 0;
        public string NombreArchivo = "Clientes.csv";

        private struct RegClientes
        {
            public Int32 Codigo;
            public string Nombre;
            public Decimal Deuda;
            public Decimal Limite;
        }
        private RegClientes[] vecClientes = new RegClientes[1500];
        private Int32 IND = 0;

        public void CargarVector()
        {
            string DatosLeidos;
            string[] vecDatos = new string[4];
            IND = 0;

            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);

            //Leer
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                vecDatos = DatosLeidos.Split(';');
                vecClientes[IND].Codigo = Convert.ToInt32(vecDatos[0]);
                vecClientes[IND].Nombre = vecDatos[1];
                vecClientes[IND].Deuda = Convert.ToDecimal(vecDatos[2]);
                vecClientes[IND].Limite = Convert.ToDecimal(vecDatos[3]);
                IND++;

                DatosLeidos = AD.ReadLine();
            }
            //Cerrar
            AD.Close();
            AD.Dispose();
        }

        private void OrdenarVector()
        {
            RegClientes aux;
            for (Int32 c = 0; c < IND - 1; c++) // contador de vueltas
            {
                for (Int32 i = 0; i < IND - 1; i++) //Recorre el vector
                {
                    if (vecClientes[i].Codigo > vecClientes[i + 1].Codigo)
                    {
                        aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = aux;

                    }

                }
            }
        }

        public void RescribirVector()
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, false);

            for (Int32 i = 0; i < IND - 1; i++)
            {
                AD.Write(vecClientes[i].Codigo);
                AD.Write(";");
                AD.Write(vecClientes[i].Nombre);
                AD.Write(";");
                AD.Write(vecClientes[i].Deuda);
                AD.Write(";");
                AD.WriteLine(vecClientes[i].Limite);
            }
            AD.Close();
            AD.Dispose();
        }

        public void OrdenarArchivo()
        {

            CargarVector();
            OrdenarVector();
            RescribirVector();


        }
        public void Grabar(string cod, string nom, string deu, string lim)
        {
            //Abrir
            StreamWriter AD = new StreamWriter(NombreArchivo, true);

            //cargar o leer 
            AD.Write(cod);
            AD.Write(";");
            AD.Write(nom);
            AD.Write(";");
            AD.Write(deu);
            AD.Write(";");
            AD.WriteLine(lim);

            //Cerrar
            AD.Close();
            AD.Dispose();
        }

        public void Listar(DataGridView Grilla)
        {
            string DatosLeidos;
            string[] vecDatos = new string[4];
            StreamReader AD = new StreamReader(NombreArchivo);
            //Leer
            DatosLeidos = AD.ReadLine();
            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {
                vecDatos = DatosLeidos.Split(';');

                Grilla.Rows.Add(vecDatos[0], vecDatos[1], vecDatos[2], vecDatos[3]);
                DatosLeidos = AD.ReadLine();
            }
            //Cerrar
            AD.Close();
            AD.Dispose();


        }
        public Int32 CantidadClientes()
        {
            string DatosLeidos;
            Int32 c = 0;
            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //Leer
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                c++;

                DatosLeidos = AD.ReadLine();
            }
            //Cerrar
            AD.Close();
            AD.Dispose();

            return c;
        }
        public Decimal DeudaClientes()
        {
            string[] vecDatos = new string[4];
            string DatosLeidos;
            Decimal Total = 0;

            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //Leer
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                vecDatos = DatosLeidos.Split(';');
                Total = Total + Convert.ToDecimal(vecDatos[2]);

                DatosLeidos = AD.ReadLine();
            }
            //Cerrar
            AD.Close();
            AD.Dispose();

            return Total;
        }
        public Decimal Promedio()
        {
            string[] vecDatos = new string[4];
            string DatosLeidos;
            Decimal Promedio = 0;
            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //Leer
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                c++;
                vecDatos = DatosLeidos.Split(';');
                Total = Total + Convert.ToDecimal(vecDatos[2]);
                if (c > 0)
                {
                    Promedio = Total / c;
                }
                DatosLeidos = AD.ReadLine();
            }
            //Cerrar
            AD.Close();
            AD.Dispose();

            return Total / c;
        }
        public Decimal PromedioDeuda2()
        {
            Decimal Promedio = 0;
            Promedio = Total / c;

            return Promedio;
        }
        public void ListarDeudores(DataGridView Grilla)
        {
            string DatosLeidos;
            string[] vecDatos = new string[4];
            StreamReader AD = new StreamReader(NombreArchivo);
            //Leer
            DatosLeidos = AD.ReadLine();
            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {
                vecDatos = DatosLeidos.Split(';');

                if (Convert.ToInt32(vecDatos[2]) > 0)
                {
                    Grilla.Rows.Add(vecDatos[0], vecDatos[1], vecDatos[2], vecDatos[3]);
                }

                DatosLeidos = AD.ReadLine();
            }
            //Cerrar
            AD.Close();
            AD.Dispose();


        }
        public Decimal PromedioDeuda()
        {
            string[] vecDatos = new string[4];
            string DatosLeidos;
            Decimal Promedio = 0;

            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //Leer
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                c++;
                vecDatos = DatosLeidos.Split(';');
                Total = Total + Convert.ToDecimal(vecDatos[2]);

                DatosLeidos = AD.ReadLine();
            }
            //Cerrar
            AD.Close();
            AD.Dispose();

            return Total / c;
        }
        public Int32 ClientesDeudores()
        {
            string DatosLeidos;
            Int32 cantDeu = 0;
            string[] vecDatos;

            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);

            //Leer
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                vecDatos = DatosLeidos.Split(';');
                if (Convert.ToDecimal(vecDatos[2]) > 0)
                {
                    cantDeu++;
                }
                DatosLeidos = AD.ReadLine();
            }
            //Cerrar
            AD.Close();
            AD.Dispose();

            return cantDeu;
        }
        public void GenerarReporte()
        {
            string DatosLeidos;
            string[] vecDatos = new string[4];
            Int32 Cantidad = 0;
            Decimal Total = 0;

            StreamWriter Reporte = new StreamWriter("Reporte.csv", false, Encoding.UTF8);

            Reporte.WriteLine("ListadoClientes");
            Reporte.WriteLine(" ");
            Reporte.WriteLine("código;Nombre;Límite;Deuda ");
            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //Leer
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                vecDatos = DatosLeidos.Split(';');
                Reporte.Write(vecDatos[0]);
                Reporte.Write(";");
                Reporte.Write(vecDatos[1]);
                Reporte.Write(";");
                Reporte.Write(vecDatos[3]);
                Reporte.Write(";");
                Reporte.WriteLine(vecDatos[2]);

                DatosLeidos = AD.ReadLine();

                Cantidad++; // contador
                Total = Total + Convert.ToDecimal(vecDatos[2]); //Acumulador
            }
            //Cerrar
            AD.Close();
            AD.Dispose();
            Reporte.WriteLine(";");
            Reporte.Write("Total de deudas:;;");
            Reporte.WriteLine(Total);
            Reporte.Write("Cantidad de clientes:;;");
            Reporte.WriteLine(Cantidad);
            Reporte.Write("Promedio de deuda:;;");
            Reporte.WriteLine(Total / Cantidad);

            Reporte.Close();
            Reporte.Dispose();
        }
        public void OrdenarPorCodigoAscendente()
        {
            Int32 C = 0;
            while (C < IND - 1)
            {
                Int32 i = 0;
                RegClientes Aux;
                while (i < IND - 1)
                {
                    if (vecClientes[i].Codigo > vecClientes[i + 1].Codigo)
                    {
                        Aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = Aux;
                    }
                    i++;
                }
                C++;
            }
        }
        public void OrdenarPorCodigoDescendente()
        {
            Int32 C = 0;
            while (C < IND - 1)
            {
                Int32 i = 0;
                RegClientes Aux;
                while (i < IND - 1)
                {
                    if (vecClientes[i].Codigo < vecClientes[i + 1].Codigo)
                    {
                        Aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = Aux;
                    }
                    i++;
                }
                C++;
            }
        }
        public void OrdenarPorNombreAscendente()
        {
            Int32 C = 0;
            while (C < IND - 1)
            {
                Int32 i = 0;
                RegClientes Aux;
                while (i < IND - 1)
                {
                    if (vecClientes[i].Nombre.CompareTo(vecClientes[i + 1].Nombre) > 0)
                    {
                        Aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = Aux;
                    }
                    i++;
                }
                C++;
            }
        }
        public void OrdenarPorNombreDescendente()
        {
            Int32 C = 0;
            while (C < IND - 1)
            {
                Int32 i = 0;
                RegClientes Aux;
                while (i < IND - 1)
                {
                    if (vecClientes[i].Nombre.CompareTo(vecClientes[i + 1].Nombre) < 0)
                    {
                        Aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = Aux;
                    }
                    i++;
                }
                C++;
            }
        }
        public void OrdenarPorLimiteAscendente()
        {
            Int32 C = 0;
            while (C < IND - 1)
            {
                Int32 i = 0;
                RegClientes Aux;
                while (i < IND - 1)
                {
                    if (vecClientes[i].Limite > vecClientes[i + 1].Limite)
                    {
                        Aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = Aux;
                    }
                    i++;
                }
                C++;
            }
        }
        public void OrdenarPorLimiteDescendente()
        {
            Int32 C = 0;
            while (C < IND - 1)
            {
                Int32 i = 0;
                RegClientes Aux;
                while (i < IND - 1)
                {
                    if (vecClientes[i].Limite < vecClientes[i + 1].Limite)
                    {
                        Aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = Aux;
                    }
                    i++;
                }
                C++;
            }
        }
        public void OrdenarPorDeudaAscendente()
        {
            Int32 C = 0;
            while (C < IND - 1)
            {
                Int32 i = 0;
                RegClientes Aux;
                while (i < IND - 1)
                {
                    if (vecClientes[i].Deuda > vecClientes[i + 1].Deuda)
                    {
                        Aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = Aux;
                    }
                    i++;
                }
                C++;
            }
        }
        public void OrdenarPorDeudaDescendente()
        {
            Int32 C = 0;
            while (C < IND - 1)
            {
                Int32 i = 0;
                RegClientes Aux;
                while (i < IND - 1)
                {
                    if (vecClientes[i].Deuda < vecClientes[i + 1].Deuda)
                    {
                        Aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = Aux;
                    }
                    i++;
                }
                C++;
            }
        }
    }
}
