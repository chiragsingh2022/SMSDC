namespace SmsdcWebApi.Model
{
    public class BaseClass
    {
        public BaseClass() { IsActive = true; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }

        public DateTimeOffset Created { get; set; }

        public DateTimeOffset? Deleted { get; set; }

        public string? DeletedBy { get; set; }

        public DateTimeOffset? Modified { get; set; }

        public string? ModifiedBy { get; set; }
    }
}
