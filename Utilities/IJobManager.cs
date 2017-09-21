namespace APSIM.Shared.Utilities
{
    /// <summary>A class for managing jobs that are to be run with the JobRunner.</summary>
    public interface IJobManager
    {
        /// <summary>Return the index of next job to run or -1 if nothing to run.</summary>
        /// <returns>Job to run or null if no more</returns>
        IRunnable GetNextJobToRun();

        /// <summary>Called by the job runner when all jobs completed</summary>
        void Completed();
    }
}