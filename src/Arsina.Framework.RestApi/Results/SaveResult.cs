using System;
using System.Collections.Generic;
using System.Text;

namespace Arsina.Framework.RestApi.Results
{
	public class SaveResult<T> : ResultBase
	{
		public SaveResult() : base(false, null) { }
		public SaveResult(bool isSuccessful, string message, T data) : base(isSuccessful, message) { }
	}
}
