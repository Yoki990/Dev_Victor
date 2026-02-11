using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.Class.Model
{
    [Table("Recette")]
    internal class Recette
    {
        [Key]
        [Column("recette_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRecette { get; set; }

        [Required]
        [Column("nom")]
        [StringLength(50)]
        [NotNull]
        public string Nom { get; set; }

        [Required]
        [Column("description")]
        [StringLength(200)]
        [NotNull]
        public string Description { get; set; }

        [Required]
        [Column("instructions")]
        [StringLength(int.MaxValue)]
        [NotNull]
        public string Instructions { get; set; }

        public Recette() { }

        public Recette(string nom, string description, string instructions)
        {
            Nom = nom;
            Description = description;
            Instructions = instructions;
        }

        public override string ToString()
        {
            return $"Id: {IdRecette}, Nom : {Nom}, Description: {Description}, Instructions: {Instructions}";
        }

    }
}
