namespace MobileAPI.Model.Domain
{
    public class MobileModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
        public string? MobileImageUrl { get; set; }
    }
}
