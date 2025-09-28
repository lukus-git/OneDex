using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneDex.Models
{
    public class Personagem
    {
        // Chave primária da tabela (auto-incrementa)
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Numero { get; set; }

        // Relacionamento com Regiao
        [Required] // Campo obrigatório
        public int RegiaoId { get; set; }
        [ForeignKey("RegiaoId")] // Define que essa propriedade é uma FK para Regiao
        public Regiao Regiao { get; set; }

        // Relacionamento com Genero
        [Required]
        public int GeneroId { get; set; }
        [ForeignKey("GeneroId")]
        public Genero Genero { get; set; }

        // Nome do personagem (máximo 30 caracteres)
        [Required, StringLength(30)]
        public string Nome { get; set; }

        // Descrição do personagem (máximo 1000 caracteres)
        [StringLength(1000)]
        public string Descricao { get; set; }

        // Afiliação do personagem (Ex: Marinha, Pirata, etc)
        [Required]
        public string Afiliacao { get; set; }

        // Altura do personagem (decimal 5,2 = até 999,99)
        [Required, Column(TypeName = "decimal(5,2)")]
        public decimal Altura { get; set; }

        // Peso do personagem (decimal 7,3 = até 9999,999)
        [Required, Column(TypeName = "decimal(7,3)")]
        public decimal Peso { get; set; }

        // Lista de Hakis do personagem (relacionamento N:N)
        public ICollection<PersonagemHaki> Haki { get; set; }
    }
}