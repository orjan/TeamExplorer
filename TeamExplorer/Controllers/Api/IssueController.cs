using System.Collections.Generic;
using System.Web.Http;
using Raven.Client.Linq;
using TeamExplorer.Models;

namespace TeamExplorer.Controllers.Api
{
    public class IssueController : DocumentApiController
    {
        // GET api/issue
        public IEnumerable<Issue> Get(int charterId)
        {
            return DocumentSession.Query<Issue>().Where(i => i.CharterId == charterId);
        }

        // POST api/issue
        public Issue Post([FromBody]Issue issue)
        {
            DocumentSession.Store(issue);
            return issue;
        }

        // PUT api/issue/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/issue/5
        public void Delete(int id)
        {
        }
    }

    public class IssueTypeController : DocumentApiController
    {
        public IEnumerable<IssueType> Get()
        {
            return DocumentSession.Query<IssueType>();
        }        
    }
}
