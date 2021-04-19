using DataLayer;
using MVCBasics.Models;

namespace MVCBasics.Controllers
{
    public class SubjectController : BaseController<SubjectModel>
    {

        public SubjectController(IBaseRepositry<SubjectModel> repo) : base(repo)
        {
        }

    }
}
