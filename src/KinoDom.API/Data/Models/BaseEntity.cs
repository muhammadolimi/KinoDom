namespace KinoDom.API.Data.Models
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; } 
    }
}
