using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class MainPanel : Form
    {
        private static string Liczba = "";
        private static string Liczba2 = "";
        private static string Znak = "";
        private static bool _click = false; // naciskanie pozostałych znaków
        private static bool _click2 = false; //czy = było naciśnięte
        private static bool _click3 = false; 
        private static double wynik = 0;
        
      
    
        public MainPanel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Operacje(string znak)
        {
            if (_click)
            {
                if (Liczba != "")
                {
                    if (_click2)
                    {
                        if (_click3)
                        {
                            wynik = Functionality.Equals(Znak, Liczba, Liczba2);
                            Wynik.Text = wynik.ToString();
                            Liczba2 = "";
                            Liczba = "";
                            _click = false;
                            _click3 = false;
                        }
                        else
                        {
                            wynik = Functionality.Equals(Znak, Liczba, Liczba2);
                            Wynik.Text = wynik.ToString();
                            _click = true;
                        }
                    }
                    else
                    {
                        wynik = Functionality.Equals(Znak, Liczba, Liczba2);
                        Wynik.Text = wynik.ToString();
                        Liczba2 = wynik.ToString();
                        Liczba = "";
                        _click = false;
                    }
                }
                else
                {
                    _click = false;
                }
            }
            else
            {
                if (Liczba2 != "")
                {
                    if (_click2)
                    {
                        if (_click3)
                        {
                            wynik = Functionality.Equals(Znak, Liczba2, Liczba);
                            Wynik.Text = wynik.ToString();
                            Liczba = "";
                            Liczba2 = "";
                            _click = false;
                            _click3 = false;
                        }
                        else
                        {
                            wynik = Functionality.Equals(Znak, Liczba2, Liczba);
                            Wynik.Text = wynik.ToString();
                            _click = false;
                        }
                    }
                    else
                    {
                        wynik = Functionality.Equals(Znak, Liczba2, Liczba);
                        Wynik.Text = wynik.ToString();
                        Liczba = wynik.ToString();
                        Liczba2 = "";
                        _click = true;
                    }
                }
                else
                    _click = true;
            }
            Znak = znak;
        }
       
        

        

        private void Wynik_Click(object sender, EventArgs e)
        {
            

        }

        private void Wyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Jeden_Click(object sender, EventArgs e)
        {
            _click3 = true;
            if (_click)
            {
                Liczba2 = Liczba2 + "1";
                Wynik.Text = Liczba2;
            }
            else
            {
                Liczba = Liczba + "1";
                Wynik.Text = Liczba;
            }
           
           
        }

        private void Dwa_Click(object sender, EventArgs e)
        {
            _click3 = true;
            if (_click)
            {
                Liczba2 = Liczba2 + "2";
                Wynik.Text = Liczba2;
            }
            else
            {

                Liczba = Liczba + "2";
                Wynik.Text = Liczba;
            }
            
        }

        private void Trzy_Click(object sender, EventArgs e)
        {
            _click3 = true;
            if (_click)
            {
                Liczba2 = Liczba2 + "3";
                Wynik.Text = Liczba2;
            }
            else
            {

                Liczba = Liczba + "3";
                Wynik.Text = Liczba;
            }
            
        }

        private void Cztery_Click(object sender, EventArgs e)
        {
            _click3 = true;
            if (_click)
            {
                Liczba2 = Liczba2 + "4";
                Wynik.Text = Liczba2;
            }
            else
            {

                Liczba = Liczba + "4";
                Wynik.Text = Liczba;
            }
            
        }

        private void Piec_Click(object sender, EventArgs e)
        {
            _click3 = true;
            if (_click)
            {
                Liczba2 = Liczba2 + "5";
                Wynik.Text = Liczba2;
            }
            else
            {

                Liczba = Liczba + "5";
                Wynik.Text = Liczba;
            }
           
        }

        private void Szesc_Click(object sender, EventArgs e)
        {
            _click3 = true;
            if (_click)
            {
                Liczba2 = Liczba2 + "6";
                Wynik.Text = Liczba2;
            }
            else
            {

                Liczba = Liczba + "6";
                Wynik.Text = Liczba;
            }
           
        }

        private void Siedem_Click(object sender, EventArgs e)
        {
            _click3 = true;
            if (_click)
            {
                Liczba2 = Liczba2 + "7";
                Wynik.Text = Liczba2;
            }
            else
            {

                Liczba = Liczba + "7";
                Wynik.Text = Liczba;
            }
           
        }

        private void Osiem_Click(object sender, EventArgs e)
        {
            _click3 = true;
            if (_click)
            {
                Liczba2 = Liczba2 + "8";
                Wynik.Text = Liczba2;
            }
            else
            {

                Liczba = Liczba + "8";
                Wynik.Text = Liczba;
            }
            
        }

        private void Dziewiec_Click(object sender, EventArgs e)
        {
            _click3 = true;
            if (_click)
            {
                Liczba2 = Liczba2 + "9";
                Wynik.Text = Liczba2;
            }
            else
            {

                Liczba = Liczba + "9";
                Wynik.Text = Liczba;
            }
           
           
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            _click3 = true;
            if (_click)
            {
                Liczba2 = Liczba2 + "0";
                Wynik.Text = Liczba2;
            }
            else
            {

                Liczba = Liczba + "0";
                Wynik.Text = Liczba;
            }
        }

        private void Rownosc_Click(object sender, EventArgs e)
        {
            _click2 = true;
            
            Operacje(Znak);
        }

        private void Mnozenie_Click(object sender, EventArgs e)
        {
            _click2 = false;
            _click3 = false;
            Operacje("*");
        }

        private void Dodawanie_Click(object sender, EventArgs e)
        {
            _click2 = false;
            _click3 = false;
            Operacje("+");
        }

        private void Odejmowanie_Click(object sender, EventArgs e)
        {
            _click2 = false;
            _click3 = false;
            Operacje("-");
        }

        private void Dzielenie_Click(object sender, EventArgs e)
        {
            _click3 = false;
            _click2 = false;
            Operacje("/");
        }

        

        private void Przecinek_Click(object sender, EventArgs e)
        {
            if (_click)
            {
                Liczba2 = Liczba2 + ",";
                Wynik.Text = Liczba2;
            }
            else
            {

                Liczba = Liczba + ",";
                Wynik.Text = Liczba;
            }
        }

        private void Kasowanie_Click(object sender, EventArgs e)
        {
            Wynik.Text = 0.ToString();
            Liczba = "";
            Liczba2 = "";
            _click = false;
        }

       

        private void Potegowanie_Click(object sender, EventArgs e)
        {
            _click2 = false;
            _click3 = false;
            Operacje("^");
           
        }

        private void Procenty_Click(object sender, EventArgs e)
        {
            _click2 = false;
            _click3 = false;
            Operacje("%");
           
        }

        private void Pierwiastek_Click(object sender, EventArgs e)
        {
            _click2 = false;
            _click3 = false;
            Operacje("//");
        }
    }
}
