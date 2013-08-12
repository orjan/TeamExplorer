using System;
using System.Collections.Generic;
using System.Web.Http;
using Raven.Client;
using Raven.Client.Linq;
using TeamExplorer.Models;

namespace TeamExplorer.Controllers.Api
{
    public class IssueController : ApiController
    {
        private IDocumentSession session;
        public IssueController()
        {
            session = MvcApplication.DocumentStore.OpenSession();
        }

        // GET api/issue
        public IEnumerable<Issue> Get()
        {
            return new Issue[]{ new Issue() {Description = "apa"}};
        }

        // GET api/issue
        public IEnumerable<Issue> Get(int charterId)
        {
            using (session)
            {
                return session.Query<Issue>().Where(i => i.CharterId == charterId);
            }
        }

        // POST api/issue
        public Issue Post([FromBody]Issue issue)
        {
            using (session)
            {
                session.Store(issue);
                session.SaveChanges();
                return issue;
            }
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
}
