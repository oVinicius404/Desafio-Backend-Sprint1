using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace desafio_backend_sprint1_Vinícius_da_Hora_de_Castro
{
    public class Aluno : Bruxo
    {
        private List<double> _notas = new List<double>();

        public List<double> Notas
        {
            get => _notas;
            set => _notas = value;
        }

        public double Media => (_notas != null && _notas.Count > 0) ? _notas.Average() : 0;

        public override void LancarFeitico()
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
        public Aluno(string nome, string casa, List<double> notas) : base(nome, casa)
        {
            Nome = nome;
            Casa = casa;
            Notas = notas;
        }
    }
}
