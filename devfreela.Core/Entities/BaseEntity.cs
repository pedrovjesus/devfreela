namespace devfreela.Core.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {

        }
        public int id { get; private set; }
    }
}