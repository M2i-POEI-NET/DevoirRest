using DevoirRest.BussinessLogic.IServices;
using DevoirRest.DAO.IDAO;
using DevoirRest.DAO.ImplDAO;
using DevoirRest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public bool Create(Student model)
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
                    Code = model.Code,
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

        public Student GetById(int Id)
        {
            if (Id <0)
            {
                return null;
            }
            try
            {
                var result = _studentDao.GetById(Id);
                return result;
            }
            catch (Exception e)
            {

                throw e.InnerException;
            }

        }
    }
}
