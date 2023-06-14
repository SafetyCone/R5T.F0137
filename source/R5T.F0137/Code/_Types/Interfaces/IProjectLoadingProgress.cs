using System;

using Microsoft.CodeAnalysis.MSBuild;


namespace R5T.F0137
{
    public interface IProjectLoadingProgress : IProgress<ProjectLoadProgress>
    {
    }
}
