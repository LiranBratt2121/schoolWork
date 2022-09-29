using ConsoleApp3;
using System.Data.SqlTypes;

namespace homeworkTask19
{
    internal class Passport
    {
        private string name;
        private int number;
        private Date expiryDate; //משתני הקלאס

        Passport(Passport lastPassport) //קונסטראקטור מעתיק (עדיין לא באמת מבין את הסיבה לקיום שלהם)
        {
            lastPassport.name = this.name;
            lastPassport.number = this.number;
            lastPassport.expiryDate = this.expiryDate;
        }
        public Passport(string name, int number, Date expiryDate) //קונסטרקטור נורמלי
        {
            this.name = name;
            this.number = number;
            this.expiryDate = expiryDate;
        }
        public string GetName()
        {
            return this.name;
        }
        public int GetNumber()
        {
            return this.number;
        }
        public Date GetExpiryDate() //פעולות מאחזרות
        {
            return this.expiryDate;
        }
        public bool IsValid(Date dateCheked) //פעולה שבודקת במקרה שהיום של הדרכון לא תקף
        {
            if (dateCheked.GetYear() > this.expiryDate.GetYear())
            {
                return true;
            }
            else if (dateCheked.GetYear() == this.expiryDate.GetYear())
            {
                if (dateCheked.GetMonth() > this.expiryDate.GetMonth())
                {
                    return true;
                }
                else if (dateCheked.GetMonth() == this.expiryDate.GetMonth())
                {
                    if (dateCheked.GetDay() > this.expiryDate.GetDay())
                    {
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }
        public void SetExpiryDate(Date newExpiryDate) //פעולה שמעדכנת את תאריך התפוגה של הדרכון
        {
            this.expiryDate = newExpiryDate;
        }
        public string tostring() //פעולה שמדפיסה את הקוד
        {
            string str = "Name: " + this.name + "\n PassportNumber: " + this.number + "\n ExpDate: " + this.expiryDate;
            return str;
        }

    }

}
