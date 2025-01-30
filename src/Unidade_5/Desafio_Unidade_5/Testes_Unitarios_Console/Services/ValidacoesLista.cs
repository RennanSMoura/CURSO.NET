using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Testes_Unitarios_Console.Services
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            List<int> listaSemNegativos = new List<int>();
            foreach(var item in lista)
            {
                if(item >= 0)
                {
                    listaSemNegativos.Add(item);
                }
            }
                return listaSemNegativos;
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numeroEscolhido)
        {
            bool numeroEstaNaLista = false;
            foreach(var item in lista)
            {
                if(item == numeroEscolhido)
                {
                    numeroEstaNaLista = true;
                }
            }
            return numeroEstaNaLista;
        }

        public List<int> MultiplicarNumerosLista(List<int> lista, int multiplicador)
        {
            List<int> listaComNumerosMultiplicados = new List<int>();
            foreach(var item in lista)
            {
                listaComNumerosMultiplicados.Add(item*multiplicador);
            }
            return listaComNumerosMultiplicados;
        }

        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            int maiorNumero = int.MinValue;

            foreach(var item in lista)
            {
                if(item > maiorNumero)
                {
                    maiorNumero = item;
                }
            }
            return maiorNumero;
        }

        public int RetornaMenorNumeroLista(List<int> lista)
        {
            int menorNumero = int.MaxValue;

            foreach(var item in lista)
            {
                if(item < menorNumero)
                {
                    menorNumero = item;
                }
            }
            return menorNumero;
        }
    }
}