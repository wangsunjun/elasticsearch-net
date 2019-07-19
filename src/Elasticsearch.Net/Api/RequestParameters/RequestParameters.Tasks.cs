// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

// ReSharper disable once CheckNamespace
namespace Elasticsearch.Net.Specification.TasksApi
{
	///<summary>Request options for Cancel <para>http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</para></summary>
	public class CancelTasksRequestParameters : RequestParameters<CancelTasksRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		///<summary>A comma-separated list of actions that should be cancelled. Leave empty to cancel all.</summary>
		public string[] Actions
		{
			get => Q<string[]>("actions");
			set => Q("actions", value);
		}

		///<summary>
		/// A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're
		/// connecting to, leave empty to get information from all nodes
		///</summary>
		public string[] Nodes
		{
			get => Q<string[]>("nodes");
			set => Q("nodes", value);
		}

		///<summary>Cancel tasks with specified parent task id (node_id:task_number). Set to -1 to cancel all.</summary>
		public string ParentTaskId
		{
			get => Q<string>("parent_task_id");
			set => Q("parent_task_id", value);
		}
	}

	///<summary>Request options for GetTask <para>http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</para></summary>
	public class GetTaskRequestParameters : RequestParameters<GetTaskRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		///<summary>Explicit operation timeout</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}

		///<summary>Wait for the matching tasks to complete (default: false)</summary>
		public bool? WaitForCompletion
		{
			get => Q<bool? >("wait_for_completion");
			set => Q("wait_for_completion", value);
		}
	}

	///<summary>Request options for List <para>http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</para></summary>
	public class ListTasksRequestParameters : RequestParameters<ListTasksRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		///<summary>A comma-separated list of actions that should be returned. Leave empty to return all.</summary>
		public string[] Actions
		{
			get => Q<string[]>("actions");
			set => Q("actions", value);
		}

		///<summary>Return detailed task information (default: false)</summary>
		public bool? Detailed
		{
			get => Q<bool? >("detailed");
			set => Q("detailed", value);
		}

		///<summary>Group tasks by nodes or parent/child relationships</summary>
		public GroupBy? GroupBy
		{
			get => Q<GroupBy? >("group_by");
			set => Q("group_by", value);
		}

		///<summary>
		/// A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're
		/// connecting to, leave empty to get information from all nodes
		///</summary>
		public string[] Nodes
		{
			get => Q<string[]>("nodes");
			set => Q("nodes", value);
		}

		///<summary>Return tasks with specified parent task id (node_id:task_number). Set to -1 to return all.</summary>
		public string ParentTaskId
		{
			get => Q<string>("parent_task_id");
			set => Q("parent_task_id", value);
		}

		///<summary>Explicit operation timeout</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}

		///<summary>Wait for the matching tasks to complete (default: false)</summary>
		public bool? WaitForCompletion
		{
			get => Q<bool? >("wait_for_completion");
			set => Q("wait_for_completion", value);
		}
	}
}