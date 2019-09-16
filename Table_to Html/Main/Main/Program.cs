using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {

            string jjh = string.Empty;
           string varHtml;
            var encabezado = "<html>";
            var encabezadoC = "</html>";
            var body = "<body>";
            var bodyC = "</body>";
            var tabla = "<table border='1'>";
            var tablaC = "</table>";
            var saltoPagina = "\r\n";
            Console.WriteLine("Este Programa pedira en pantalla las dimensiones de una matriz (tabla de multiplicar ), ");
            Console.WriteLine("los numeros pares tendran fondo negro  y letra en  blanco!! ");
            Console.WriteLine("Digite numero de celdas horizontales: ");


            var horizontal_text = Console.ReadLine();
            //si el usuario no inserta ninguyn valor 
            if (horizontal_text== string.Empty)
            {
                horizontal_text = "10";
            }

            double horizontal = Convert.ToDouble(horizontal_text);

            Console.WriteLine("Digite numero de celdas verticales: ");
            string vertical_Text = Console.ReadLine();
            //si el usuario no inserta ninguyn valor 
            if (vertical_Text == string.Empty)
            {
                vertical_Text = "10";
            }

            double vertical = Convert.ToDouble(vertical_Text);
                       
            Console.WriteLine("ud selecciono una matriz = " + vertical_Text + "X" + horizontal_text);

                        
            var color = string.Empty;
            var  font = string.Empty;
            
            varHtml = encabezado + (saltoPagina);
            varHtml += body + (saltoPagina);
            varHtml += tabla + (saltoPagina);
            varHtml += "<tr>" + (saltoPagina);

            //Prints X
            varHtml += "<td title='WELCOME TO MY  PROGRAM'>" + "X" + "</td>" + (saltoPagina);//prints "x" at the origin

            //Horizontal        
            for (int h = 1; h <= horizontal; ++h)
            {


                varHtml += "<td title='You are over the Horizontal line'>" + h + "</td>" + (saltoPagina); //Prints nummber from 1 to "horizontal"


            }

            varHtml += "</tr>" + (saltoPagina);
            int x = 1;
            int g = 1;

            //Vertical
            for (int v = 1; v <= vertical; ++v)
            {


                varHtml += "<tr>" + (saltoPagina);

                varHtml += "<td title='You are over the vertical line'>" + (v) + "</td>" + (saltoPagina);

                //Horizontal        
                for (int number = 1; number <= horizontal; ++number)// Prints nummber from 1 to   "vertical"
                {

                    int value = x * g;

                    if (value % 2 == 0)//numeros pares
                    {
                        color = "bgcolor='#000000'";//fondo negro
                        font = "font color='white'";

                        //<font color="red">
                    }
                    else//impares
                    {

                        color = "bgcolor='#FF66CC'";// fondo rosa 
                        font = "font color='black'";
                    }


                    //automatizar color
                    var celda = string.Format("<td {0} title='{4}X{5}={3}'> <{2}> {1}</font></td>", color, value,font,value,x,g);
                    varHtml += celda + (saltoPagina);
                   
                    g = g + 1;

                }
                g = 1;
                x = x + 1;

                varHtml += "</tr>" + (saltoPagina);
            }

            varHtml += tablaC + (saltoPagina);
            varHtml += saltoPagina + (saltoPagina);
            varHtml += bodyC + (saltoPagina);
            varHtml += saltoPagina +(saltoPagina);
            varHtml += encabezadoC +(saltoPagina);

            // Console.WriteLine(varHtml);


            

            //WRITE FILE TO HTML
            System.IO.File.WriteAllText(@"D:\MAO_TEST\Table_to Html\MainTablero.html", varHtml);

            
           
        }
    }
}
