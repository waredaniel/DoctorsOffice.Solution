using System.Collections.Generic;

namespace DoctorsOffice.Models
{
  public class Patient
  {
    public Patient()
    {
      this.JoinEntities = new HashSet<DoctorPatient>();
    }

    public int PatientId { get; set; }
    public string PatientName { get; set; }

    public virtual ICollection<DoctorPatient> JoinEntities { get; }
  }
}