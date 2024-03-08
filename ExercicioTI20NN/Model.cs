﻿using System;
using System.Collections.Generic;
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



    }//fim da classe
}//fim do projeto
