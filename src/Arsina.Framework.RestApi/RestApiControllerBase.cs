using Arsina.Framework.RestApi.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arsina.Framework.RestApi
{
	[ApiController]
	public class RestApiControllerBase: ControllerBase
	{
		public ApiResult<T> ApiResult<T>(bool isSuccessful, string message = "", T data = null) where T : class
		{
			return new ApiResult<T>(isSuccessful, data, message);
		}

		public PaginatedResult<T> ApiPaginatedResult<T>(IList<T> data, int totalCount, int pageNumber, bool isSuccessful, string message) where T : class
		{
			return new PaginatedResult<T>(data, totalCount, pageNumber, isSuccessful, message);
		}

		public SaveResult<T> ApiSaveResult<T>(T data, bool isSuccessful = true, string message = "Saved Successfully")
		{
			return new SaveResult<T>(isSuccessful, message, data);
		}

		public SaveResult<T> ApiSaveResultFailed<T>(string message) where T : class
		{
			// No data should be send if it's not successful 
			// For security reasons
			return new SaveResult<T>(false, message, null);
		}

		public DeleteResult<TKey> ApiDeleteResult<TKey>(TKey id, bool isSuccessful = true, string message = "Deleted Successfully")
		{
			return new DeleteResult<TKey>(isSuccessful, message, id);
		}
	}
}
