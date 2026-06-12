using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryDiFiniInstanciaEvaluativa1
{
    internal class clsRubros
    {
        private OleDbConnection conexion = new OleDbConnection(); //Se crea un objeto para que la aplicación se conecte a la base de datos
        private OleDbCommand comando = new OleDbCommand(); //Objeto que almacena y ejecuta instrucciones SQL sobre una base de datos
        private OleDbDataAdapter adaptador = new OleDbDataAdapter(); //Adaptador para transferir datos entre la base de datos

        //Que tipo de base de datos se va a usar y cual es, donde esta
        private String CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=InstanciaEvaluativa2.mdb";

        //Que tablas vamos a usar
        private String Tabla = "Rubros";
        private String Tabla2 = "Articulos";

        //Variables para calcular etiquetas
        private Decimal total;
        private Int32 cantidad;

        //Variables de Artículos
        private String cod;
        private String nom;
        private Decimal cos;
        private Int32 stk;
        private String rub;

        //Propiedades / Funciones para pasar las variables al formulario
        public Decimal Total
        {
            get { return total; }
        }

        public Int32 Cantidad
        {
            get { return cantidad; }
        }

        public String Codigo
        {
            get { return cod; }
            set { cod = value; }
        }

        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        public Decimal Costo
        {
            get { return cos; }
            set { cos = value; }
        }

        public Int32 Stock
        {
            get { return stk; }
            set { stk = value; }
        }

        public String Rubro
        {
            get { return rub; }
            set { rub = value; }
        }

        public Decimal ValorStock
        {
            get { return cos * stk; }
        }

        public void GuardarDatos(ComboBox Combo)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader DR = comando.ExecuteReader();

                Combo.Items.Clear();

                while (DR.Read())
                {
                    Combo.Items.Add(DR.GetString(1));
                }

                DR.Close();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //Carga los datos de la base de datos en el DataGridView según el rubro
        public Decimal CargarDatosGrilla(DataGridView Grilla, String RubroBuscado)
        {
            Decimal TotalValorStock = 0;

            try
            {
                Int32 idRubro = 0;

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                //Buscar el Id del rubro seleccionado
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader DR = comando.ExecuteReader();

                while (DR.Read())
                {
                    if (DR.GetString(1) == RubroBuscado)
                    {
                        idRubro = DR.GetInt32(0);
                    }
                }

                DR.Close();

                //Leer artículos
                comando.CommandText = Tabla2;
                DR = comando.ExecuteReader();

                Grilla.Rows.Clear();

                while (DR.Read())
                {
                    if (DR.GetInt32(4) == idRubro)
                    {
                        Decimal ValorStock = DR.GetDecimal(2) * DR.GetInt32(3);

                        TotalValorStock += ValorStock;

                        int i = Grilla.Rows.Add();

                        Grilla.Rows[i].Cells[0].Value = DR.GetString(0);
                        Grilla.Rows[i].Cells[1].Value = DR.GetString(1);
                        Grilla.Rows[i].Cells[2].Value = DR.GetDecimal(2);
                        Grilla.Rows[i].Cells[3].Value = DR.GetInt32(3);
                        Grilla.Rows[i].Cells[4].Value = ValorStock;
                    }
                }

                DR.Close();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return TotalValorStock;
        }

        //Método para contar la cantidad de artículos por rubro
        public Int32 ContarArticulosPorRubro(String RubroBuscado)
        {
            Int32 CantidadArticulos = 0;

            try
            {
                Int32 idRubro = 0;

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader DR = comando.ExecuteReader();

                while (DR.Read())
                {
                    if (DR.GetString(1) == RubroBuscado)
                    {
                        idRubro = DR.GetInt32(0);
                    }
                }

                DR.Close();

                comando.CommandText = Tabla2;
                DR = comando.ExecuteReader();

                while (DR.Read())
                {
                    if (DR.GetInt32(4) == idRubro)
                    {
                        CantidadArticulos++;
                    }
                }

                DR.Close();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return CantidadArticulos;
        }

        //Método para exportar los datos de la grilla
        public void ExportarDatos(DataGridView Grilla, String NombreArchivo)
        {
            try
            {
                StreamWriter Exportacion = new StreamWriter(NombreArchivo, false, Encoding.UTF8);

                Exportacion.WriteLine("Codigo;Descripcion;Costo;Stock;ValorStock");

                for (Int32 i = 0; i < Grilla.Rows.Count; i++)
                {
                    if (Grilla.Rows[i].Cells[0].Value != null)
                    {
                        Exportacion.Write(Grilla.Rows[i].Cells[0].Value);
                        Exportacion.Write(";");
                        Exportacion.Write(Grilla.Rows[i].Cells[1].Value);
                        Exportacion.Write(";");
                        Exportacion.Write(Grilla.Rows[i].Cells[2].Value);
                        Exportacion.Write(";");
                        Exportacion.Write(Grilla.Rows[i].Cells[3].Value);
                        Exportacion.Write(";");
                        Exportacion.WriteLine(Grilla.Rows[i].Cells[4].Value);
                    }
                }

                Exportacion.Close();
                Exportacion.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ImprimirArticulos(PrintPageEventArgs reporte)
        {
            try
            {
                Font LetraTitulo1 = new Font("Arial", 20);
                Font LetraTitulo2 = new Font("Arial", 10);
                Font LetraTexto = new Font("Arial", 8);

                Int32 f = 200;

                reporte.Graphics.DrawString("Listado de Artículos", LetraTitulo1, Brushes.Red, 100, 100);

                reporte.Graphics.DrawString("Código", LetraTitulo2, Brushes.Blue, 20, 180);
                reporte.Graphics.DrawString("Descripción", LetraTitulo2, Brushes.Blue, 120, 180);
                reporte.Graphics.DrawString("Costo", LetraTitulo2, Brushes.Blue, 450, 180);
                reporte.Graphics.DrawString("Stock", LetraTitulo2, Brushes.Blue, 550, 180);
                reporte.Graphics.DrawString("IdRubro", LetraTitulo2, Brushes.Blue, 650, 180);

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla2;

                adaptador = new OleDbDataAdapter(comando);

                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla2);

                if (DS.Tables[Tabla2].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla2].Rows)
                    {
                        reporte.Graphics.DrawString(fila["Codigo"].ToString(), LetraTexto, Brushes.Black, 20, f);
                        reporte.Graphics.DrawString(fila["Descripcion"].ToString(), LetraTexto, Brushes.Black, 120, f);
                        reporte.Graphics.DrawString(fila["Costo"].ToString(), LetraTexto, Brushes.Black, 450, f);
                        reporte.Graphics.DrawString(fila["Stock"].ToString(), LetraTexto, Brushes.Black, 550, f);
                        reporte.Graphics.DrawString(fila["IdRubro"].ToString(), LetraTexto, Brushes.Black, 650, f);

                        f = f + 20;
                    }
                }

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}