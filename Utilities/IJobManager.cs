namespace APSIM.Shared.Utilities
{
    /// <summary>A class for managing jobs that are to be run with the JobRunner.</summary>
    public interface IJobManager
    {
        /// <summary>Return the next job to run or null if nothing to run.</summary>
        IRunnable GetNextJobToRun();

        /// <summary>Called by the job runner when all jobs completed</summary>
        void Completed();
    }
}