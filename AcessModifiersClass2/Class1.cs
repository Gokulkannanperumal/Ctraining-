using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessModifiersClass2   // assembley2
{
    public class AcessModifierTraningClass2
    {
        private String StudentName;
        internal string FatherName;
        protected internal string MothersName = "Lilly";

        private protected string sisterName = "jeni";
        public string _StudentName
        {
            get { return this.StudentName; }
            set
            {
                if (this._StudentName == "Alice")
                { this.StudentName = this._StudentName; }
            }
        }

        public void DisplayStudentName()
        {
            Console.WriteLine("Student Name Is : " + StudentName);
            
        }


    }


   class AcessModifierTraningClass3
    {
        public void InvokeClass2()
        {
            AcessModifierTraningClass2 obj1 = new AcessModifierTraningClass2();

            obj1.FatherName = "jhon";
            //obj1.MothersName = "Lilly";
        }
    }

    class AcessModifierTraningClass4 : AcessModifierTraningClass2
    {
        public void displaysister()
        {
            Console.WriteLine("display SisterName :" + sisterName);
        }
    }
}
