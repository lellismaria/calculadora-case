using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' }); //Implemente o calculo de divisao

            Calculadora calculadora = new Calculadora();
            Stack<Operacoes> pilhaResultados = new Stack<Operacoes>();

            
            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Dequeue();
                try
                {
                    calculadora.calcular(operacao);
                    pilhaResultados.Push(operacao);
                    Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA,operacao.operador,operacao.valorB, operacao.resultado);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Erro:{0}", ex.Message);
                }

                Console.WriteLine("Operações restantes na fila: ");
                foreach (var op in filaOperacoes)
                {
                    Console.WriteLine("{0} {1} {2}", op.valorA, op.operador, op.valorB);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Resultados dos cálculos:");
            foreach (var resultado in pilhaResultados)
            {
                Console.WriteLine("{0} {1} {2} = {3}", resultado.valorA, resultado.operador, resultado.valorB, resultado.resultado);
            }
        }
    }
}
