using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OneDex.Models
{
    public class Regiao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Nome da região (ex: East Blue, Grand Line e etc)
        [Required, StringLength(30)]
        public string Nome { get; set; }

        // Lista de personagens pertencentes a essa região
        public ICollection<Personagem> Personagens { get; set; }
    }
}