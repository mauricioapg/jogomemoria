using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace JogoMemoria
{
    public partial class telaJogo : Form
    {
        TableLayoutPanel tabelaAtual;
        int nivel = 1;
        int limite;
        string versoCarta = "verso_carta.png";
        System.Timers.Timer verificador;
        System.Timers.Timer finalizador;
        Boolean concluido = false;
        int contadorCartas = 0;
        int contadorAcertos = 0;
        int contadorTentativas = 0;
        Button carta2;
        Image imagemEscolhida1;
        Image imagemEscolhida2;
        public static List<Image> listaRandom = new List<Image>();
        public static List<Image> listaImagens = new List<Image>();
        public static List<Image> listaAux0 = new List<Image>();
        public static List<Image> listaAux1 = new List<Image>();
        public static List<Image> listaAux2 = new List<Image>();
        public static DirectoryInfo pastaRaiz = new DirectoryInfo(@"imagens/");
        public static DirectoryInfo pasta;

        public telaJogo()
        {
            InitializeComponent();
        }

        public void IniciarVerificacao()
        {
            verificador = new System.Timers.Timer();
            verificador.Interval = 1000; //a cada 1 segundo o programa é executado novamente
            verificador.Elapsed += new ElapsedEventHandler(VerificarConclusao_Tick);
            verificador.Enabled = true;
        }

        public void FinalizarNivel()
        {
            finalizador = new System.Timers.Timer();
            finalizador.Interval = 1000; //a cada 1 segundo o programa é executado novamente
            finalizador.Elapsed += new ElapsedEventHandler(FinalizadorNivel_Tick);
            finalizador.Enabled = true;
        }

        private void FinalizadorNivel_Tick(object sender, ElapsedEventArgs e)
        {
            finalizador.Start();
            if (concluido == true)
            {
                btnAvancar.Enabled = true;
            }
        }

        private void DefinirTabelaAtual()
        {
            if (nivel == 1)
            {
                tabelaAtual = tabelaNivel1;
            }
            else if (nivel == 2)
            {
                tabelaAtual = tabelaNivel2;
            }
            else if (nivel == 3)
            {
                tabelaAtual = tabelaNivel3;
            }
        }

        private void VerificarConclusao_Tick(object sender, ElapsedEventArgs e)
        {
            DefinirTabelaAtual();
            int contadorDesabilitados = 0;
            foreach (Button item in tabelaAtual.Controls)
            {
                if (item.Enabled == false)
                {
                    contadorDesabilitados++;
                }
            }
            if (contadorDesabilitados == tabelaAtual.Controls.Count)
            {
                concluido = true;
                verificador.Stop();
                cronometro.Stop();
                //MessageBox.Show("Parabéns, você concluiu este jogo!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void telaPrincipal_Load(object sender, EventArgs e)
        {
            IniciarPrograma();
            DefinirFontesPadrao();
        }

        private void IniciarPrograma()
        {
            labelNivel.Text = "Nível: " + nivel.ToString();
            if (nivel == 1)
            {
                OrganizarItens(tabelaNivel1);
                tabelaNivel3.Visible = false;
                tabelaNivel2.Visible = false;
                tabelaNivel1.Visible = true;
            }
            else if (nivel == 2)
            {
                OrganizarItens(tabelaNivel2);
                tabelaNivel1.Visible = false;
                tabelaNivel3.Visible = false;
                tabelaNivel2.Visible = true;
            }
            else if (nivel == 3)
            {                
                OrganizarItens(tabelaNivel3);
                tabelaNivel1.Visible = false;
                tabelaNivel2.Visible = false;
                tabelaNivel3.Visible = true;      
            }            
            AdicionarBotoes();
            EmbaralharCartasLista(listaImagens);
            IniciarVerificacao();
            cronometro.Start();
        }

        private void DefinirFontesPadrao()
        {
            PrivateFontCollection font = new PrivateFontCollection();
            font.AddFontFile(@"fontes/Comic Book.otf");
            label1.Font = new Font(font.Families[0], 18, FontStyle.Bold);
            label2.Font = new Font(font.Families[0], 18, FontStyle.Bold);
            label3.Font = new Font(font.Families[0], 18, FontStyle.Bold);
            label5.Font = new Font(font.Families[0], 26, FontStyle.Regular);
            labelTentativas.Font = new Font(font.Families[0], 24, FontStyle.Bold);
            labelAcertos.Font = new Font(font.Families[0], 24, FontStyle.Bold);
            labelMinutos.Font = new Font(font.Families[0], 24, FontStyle.Bold);
            labelSegundos.Font = new Font(font.Families[0], 24, FontStyle.Bold);
            labelNivel.Font = new Font(font.Families[0], 16, FontStyle.Bold);
            menuReiniciar.Font = new Font(font.Families[0], 16, FontStyle.Bold);
        }

        private void OrganizarItens(TableLayoutPanel t)
        {
            t.Location = new Point((this.Size.Width / 2) - (t.Size.Width / 2), (this.Size.Height / 2) - (t.Size.Height / 2));
            panelResultados.Location = new Point((this.Size.Width / 2) - (t.Size.Width / 2), (this.Size.Height / 6) - (t.Size.Height / 7));
            ZerarContadores();
        }

        private void ZerarContadores()
        {
            labelAcertos.Text = "00";
            labelTentativas.Text = "00";
            labelSegundos.Text = "00";
            labelMinutos.Text = "00";
            contadorAcertos = 0;
            contadorTentativas = 0;
        }

        private void ContarTentativas()
        {
            contadorTentativas++;
            if (contadorTentativas < 9)
            {
                labelTentativas.Text = "0" + contadorTentativas;
            }
            else
            {
                labelTentativas.Text = contadorTentativas.ToString();
            }
        }

        private void AdicionarBotoes()
        {
            DefinirTabelaAtual();
            Button carta;
            CarregarImagens(pasta = new DirectoryInfo(@"imagens/" + telaInicial.categoriaEscolhida + "/"));
            //MessageBox.Show(pasta.ToString());

            foreach (var imagem in listaImagens)
            {
                carta = new Button();
                carta.BackgroundImage = Image.FromFile(pastaRaiz + versoCarta);
                carta.BackgroundImageLayout = ImageLayout.Zoom;
                carta.Size = new Size(tabelaAtual.ClientSize.Width, tabelaAtual.ClientSize.Height);
                //carta.Margin = new Padding(0, 0, 20, 30);
                carta.Tag = 0;
                carta.Click += new EventHandler(Botao_Click);
                tabelaAtual.Controls.Add(carta);
            }
        }

        async Task Espera(int tempo)
        {
            await Task.Delay(tempo);
        }

        private async void VerificarCartas(Image img1, Image img2, Button btn1, Button btn2)
        {
            await Espera(500);
            if (contadorCartas == 2 && CompararImagens(img1, img2))
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                contadorAcertos++;
                if (Convert.ToInt32(labelAcertos.Text) < 9)
                {
                    labelAcertos.Text = "0" + contadorAcertos;
                }
                else
                {
                    labelAcertos.Text = contadorAcertos.ToString();
                }
                //MessageBox.Show("Iguais");
            }
            else
            {
                //MessageBox.Show("Diferentes");
                btn1.BackgroundImage = Image.FromFile(pastaRaiz + versoCarta);
                btn2.BackgroundImage = Image.FromFile(pastaRaiz + versoCarta);
                btn1.Tag = 0;
                btn2.Tag = 0;
            }
            contadorCartas = 0;
            ContarTentativas();
        }

        public List<Image> EmbaralharCartasLista(List<Image> l)
        {
            var rand = new Random();
            var listaEmbaralhada = l.OrderBy(x => rand.Next()).ToList();
            l = listaEmbaralhada;
            return l;
        }

        public void CarregarImagens(DirectoryInfo pasta)
        {
            foreach (FileInfo arquivo in pasta.GetFiles())
            {
                listaRandom.Add(Image.FromFile(arquivo.FullName));
            }

            if (nivel == 1)
            {
                limite = 6;
            }
            else if (nivel == 2)
            {
                limite = 12;
            }
            else if(nivel == 3)
            {
                limite = 18;
            }

            listaAux0 = EmbaralharCartasLista(listaRandom);

            listaAux1 = listaAux0.GetRange(0, limite);

            listaAux2 = EmbaralharCartasLista(listaAux1);

            foreach (var item in listaAux1)
            {
                listaImagens.Add(item);
            }

            foreach (var item in listaAux2)
            {
                listaImagens.Add(item);
            }
            //teste tela = new teste();
            //tela.MdiParent = telaFundo.ActiveForm;
            //tela.Show();
            //MessageBox.Show("qtde itens Random: " + listaRandom.Count + "\nqtde itens Lista 1: " + listaAux1.Count + "\nqtde itens Lista 2: " + listaAux2.Count + "\nqtde itens Lista Imagens: " + listaImagens.Count);
        }

        public static byte[] ObterBytesImagens(Image image)
        {
            using (var stream = new System.IO.MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                var byteArray = new byte[stream.Length];
                stream.Read(byteArray, 0, Convert.ToInt32(stream.Length));
                return byteArray;
            }
        }

        public Boolean CompararImagens(Image img1, Image img2)
        {
            return Enumerable.SequenceEqual(ObterBytesImagens(img1), ObterBytesImagens(img2));
        }

        private void Botao_Click(object sender, EventArgs e)
        {
            try
            {
                Button carta1 = (sender as Button);

                if (carta1.Tag.Equals(0))
                {
                    if (contadorCartas == 2)
                    {
                        //Não faz nada
                    }
                    else if (contadorCartas == 1)
                    {
                        carta1.Tag = 1;
                        contadorCartas++;
                        if (nivel == 1)
                        {
                            switch (carta1.TabIndex)
                            {
                                case 0:
                                    carta1.BackgroundImage = listaImagens[0];
                                    imagemEscolhida2 = listaImagens[0];
                                    break;
                                case 1:
                                    carta1.BackgroundImage = listaImagens[1];
                                    imagemEscolhida2 = listaImagens[1];
                                    break;
                                case 2:
                                    carta1.BackgroundImage = listaImagens[2];
                                    imagemEscolhida2 = listaImagens[2];
                                    break;
                                case 3:
                                    carta1.BackgroundImage = listaImagens[3];
                                    imagemEscolhida2 = listaImagens[3];
                                    break;
                                case 4:
                                    carta1.BackgroundImage = listaImagens[4];
                                    imagemEscolhida2 = listaImagens[4];
                                    break;
                                case 5:
                                    carta1.BackgroundImage = listaImagens[5];
                                    imagemEscolhida2 = listaImagens[5];
                                    break;
                                case 6:
                                    carta1.BackgroundImage = listaImagens[6];
                                    imagemEscolhida2 = listaImagens[6];
                                    break;
                                case 7:
                                    carta1.BackgroundImage = listaImagens[7];
                                    imagemEscolhida2 = listaImagens[7];
                                    break;
                                case 8:
                                    carta1.BackgroundImage = listaImagens[8];
                                    imagemEscolhida2 = listaImagens[8];
                                    break;
                                case 9:
                                    carta1.BackgroundImage = listaImagens[9];
                                    imagemEscolhida2 = listaImagens[9];
                                    break;
                                case 10:
                                    carta1.BackgroundImage = listaImagens[10];
                                    imagemEscolhida2 = listaImagens[10];
                                    break;
                                case 11:
                                    carta1.BackgroundImage = listaImagens[11];
                                    imagemEscolhida2 = listaImagens[11];
                                    break;
                            }
                        }
                        else if (nivel == 2)
                        {
                            switch (carta1.TabIndex)
                            {
                                case 0:
                                    carta1.BackgroundImage = listaImagens[0];
                                    imagemEscolhida2 = listaImagens[0];
                                    break;
                                case 1:
                                    carta1.BackgroundImage = listaImagens[1];
                                    imagemEscolhida2 = listaImagens[1];
                                    break;
                                case 2:
                                    carta1.BackgroundImage = listaImagens[2];
                                    imagemEscolhida2 = listaImagens[2];
                                    break;
                                case 3:
                                    carta1.BackgroundImage = listaImagens[3];
                                    imagemEscolhida2 = listaImagens[3];
                                    break;
                                case 4:
                                    carta1.BackgroundImage = listaImagens[4];
                                    imagemEscolhida2 = listaImagens[4];
                                    break;
                                case 5:
                                    carta1.BackgroundImage = listaImagens[5];
                                    imagemEscolhida2 = listaImagens[5];
                                    break;
                                case 6:
                                    carta1.BackgroundImage = listaImagens[6];
                                    imagemEscolhida2 = listaImagens[6];
                                    break;
                                case 7:
                                    carta1.BackgroundImage = listaImagens[7];
                                    imagemEscolhida2 = listaImagens[7];
                                    break;
                                case 8:
                                    carta1.BackgroundImage = listaImagens[8];
                                    imagemEscolhida2 = listaImagens[8];
                                    break;
                                case 9:
                                    carta1.BackgroundImage = listaImagens[9];
                                    imagemEscolhida2 = listaImagens[9];
                                    break;
                                case 10:
                                    carta1.BackgroundImage = listaImagens[10];
                                    imagemEscolhida2 = listaImagens[10];
                                    break;
                                case 11:
                                    carta1.BackgroundImage = listaImagens[11];
                                    imagemEscolhida2 = listaImagens[11];
                                    break;
                                case 12:
                                    carta1.BackgroundImage = listaImagens[12];
                                    imagemEscolhida2 = listaImagens[12];
                                    break;
                                case 13:
                                    carta1.BackgroundImage = listaImagens[13];
                                    imagemEscolhida2 = listaImagens[13];
                                    break;
                                case 14:
                                    carta1.BackgroundImage = listaImagens[14];
                                    imagemEscolhida2 = listaImagens[14];
                                    break;
                                case 15:
                                    carta1.BackgroundImage = listaImagens[15];
                                    imagemEscolhida2 = listaImagens[15];
                                    break;
                                case 16:
                                    carta1.BackgroundImage = listaImagens[16];
                                    imagemEscolhida2 = listaImagens[16];
                                    break;
                                case 17:
                                    carta1.BackgroundImage = listaImagens[17];
                                    imagemEscolhida2 = listaImagens[17];
                                    break;
                                case 18:
                                    carta1.BackgroundImage = listaImagens[18];
                                    imagemEscolhida2 = listaImagens[18];
                                    break;
                                case 19:
                                    carta1.BackgroundImage = listaImagens[19];
                                    imagemEscolhida2 = listaImagens[19];
                                    break;
                                case 20:
                                    carta1.BackgroundImage = listaImagens[20];
                                    imagemEscolhida2 = listaImagens[20];
                                    break;
                                case 21:
                                    carta1.BackgroundImage = listaImagens[21];
                                    imagemEscolhida2 = listaImagens[21];
                                    break;
                                case 22:
                                    carta1.BackgroundImage = listaImagens[22];
                                    imagemEscolhida2 = listaImagens[22];
                                    break;
                                case 23:
                                    carta1.BackgroundImage = listaImagens[23];
                                    imagemEscolhida2 = listaImagens[23];
                                    break;
                            }
                        }
                        else if (nivel == 3)
                        {
                            switch (carta1.TabIndex)
                            {
                                case 0:
                                    carta1.BackgroundImage = listaImagens[0];
                                    imagemEscolhida2 = listaImagens[0];
                                    break;
                                case 1:
                                    carta1.BackgroundImage = listaImagens[1];
                                    imagemEscolhida2 = listaImagens[1];
                                    break;
                                case 2:
                                    carta1.BackgroundImage = listaImagens[2];
                                    imagemEscolhida2 = listaImagens[2];
                                    break;
                                case 3:
                                    carta1.BackgroundImage = listaImagens[3];
                                    imagemEscolhida2 = listaImagens[3];
                                    break;
                                case 4:
                                    carta1.BackgroundImage = listaImagens[4];
                                    imagemEscolhida2 = listaImagens[4];
                                    break;
                                case 5:
                                    carta1.BackgroundImage = listaImagens[5];
                                    imagemEscolhida2 = listaImagens[5];
                                    break;
                                case 6:
                                    carta1.BackgroundImage = listaImagens[6];
                                    imagemEscolhida2 = listaImagens[6];
                                    break;
                                case 7:
                                    carta1.BackgroundImage = listaImagens[7];
                                    imagemEscolhida2 = listaImagens[7];
                                    break;
                                case 8:
                                    carta1.BackgroundImage = listaImagens[8];
                                    imagemEscolhida2 = listaImagens[8];
                                    break;
                                case 9:
                                    carta1.BackgroundImage = listaImagens[9];
                                    imagemEscolhida2 = listaImagens[9];
                                    break;
                                case 10:
                                    carta1.BackgroundImage = listaImagens[10];
                                    imagemEscolhida2 = listaImagens[10];
                                    break;
                                case 11:
                                    carta1.BackgroundImage = listaImagens[11];
                                    imagemEscolhida2 = listaImagens[11];
                                    break;
                                case 12:
                                    carta1.BackgroundImage = listaImagens[12];
                                    imagemEscolhida2 = listaImagens[12];
                                    break;
                                case 13:
                                    carta1.BackgroundImage = listaImagens[13];
                                    imagemEscolhida2 = listaImagens[13];
                                    break;
                                case 14:
                                    carta1.BackgroundImage = listaImagens[14];
                                    imagemEscolhida2 = listaImagens[14];
                                    break;
                                case 15:
                                    carta1.BackgroundImage = listaImagens[15];
                                    imagemEscolhida2 = listaImagens[15];
                                    break;
                                case 16:
                                    carta1.BackgroundImage = listaImagens[16];
                                    imagemEscolhida2 = listaImagens[16];
                                    break;
                                case 17:
                                    carta1.BackgroundImage = listaImagens[17];
                                    imagemEscolhida2 = listaImagens[17];
                                    break;
                                case 18:
                                    carta1.BackgroundImage = listaImagens[18];
                                    imagemEscolhida2 = listaImagens[18];
                                    break;
                                case 19:
                                    carta1.BackgroundImage = listaImagens[19];
                                    imagemEscolhida2 = listaImagens[19];
                                    break;
                                case 20:
                                    carta1.BackgroundImage = listaImagens[20];
                                    imagemEscolhida2 = listaImagens[20];
                                    break;
                                case 21:
                                    carta1.BackgroundImage = listaImagens[21];
                                    imagemEscolhida2 = listaImagens[21];
                                    break;
                                case 22:
                                    carta1.BackgroundImage = listaImagens[22];
                                    imagemEscolhida2 = listaImagens[22];
                                    break;
                                case 23:
                                    carta1.BackgroundImage = listaImagens[23];
                                    imagemEscolhida2 = listaImagens[23];
                                    break;
                                case 24:
                                    carta1.BackgroundImage = listaImagens[24];
                                    imagemEscolhida2 = listaImagens[24];
                                    break;
                                case 25:
                                    carta1.BackgroundImage = listaImagens[25];
                                    imagemEscolhida2 = listaImagens[25];
                                    break;
                                case 26:
                                    carta1.BackgroundImage = listaImagens[26];
                                    imagemEscolhida2 = listaImagens[26];
                                    break;
                                case 27:
                                    carta1.BackgroundImage = listaImagens[27];
                                    imagemEscolhida2 = listaImagens[27];
                                    break;
                                case 28:
                                    carta1.BackgroundImage = listaImagens[28];
                                    imagemEscolhida2 = listaImagens[28];
                                    break;
                                case 29:
                                    carta1.BackgroundImage = listaImagens[29];
                                    imagemEscolhida2 = listaImagens[29];
                                    break;
                                case 30:
                                    carta1.BackgroundImage = listaImagens[30];
                                    imagemEscolhida2 = listaImagens[30];
                                    break;
                                case 31:
                                    carta1.BackgroundImage = listaImagens[31];
                                    imagemEscolhida2 = listaImagens[31];
                                    break;
                                case 32:
                                    carta1.BackgroundImage = listaImagens[32];
                                    imagemEscolhida2 = listaImagens[32];
                                    break;
                                case 33:
                                    carta1.BackgroundImage = listaImagens[33];
                                    imagemEscolhida2 = listaImagens[33];
                                    break;
                                case 34:
                                    carta1.BackgroundImage = listaImagens[34];
                                    imagemEscolhida2 = listaImagens[34];
                                    break;
                                case 35:
                                    carta1.BackgroundImage = listaImagens[35];
                                    imagemEscolhida2 = listaImagens[35];
                                    break;
                            }
                        }
                        VerificarCartas(imagemEscolhida1, imagemEscolhida2, carta1, carta2);
                    }
                    else
                    {
                        carta1.Tag = 1;
                        contadorCartas++;
                        if (nivel == 1)
                        {
                            switch (carta1.TabIndex)
                            {
                                case 0:
                                    carta1.BackgroundImage = listaImagens[0];
                                    imagemEscolhida1 = listaImagens[0];
                                    break;
                                case 1:
                                    carta1.BackgroundImage = listaImagens[1];
                                    imagemEscolhida1 = listaImagens[1];
                                    break;
                                case 2:
                                    carta1.BackgroundImage = listaImagens[2];
                                    imagemEscolhida1 = listaImagens[2];
                                    break;
                                case 3:
                                    carta1.BackgroundImage = listaImagens[3];
                                    imagemEscolhida1 = listaImagens[3];
                                    break;
                                case 4:
                                    carta1.BackgroundImage = listaImagens[4];
                                    imagemEscolhida1 = listaImagens[4];
                                    break;
                                case 5:
                                    carta1.BackgroundImage = listaImagens[5];
                                    imagemEscolhida1 = listaImagens[5];
                                    break;
                                case 6:
                                    carta1.BackgroundImage = listaImagens[6];
                                    imagemEscolhida1 = listaImagens[6];
                                    break;
                                case 7:
                                    carta1.BackgroundImage = listaImagens[7];
                                    imagemEscolhida1 = listaImagens[7];
                                    break;
                                case 8:
                                    carta1.BackgroundImage = listaImagens[8];
                                    imagemEscolhida1 = listaImagens[8];
                                    break;
                                case 9:
                                    carta1.BackgroundImage = listaImagens[9];
                                    imagemEscolhida1 = listaImagens[9];
                                    break;
                                case 10:
                                    carta1.BackgroundImage = listaImagens[10];
                                    imagemEscolhida1 = listaImagens[10];
                                    break;
                                case 11:
                                    carta1.BackgroundImage = listaImagens[11];
                                    imagemEscolhida1 = listaImagens[11];
                                    break;
                            }
                        }
                        else if (nivel == 2)
                        {
                            switch (carta1.TabIndex)
                            {
                                case 0:
                                    carta1.BackgroundImage = listaImagens[0];
                                    imagemEscolhida1 = listaImagens[0];
                                    break;
                                case 1:
                                    carta1.BackgroundImage = listaImagens[1];
                                    imagemEscolhida1 = listaImagens[1];
                                    break;
                                case 2:
                                    carta1.BackgroundImage = listaImagens[2];
                                    imagemEscolhida1 = listaImagens[2];
                                    break;
                                case 3:
                                    carta1.BackgroundImage = listaImagens[3];
                                    imagemEscolhida1 = listaImagens[3];
                                    break;
                                case 4:
                                    carta1.BackgroundImage = listaImagens[4];
                                    imagemEscolhida1 = listaImagens[4];
                                    break;
                                case 5:
                                    carta1.BackgroundImage = listaImagens[5];
                                    imagemEscolhida1 = listaImagens[5];
                                    break;
                                case 6:
                                    carta1.BackgroundImage = listaImagens[6];
                                    imagemEscolhida1 = listaImagens[6];
                                    break;
                                case 7:
                                    carta1.BackgroundImage = listaImagens[7];
                                    imagemEscolhida1 = listaImagens[7];
                                    break;
                                case 8:
                                    carta1.BackgroundImage = listaImagens[8];
                                    imagemEscolhida1 = listaImagens[8];
                                    break;
                                case 9:
                                    carta1.BackgroundImage = listaImagens[9];
                                    imagemEscolhida1 = listaImagens[9];
                                    break;
                                case 10:
                                    carta1.BackgroundImage = listaImagens[10];
                                    imagemEscolhida1 = listaImagens[10];
                                    break;
                                case 11:
                                    carta1.BackgroundImage = listaImagens[11];
                                    imagemEscolhida1 = listaImagens[11];
                                    break;
                                case 12:
                                    carta1.BackgroundImage = listaImagens[12];
                                    imagemEscolhida1 = listaImagens[12];
                                    break;
                                case 13:
                                    carta1.BackgroundImage = listaImagens[13];
                                    imagemEscolhida1 = listaImagens[13];
                                    break;
                                case 14:
                                    carta1.BackgroundImage = listaImagens[14];
                                    imagemEscolhida1 = listaImagens[14];
                                    break;
                                case 15:
                                    carta1.BackgroundImage = listaImagens[15];
                                    imagemEscolhida1 = listaImagens[15];
                                    break;
                                case 16:
                                    carta1.BackgroundImage = listaImagens[16];
                                    imagemEscolhida1 = listaImagens[16];
                                    break;
                                case 17:
                                    carta1.BackgroundImage = listaImagens[17];
                                    imagemEscolhida1 = listaImagens[17];
                                    break;
                                case 18:
                                    carta1.BackgroundImage = listaImagens[18];
                                    imagemEscolhida1 = listaImagens[18];
                                    break;
                                case 19:
                                    carta1.BackgroundImage = listaImagens[19];
                                    imagemEscolhida1 = listaImagens[19];
                                    break;
                                case 20:
                                    carta1.BackgroundImage = listaImagens[20];
                                    imagemEscolhida1 = listaImagens[20];
                                    break;
                                case 21:
                                    carta1.BackgroundImage = listaImagens[21];
                                    imagemEscolhida1 = listaImagens[21];
                                    break;
                                case 22:
                                    carta1.BackgroundImage = listaImagens[22];
                                    imagemEscolhida1 = listaImagens[22];
                                    break;
                                case 23:
                                    carta1.BackgroundImage = listaImagens[23];
                                    imagemEscolhida1 = listaImagens[23];
                                    break;
                            }
                        }
                        else if (nivel == 3)
                        {
                            switch (carta1.TabIndex)
                            {
                                case 0:
                                    carta1.BackgroundImage = listaImagens[0];
                                    imagemEscolhida1 = listaImagens[0];
                                    break;
                                case 1:
                                    carta1.BackgroundImage = listaImagens[1];
                                    imagemEscolhida1 = listaImagens[1];
                                    break;
                                case 2:
                                    carta1.BackgroundImage = listaImagens[2];
                                    imagemEscolhida1 = listaImagens[2];
                                    break;
                                case 3:
                                    carta1.BackgroundImage = listaImagens[3];
                                    imagemEscolhida1 = listaImagens[3];
                                    break;
                                case 4:
                                    carta1.BackgroundImage = listaImagens[4];
                                    imagemEscolhida1 = listaImagens[4];
                                    break;
                                case 5:
                                    carta1.BackgroundImage = listaImagens[5];
                                    imagemEscolhida1 = listaImagens[5];
                                    break;
                                case 6:
                                    carta1.BackgroundImage = listaImagens[6];
                                    imagemEscolhida1 = listaImagens[6];
                                    break;
                                case 7:
                                    carta1.BackgroundImage = listaImagens[7];
                                    imagemEscolhida1 = listaImagens[7];
                                    break;
                                case 8:
                                    carta1.BackgroundImage = listaImagens[8];
                                    imagemEscolhida1 = listaImagens[8];
                                    break;
                                case 9:
                                    carta1.BackgroundImage = listaImagens[9];
                                    imagemEscolhida1 = listaImagens[9];
                                    break;
                                case 10:
                                    carta1.BackgroundImage = listaImagens[10];
                                    imagemEscolhida1 = listaImagens[10];
                                    break;
                                case 11:
                                    carta1.BackgroundImage = listaImagens[11];
                                    imagemEscolhida1 = listaImagens[11];
                                    break;
                                case 12:
                                    carta1.BackgroundImage = listaImagens[12];
                                    imagemEscolhida1 = listaImagens[12];
                                    break;
                                case 13:
                                    carta1.BackgroundImage = listaImagens[13];
                                    imagemEscolhida1 = listaImagens[13];
                                    break;
                                case 14:
                                    carta1.BackgroundImage = listaImagens[14];
                                    imagemEscolhida1 = listaImagens[14];
                                    break;
                                case 15:
                                    carta1.BackgroundImage = listaImagens[15];
                                    imagemEscolhida1 = listaImagens[15];
                                    break;
                                case 16:
                                    carta1.BackgroundImage = listaImagens[16];
                                    imagemEscolhida1 = listaImagens[16];
                                    break;
                                case 17:
                                    carta1.BackgroundImage = listaImagens[17];
                                    imagemEscolhida1 = listaImagens[17];
                                    break;
                                case 18:
                                    carta1.BackgroundImage = listaImagens[18];
                                    imagemEscolhida1 = listaImagens[18];
                                    break;
                                case 19:
                                    carta1.BackgroundImage = listaImagens[19];
                                    imagemEscolhida1 = listaImagens[19];
                                    break;
                                case 20:
                                    carta1.BackgroundImage = listaImagens[20];
                                    imagemEscolhida1 = listaImagens[20];
                                    break;
                                case 21:
                                    carta1.BackgroundImage = listaImagens[21];
                                    imagemEscolhida1 = listaImagens[21];
                                    break;
                                case 22:
                                    carta1.BackgroundImage = listaImagens[22];
                                    imagemEscolhida1 = listaImagens[22];
                                    break;
                                case 23:
                                    carta1.BackgroundImage = listaImagens[23];
                                    imagemEscolhida1 = listaImagens[23];
                                    break;
                                case 24:
                                    carta1.BackgroundImage = listaImagens[24];
                                    imagemEscolhida1 = listaImagens[24];
                                    break;
                                case 25:
                                    carta1.BackgroundImage = listaImagens[25];
                                    imagemEscolhida1 = listaImagens[25];
                                    break;
                                case 26:
                                    carta1.BackgroundImage = listaImagens[26];
                                    imagemEscolhida1 = listaImagens[26];
                                    break;
                                case 27:
                                    carta1.BackgroundImage = listaImagens[27];
                                    imagemEscolhida1 = listaImagens[27];
                                    break;
                                case 28:
                                    carta1.BackgroundImage = listaImagens[28];
                                    imagemEscolhida1 = listaImagens[28];
                                    break;
                                case 29:
                                    carta1.BackgroundImage = listaImagens[29];
                                    imagemEscolhida1 = listaImagens[29];
                                    break;
                                case 30:
                                    carta1.BackgroundImage = listaImagens[30];
                                    imagemEscolhida1 = listaImagens[30];
                                    break;
                                case 31:
                                    carta1.BackgroundImage = listaImagens[31];
                                    imagemEscolhida1 = listaImagens[31];
                                    break;
                                case 32:
                                    carta1.BackgroundImage = listaImagens[32];
                                    imagemEscolhida1 = listaImagens[32];
                                    break;
                                case 33:
                                    carta1.BackgroundImage = listaImagens[33];
                                    imagemEscolhida1 = listaImagens[33];
                                    break;
                                case 34:
                                    carta1.BackgroundImage = listaImagens[34];
                                    imagemEscolhida1 = listaImagens[34];
                                    break;
                                case 35:
                                    carta1.BackgroundImage = listaImagens[35];
                                    imagemEscolhida1 = listaImagens[35];
                                    break;
                            }
                        }
                        carta2 = carta1;
                    }
                }
                else
                {
                    contadorCartas--;
                    carta1.Tag = 0;
                    carta1.BackgroundImage = Image.FromFile(pastaRaiz + versoCarta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cronometro_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(labelSegundos.Text) < 9)
            {
                labelSegundos.Text = "0" + (Convert.ToInt32(labelSegundos.Text) + 1).ToString();
            }
            else if (Convert.ToInt32(labelSegundos.Text) == 59)
            {
                labelSegundos.Text = "00";
                if (Convert.ToInt32(labelMinutos.Text) < 9)
                {
                    labelMinutos.Text = "0" + (Convert.ToInt32(labelMinutos.Text) + 1).ToString();
                }
                else
                {
                    labelMinutos.Text = (Convert.ToInt32(labelMinutos.Text) + 1).ToString();
                }
            }
            else
            {
                labelSegundos.Text = (Convert.ToInt32(labelSegundos.Text) + 1).ToString();
            }
        }

        private void menuReiniciar_Click(object sender, EventArgs e)
        {
            DefinirTabelaAtual();
            listaImagens.Clear();
            tabelaAtual.Controls.Clear();
            IniciarPrograma();
        }

        private int ContarItensPasta()
        {
            int cont = 0;
            foreach (var item in pasta.GetFiles())
            {
                cont++;
            }
            return cont;
        }

        private async void btnAvancar_Click(object sender, EventArgs e)
        {
            if (nivel == 3)
            {
                ptBoxErro.BackgroundImage = Image.FromFile(@"imagens/sem_niveis2.jpg");
                ptBoxErro.Visible = true;
                await Espera(1000);
                ptBoxErro.Visible = false;
            }
            else if (ContarItensPasta() < 12)
            {
                ptBoxErro.BackgroundImage = Image.FromFile(@"imagens/sem_niveis.jpg");
                ptBoxErro.Visible = true;
                await Espera(1000);
                ptBoxErro.Visible = false;
            }
            else
            {
                if (concluido == true)
                {
                    nivel++;
                    concluido = false;
                    DefinirTabelaAtual();
                    listaImagens.Clear();
                    tabelaAtual.Controls.Clear();
                    IniciarPrograma();
                }
                else
                {
                    ptBoxErro.BackgroundImage = Image.FromFile(@"imagens/fim_nivel.jpg");
                    ptBoxErro.Visible = true;
                    await Espera(1000);
                    ptBoxErro.Visible = false;
                }
            }
        }

        private void ReabrirListaCategorias()
        {
            telaInicial tela = new telaInicial();
            tela.MdiParent = telaFundo.ActiveForm;
            tela.Show();
            listaAux0.Clear();
            listaAux1.Clear();
            listaAux2.Clear();
            listaImagens.Clear();
            listaRandom.Clear();
            if (telaInicial.adm == true)
            {
                tela.menuCriarCategoria.Visible = true;
                tela.menuRemoverCategoria.Visible = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panelResultados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelErro_Click(object sender, EventArgs e)
        {

        }

        private void telaJogo_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            ReabrirListaCategorias();
            this.Close();
        }
    }
}
