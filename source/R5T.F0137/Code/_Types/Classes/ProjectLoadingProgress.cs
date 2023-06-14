using System;

using Microsoft.CodeAnalysis.MSBuild;


namespace R5T.F0137
{
    /// <summary>
    /// Outputs project load progress to the console.
    /// </summary>
    public class ProjectLoadingProgress : IProjectLoadingProgress
    {
        public void Report(ProjectLoadProgress progress)
        {
            var targetFrameworkToken = progress.TargetFramework is not null
                ? $" {progress.TargetFramework}"
                : String.Empty
                ;

            var representation = $"{progress.FilePath}\n{progress.ElapsedTime}: {progress.Operation}{targetFrameworkToken}";

            Console.WriteLine(representation);
        }
    }
}
