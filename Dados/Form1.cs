using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dados
{
    public partial class frmDados : Form
    {
        public frmDados()
        {
            InitializeComponent();
        }

        Random R = new Random();  //Declara el objeto generador de numeros random, se declara afuera del procedimiento para que sea global
        private void btnGirar_Click(object sender, EventArgs e)
        {
         Int32 n = R.Next(1 , 7);// el metodo next asigna un intervalo de valores, toma un valor mayor o igual al 1er numero y menor al ultimo.
         lblResultado.Text = Convert.ToString(n);  
            switch (n)
            {
             case 1:
             pctImagen.Image = Dados.Properties.Resources._1;
             break;
             case 2:
             pctImagen.Image = Dados.Properties.Resources._2;
             break;
             case 3:
             pctImagen.Image = Dados.Properties.Resources._3;
             break;
             case 4:
             pctImagen.Image = Dados.Properties.Resources._4;
             break;
             case 5:
             pctImagen.Image = Dados.Properties.Resources._5;
             break;
             case 6:
             pctImagen.Image = Dados.Properties.Resources._6;
             break;
             default:
             break;
            }
        }
    }
}
