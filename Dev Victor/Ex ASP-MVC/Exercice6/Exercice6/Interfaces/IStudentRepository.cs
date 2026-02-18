using Exercice6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6.Interfaces
{
    public interface IStudentRepository
    {
        public List<Student> GetAll();
        public Student AddStudent(Student student);
    }
}
