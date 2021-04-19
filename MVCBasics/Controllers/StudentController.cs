using DataLayer;
using MVCBasics.Models;

namespace MVCBasics.Controllers
{
    public class StudentController : BaseController<StudentModel>
    {

        public StudentController(IBaseRepositry<StudentModel> repo) : base(repo)
        {
        }

    }
}
