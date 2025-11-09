namespace devfreela.Core.Exception
{
    public class ProjectAlreadyStartedException : Exception
    {
        public ProjectAlreadyStartedException() : base("Project is already in Started status") { }
    }
}
