using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ///otorga los valores al combobox
            this.cmbOperacion.Items.AddRange(new object[] {"+","-","*","/"});

            this.lblResultado.Text = "0";
        }

        /// <summary>
        /// limpia los textbox, combobox y labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "0";
            cmbOperacion.Text = "";
            txtNumero1.Clear();
            txtNumero2.Clear();
            
        }

        /// <summary>
        /// a hacer click en el button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero primerOperador = new Numero(txtNumero1.Text);
            Numero segundoOperador = new Numero(txtNumero2.Text);
            string operador = Calculadora.validarOperador(cmbOperacion.Text);

            if(txtNumero2.Text == "" || txtNumero1.Text == "")
            {
                MessageBox.Show("Falta completar alguno de los numeros. Por favor comletar.");
            }
            else if (cmbOperacion.Text == "")
            {
                MessageBox.Show("Flata completar el operador. Por favor completar");
            }
            else
            {
                if(cmbOperacion.Text != "+" && cmbOperacion.Text != "-" && cmbOperacion.Text != "*" && cmbOperacion.Text != "/")
                {
                    cmbOperacion.Text = "+";
                }

                lblResultado.Text = Convert.ToString(Calculadora.operar(primerOperador, segundoOperador, operador));
            }

            
        }
    }
}
