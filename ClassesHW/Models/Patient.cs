namespace ClassesHW
{
    internal class Patient
    {
        public string name;
        public TreatmentPlan plan;

        public Patient(string name, int treatmentCode)
        {
            this.name = name;
            this.plan = new TreatmentPlan(treatmentCode);
        }
    }
}
