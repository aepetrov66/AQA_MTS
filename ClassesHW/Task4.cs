namespace ClassesHW
{
    public class Task4
    {
        public void Execute()
        {
            Patient patient1 = new Patient("John", 1);
            patient1.plan.doctor.Treat();

            Patient patient2 = new Patient("James", 2);
            patient2.plan.doctor.Treat();

            Patient patient3 = new Patient("Jake", 3);
            patient3.plan.doctor.Treat();

            Patient patient4 = new Patient("Bill", 4);
            patient4.plan.doctor.Treat();
        }
    }
}
