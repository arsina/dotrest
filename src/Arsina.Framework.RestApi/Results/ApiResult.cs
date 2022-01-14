using System;
using System.Collections.Generic;
using System.Text;

namespace Arsina.Framework.RestApi.Results
{
	public class ApiResult<T> : ResultBase where T : class
	{
		public ApiResult() : base(false, "")
		{

		}
		public ApiResult(bool isSuccessful, T data = null, string message = null)
			: base(isSuccessful, message)
		{
			this.Data = data;
		}
		public T Data { get; set; }
	}
}
