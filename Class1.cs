using System.Net.NetworkInformation;

namespace ConsoleApp3
{
    internal class Date
    {
        private int year;
        private int month;
        private int day;
        public static int counter;
        private int studentNumber;

        static Date()
        {
            Date.counter = 0;
        }
        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            Date.counter++;
            this.studentNumber = Date.counter;
        }
        public int GetYear()
        {
            return this.year;
        }
        public int GetMonth()
        {
            return this.month;
        }
        public int GetDay()
        {
            return this.day;
        }
        public int GetStudentNumber()
        {
            return this.studentNumber;
        }
        public void SetYear(int year)
        {
            this.year = year;
        }
        public void SetMonth(int month)
        {
            if (month < 12 && month > 1)
                this.month = month;
            else
                this.month = 9999;
        }
        public void SetDate(int day)
        {
            if (day < 31 && day > 1)
                this.day = day;
            else
                this.day = 9999;
        }
        private void SetStudentNumber(int studentNumber)
        {
            this.studentNumber = studentNumber;
        }
        public bool Before(Date date)
        {
            if (date.GetYear() == this.GetYear())
            {
                if (date.GetMonth() == this.GetMonth())
                {
                    if (date.GetDay() == this.GetDay())
                    {
                        return false; // if this happens the days are equal
                    }
                    else if (date.GetDay() < this.GetDay())
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else if (date.GetMonth() < this.GetMonth())
                {
                    return true;
                }
                else
                    return false;
            }
            else if (date.GetYear() < this.GetYear())
            {
                return true;
            }
            else
                return false;

        }
        public string toString()
        {
            string str = "(" + this.day + "/" + this.month + "/" + this.day + ")\n" + "object number: " + this.studentNumber;
            return str;
        }
    }
}