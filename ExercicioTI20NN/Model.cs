using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI20N
{
    class Model
    {

        //Construtor
        public Model()
        {

        }//fim do método construtor

        //Exercício 01: Faça um programa que imprima os números de 1 a 10.
        public string ExercicioUm()
        {
            string resultado = "";

            for (int i = 0; i < 10; i++)
            {
                resultado += "\n" + (i + 1);
            }

            return resultado;
        }//fim do método

        //Faça um programa que imprima os números pares de 1 a 20.
        public string ExercicioDois()
        {
            string resultado = "";

            for(int i = 0; i < 20; i++)
            {
                if((i+1) % 2 == 0)
                {
                    resultado += "\n" + (i + 1);
                }//fim do if
            }//fim do for

            return resultado;
        }//fim do exercicio dois

        //Exercício 3: Faça um programa que calcule a soma dos números de 1 a 100.
        public int ExercicioTres()
        {
            int soma = 0;

            for(int i=1; i <= 100; i++)
            {
                soma += i;
            }//fim do for

            return soma;
        }//fim do método

        //Exercício 4: Faça um programa que imprima os múltiplos de 5 de 1 a 50.
        public string ExercicioQuatro()
        {
            string multiplo = "";
            for(int i=1; i <= 50; i++)
            {
                if(i % 5 == 0)
                {
                    multiplo += "\n" + i;
                }
            }

            return multiplo;
        }//fim do método
        
        //Exercício 5: Faça um programa que peça ao usuário um número e imprima se é par ou ímpar.
        public string ExercicioCinco(int num)
        {
            if(num % 2 == 0)
            {
                return num + " é par";
            }
            else
            {
                return num + "é ímpar";
            }
        }//fim do método

        //Exercício 6: Faça um programa que peça ao usuário um número e imprima se é positivo, negativo ou zero.
        public string ExercicioSeis(int num)
        {
            if(num < 0)
            {
                return num + " é Negativo!";
            }else if(num > 0)
            {
                return num + " é Positivo!";
            }
            else
            {
                return num + " é Zero!";
            }
        }//fim do método

        //Exercício 7: Faça um programa que peça ao usuário um
        //número e imprima a tabuada desse número.
        public string ExercicioSete(int num)
        {
            string resultado = "";

            for(int i=0; i <= 10; i++)
            {
                resultado += num + " * " + i + " = " + (num * i) + "\n";
            }//fim do for

            return resultado;
        }//fim do método

        //Exercício 8: Faça um programa que peça ao usuário um número e
        //imprima os números de 1 até esse número.
        public string ExercicioOito(int num)
        {
            string resultado = "";

            for(int i=0; i <= num; i++)
            {
                resultado += "\n" + i;
            }

            return resultado;
        }//fim do método

        //Exercício 9: Faça um programa que peça ao usuário um número e
        //imprima a soma dos números de 1 até esse número.
        public int ExercicioNove(int num)
        {
            int soma = 0;

            for (int i = 0; i <= num; i++)
            {
                soma += i;
            }

            return soma;
        }//fim do método

        //Exercício 10: Faça um programa que
        //imprima os números primos de 1 a 20.
        public string ExercicioDez()
        {
            string primos = "2 3 5";
            for(int i=2; i <= 20; i++)
            {
                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0)
                {
                    primos += " " + i;
                }                
            }//fim do for
            return primos;
        }//fim do método

        //Exercício 11: Faça um programa que peça ao usuário um
        //número e verifique se é primo.
        public string ExercicioOnze(int num)
        {
            if (num % 2 != 0 && num % 3 != 0 && num % 5 != 0)
            {
                return "Primo!";
            }else if(num == 2 || num == 3 || num == 5)
            {
                return "Primo!";
            }
            else
            {
                return "Não Primo!";
            }
        }//fim do método

        //Exercício 12: Faça um programa que calcule o fatorial de um número.
        public int ExercicioDoze(int num)
        {
            int fatorial = 1;
            for(int i = num; i >= 1; i--)
            {
                fatorial *= i;  
            }
            return fatorial;
        }//fim do método

        //Exercício 13: Faça um programa que imprima a sequência de Fibonacci
        //até o décimo termo.
        public string ExercicioTreze()
        {
            string resultado = "0 1";
            int fib1 = 0;
            int fib2 = 1;
            int fib3 = 0;
            for(int i = 1; i <= 8; i++)
            {
                fib3 = fib1 + fib2;
                resultado += " " + fib3; 
                fib1 = fib2;
                fib2 = fib3;
            }//fim do for

            return resultado;
        }//fim do método

        //Exercício 14: Faça um programa que peça ao usuário 
        //um número e imprima se é um número de Fibonacci.
        public string ExercicioCatorze(int num)
        {
            string resultado = "0 1";
            int fib1 = 0;
            int fib2 = 1;
            int fib3 = 0;
            for (int i = 1; i <= num-2; i++)
            {
                fib3 = fib1 + fib2;
                resultado += " " + fib3;
                fib1 = fib2;
                fib2 = fib3;
            }//fim do for

            return resultado;
        }//fim do método

        //Exercício 15: Faça um programa que peça ao usuário um
        //número e calcule a soma dos seus dígitos.
        public int ExercicioQuinze(int num)
        {
            string resultado = "" + num; //Convertendo o número para texto
            int tamanho = resultado.Length;//Retorna o tamanho do texto
            int soma = 0;
            for(int i=0; i < tamanho; i++)
            {
                soma += Convert.ToInt32(resultado.Substring(i, 1));//coletando 1 caracter por vez
            }
            return soma;
        }//fim do método
        
        //Exercício 16: Faça um programa que peça ao usuário um número
        //e imprima os números pares e ímpares de 1 até esse número.
        public string ExercicioDezesseis(int num)
        {
            string par = "";
            string impar = "";
            for(int i=1; i <= num; i++)
            {
                if(i % 2 == 0)
                {
                    par += " " + i;
                }
                else
                {
                    impar += " " + i;
                }
            }
            return "Pares: " + par + "\nÍmpares: " + impar;
        }//fim do método

        //Exercicio 17: Faça um programa que peça ao usuario um numero e imprima o dobro desse numero.
        public int ExercicioDezessete(int num)
        {
            int resultado = 0;

            resultado = num * 2;

            return resultado;
        }

        //Exercicio 18: Faça um programa que peça ao usuario dois numeros e imprima a media deles.
        public double ExercicioDezoito( double num1, double num2)
        {
            double media = 0;

            media = (num1 + num2) / 2;

            return media;
        }

        //Exercicio 19: Faça um programa que converta a temperatura de Celsius para Fahrenheit. A formula é F = C * 9/5 + 32.
        public double ExercicioDezenove(double celsius)
        {
            double fahrenheit = 0;

            fahrenheit = celsius * 9 / 5 + 32;

            return fahrenheit;
        }

        //Exercicio 20: Faça um programa que peça o raio de um circulo e imprima a area. A formula é A = pi * raio^2.

        public double ExercicioVinte(double raio)
        {
            double area = 0;

            area = Math.PI * raio * raio; //no lugar de "raio * raio;" poderia colocar "Math.pow(raio, 2);" para fazer a operação da potencia.

            return area;
        }
        
        //Exercicio 21: Faça um programa que peça um numero e imprima seu quadrado.
        public int ExercicioVinteUm(int num)
        {
            int resultado = 0;

            resultado = num * num;

            return resultado;
        }

        //Exercicio 22: Faça um programa que peça dois numeros e imprima o maior deles
        public int ExercicioVinteDois(int num3, int num4)
        {
            if(num3 > num4)
            {
                return num3;
            }
            else
            {
                return num4;
            }
        }

        //Exercicio 23: Faça um programa que peça dois numeros e imprima "São iguais" se forem iguais e "São diferentes" se forem diferentes
        public string ExercicioVinteTres(int num3,int num4)
        {

            if(num3 != num4)
            {
                return "São diferentes";
            }
            else
            {
                return "São iguais";
            }
        }

        //Exericio 24: Faça um porgrama que peça a idade do usario e imprima se ele é maior ou menor de idade
        public string ExercicioVinteQuatro(int num)
        {
            if(num < 18)
            {
                return "Menor de idade";
            }
            else
            {
                return "Maior de idade";
            }
        }

        //Exercicio 25: Faça um programa que peça dois numeros e imprima o menor deles 
        public int ExercicioVinteCinco(int num3, int num4)
        {
            if (num3 < num4)
            {
                return num3;
            }
            else
            {
                return num4;
            }
        }

        //Exercicio 26: Faça um programa que peça a altura e o peso de uma pessoa e calcule o IMC(Indice de Massa Corporal)! A formula é IMC= peso/altura^2

        public double ExercicioVinteSeis(double peso, double altura)
        {
            return peso / (altura * altura);
        } 
    }//fim da classe
}//fim do projeto
