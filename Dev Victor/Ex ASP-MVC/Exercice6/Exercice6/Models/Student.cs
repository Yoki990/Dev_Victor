using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Prénom requis")]
        [Range(0, 120, ErrorMessage = "Saisie incorrecte")]
        public string FirstName {  get; set; }

        [Required(ErrorMessage = "Nom requis")]
        [Range(0, 120, ErrorMessage = "Saisie incorrecte")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Âge requis")]
        [Range(0,120,ErrorMessage = "Âge compris entre 0 et 120 ans SVP")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Email requis")]
        [EmailAddress(ErrorMessage = "Saisie incorrecte")]
        public string Email {  get; set; }


        public Student() { }

        public Student(int id, string firstName, string lastName, int age, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
        }
    }
}
