namespace Task2;

public class TreatmentPlan
{
    int treatmentCode;
    public Doctor doctor;

    public TreatmentPlan(int code)
    {
        this.treatmentCode = code;
        switch (treatmentCode)
        {
            case 1:
                this.doctor = new Surgeon();
                break;
            case 2:
                this.doctor = new Dentist();
                break;
            default:
                this.doctor = new Therapist();
                break;
        }
    }
}