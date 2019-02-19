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
    public partial class Form2 : Form
    {
        //declaración de arreglos
        int[,] arreglo = new int[3, 3];

        public Form2()
        {
            InitializeComponent();
        }
        //declaracion de función sin retorno
        void llenar()
        {
            //declaracion de ciclo for para recorrer arreglo
            for(int f=0; f < 3; f++)
            {
                for(int c = 0; c < 3; c++)
                {
                    arreglo[f, c] = c;
                }
            }
        }
        //declaracion de función sin retorno
        void mostrar()
        {
            dataGridView1.Rows.Clear();
            for(int f = 0; f < 3; f++)
            {
                dataGridView1.Rows.Add(arreglo[f,0],arreglo[f,1],arreglo[f,2]);
                
            }
 
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //llamado de función
            llenar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //llamado de función
            mostrar();
        }
    }
}
