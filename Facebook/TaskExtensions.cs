using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Facebook
{
	internal static class TaskExtensions
	{
		public static Task<T2> Then<T1, T2>(this Task<T1> first, Func<T1, T2> next)
		{
			if (first == null)
			{
				throw new ArgumentNullException("first");
			}
			if (next == null)
			{
				throw new ArgumentNullException("next");
			}
			TaskCompletionSource<Facebook.T2> taskCompletionSource = new TaskCompletionSource<T2>();
			first.ContinueWith((Task<Facebook.T1> param0) => {
				if (first.IsFaulted)
				{
					taskCompletionSource.TrySetException(first.Exception.InnerExceptions);
					return;
				}
				if (first.IsCanceled)
				{
					taskCompletionSource.TrySetCanceled();
					return;
				}
				try
				{
					Facebook.T2 result = next(first.Result);
					taskCompletionSource.TrySetResult(result);
				}
				catch (Exception exception)
				{
					taskCompletionSource.TrySetException(exception);
				}
			});
			return taskCompletionSource.Task;
		}
	}
}