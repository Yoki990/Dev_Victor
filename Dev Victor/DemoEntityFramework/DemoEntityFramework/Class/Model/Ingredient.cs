using Microsoft.EntityFrameworkCore.Metadata.Conventions;
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
    [Table("Ingrédient")]
    internal class Ingredient
    {
        [Key]
        [Column("ingredient_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdIngredient { get; set; }

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

        public Ingredient() { }

        public Ingredient(string nom, string description)
        {
            Nom = nom;
            Description = description;
        }

        public override string ToString()
        {
            return $"Id: {IdIngredient}, Nom : {Nom}, Description: {Description}";
        }
    }
}
