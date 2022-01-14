using System;
using System.Collections.Generic;
using System.Text;

namespace Arsina.Framework.RestApi.Results
{
	public class PaginatedResult<T> : ResultBase
	{
		public PaginatedResult() : base(false, null) { }
		public PaginatedResult(IList<T> items, int totalCount, int pageNumber = 0, bool isSuccessful = true, string message = "") : base(isSuccessful, message)
		{
			this.Items = items;
			this.PageNumber = pageNumber;
			this.TotalCount = totalCount;
		}

		public IList<T> Items { get; }
		public int PageNumber { get; set; }
		public int PageSize { get; set; }
		public int TotalCount { get; set; }
	}
}
