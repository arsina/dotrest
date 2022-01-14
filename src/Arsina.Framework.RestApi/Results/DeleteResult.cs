using System;
using System.Collections.Generic;
using System.Text;

namespace Arsina.Framework.RestApi.Results
{
	public class DeleteResult<TKey> : ResultBase
	{
		public DeleteResult() : base(false, null) { }

		public DeleteResult(bool isSuccessful, string message, TKey id) : base(isSuccessful, message)
		{
			this.DeleteItemId = id;
		}

		public TKey DeleteItemId { get; set; }
	}
}
