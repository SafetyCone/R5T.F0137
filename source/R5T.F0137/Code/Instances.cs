using System;


namespace R5T.F0137
{
    public static class Instances
    {
        public static F0000.IActionOperator ActionOperator => F0000.ActionOperator.Instance;
        public static F0137.IProjectLoadingProgresses ProjectLoadingProgresses => F0137.ProjectLoadingProgresses.Instance;
        public static F0136.IWorkspaceOperator WorkspaceOperator => F0136.WorkspaceOperator.Instance;
    }
}