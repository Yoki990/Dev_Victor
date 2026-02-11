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
    internal class RecetteIngredient
    {
        /*[Key]
        [Column("recette_id")]
        public int IdRecette { get; set; }

        [Key]
        [Column("ingredient_id")]
        public int IdIngredient { get; set; }*/

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("Id_recette")]
        public int? IdRecette { get; set; }

        [Required]
        [Column("Id_ingredient")]
        public int? IdIngredient { get; set; }

        [StringLength(10)]
        [NotNull]
        public string Quantite { get; set; }

        public RecetteIngredient() { }

        public RecetteIngredient(int idRecette, int idIngredient, string quantite)
        {
            IdRecette = idRecette;
            IdIngredient = idIngredient;
            Quantite = quantite;
        }

        public override string ToString()
        {
            return $"{IdRecette} avec {Quantite} de {IdIngredient}";
        }
    }
}
