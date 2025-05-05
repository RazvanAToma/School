
namespace H23___TestDokument
{
    internal class TicketBuying
    {
        public int age;

        public TicketBuying(int age)
        {
            this.age = age;
        }

        public float checkPrice()
        {
            if (age <= 15)
            {
                return 30.0f;
            }
            else if (age >= 67)
            {
                return 35.0f;
            }
            else
            {
                return 50.0f;
            }
        }
    }
}
