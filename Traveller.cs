using ConsoleApp3;

namespace homeworkTask19
{
    internal class Traveller
    {
        private Passport passport;
        private bool isPayed;

        public Traveller(Passport passport, bool isPayed)
        {
            this.passport = passport;
            this.isPayed = isPayed;
        }

        public void Pay()
        {
            this.isPayed = true;
        }

        public bool IsPayed()
        {
            if (this.isPayed == true)
                return true;
            return false;
        }

        public bool CheckTravel(Date travelDate)
        {
            if (passport.IsValid(travelDate) == true && IsPayed() == true)
                return true;
            return false;
        }

        public string tostring()
        {
            string str = passport.tostring() + "\n IsPayed: " + this.IsPayed();
            return str;
        }




    }
}
