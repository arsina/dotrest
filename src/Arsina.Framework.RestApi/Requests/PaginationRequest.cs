using System;
using System.Collections.Generic;
using System.Text;

namespace Arsina.Framework.RestApi.Requests
{
	public class PaginationRequest<TFilterModel>
	{
		public int PageNumber { get; set; }
		public int PageSize { get; set; }
		public TFilterModel Filter { get; set; }
	}
}
