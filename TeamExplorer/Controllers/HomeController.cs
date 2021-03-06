﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TeamExplorer.Models;
using TeamExplorer.Queries;

namespace TeamExplorer.Controllers
{
    public class HomeController : DocumentController
    {
        public ActionResult Index()
        {
            // Create the first charter if it doensn't exists

            if (!DocumentSession.Query<IssueType>().Any())
            {
                DocumentSession.Store(new IssueType{Name = "Bug"});
                DocumentSession.Store(new IssueType{Name = "Issue"});
                DocumentSession.Store(new IssueType{Name = "Note"});

                DocumentSession.SaveChanges();
            }

            var charter = DocumentSession.Query<Charter>().FirstOrDefault();
            if (charter == null)
            {
                DocumentSession.Store(new Charter
                                          {
                                              Title = "Default charter, something to start with", 
                                              IsActive = true
                                          });

                DocumentSession.SaveChanges();
            }

            IEnumerable<Charter> charters = Query(new ActiveCharters());
            return View(charters);
        }
    }
}
