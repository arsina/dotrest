using System;
using System.Collections.Generic;
using System.Text;

namespace Arsina.Framework.RestApi.Results
{
	public abstract class ResultBase
	{
		public ResultBase(bool isSuccessful, string message)
		{
			this.IsSuccessful = isSuccessful;
			this.Message = message;
		}
		public bool IsSuccessful { get; set; }
		public string Message { get; set; }
	}
}
