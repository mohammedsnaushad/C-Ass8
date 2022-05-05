using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;



namespace reflectionApp
{
    [AttributeUsage(AttributeTargets.Class |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Constructor |
    AttributeTargets.Property, AllowMultiple = true)]
    class SoftwareAtttribute : System.Attribute
    {
        private string ProjectName;
        private string Description;
        private string ClientName;
        private string StartedDate;
        private string EndDate;



        public string PName
        {
            get { return ProjectName; }
            set { ProjectName = value; }
        }
        public string Descript
        {
            get { return Description; }
            set { Description = value; }
        }
        public string CName
        {
            get { return ClientName; }
            set { ClientName = value; }
        }
        public string SDate
        {
            get { return StartedDate; }
            set { StartedDate = value; }
        }
        public string EDate
        {
            get { return EndDate; }
            set { EndDate = value; }
        }
        public class HDFCAccount : SoftwareAtttribute
        {
            public void displayAccount(string PName, string Descript, string CName)
            {



                this.Description = Descript;
                this.ProjectName = PName;
                this.ClientName = CName;
                Console.WriteLine("Project Description : " + Description);
                Console.WriteLine("Projectname : " + ProjectName);
                Console.WriteLine("Project Client Name : " + ClientName);



            }
        }



        public class ICICIAccount : SoftwareAtttribute
        {
            public void displayAccount(string Descript, string PName, string CName, string SDate, string EDate)
            {



                this.Description = Descript;
                this.ProjectName = PName;
                this.ClientName = CName;
                this.StartedDate =SDate;
                this.EndDate = EDate;
                Console.WriteLine("\nProject Description : " + Description);
                Console.WriteLine("Projectname : " + ProjectName);
                Console.WriteLine("Project Client Name : " + ClientName);
                Console.WriteLine("Project Started Date : " + StartedDate);
                Console.WriteLine("Project End Date : \n" + EndDate);
            }
        }



        class Test
        {
            static void Main(string[] args)
            {
                HDFCAccount HA = new HDFCAccount();
                HA.displayAccount("Assignment7", "reflection", "CLIENT1");
                ICICIAccount IA = new ICICIAccount();
                IA.displayAccount("Assignment7", "reflection", "CLIENT2", "03-03-2022", "04-04-2022");




                Assembly executing = Assembly.GetExecutingAssembly();
                Type[] types = executing.GetTypes();
                foreach (Type t in types)
                {
                    MethodInfo[] mi = t.GetMethods();
                    foreach (var m in mi)
                    {



                        Console.WriteLine(m);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}