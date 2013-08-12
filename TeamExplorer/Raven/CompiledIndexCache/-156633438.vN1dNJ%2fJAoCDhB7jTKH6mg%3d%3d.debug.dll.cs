using Raven.Abstractions;
using Raven.Database.Linq;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System;
using Raven.Database.Linq.PrivateExtensions;
using Lucene.Net.Documents;
using System.Globalization;
using System.Text.RegularExpressions;
using Raven.Database.Indexing;


public class Index_Auto_2fCharters_2fByIsActiveAndTitleSortByTitle : Raven.Database.Linq.AbstractViewGenerator
{
	public Index_Auto_2fCharters_2fByIsActiveAndTitleSortByTitle()
	{
		this.ViewText = @"from doc in docs.Charters
select new { IsActive = doc.IsActive, Title = doc.Title }";
		this.ForEntityNames.Add("Charters");
		this.AddMapDefinition(docs => 
			from doc in docs
			where string.Equals(doc["@metadata"]["Raven-Entity-Name"], "Charters", System.StringComparison.InvariantCultureIgnoreCase)
			select new {
				IsActive = doc.IsActive,
				Title = doc.Title,
				__document_id = doc.__document_id
			});
		this.AddField("IsActive");
		this.AddField("Title");
		this.AddField("__document_id");
		this.AddQueryParameterForMap("IsActive");
		this.AddQueryParameterForMap("Title");
		this.AddQueryParameterForMap("__document_id");
		this.AddQueryParameterForReduce("IsActive");
		this.AddQueryParameterForReduce("Title");
		this.AddQueryParameterForReduce("__document_id");
	}
}
