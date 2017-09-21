namespace APSIM.Shared.Utilities
{
    /// <summary>A runnable interface.</summary>
    public interface IRunnable
    {
        /// <summary>Called to start the job. Can throw on error.</summary>
        /// <param name="cancelToken">Is cancellation pending?</param>
        void Run(System.Threading.CancellationTokenSource cancelToken);
    }
}