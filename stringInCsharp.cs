using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "What if Ineed a \nnew line?"; //quebra de linha
            //string myString = "Go to your c:\\ drive";
            //string myString = @"Go to your c:\ drive";

            //string myString = String.Format("{0} = {1}", "First", "Second");

            //string myString = string.Format("{0:C}", 123.45); //{0:C} representa moeda local
            //string myString = string.Format("{0:N}", 12154544684654); // {0:N} organiza o numero em casa decimais
            //string myString = string.Format("Percentage: {0:P}", .123); // P de porcetagem 12,30%
            //string myString = string.Format("Phone Number: {0:(### ###-####)}", 123456890); // formato de numero telefonico

            //string myString = " That summer we took threes acroos the board ";

            //myString = myString.Substring(6, 14); // ele começa apos a posição 6 entre 14
            //myString = myString.ToUpper(); // Tudo em maiucuslo
            //myString = myString.Replace(" ", "--"); //onde tem espeçao vazio na frase ele vai substiruir por --
            //myString = myString.Remove(5, 14); // vai remover da posição 5 até 14
            //myString = String.Format("Length before: {0} -- Length after: {1}", myString.Length, myString.Trim().Length);

            /*
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();//converte int para string
            }
            */

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);

            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
