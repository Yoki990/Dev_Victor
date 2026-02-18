using Exercice6.Interfaces;
using Exercice6.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository repo)
        {
            _studentRepository = repo;
        }

        public List<Student> Students()
        {
            return _studentRepository.GetAll();
        }

        public Student AddStudent(Student student)
        {
            return _studentRepository.AddStudent(student);
        }
    }
}
