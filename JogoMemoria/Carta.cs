using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoMemoria
{
    class Carta
    {
        public static void ImagensBotoesNivel1(Button b, List<Image> lista, List<Image> lista2, Image img)
        {
            switch (b.TabIndex)
            {
                case 0:
                    b.BackgroundImage = lista[0];
                    img = lista[0];
                    break;
                case 1:
                    b.BackgroundImage = lista[1];
                    img = lista[1];
                    break;
                case 2:
                    b.BackgroundImage = lista[2];
                    img = lista[2];
                    break;
                case 3:
                    b.BackgroundImage = lista[3];
                    img = lista[3];
                    break;
                case 4:
                    b.BackgroundImage = lista2[0];
                    img = lista2[0];
                    break;
                case 5:
                    b.BackgroundImage = lista2[1];
                    img = lista2[1];
                    break;
                case 6:
                    b.BackgroundImage = lista2[2];
                    img = lista2[2];
                    break;
                case 7:
                    b.BackgroundImage = lista2[3];
                    img = lista2[3];
                    break;
            }
        }

        public static void ImagensBotoesNivel2(Button b, List<Image> lista, List<Image> lista2, Image img)
        {
            switch (b.TabIndex)
            {
                case 0:
                    b.BackgroundImage = lista[0];
                    img = lista[0];
                    break;
                case 1:
                    b.BackgroundImage = lista[1];
                    img = lista[1];
                    break;
                case 2:
                    b.BackgroundImage = lista[2];
                    img = lista[2];
                    break;
                case 3:
                    b.BackgroundImage = lista[3];
                    img = lista[3];
                    break;
                case 4:
                    b.BackgroundImage = lista[4];
                    img = lista[4];
                    break;
                case 5:
                    b.BackgroundImage = lista[5];
                    img = lista[5];
                    break;
                case 6:
                    b.BackgroundImage = lista[6];
                    img = lista[6];
                    break;
                case 7:
                    b.BackgroundImage = lista[7];
                    img = lista[7];
                    break;
                case 8:
                    b.BackgroundImage = lista2[0];
                    img = lista2[0];
                    break;
                case 9:
                    b.BackgroundImage = lista2[1];
                    img = lista2[1];
                    break;
                case 10:
                    b.BackgroundImage = lista2[2];
                    img = lista2[2];
                    break;
                case 11:
                    b.BackgroundImage = lista2[3];
                    img = lista2[3];
                    break;
                case 12:
                    b.BackgroundImage = lista2[4];
                    img = lista2[4];
                    break;
                case 13:
                    b.BackgroundImage = lista2[5];
                    img = lista2[5];
                    break;
                case 14:
                    b.BackgroundImage = lista2[6];
                    img = lista2[6];
                    break;
                case 15:
                    b.BackgroundImage = lista2[7];
                    img = lista2[7];
                    break;
            }
        }
    }
}
