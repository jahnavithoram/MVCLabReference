using DataLayer;
using MVCBasics.Models;

namespace MVCBasics.Controllers
{
    public class EmployeeController : BaseController<EmployeeModel>
    {

        public EmployeeController(IBaseRepositry<EmployeeModel> repo) : base(repo)
        {
        }

    }
}
