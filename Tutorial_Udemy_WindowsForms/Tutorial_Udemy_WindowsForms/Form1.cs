using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaLogica;
using capaLogica.Library;

namespace Tutorial_Udemy_WindowsForms
{
    public partial class Form1: Form
    {
        private LEstudiantes estudiante;
        private Librarys librarys; 
        public Form1()
        {
            InitializeComponent();
            librarys = new Librarys();
            var listTextBoxs = new List<TextBox>();
            listTextBoxs.Add(txtNombre);
            listTextBoxs.Add(txtID);
            listTextBoxs.Add(txtApellido);
            listTextBoxs.Add(txtEmail);
            var listLabel = new List<Label>();
            listLabel.Add(lblNombre);
            listLabel.Add(lblID);
            listLabel.Add(lblApellido);
            listLabel.Add(lblEmail);
            listLabel.Add(lblPaginas);
            Object[] objetos = { 
                pictureBox1,
                Properties.Resources.person_24dp_1F1F1F,
                dataGridView1,
                numericUpDown1
            };

            estudiante = new LEstudiantes(listTextBoxs, listLabel, objetos);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            librarys.uploadImage.CargarImagen(pictureBox1);
        }

        //txtNombre
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
                lblNombre.ForeColor = Color.LightSlateGray;
            else
            {
                lblNombre.ForeColor = Color.Green;
                lblNombre.Text = "Nombre"; 
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.txtBoxEvent.txtKeyPress(e);
        }

        //txtID
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
                lblID.ForeColor = Color.LightSlateGray;
            else
                lblID.ForeColor = Color.Green; lblID.Text = "ID";
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.txtBoxEvent.numberKeyPress(e);
        }

        //txtApellido
        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text.Equals(""))
                lblApellido.ForeColor = Color.LightSlateGray;
            else
                lblApellido.ForeColor = Color.Green; lblApellido.Text = "Apellido";
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.txtBoxEvent.txtKeyPress(e);
        }

        //txtEmail
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals(""))
                lblEmail.ForeColor = Color.LightSlateGray;
            else
                lblEmail.ForeColor = Color.Green; lblEmail.Text = "email";
        }

        //Botones
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            estudiante.Registrar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            estudiante.BuscarEstudiante(txtBuscar.Text);
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            estudiante.Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estudiante.Eliminar();
        }

        //Botones paginador
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            estudiante.paginador("Primero");
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            estudiante.paginador("Anterior");
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            estudiante.paginador("Siguiente");
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            estudiante.paginador("Ultimo");
        }

        //Paginador
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            estudiante.registroPaginas();
        }

        //DataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
                estudiante.GetEstudiante();
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
                estudiante.GetEstudiante();
        }

        
    }
}
