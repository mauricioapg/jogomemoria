using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoMemoria
{
    public partial class teste : Form
    {
        public teste()
        {
            InitializeComponent();
        }

        private void teste_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = telaJogo.listaAux1[0];
            pictureBox2.BackgroundImage = telaJogo.listaAux1[1];
            pictureBox3.BackgroundImage = telaJogo.listaAux1[2];
            pictureBox4.BackgroundImage = telaJogo.listaAux1[3];
            pictureBox5.BackgroundImage = telaJogo.listaAux1[4];
            pictureBox6.BackgroundImage = telaJogo.listaAux1[5];
            pictureBox7.BackgroundImage = telaJogo.listaAux1[6];
            pictureBox8.BackgroundImage = telaJogo.listaAux1[7];
            pictureBox9.BackgroundImage = telaJogo.listaAux1[8];
            pictureBox10.BackgroundImage = telaJogo.listaAux1[9];
            pictureBox11.BackgroundImage = telaJogo.listaAux1[10];
            pictureBox12.BackgroundImage = telaJogo.listaAux1[11];

            pictureBox13.BackgroundImage = telaJogo.listaAux2[0];
            pictureBox14.BackgroundImage = telaJogo.listaAux2[1];
            pictureBox15.BackgroundImage = telaJogo.listaAux2[2];
            pictureBox16.BackgroundImage = telaJogo.listaAux2[3];
            pictureBox17.BackgroundImage = telaJogo.listaAux2[4];
            pictureBox18.BackgroundImage = telaJogo.listaAux2[5];
            pictureBox19.BackgroundImage = telaJogo.listaAux2[6];
            pictureBox20.BackgroundImage = telaJogo.listaAux2[7];
            pictureBox21.BackgroundImage = telaJogo.listaAux2[8];
            pictureBox22.BackgroundImage = telaJogo.listaAux2[9];
            pictureBox23.BackgroundImage = telaJogo.listaAux2[10];
            pictureBox24.BackgroundImage = telaJogo.listaAux2[11];
        }
    }
}
