using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularPromedioNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblpromedio.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nota1 = txtnota1.Text;
            string nota2 = txtnota2.Text;
            string nota3 = txtnota3.Text;

            double nota1int = Convert.ToDouble(nota1);
            double nota2int = Convert.ToDouble(nota2);
            double nota3int = Convert.ToDouble(nota3);

            double promedio = (nota1int + nota2int + nota3int) / 3;

            lblpromedio.Text = Convert.ToString(promedio);
            lblpromedio.Visible = true;
        }
    }
}
