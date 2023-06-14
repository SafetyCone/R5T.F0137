using System;

using R5T.T0131;


namespace R5T.F0137
{
    [ValuesMarker]
    public partial interface IProjectLoadingProgresses : IValuesMarker
    {
        public IProjectLoadingProgress Console => new ProjectLoadingProgress();
    }
}
