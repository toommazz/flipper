namespace flipper.domain.core
{
    public abstract class Entity
    {
        public Entity(DateTime update)
        {
            Id = Guid.NewGuid();
            Create = DateTime.Now;
            Update = update;
        }

        public Guid Id { get; private set; }

        public DateTime Create { get; private set; }

        public DateTime Update { get; private set; }
    }
}
