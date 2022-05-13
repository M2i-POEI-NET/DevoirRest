using DevoirRest.BussinessLogic.IServices;
using DevoirRest.DAO.IDAO;
using DevoirRest.DTO.ViewBindingModel;
using DevoirRest.DTO.ViewModel;
using DevoirRest.Model;
using System;

namespace DevoirRest.BussinessLogic.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentDAO _studentDao;
        public StudentService(IStudentDAO studentDao)
        {
            _studentDao = studentDao;
        }

        /// <summary>
        ///     create student
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Create(StudentVM model)
        {
            bool result = false;
            if (model == null )
            {
                return result;
            }
            
            try
            {
                var student = new Student()
                {
                    Code     =  model.Code,      
                    Name = model.Name

                };
                student.BaseCreate(true);
                _studentDao.Insert(student);
                result = true;
                return result;
            }
            catch (Exception e)
            {

                throw e.InnerException;
                
            }
            return result;
        }

        public StudentVBM GetById(int Id)
        {
            if (Id <0)
            {
                return null;
            }
            try
            {
                var result = _studentDao.GetById(Id);
                if (result == null) return null;
                var vbm = new StudentVBM()
                {
                    Code = result.Code,
                    Name = result.Name,
                    Id = result.Id
                };
                return vbm;
            }
            catch (Exception e)
            {

                throw e.InnerException;
            }

        }


    }
}
