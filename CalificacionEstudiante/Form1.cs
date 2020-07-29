using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalificacionEstudiante
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (txtNota1.Text == "" || txtNota2.Text == "" || txtNota3.Text == "" || txtNota4.Text == "")
            {
                MessageBox.Show("Todos los campos deben estar diligenciados"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double suma, nota1, nota2, nota3, nota4, resultado;

                nota1 = double.Parse(txtNota1.Text);
                nota2 = double.Parse(txtNota2.Text);
                nota3 = double.Parse(txtNota3.Text);
                nota4 = double.Parse(txtNota4.Text);


                suma = nota1 + nota2 + nota3 + nota4;

                resultado = suma / 4;

                lblResultado.Text = Convert.ToString(resultado);

                label6.Visible = true;
                lblResultado.Visible = true;
            }

           
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            txtNota1.Text = String.Empty;
            txtNota2.Text = String.Empty;
            txtNota3.Text = String.Empty;
            txtNota4.Text = String.Empty;

            label6.Visible = false;
            lblResultado.Visible = false;
            txtNota1.Focus();
        }
    }
}
