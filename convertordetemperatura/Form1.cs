using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace convertordetemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ConsoleWriteLine(string s, string v)
        {
            textBox1.Text += "\r\n" + s + "\r\n";
            textBox1.Text += "\r\n" + v.ToString() + "\r\n";
        }
        public string ConsoleReadLine()
        {

            return textBox2.Text;
        }

        public string ConsoleReadLine2()
        {

            return textBox3.Text;
        }

        public string ConsoleReadLine3()
        {

            return textBox4.Text;
        }

        public void calculeazatemperatura()
        { 
        //main

            ConsoleWriteLine("Selectati directia de conversie","0");
            ConsoleWriteLine("1. Din grade Celsius in grade Fahrenheit", "0");
            ConsoleWriteLine("2. Din grade Fahrenheit in grade Celsius", "0");
            Console.Write(":");
            string selection = ConsoleReadLine();
            double f, c = 0;
            switch (selection)
            {
                case "1":
                    Console.Write("Introduceti temperatura in grade Celsius: ");
                    f = TemperatureConverter.CelsiusToFahrenheit(ConsoleReadLine2());
                    // se afişează rezultatul cu 2 zecimale
                    ConsoleWriteLine("Temperatura in grade Fahrenheit: {0:F2}", f.ToString());
                    break;
                case "2":
                    Console.Write("Introduceti temperatura in grade Fahrenheit: ");
                    c = TemperatureConverter.FahrenheitToCelsius(ConsoleReadLine3());
                    ConsoleWriteLine("Temperatura in grade Celsius: {0:F2}", c.ToString());
                    break;
                default:
                    ConsoleWriteLine("Selectati un tip de conversie","0");
                    break;
            }
            // aşteaptă apăsarea tastei ENTER
            ConsoleReadLine();


        }
        private void Form1_Load(object sender, EventArgs e)
        {

            calculeazatemperatura();
        }
    }
}
