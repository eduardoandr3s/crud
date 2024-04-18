using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clases.CConexion objetoConexion = new clases.CConexion();
            objetoConexion.EstablecerConexion();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            CRUD.clases.Calumnos objetoAlumnos = new CRUD.clases.Calumnos();
            objetoAlumnos.guardarAlumnos(txtnombre, txtapellido);
            objetoAlumnos.mostrarAlumnos(dgvtotalalumnos);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            CRUD.clases.Calumnos objetoAlumnos = new CRUD.clases.Calumnos();
            objetoAlumnos.modificarAlumnos(txtid, txtnombre, txtapellido);
            objetoAlumnos.mostrarAlumnos(dgvtotalalumnos);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            CRUD.clases.Calumnos objetoAlumnos = new CRUD.clases.Calumnos();
            objetoAlumnos.eliminarAlumnos(txtid);
            objetoAlumnos.mostrarAlumnos(dgvtotalalumnos);
        }
    }
}
