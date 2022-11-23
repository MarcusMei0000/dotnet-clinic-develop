namespace Dentistry.WebAPI.Models;
using Dentistry.Entities.Models;
public class ScheduleResponse
{
    public Guid DoctorId { get; set; }

    public DateTime ReceptionStart { get; set; }
    public DateTime ReceptionEnd { get; set; }

    public ICollection<Reception> Receptions { get; set; }
}