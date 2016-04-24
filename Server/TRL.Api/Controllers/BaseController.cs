namespace Base.Api.Controllers
{
    using System.Web.Http;

    using TRL.Data.UnitOfWork;

    public abstract class BaseController : ApiController
    {
        protected IApplicationData data;

        public BaseController(IApplicationData data)
        {
            this.data = data;
        }
    }
}