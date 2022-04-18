using EntidadesTP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MiCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnOperar_Click(object sender, EventArgs e)
        {
            char operador;
            double resultado;
            StringBuilder resultadoList = new StringBuilder();
            char.TryParse(cmbOperador.Text, out operador);
            resultado = Operar(txtNumero1.Text, txtNumero2.Text, operador);
            this.lblResultado.Text = resultado.ToString();
            resultadoList.AppendLine(txtNumero1.Text + operador + txtNumero2.Text + "= " + resultado);
            this.lstOperaciones.Items.Add(resultadoList);

            if (resultado == double.MinValue)
            {
                MessageBox.Show("No es posible divivir por cero");

            }
        }
        private static double Operar(string numero1, string numero2, char operador)
        {
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);
            Calculadora calculadora = new Calculadora();

            for (int i = 0; i < numero1.Length; i++)
            {
                if (numero1[i] >= 'a' || numero1[i] >= 'A')
                {
                    MessageBox.Show("No es posible realizar operacion con letras");
                    break;
                }
            }
            for (int j = 0; j < numero2.Length; j++)
            {
                if (numero2[j] >= 'a' || numero2[j] >= 'A')
                {
                    MessageBox.Show("No es posible realizar operacion con letras");
                    break;
                }
            }

            double resultado = calculadora.Operar(num1, num2, operador);
            return resultado;
        }
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando operando = new Operando();
            string resultado;
            resultado = operando.DecimalBinario(this.lblResultado.Text);
            this.lblResultado.Text = resultado;
            this.lstOperaciones.Items.Add(resultado.ToString());
        }

        /// <summary>
        /// Evento que llama al metodo BinarioDecimal para mostrar el resultado en el label y listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string resultadoDecimal;
            Operando operando = new Operando();
            resultadoDecimal = operando.BinarioDecimal(this.lblResultado.Text);
            this.lblResultado.Text = resultadoDecimal;
            this.lstOperaciones.Items.Add(resultadoDecimal.ToString());
        }
       
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperador.Text = "";
            lblResultado.Text = "0";
            lstOperaciones.Items.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        
    }
}
