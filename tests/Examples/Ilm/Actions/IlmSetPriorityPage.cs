using Elastic.Elasticsearch.Xunit.XunitPlumbing;
using System.ComponentModel;
using Nest;

namespace Examples.Ilm.Actions
{
	public class IlmSetPriorityPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		[Description("ilm/actions/ilm-set-priority.asciidoc:29")]
		public void Line29()
		{
			// tag::149a0eea54cdf6ea3052af6dba2d2a63[]
			var response0 = new SearchResponse<object>();
			// end::149a0eea54cdf6ea3052af6dba2d2a63[]

			response0.MatchesExample(@"PUT _ilm/policy/my_policy
			{
			  ""policy"": {
			    ""phases"": {
			      ""warm"": {
			        ""actions"": {
			          ""set_priority"" : {
			            ""priority"": 50
			          }
			        }
			      }
			    }
			  }
			}");
		}
	}
}