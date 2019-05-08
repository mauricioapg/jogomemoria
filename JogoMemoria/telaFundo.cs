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

namespace JogoMemoria
{
    public partial class telaFundo : Form
    {
        public telaFundo()
        {
            InitializeComponent();
        }

        private void telaFundo_Load(object sender, EventArgs e)
        {
            abrirTelaInicial();   
        }

        private void abrirTelaInicial()
        {
            telaInicial objTela = new telaInicial();
            objTela.MdiParent = telaFundo.ActiveForm;
            objTela.Show();
        }

        private void telaFundo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Directory.Exists(telaCriarCategoria.caminhoFotos))
            {
                if (Directory.GetFiles(telaCriarCategoria.caminhoFotos).Length == 0)
                {
                    Directory.Delete(telaCriarCategoria.caminhoFotos);
                }
            }
        }
    }
}
