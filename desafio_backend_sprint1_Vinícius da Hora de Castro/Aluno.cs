using System;
using System.Collections.Generic;
using System.Text;

namespace desafio_backend_sprint1_Vinícius_da_Hora_de_Castro
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Casa { get; set; }
        public double Notas { get; set; }
        public double Media { get; set; }
        public void LancarFeitico()
        {
            Console.WriteLine($"O(a) aluno(a) {Nome} falhou em lançar um feitiço!");
            Console.WriteLine(@"
     ＜~ヽ、
    　/　　＼
    ,' ==＝=｀､
  ＜__( ಥ︿ಥ)_＞ 
    ⊂　　   つ━━💨...
      しーーＪ  ");
        }

        public Aluno(string nome, string casa, double media, double notas)
        {
            Nome = nome;
            Casa = casa;
            Notas = notas;
            Media = media;
        }
    }
}
