using DevoirRest.Context;
using DevoirRest.DAO.IDAO;
using DevoirRest.Model;
using DevoirRest.PatternRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevoirRest.DAO.ImplDAO
{
    public class StudentDAO : Repository<Student>, IStuddentDAO
    {
        public StudentDAO() : base(Ctx)
        {

        }

    }
}
