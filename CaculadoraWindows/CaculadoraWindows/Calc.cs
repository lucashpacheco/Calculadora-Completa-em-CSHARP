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
    public partial class Calc : Form
    {
        StringBuilder display = new StringBuilder("");
        StringBuilder displayequacao = new StringBuilder("");

        public Calc()
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

            //string expressaobruta = Convert.ToString(displayequacao);

            //string expressaovalidada = Convert.ToString(ValidaSinalFinal(expressaobruta));

            //equacao.Text = Convert.ToString(expressaovalidada);


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

            //string expressaobruta = Convert.ToString(displayequacao);

            //string expressaovalidada = Convert.ToString(ValidaSinalFinal(expressaobruta));

            //equacao.Text = Convert.ToString(expressaovalidada);

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

            //string expressaobruta = Convert.ToString(displayequacao);

            //string expressaovalidada = Convert.ToString(ValidaSinalFinal(expressaobruta));

            //equacao.Text = Convert.ToString(expressaovalidada);

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
            string expressaobruta = Convert.ToString(displayequacao);

            string expressaovalidada = Convert.ToString(ValidaSinalFinal(expressaobruta));

            displayequacao.Append(display);

            displayequacao.Append("/");

            display.Clear();

            txt_display.Text = Convert.ToString(display);

            equacao.Text = Convert.ToString(expressaovalidada);

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

            double raiz = Convert.ToDouble(Convert.ToString(display)) * Convert.ToDouble(Convert.ToString(display));

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
            string log = Convert.ToString(display);

            string expressaobruta = Convert.ToString(displayequacao);

            string expressaovalidada = Convert.ToString(ValidaSinalFinal(expressaobruta));

            double resultado1 = double.Parse(Resolve(expressaovalidada));

            displayequacao.Append(display);


            display.Clear();

            txt_display.Text = Convert.ToString(expressaovalidada);

            equacao.Text = Convert.ToString(expressaovalidada);

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

        public string ValidaSinalFinal(string expressaobruta)
        {
            string expressaovalidada = expressaobruta;

            object enumero = Convert.ToString(expressaobruta.Substring(expressaobruta.Length - 1, 1)).GetType();

            object stringtype = enumero.ToString();

            MessageBox.Show(Convert.ToString(stringtype));
            //object stringnumericamodelo = 1.IsNumber();


            //while (Convert.ToBoolean(stringtype.Equals)
            //{
            //    char ultimochar = Convert.ToChar(expressaobruta.Substring(expressaobruta.Length - 1, 1));

            //    while (ultimochar == '+')
            //    {
            //        expressaovalidada = expressaobruta.Substring(0, expressaobruta.Length - 1);
            //    }
            //    while (ultimochar == '-')
            //    {
            //        expressaovalidada = expressaobruta.Substring(0, expressaobruta.Length - 1);
            //    }
            //    while (ultimochar == '*')
            //    {
            //        expressaovalidada = expressaobruta.Substring(0, expressaobruta.Length - 1);
            //    }
            //    while (ultimochar == '/')
            //    {
            //        expressaovalidada = expressaobruta.Substring(0, expressaobruta.Length - 1);
            //    }

            //}



            return expressaovalidada;

            //for (ultimochar = '+' ) ;

            //if (ultimochar = '+'|| ultimochar = '-' || ultimochar = '/' || ultimochar = '*')
            //{

            //}
        }

        public string ValidaSinalMeio(string expressaobruta)
        {
            string expressaovalidada = expressaobruta;

            char ultimochar = Convert.ToChar(expressaobruta.Substring(expressaobruta.Length - 1, 1));

            if (ultimochar == '+')
            {
                expressaovalidada = expressaobruta.Substring(0, expressaobruta.Length - 1);
            }
            else if (ultimochar == '-')
            {
                expressaovalidada = expressaobruta.Substring(0, expressaobruta.Length - 1);
            }
            else if (ultimochar == '*')
            {
                expressaovalidada = expressaobruta.Substring(0, expressaobruta.Length - 1);
            }
            else if (ultimochar == '/')
            {
                expressaovalidada = expressaobruta.Substring(0, expressaobruta.Length - 1);
            }
            else
            {
                expressaovalidada = expressaobruta;
            }

            return expressaovalidada;

            //for (ultimochar = '+' ) ;

            //if (ultimochar = '+'|| ultimochar = '-' || ultimochar = '/' || ultimochar = '*')
            //{

            //}
        }




        private void Calc_Load(object sender, EventArgs e)
        {

        }
    }
}
