using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace funciones
{
    public partial class Form1 : Form
    {
        int valor=0;
        int nocambia=0;


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
         //   saludo(textBox1.Text);
        }

        void saludo(string nombre)
        {
            MessageBox.Show("Buenos dias"+nombre);
        }
        int division(int y)
        {
            return y / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(division(Convert.ToInt16(textBox1.Text)).ToString());
            cambio_valor(ref valor,nocambia);
            MessageBox.Show(valor.ToString()+ "otro valor"+ nocambia.ToString());
        }

        private string saludo2(string nombre = "Andres")
        {
            return "Bienvenido" + nombre;
        }

        private void cambio_valor(ref int x, int x2)
        {
            x = 10;
            x2 = 20;
        }

        int arreglos(params int[] numeros)
        {
            
            return numeros[2];
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                
                MessageBox.Show(saludo2());
            }
            else
            {
                MessageBox.Show(saludo2(textBox1.Text));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mensaje;
            int[] n = { 14, 22, 6, 48, 15 };
            mensaje = "Su arreglo es de longitud:" + arreglos(n).ToString();
            MessageBox.Show(mensaje);
        }
    }
}
