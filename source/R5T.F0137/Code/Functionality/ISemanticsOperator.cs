using System;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;

using R5T.T0132;
using R5T.T0172;


namespace R5T.F0137
{
    [FunctionalityMarker]
    public partial interface ISemanticsOperator : IFunctionalityMarker
    {
        public async Task In_ProjectContext_WithoutProgress(
            IProjectFilePath projectFilePath,
            Action<Project> projectAction = default)
        {
            await Instances.WorkspaceOperator.In_WorkspaceContext(
                async workspace =>
                {
                    var project = await workspace.OpenProjectAsync(projectFilePath.Value);

                    Instances.ActionOperator.Run(
                        projectAction,
                        project);
                });
        }

        public async Task In_ProjectContext(
            IProjectFilePath projectFilePath,
            IProjectLoadingProgress projectLoadingProgress,
            Action<Project> projectAction = default)
        {
            await Instances.WorkspaceOperator.In_WorkspaceContext(
                async workspace =>
                {
                    var project = await workspace.OpenProjectAsync(
                        projectFilePath.Value,
                        projectLoadingProgress);

                    Instances.ActionOperator.Run(
                        projectAction,
                        project);
                });
        }

        public Task In_ProjectContext(
            IProjectFilePath projectFilePath,
            Action<Project> projectAction = default)
        {
            return this.In_ProjectContext(
                projectFilePath,
                Instances.ProjectLoadingProgresses.Console,
                projectAction);
        }

        public async Task In_ProjectContext_WithoutProgress(
            IProjectFilePath projectFilePath,
            Func<Project, Task> projectAction = default)
        {
            await Instances.WorkspaceOperator.In_WorkspaceContext(
                async workspace =>
                {
                    var project = await workspace.OpenProjectAsync(projectFilePath.Value);

                    await Instances.ActionOperator.Run(
                        projectAction,
                        project);
                });
        }

        public async Task In_ProjectContext(
            IProjectFilePath projectFilePath,
            IProjectLoadingProgress projectLoadingProgress,
            Func<Project, Task> projectAction = default)
        {
            await Instances.WorkspaceOperator.In_WorkspaceContext(
                async workspace =>
                {
                    var project = await workspace.OpenProjectAsync(
                        projectFilePath.Value,
                        projectLoadingProgress);

                    await Instances.ActionOperator.Run(
                        projectAction,
                        project);
                });
        }

        public Task In_ProjectContext(
            IProjectFilePath projectFilePath,
            Func<Project, Task> projectAction = default)
        {
            return this.In_ProjectContext(
                projectFilePath,
                Instances.ProjectLoadingProgresses.Console,
                projectAction);
        }
    }
}
