using System;

namespace devfreela.Core.Exceptions
{
    public class ProjectAlreadyStartedException : Exception
    {
        public ProjectAlreadyStartedException()
            : base("Project is already in Started status") { }
    }
}
