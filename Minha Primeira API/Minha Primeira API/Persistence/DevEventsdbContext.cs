using Minha_Primeira_API.Entities;
namespace Minha_Primeira_API.Persistence
{
    public class DevEventsdbContext
    {
        public List<DevEvents> DevEvents { get; set; }
        public DevEventsdbContext() { 

            DevEvents = new List<DevEvents>();

        }

    }
}
