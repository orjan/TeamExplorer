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


public class Index_Auto_2fIssues_2fByCharterId : Raven.Database.Linq.AbstractViewGenerator
{
	public Index_Auto_2fIssues_2fByCharterId()
	{
		this.ViewText = @"from doc in docs.Issues
select new { CharterId = doc.CharterId }";
		this.ForEntityNames.Add("Issues");
		this.AddMapDefinition(docs => 
			from doc in docs
			where string.Equals(doc["@metadata"]["Raven-Entity-Name"], "Issues", System.StringComparison.InvariantCultureIgnoreCase)
			select new {
				CharterId = doc.CharterId,
				__document_id = doc.__document_id
			});
		this.AddField("CharterId");
		this.AddField("__document_id");
		this.AddQueryParameterForMap("CharterId");
		this.AddQueryParameterForMap("__document_id");
		this.AddQueryParameterForReduce("CharterId");
		this.AddQueryParameterForReduce("__document_id");
	}
}
