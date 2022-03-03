using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Among_us
{
    class Dibujo_Figura
    {
        int x, y, alto, ancho;
        int mitadAncho, mitadAlto;

        //Metodo que dibuja la figura
        public void DibujarF(ref Graphics papel, int Alto, int Ancho)
        {
            alto = Alto;//284
            ancho = Ancho;//462

            mitadAncho = ancho / 2;
            mitadAlto = alto / 2;
            Pen lapiz1 = new Pen(Color.Black, 2);
            //Dibuja la Cajit de Among Us
            SolidBrush brocha1 = new SolidBrush(Color.Red);
            Point[] AmongusMochula = new Point[]
             {
                new Point(mitadAncho-110,90),
                new Point(mitadAncho-110,160),
                new Point(mitadAncho-70,160),
                new Point(mitadAncho-70,90),
             };
            papel.DrawPolygon(lapiz1, AmongusMochula);
            papel.FillPolygon(brocha1, AmongusMochula);

            //Cuerpo Among Us
            SolidBrush brocha2 = new SolidBrush(Color.Red);
            papel.FillEllipse(brocha2, mitadAncho - 88, mitadAlto - 95, 107, 80);
            papel.DrawEllipse(lapiz1, mitadAncho - 88, mitadAlto - 95, 107, 80);
            papel.FillRectangle(brocha2, mitadAncho - 88, mitadAlto - 60, 106, 111);            
            papel.DrawRectangle(lapiz1, mitadAncho - 88, mitadAlto - 60, 106, 111);
            SolidBrush brocha3 = new SolidBrush(Color.Red);
            papel.FillRectangle(brocha3, mitadAncho - 87, mitadAlto - 62, 100, 100);

            //Pies del Amoung Us
            SolidBrush brocha4 = new SolidBrush(Color.Black);
            papel.FillEllipse(brocha3, mitadAncho - 88, mitadAlto +63 , 45, 20);
            papel.DrawEllipse(lapiz1, mitadAncho - 88, mitadAlto + 63, 45, 20);
            papel.FillRectangle(brocha3, mitadAncho - 88, mitadAlto + 35, 45, 40);
            papel.DrawRectangle(lapiz1, mitadAncho - 88, mitadAlto + 35, 45, 40);
            papel.FillRectangle(brocha3, mitadAncho - 87, mitadAlto + 6, 50, 44);
            papel.FillRectangle(brocha3, mitadAncho - 87, mitadAlto + 33, 44, 44);

            papel.FillEllipse(brocha3, mitadAncho - 27, mitadAlto + 63, 45, 20);
            papel.DrawEllipse(lapiz1, mitadAncho - 27, mitadAlto + 63, 45, 20);
            papel.FillRectangle(brocha3, mitadAncho - 27, mitadAlto + 35, 45, 40);
            papel.DrawRectangle(lapiz1, mitadAncho - 27, mitadAlto + 35, 45, 39);
            papel.FillRectangle(brocha3, mitadAncho - 26, mitadAlto + 35, 44, 40);
            papel.FillRectangle(brocha3, mitadAncho - 30, mitadAlto + 2, 48, 49);
            

            //Ojo
            SolidBrush brocha5 = new SolidBrush(Color.DarkGray);
            papel.FillEllipse(brocha5, mitadAncho - 39, mitadAlto - 70, 80, 45);
            papel.DrawEllipse(lapiz1, mitadAncho - 39, mitadAlto - 70, 80, 45);


        }
    }
}
