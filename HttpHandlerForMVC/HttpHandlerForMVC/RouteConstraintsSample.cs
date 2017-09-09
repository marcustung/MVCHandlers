using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RouteConstraintsSample.HttpHandlers
{
	public class IndexB : IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			var valueFromPathInfo = context.Request.PathInfo.Replace("/", string.Empty);
			var valueFromUrl = context.Request.Url.Segments[2];

			context.Response.ContentType = "text/html";
			context.Response.Write(string.Format("<Path> image id : {0}", valueFromPathInfo));
			context.Response.Write("<br>");
			context.Response.Write(string.Format("<Url> image id : {0}", valueFromUrl));
		}

		public bool IsReusable
		{
			get
			{
				return false;
			}
		}
	}
}