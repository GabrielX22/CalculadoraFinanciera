using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraFinanciera
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string rutaArchivoPDF = Path.Combine(Application.StartupPath, "Resources", "manualsusuario.html");
            webpdf.Navigate(rutaArchivoPDF);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
