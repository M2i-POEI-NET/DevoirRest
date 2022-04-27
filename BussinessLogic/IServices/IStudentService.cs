using DevoirRest.DTO.ViewBindingModel;
using DevoirRest.DTO.ViewModel;
using DevoirRest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevoirRest.BussinessLogic.IServices
{
    public interface IStudentService
    {
        public StudentVBM GetById(int Id);
        public bool Create(StudentVM model);

    }
}
