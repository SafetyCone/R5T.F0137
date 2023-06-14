using System;


namespace R5T.F0137
{
    public class SemanticsOperator : ISemanticsOperator
    {
        #region Infrastructure

        public static ISemanticsOperator Instance { get; } = new SemanticsOperator();


        private SemanticsOperator()
        {
        }

        #endregion
    }
}
