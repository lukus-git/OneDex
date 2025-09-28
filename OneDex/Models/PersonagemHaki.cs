using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneDex.Models
{
    public class PersonagemHaki
    {
        // Chave composta (Personagem + Haki)
        [Key, Column(Order = 0)]
        public int PersonagemNumero { get; set; }
        [ForeignKey("PersonagemNumero")]
        public Personagem Personagem { get; set; }

        [Key, Column(Order = 1)]
        public int HakiId { get; set; }
        [ForeignKey("HakiId")]
        public Haki Haki { get; set; }     
    }
}