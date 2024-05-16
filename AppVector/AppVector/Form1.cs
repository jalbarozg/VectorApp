using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppVector
{
    public partial class Frmvectores : Form
    {
        //creando una instancia de mi clase vector
        clsVector v = new clsVector();
        public Frmvectores()
        {
            InitializeComponent();
        }
        private void mostrarVector() {
            lbresultado.Text = "";
            for (int i = 0; i < v.longitud(); i++) {
                lbresultado.Text = lbresultado.Text + v.obtenervalor(i) + ",";
            }
            lbresultado.Text = lbresultado.Text + "]";
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            int x =Convert.ToInt16(txtvalor.Text);
            v.adicionar(x);
            mostrarVector();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(txtvalor.Text);
            v.adicionar(x);
            mostrarVector();

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {    
            mostrarVector();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            mostrarVector();
        }

        private void invertirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.invertir();
            mostrarVector();
        }
        private void cantDeParesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = v.cantPares();
            MessageBox.Show("Cant. de elementos pares: " + c.ToString());

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cantDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }    
    }
}
