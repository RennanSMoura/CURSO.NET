// O conceito de polimorfismo é de sobrescrever métodos de classes herdadas, fazendo com que seja possível reutilizar um determinado método, mas sobrescrevendo a classe anterior
using Construtor_Heranca.Models;

Aluno aluno = new Aluno();

aluno.Nome = "Rennan";
aluno.Idade = 20;
aluno.Nota = 10;
aluno.Apresentar();

Professor professor = new Professor();
professor.Nome = "Leonardo";
professor.Idade = 30;
professor.Salario = 1000;
professor.Apresentar();
