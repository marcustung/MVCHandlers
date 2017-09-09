using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace HttpHandlerForMVC
{
	public class MarcusHandler : IHttpHandler
	{
		public bool IsReusable
		{
			get
			{
				return false;
			}
		}

		public void ProcessRequest(HttpContext context)
		{
			context.Response.ContentType = "text/plain";
			context.Response.Write("This is a book");
		}
	}
}