using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CaculadoraWindows
{
    public partial class Form1 : Form
    {
        StringBuilder display = new StringBuilder("");
        StringBuilder displayequacao = new StringBuilder("");

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_n1_Click(object sender, EventArgs e)
        {

            display.Append("1");
            txt_display.Text = Convert.ToString(display);

        }

        private void btn_n2_Click(object sender, EventArgs e)
        {

            display.Append("2");
            txt_display.Text = Convert.ToString(display);

        }

        private void btn_n3_Click(object sender, EventArgs e)
        {
            display.Append("3");
            txt_display.Text = Convert.ToString(display);
        }

        private void btn_n4_Click(object sender, EventArgs e)
        {
            display.Append("4");
            txt_display.Text = Convert.ToString(display);
        }

        private void btn_n5_Click(object sender, EventArgs e)
        {
            display.Append("5");
            txt_display.Text = Convert.ToString(display);
        }



        private void btn_n6_Click(object sender, EventArgs e)
        {
            display.Append("6");
            txt_display.Text = Convert.ToString(display);
        }



        private void btn_n7_Click(object sender, EventArgs e)
        {
            display.Append("7");
            txt_display.Text = Convert.ToString(display);
        }

        private void btn_n8_Click(object sender, EventArgs e)
        {
            display.Append("8");
            txt_display.Text = Convert.ToString(display);
        }

        private void btn_n9_Click(object sender, EventArgs e)
        {
            display.Append("9");
            txt_display.Text = Convert.ToString(display);
        }

        private void btn_n0_Click(object sender, EventArgs e)
        {
            display.Append("0");
            txt_display.Text = Convert.ToString(display);
        }



        private void btn_virgula_Click(object sender, EventArgs e)
        {
            display.Append(".");
            txt_display.Text = Convert.ToString(display);
        }

        private void btn_mais_Click(object sender, EventArgs e)
        {

            Somar();
        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            Subtrair();
        }

        private void btn_vezes_Click(object sender, EventArgs e)
        {
            Multiplicar();
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            Dividir();
        }
        private void btn_raiz_Click(object sender, EventArgs e)
        {
            Raiz();
        }
        private void btn_quadrado_Click(object sender, EventArgs e)
        {
            Quadrado();
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            Igual();
        }
        private void btn_1porx_Click(object sender, EventArgs e)
        {
            UmPorX();
        }
        private void btn_c_Click(object sender, EventArgs e)
        {
            LimpaTudo();
        }
        private void btn_ce_Click(object sender, EventArgs e)
        {
            LimpaTudo();
        }

        public string Somar()
        {


            displayequacao.Append(display);

            string log = Convert.ToString(display);

            displayequacao.Append("+");

            display.Clear();

            txt_display.Text = Convert.ToString(display);

            equacao.Text = Convert.ToString(displayequacao);

            return Convert.ToString(displayequacao);

        }

        public string Subtrair()
        {


            displayequacao.Append(display);

            string log = Convert.ToString(display);

            displayequacao.Append("-");

            display.Clear();

            txt_display.Text = Convert.ToString(display);

            equacao.Text = Convert.ToString(displayequacao);

            return Convert.ToString(displayequacao);

        }
        public string Multiplicar()
        {


            displayequacao.Append(display);

            string log = Convert.ToString(display);

            displayequacao.Append("*");

            display.Clear();

            txt_display.Text = Convert.ToString(display);

            equacao.Text = Convert.ToString(displayequacao);

            return Convert.ToString(displayequacao);

        }

        public string Dividir()
        {


            displayequacao.Append(display);

            displayequacao.Append("/");

            display.Clear();

            txt_display.Text = Convert.ToString(display);

            equacao.Text = Convert.ToString(displayequacao);

            return Convert.ToString(displayequacao);

        }
        public string Raiz()
        {

            double raiz = Math.Sqrt(Convert.ToDouble(Convert.ToString(display)));

            string raizq = Convert.ToString(raiz, CultureInfo.InvariantCulture);

            display.Clear();

            display.Append(Convert.ToString(raizq));

            //display.Append(display);

            //display.Clear();

            txt_display.Text = Convert.ToString(display);

            equacao.Text = Convert.ToString(displayequacao);

            return Convert.ToString(displayequacao);

        }
        public string Quadrado()
        {

            double raiz = Convert.ToDouble(Convert.ToString(display))* Convert.ToDouble(Convert.ToString(display));

            string raizq = Convert.ToString(raiz, CultureInfo.InvariantCulture);

            display.Clear();

            display.Append(Convert.ToString(raizq));

            //displayequacao.Append(display);

            //display.Clear();

            txt_display.Text = Convert.ToString(display);

            equacao.Text = Convert.ToString(displayequacao);

            return Convert.ToString(displayequacao);

        }
        public string UmPorX()
        {

            double umporx = 1 / Convert.ToDouble(Convert.ToString(display));

            string umporx_stg = Convert.ToString(umporx, CultureInfo.InvariantCulture);

            display.Clear();

            display.Append(Convert.ToString(umporx_stg));

            //displayequacao.Append(display);

            //display.Clear();

            txt_display.Text = Convert.ToString(display);

            equacao.Text = Convert.ToString(displayequacao);

            return Convert.ToString(displayequacao);

        }
        public string Igual()
        {




            displayequacao.Append(display);

            string log = Convert.ToString(display);

            display.Clear();

            txt_display.Text = Convert.ToString(display);

            equacao.Text = Convert.ToString(displayequacao);

            string expressao1 = Convert.ToString(displayequacao);

            double resultado1 = double.Parse(Resolve(expressao1));

            txt_display.Text = Convert.ToString(resultado1, CultureInfo.InvariantCulture);

            return Convert.ToString(displayequacao);

        }

        public string LimpaTudo()
        {




            displayequacao.Clear();

            display.Clear();

            txt_display.Text = Convert.ToString(display);

            equacao.Text = Convert.ToString(displayequacao);


            return Convert.ToString(displayequacao);

        }

        public string Resolve(String expressao1)
        {

            DataTable table = new DataTable();

            String espressao = expressao1;

            String resultado = table.Compute(espressao, String.Empty).ToString();

            return Convert.ToString(resultado);
        }

        
    }
}
