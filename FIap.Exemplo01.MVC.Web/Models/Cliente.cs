using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIap.Exemplo01.MVC.Web.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Credito { get; set; }
        [Display(Name = "Possui Necessidades Especiais?")]
        public bool NecessidadesEspeciais { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
