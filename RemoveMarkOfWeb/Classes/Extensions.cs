using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace RemoveMarkOfWeb.Classes
{
    public static class Extensions
    {
        /// <summary>
        /// Async wait for process to complete
        /// </summary>
        /// <param name="process">Process to wait for</param>
        /// <param name="cancellationToken">Optional cancellation token if the process was lengthy</param>
        /// <returns></returns>
        public static Task WaitForExitAsync(this Process process, CancellationToken cancellationToken = default)
        {
            if (process.HasExited)
            {
                return Task.CompletedTask;
            }

            var tcs = new TaskCompletionSource<object>();

            process.EnableRaisingEvents = true;
            process.Exited += (sender, args) => tcs.TrySetResult(null);

            if (cancellationToken != default)
            {
                cancellationToken.Register(() => tcs.SetCanceled());
            }

            return process.HasExited ? Task.CompletedTask : tcs.Task;

        }
    }
}