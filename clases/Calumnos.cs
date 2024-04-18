using crud.clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.clases
{
    internal class Calumnos
    {
        public void mostrarAlumnos(DataGridView tablaAlumnos)
        {
            try
            {

                CConexion objetoConexion = new CConexion();

                string query = "select * from alumnos";

                tablaAlumnos.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.EstablecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaAlumnos.DataSource = dt;
                objetoConexion.CerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudierón mostrar los datos consulta al administrador de la base de datos" + ex.ToString());
            }
        }

        public void guardarAlumnos(TextBox nombre, TextBox apellido)
        {
            try
            {

                CConexion objetoConexion = new CConexion();

                string query = "insert into alumnos (nombre,apellido)" + "values ('" + nombre.Text + "','" + apellido.Text + "');";

                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.EstablecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();
                MessageBox.Show("Los registros  se guardaron de forma correcta");


                while (reader.Read())
                {


                }



                objetoConexion.CerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudierón mostrar los datos consulta al administrador de la base de datos" + ex.ToString());
            }
        }

        public void seleccionarAlumnos(DataGridView tablaAlumnos, TextBox id, TextBox nombre, TextBox apellido)
        {
            try
            {

                id.Text = tablaAlumnos.CurrentRow.Cells[0].Value.ToString();
                nombre.Text = tablaAlumnos.CurrentRow.Cells[1].Value.ToString();
                apellido.Text = tablaAlumnos.CurrentRow.Cells[2].Value.ToString();


            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudierón modificar los datos consulta al administrador de la base de datos" + ex.ToString());
            }
        }

        public void modificarAlumnos(TextBox id, TextBox nombre, TextBox apellido)
        {
            try
            {

                CConexion objetoConexion = new CConexion();

                string query = "update alumnos set nombre='" + nombre.Text + "',apellido='" + apellido.Text + "'where id='" + id.Text + "';";

                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.EstablecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();
                MessageBox.Show("Los registros  se modificarón de forma correcta");


                while (reader.Read())
                {


                }



                objetoConexion.CerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudierón mostrar los datos consulta al administrador de la base de datos" + ex.ToString());
            }
        }

        public void eliminarAlumnos(TextBox id)
        {
            try
            {

                CConexion objetoConexion = new CConexion();

                string query = "delete from alumnos where id= '" + id.Text + "';";

                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.EstablecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();
                MessageBox.Show("Los registros  se eliminarón de forma correcta");


                while (reader.Read())
                {


                }



                objetoConexion.CerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudierón eliminar los datos, consulta al administrador de la base de datos" + ex.ToString());
            }
        }
    }
}