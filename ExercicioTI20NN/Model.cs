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

        //Exercício 27: Faça um algoritmo que leia a idade de uma pessoa expressa em anos,
        //meses e dias e escreva a idade dessa pessoa expressa apenas em dias.
        //Considerar ano com 365 dias e mês com 30 dias.
        public int ExercicioVinteSete(int dia, int mes, int ano)
        {
            int idade = 0;

            idade = (ano * 365) + (mes * 12) + dia;

            return idade;
        }


        //Exercício 28:  Ler o salário fixo e o valor das vendas efetuadas pelo
        //vendedor de uma empresa.Sabendo-se que ele recebe uma
        //comissão de 3% sobre o total das vendas até R$ 1.500,00
        //mais 5% sobre o que ultrapassar este valor, calcular e
        //escrever o seu salário total
        public double ExercicioVinteOito(double salarioFixo, double vendas)
        {
            double vendasComissao = 0;

            if(vendas <= 1500)
            {
                vendasComissao = vendas * 0.03;
            }
            else if(vendas > 1500) 
            {
                vendasComissao = vendas * 0.05;
            }

            return salarioFixo + vendasComissao;
        }

        //Exercício 29: Ler 10 valores e escrever quantos desses valores lidos são NEGATIVOS.
        public int ExercicioVinteNove()
        {
            int num = 0;
            int cont = 0;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe um número: ");
                num = Convert.ToInt32(Console.ReadLine());

                if(num < 0)
                {
                    cont++;
                }
            }
            return cont;
        }


        //Exercício 30: Escreva um algoritmo para ler 10 números. Todos os
        //números lidos com valor inferior a 40 devem ser somados.
        //Escreva o valor final da soma efetuada

        public int ExercicioTrinta()
        {
            int num = 0;
            int soma = 0;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe um numero: ");
                num = Convert.ToInt32(Console.ReadLine());

                if(num < 40)
                {
                    soma += num;
                }
            }
            return soma;
        }

        //Exercício 31: Escreva um algoritmo que permita a leitura das notas de
        //uma turma de 20 alunos.Calcular a média da turma.Escrever a média da turma.

        public double ExercicioTrintaUm()
        {
            double media = 0;
            double nota = 0;
            double soma = 0;
            for(int i = 0; i <= 20; i++)
            {
                Console.WriteLine("Informe um numero: ");
                nota = Convert.ToInt32(Console.ReadLine());

                soma += nota;

                media = soma / 20;

            }
            return media;
        }

        //Exercício 32: Faça um algoritmo que calcule a quantidade de litros de
        //combustível gasta em uma viagem, utilizando um automóvel
        //que faz 12Km por litro.Para obter o cálculo, o usuário deve
        //fornecer o tempo gasto na viagem e a velocidade média
        //durante ela.Desta forma, será possível obter a distância
        //percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE.
        //Tendo o valor da distância, basta calcular a quantidade de
        //litros de combustível utilizada na viagem com a fórmula:
        //LITROS_USADOS = DISTANCIA / 12.O programa deve
        //apresentar os valores da velocidade média, tempo gasto na
        //viagem, a distância percorrida e a quantidade de litros
        //utilizada na viagem

        public string ExercicioTrintaDois(double tempo, double velociMedia)
        {
            double distancia = 0;
            double litrosUsados = 0;

            distancia = tempo * velociMedia;
            
            litrosUsados = distancia / 12;

            return "A velocidade média é de: " + velociMedia + "\n O tempo gasto na viagem é de: " + tempo + "\n A distância percorrida é de: " + distancia + "\n A quantidade de litros utilizada é de: " + litrosUsados;
        }

        //Exercício 33: Escreva um algoritmo para ler as dimensões de um retângulo (base e
        //altura), calcular e escrever a área do retângulo

        public string ExercicioTrintaTres(double bases, double altura)
        {
            double area = 0;

            area = bases * altura / 2;

            return "A area do tringulo é de: " + area;
        }

        //Exercício 34: Escreva um algoritmo para ler o número total de eleitores de um
        //município, o número de votos brancos, nulos e válidos.Calcular e
        //escrever o percentual que cada um representa em relação ao total de eleitores 
        //total/voto * 100
        public string ExercicioTrintaQuatro(double totalEleitores, double votosBrancos, double votosValidos, double votosNulos)
        {
            return "O total de eleitores é de: " + totalEleitores + "\nA porcentagem de votos branco é de: " + (votosBrancos / totalEleitores) * 100 + "%" + "\nA porcentagem de votos nulos é de: " + (votosNulos / totalEleitores) * 100 + "%" + "\nA porcentagem de votos validos é de: " + (votosValidos / totalEleitores) * 100 + "%";
        }


        //Exercício 35: O custo de um carro novo ao consumidor é a soma do custo de fábrica
        //com a porcentagem do distribuidor e dos impostos(aplicados ao custo
        //de fábrica). Supondo que o percentual do distribuidor seja de 28% e os
        //impostos de 45%, escrever um algoritmo para ler o custo de fábrica de
        //um carro, calcular e escrever o custo final ao consumidor.
        public string ExercicioTrintaCinco(double custoFabrica)
        {
            double valorDistribuidor = 0;
            double valorImposto = 0;
            double valorFinal = 0;

            valorDistribuidor = custoFabrica * 0.28;
            valorImposto = custoFabrica * 0.45;
            valorFinal = custoFabrica + valorDistribuidor + valorImposto;

            return "O valor final do carro é de: " + valorFinal;
        }

        //Exercício 36: Uma revendedora de carros usados paga a seus funcionários
        //vendedores um salário fixo por mês, mais uma comissão também fixa
        //para cada carro vendido e mais 5% do valor das vendas por ele
        //efetuadas.Escrever um algoritmo que leia o número de carros por ele
        //vendidos, o valor total de suas vendas, o salário fixo e o valor que ele
        //recebe por carro vendido. Calcule e escreva o salário final do vendedor.
        public string ExercicioTrintaSeis(double salarioFixo, double comissaoFixa, double carrosVendidos, double valorVendas)
        {
            double salarioFinal = 0;
            double comissaoVendas = 0;

            comissaoVendas = valorVendas * 0.05;
            salarioFinal = salarioFixo + comissaoFixa + comissaoVendas;

            return "O salario fixo é de: R$ " + salarioFixo + "\nO numero de carros vendido foi de: " + carrosVendidos + "\nO valor total das vendas foi de: R$ " + valorVendas + "\nO salario final é de: R$ " + salarioFinal;
        }



        //Exercício 37:  Faça um programa que imprima os números de 1 a 100,
        //mas substitua os múltiplos de 3 por "Fizz" e os múltiplos de 5 por "Buzz".
        //Para números que são múltiplos de ambos (3 e 5), imprima "FizzBuzz".
        public string ExercicioTrintaSete()
        {
            string multiplo = "";
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    multiplo += "\n" + "Fiz";
                }              
                else if(i % 5 == 0)
                {
                    multiplo += "\n" + "Buzz";
                }
                else if(i % 3 == 0 && i % 5 == 0)
                {
                    multiplo += "\n" + "FizBuzz";
                }
                else
                {
                    multiplo += "\n" + i;
                }
            }
            return multiplo;
        }


        //Exercício 38: Faça um programa que imprima os números de 100 a 1, em ordem decrescente.

        public string ExercicioTrintaOito()
        {
            string num = "";
            for (int i = 100; i >= 1; i--)
            {
                num += "\n" + i;
            }
            return num;
        }

        //Exercício 39: Faça um programa que peça ao usuário uma palavra e imprima
        //cada letra dela em uma linha.
        public string ExercicioTrintaNove(string palavra)
        {

        }


        //Exercício 40:  Faça um programa que peça ao usuário um número e imprima
        //a soma dos números pares até esse número.

        //Exercício 41: Faça um algoritmo que leia os valores de A, B, C e em
        //seguida imprima na tela a soma entre A e B é mostre se a soma é menor que C.



        //Exercício 42: Faça um algoritmo que leia dois valores inteiros A e B,
        //se os valores de A e B forem iguais, deverá somar os dois valores,
        //senão deverá multiplicar. Ao final de qualquer um dos cálculos deve-se
        //atribuir o resultado a uma variável C e imprimir na tela.



        //Exercício 43: Faça um algoritmo que receba um número inteiro e imprima na
        //tela o seu antecessor e o seu sucessor.



        //Exercício 44: Faça um algoritmo que leia o valor do salário mínimo e o
        //valor do salário de um usuário, calcule quantos salários mínimos esse 
        //usuário ganha e imprima na tela o resultado.



        //Exercício 45:  Faça um algoritmo que leia três valores inteiros diferentes e
        //imprima na tela os valores em ordem decrescente.



        //Exercício 46:Faça um algoritmo que leia quatro notas obtidas por um aluno,
        //calcule a média das nota obtidas, imprima na tela o nome do aluno e 
        //se o aluno foi aprovado ou reprovado.
        //Para o aluno ser considerado aprovado sua média final deve ser maior ou igual a 7.



        //Exercício 47: Faça um algoritmo que receba um valor A e B, e troque o valor de A por B e o
        //valor de B por A e imprima na tela os valores.



        //Exercício 48: Faça um algoritmo que leia o ano em que uma pessoa nasceu,
        //imprima na tela quantos anos, meses e dias essa pessoa ja viveu. Leve em 
        //consideração o ano com 365 dias e o mês com 30 dias. (Ex: 5 anos, 2 meses e 15 dias de vida)



        //Exercício 49: Faça um algoritmo que leia três valores que representam os três lados
        //de um triângulo e verifique se são válidos, determine se o triângulo é 
        //equilátero, isósceles ou escaleno.



        //Exercício 50: Faça um algoritmo que calcule a quantidade de litros de combustível
        //gastos em uma viagem, sabendo que o carro faz 12km com um litro.
        //Deve-se fornecer ao usuário o tempo que será gasto na viagem a sua velocidade média,
        //distância percorrida e a quantidade de litros utilizados para fazer a viagem.
        // Fórmula: distância = tempo x velocidade.  litros usados = distância / 12.
    }//fim da classe
}//fim do projeto
