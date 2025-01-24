using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedade.Models
{
    public class Curso
    {
        public string Nome{get ; set}
        public Lista<Pessoa> Alunos {get; set;}

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno)
        }

        public int ObterQuantidadeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {

            for(int count = 1; count <= Alunos.Count; count++)
        {
            string texto - "N° " + count + " " + Alunos[count].NomeCompleto  ;
            Console.WriteLine(texto);
            
}
            
        }

    }

}