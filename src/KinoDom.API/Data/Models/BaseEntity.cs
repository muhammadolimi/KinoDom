namespace KinoDom.API.Data.Models
{
    public abstract class BaseEntity
    {
        public Guid guid { get; set; }
        public bool isActive { get; set; }
        public DateTime createdAt { get; set; } 
    }
}
