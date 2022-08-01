using System.Collections.Generic;

namespace DoctorsOffice.Models
{
  public class Doctor
  {
    public Doctor()
    {
      this.JoinEntities = new HashSet<DoctorPatient>();
    }

    public int DoctorId { get; set; }
    public string DoctorName { get; set; }
    public string DoctorSpecialty { get; set; }
    public virtual ICollection<DoctorPatient> JoinEntities { get; set; }
  }
}