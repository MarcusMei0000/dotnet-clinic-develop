namespace Dentistry.Entities.Models;
public class Doctor : BaseEntity
{
    public Guid UserId { get; set; }
    public short ReceprionRoom { get; set; }

    public virtual Speciality Speciality { get; set; }
    public virtual ICollection<Schedule> Schedules { get; set; }
}
