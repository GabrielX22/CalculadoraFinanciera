using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraFinanciera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*comboper.Text = "Elige el tiempo del periodo";*/
            texttasa.Text = "tasa en decimales";


            string[] tipos = new string[] { "Capital", "Tasa de Interés", "# de Periodos", "Monto" };
            string[] tiempo = new string[] { "Quincenas", "Meses", "Bimestres", "Trimestres", "Cuatrimestres", "Semestres", "Años", "Pagos" };
            /*comboper.Items.AddRange(tiempo);*/
            combotipo.Items.AddRange(tipos);


            


        }

        private void comboper_DropDown(object sender, EventArgs e)
        {
           /* if (comboper.Text == "Elige el tiempo del periodo") // Si el texto actual es el texto de sugerencia
            {
                comboper.Text = ""; // Borra el texto cuando el usuario hace clic en el ComboBox
            }*/
        }

        private void combotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si se selecciona "Capital", "Tasa de Interés", "# de Periodos", o "Monto", deshabilita una TextBox
            if (combotipo.SelectedItem.ToString() == "Capital")            
            {
                textcap.Enabled = false;
                textcap.Text = "";
                texttasa.Enabled = true;
                textper.Enabled = true;
                textmon.Enabled = true;
            }
            else if (combotipo.SelectedItem.ToString() == "Tasa de Interés")
            {
                textcap.Enabled = true;
                texttasa.Enabled = false;
                texttasa.Text = "";
                textper.Enabled = true;
                textmon.Enabled = true;
            }
            else if (combotipo.SelectedItem.ToString() == "# de Periodos")
            {
                textcap.Enabled = true;
                texttasa.Enabled = true;
                textper.Enabled = false;
                /*comboper.Enabled = false;*/
                textper.Text = "";
                textmon.Enabled = true;
            }
            else if (combotipo.SelectedItem.ToString() == "Monto")
            {
                textcap.Enabled = true;
                texttasa.Enabled = true;
                textper.Enabled = true;
                textmon.Text = "";
                textmon.Enabled = false;
            }
            else
            {
                // En caso contrario, habilita los TextBox
                textcap.Enabled = true;
                texttasa.Enabled = true;
                textper.Enabled = true;
                textmon.Enabled = true;
            }
        }

        private void comboper_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        /*private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboper.Text)) // Si el usuario no seleccionó nada
            {
                comboper.Text = "Elige el tiempo del periodo"; // Vuelve a mostrar el texto de sugerencia
            }
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butcalcu_Click(object sender, EventArgs e)
        {
            var calculadora = new CIC();
            double capi;
            double tasi;
            int peri;
            double monti;
            double.TryParse(textcap.Text, out capi);
            double.TryParse(texttasa.Text, out tasi);
            int.TryParse(textper.Text, out peri);
            double.TryParse(textmon.Text, out monti);

            if (string.IsNullOrWhiteSpace(textcap.Text)){
                if (string.IsNullOrWhiteSpace(textmon.Text) || string.IsNullOrWhiteSpace(texttasa.Text) || string.IsNullOrWhiteSpace(textper.Text))
                {
                    MessageBox.Show("Por favor, rellena todos los datos necesarios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double calcapi = calculadora.CalcularCapital(monti, tasi, peri);
                    textcalcu.Text = $"El capital es de ${calcapi}";
                }
                
            }
            else if (string.IsNullOrWhiteSpace(texttasa.Text))
            {
                if (string.IsNullOrWhiteSpace(textcap.Text) || string.IsNullOrWhiteSpace(textmon.Text) || string.IsNullOrWhiteSpace(textper.Text))
                {
                    MessageBox.Show("Por favor, rellena todos los datos necesarios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double caltasa = calculadora.CalcularTasa(capi, monti, peri);
                    double calpor = caltasa * 100;
                    textcalcu.Text = $"La tasa de interés es de {caltasa} en decimal y {calpor}% en porcentaje";
                }
            }
                
            else if (string.IsNullOrWhiteSpace(textper.Text))
            {
                if (string.IsNullOrWhiteSpace(textcap.Text) || string.IsNullOrWhiteSpace(texttasa.Text) || string.IsNullOrWhiteSpace(textmon.Text))
                {
                    MessageBox.Show("Por favor, rellena todos los datos necesarios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double calper = calculadora.CalcularPeriodos(capi, tasi, monti);
                    textcalcu.Text = $"Los periodos para completar el pago es de {calper}";
                }
                
            }
            else if (string.IsNullOrWhiteSpace(textmon.Text))
            {
                if (string.IsNullOrWhiteSpace(textcap.Text) || string.IsNullOrWhiteSpace(texttasa.Text) || string.IsNullOrWhiteSpace(textper.Text))
                {
                    MessageBox.Show("Por favor, rellena todos los datos necesarios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double calmon = calculadora.CalcularMonto(capi, tasi, peri);
                    textcalcu.Text = $"El monto es de ${calmon}";
                }
                
            }
            else
            {
                MessageBox.Show("Por favor, rellena todos los datos necesarios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public class CIC
        {
            public double CalcularMonto(double capitalInicial, double tasaInteres, int periodos)
            {
                double capi = capitalInicial * Math.Pow(1 + tasaInteres, periodos);
                double capiresul = Math.Round(capi, 2);
                return capiresul;
            }

            public double CalcularCapital(double monto, double tasaInteres, int periodos)
            {
                double cmonto = monto / Math.Pow(1 + tasaInteres, periodos);
                double montofinal = Math.Round(cmonto, 2);
                return montofinal;
            }

            public double CalcularTasa(double capitalInicial, double monto, int periodos)
            {
                double resultado = Math.Pow(monto / capitalInicial, 1.0 / periodos) - 1;
                double resulfinal = Math.Round(resultado, 2);
                return resulfinal;
            }

            public double CalcularPeriodos(double capitalInicial, double tasaInteres, double monto)
            {
                double periodo = Math.Log(monto / capitalInicial) / Math.Log(1 + tasaInteres);
                double periodofinal = Math.Round(periodo, 2);
                return periodofinal;
            }
        }

        private void texttasa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void texttasa_Click(object sender, EventArgs e)
        {
            if (texttasa.Text == "tasa en decimales")
            {
                texttasa.Text = "";
            }
        }

        private void texttasa_EnabledChanged(object sender, EventArgs e)
        {
            if (texttasa.Text == "")
            {
                texttasa.Text = "tasa en decimales";
            }
        }

        private void quesbutton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();

            // Mostrar el formulario
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textpor.Text, out int valor))
            {
                if (double.TryParse(textpor.Text, out double porcentaje))
                {
                    double decimalValue = porcentaje / 100;

                    textdec.Text = decimalValue.ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Ingresa un valor numérico válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (valor > 100)
                {
                    textpor.Clear();
                    textdec.Clear();
                    MessageBox.Show("El valor no puede ser mayor a 100", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void textpor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; 
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textdec.Clear();
        }

        private void textpor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textcap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true; 
            }
        }

        private void texttasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void textper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void textmon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
