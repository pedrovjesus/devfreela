namespace devfreela.Application.ViewModel
{
    public class ProjectDetailsViewModel
    {
        private DateTime? startedAt;
        private DateTime? finishedAt;

        public ProjectDetailsViewModel(int id, string title, string description, decimal totalCost, DateTime? startedAt, DateTime? finishedAt)
        {
            Id = id;
            Title = title;
            Description = description;
            TotalCost = totalCost;
            this.startedAt = startedAt;
            this.finishedAt = finishedAt;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime StartedAt { get; private set; }
        public DateTime FinishedAt { get; private set; }

    }
}