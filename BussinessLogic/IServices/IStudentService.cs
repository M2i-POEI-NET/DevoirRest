using DevoirRest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevoirRest.BussinessLogic.IServices
{
    public interface IStudentService
    {
        public Student GetById(int Id);
        public bool Create(Student model);

    }
}
