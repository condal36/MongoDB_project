using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSwebapi.Models
{
	public class DeletMemberResponse
	{
		public bool ok { get; set; }
		public string errMsg { get; set; }

		public DeletMemberResponse()
		{
			this.ok = true;
			this.errMsg = "";
		}
	}
}