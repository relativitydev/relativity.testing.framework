using System.Diagnostics;
using System.Linq;
using System.Text;
using Castle.DynamicProxy;

namespace Relativity.Testing.Framework.Logging
{
	/// <summary>
	/// Represents the logging interceptor that writes log messages before and after method invocation.
	/// </summary>
	public class LoggingInterceptor : IInterceptor
	{
		private readonly ILogService _logService;

		/// <summary>
		/// Initializes a new instance of the <see cref="LoggingInterceptor"/> class.
		/// </summary>
		/// <param name="logService">The log service.</param>
		public LoggingInterceptor(ILogService logService)
		{
			_logService = logService;
		}

		/// <summary>
		/// Intercepts the specified invocation.
		/// </summary>
		/// <param name="invocation">The invocation.</param>
		public void Intercept(IInvocation invocation)
		{
			string methodInvocationMessage = BuildMethodInvocationMessage(invocation);

			_logService.Trace($"Starting: {methodInvocationMessage}");

			Stopwatch stopwatch = Stopwatch.StartNew();
			invocation.Proceed();
			stopwatch.Stop();

			_logService.Trace($"Finished: {methodInvocationMessage} ({stopwatch.Elapsed.TotalSeconds.ToString("F3")}s)");
		}

		private static string BuildMethodInvocationMessage(IInvocation invocation)
		{
			StringBuilder builder = new StringBuilder(invocation.TargetType.FullName)
				.Append($".{invocation.Method.Name}");

			if (invocation.GenericArguments?.Any() ?? false)
			{
				builder.Append($"<{string.Join(", ", invocation.GenericArguments.Select(x => x.Name))}>");
			}

			builder.Append($"({string.Join(", ", invocation.Arguments.Select(x => ObjectToStringConverter.ToString(x)))})");

			return builder.ToString();
		}
	}
}
