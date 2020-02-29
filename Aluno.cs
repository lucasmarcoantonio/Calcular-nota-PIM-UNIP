using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Aluno___Fabricio
{
    class Aluno
    {
        public string NomeAluno;
        public string RA;
        public int Idade;
        public float Nota1;
        public float Nota2;
        public float NotaPim;
        public float Media;
        

        public void Status()
        {
            Console.WriteLine("Aluno: {0}\tRA: {1}\t\tIdade: {2}\tNota B1: {3}\tNota B2: {4}\tNota PIM: {5}\tMedia: {6}",
                               NomeAluno,RA,Idade,Nota1,Nota2,NotaPim,Media);
        }


       
    }
}
