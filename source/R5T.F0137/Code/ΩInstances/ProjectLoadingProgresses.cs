using System;


namespace R5T.F0137
{
    public class ProjectLoadingProgresses : IProjectLoadingProgresses
    {
        #region Infrastructure

        public static IProjectLoadingProgresses Instance { get; } = new ProjectLoadingProgresses();


        private ProjectLoadingProgresses()
        {
        }

        #endregion
    }
}
