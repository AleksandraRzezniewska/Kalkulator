using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Functionality
    {
        public static double Equals(string _znak, string _liczba1, string _liczba2)
        {
            double wynik = 0;
            switch (_znak)

            {
                case "+":
                    wynik = float.Parse(_liczba1) + float.Parse(_liczba2);
                    break;
                case "-":
                    wynik = float.Parse(_liczba1) - float.Parse(_liczba2);
                    break;
                case "*":
                    wynik = float.Parse(_liczba1) * float.Parse(_liczba2);
                    break;
                case "/":
                    if (_liczba2 != "0")
                    {
                        wynik = float.Parse(_liczba1) / float.Parse(_liczba2);
                    }
                    else
                    {
                        wynik = 0;
                    }
                    break;
                case "^":
                    wynik = float.Parse(_liczba1) * float.Parse(_liczba1);
                    break;
                case "%":
                    wynik = float.Parse(_liczba1) / 100;
                    break;
                case "//":
                    wynik = Math.Sqrt(Convert.ToDouble(_liczba1));
                    break;

                default:
                    break;
            }
            return wynik;
        }
    }
}
