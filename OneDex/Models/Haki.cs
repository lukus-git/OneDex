using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneDex.Models
{
    public class Haki
    {
        // Chave primária da tabela
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Nome do tipo de Haki (único e obrigatório)
        [Required, StringLength(40)]
        public string Nome { get; set; }

        // Cor para interface ou visualização
        [Required, StringLength(30)]
        public string Cor { get; set; }

        // Descrição detalhada do Haki
        public string Descricao { get; set; }

        // Lista de personagens que possuem este Haki (relacionamento N:N)
        public ICollection<PersonagemHaki> Personagens { get; set; }
    }
}