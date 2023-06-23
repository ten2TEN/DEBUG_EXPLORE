using System;
using Twitterizer;

namespace Twitterizer.Core
{
	internal static class CommandPerformer
	{
		public static TwitterResponse<T> PerformAction<T>(ICommand<T> command)
		where T : ITwitterObject
		{
			command.Init();
			return command.ExecuteCommand();
		}
	}
}