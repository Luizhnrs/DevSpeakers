namespace Minha_Primeira_API.Entities
{
    public class DevEvents
    {
        public DevEvents()
        {
            Speaker = new List<DevEventSpeaker>();
            IsDeleted = false;
        }
        public Guid Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<DevEventSpeaker> Speaker { get; set; } 
        public bool IsDeleted { get; set; }

        public void Update(string title, string description, DateTime startDate,DateTime endDate)
        {
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
        }
        public void Delete() {
            IsDeleted = true;
        }
    }
}
