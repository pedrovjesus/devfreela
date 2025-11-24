namespace devfreela.Application.ViewModel
{
    public class ProjectViewModel
    {
        public ProjectViewModel(string title, DateTime createdAt)
        {
            Title = title;
            CreatedAt = createdAt;
        }

        public ProjectViewModel(int Id,string title, DateTime createdAt)
        {
            this.Id = Id;
            Title = title;
            CreatedAt = createdAt;
        }
        public int Id { get; private set; }
        public string Title { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}