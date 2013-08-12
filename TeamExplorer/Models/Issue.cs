using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace TeamExplorer.Models
{
    public class Issue
    {
        public Issue()
        {
            Images = new Collection<string>();
        }

        public int Id { get; set; }
        public int CharterId { get; set; }

        // TODO: should fix required fields
        //[Required]
        public IssueType IssueType { get; set; }
        //[Required]
        public string Description { get; set; }
        public string IssueDetails { get; set; }
        public string Url { get; set; }
        public string Stacktrace { get; set; }

        /// <summary>
        /// This contains the image src, the actual image should be stored somewhere else later on:
        /// TODO: file or raven attachements
        /// </summary>
        public ICollection<string> Images { get; set; }
    }

    public enum IssueType
    {
        Bug, Issue, Note
    }
}