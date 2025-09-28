using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OneDex.Models
{
    public class Genero
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Nome do gênero (ex: Masculino, Feminino)
        [Required, StringLength(30)]
        public string Nome { get; set; }

        // Lista de personagens que possuem este gênero
        public ICollection<Personagem> Personagens { get; set; }
    }
}