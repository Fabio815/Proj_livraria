using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_livraria.Modelo
{
    internal class TabelaEmprestimos
    {
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }

    }
}
