using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial2_ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //valido si el usuario ingreso un frase
            if (this.txtfrase.txt.length == 0)
            {
                MessageBox.Show("por favor ingresa una frase...");
                //ubica el cursor en el cuadro de texto txtfrase
                this.txtfrase.focus();
            }

            //creo el array de palabras
            string[] palabras = this.txtfrase.txt.split(" ");
            this.itspalbras.ttems.clear();

            //lleno el listbox con las palobras
            for(int i=0; i<palabras.Length; i++)
            {
                this.lstpalabras.Items.Add(palabras[i] + "- - >" + palabras[i].length + "caracteres...");
            }
                
            
        }
    }
}
