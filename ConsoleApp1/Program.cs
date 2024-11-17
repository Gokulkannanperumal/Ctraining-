using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessModifiersClass2;
using classExceptionHandeling;
using ConsoleApp1;
using CustomExceptionHandeling;
using DeligatesAndEvents;
using Collections;
using DelegateTrainig;
using DI_Example;
using System.Security.AccessControl;
using CURD_Operation;

namespace ACcessModifierClass1    //assembley1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Public  //Scope: Anywhere, including other assemblies.
            ////Private // Within the same class.
            ////Internal //Within the same assembly. 
            ////protected Internal //Within the same assembly or derived classes, even if they are in a different assembly.
            ////private protected // Within the same class and derived classes, but only if they are in the same assembly.
            ////AcessModifierTraningClass2 obj = new AcessModifierTraningClass2();
            ////obj._StudentName = "Alice";
            //////obj.FatherName = "Jhon";
            //////obj.MothersName = "Lilly";
            ////obj.DisplayStudentName();

            ////Console.WriteLine("Student Name is :: "+obj._StudentName);

            ////CustomException objexp = new CustomException();
            ////objexp.HandelingException();


            ////arrays newarr = new arrays();
            ////newarr.looparray();
            ////newarr.jaggarr();
            ////Exceptiohandeling obj = new Exceptiohandeling();
            ////obj.DifferencebetweenThedata();
            ////obj.AddData();
            ////obj.displayData();

            ////Deligates obj = new Deligates();//passing method as parameter
            ////ProcessNotifier delprocess = obj.NotifyMessage;

            ////delprocess("Welcome all");

            ////delprocess += obj.NotifyNewMessage;
            //SubscribeEvent objSubscribeEvent = new SubscribeEvent();
            //objSubscribeEvent.invokedeligates();


            //SubscribeEvent onjsub = new SubscribeEvent();
            //subscribeEvent2 obj1 = new subscribeEvent2();
            ////onjsub.invokedeligates();
            //collections onjc = new collections();
            //onjc.CollectionExample();

            //WorkingOnFiles obj = new WorkingOnFiles();
            //obj.writetext("helloworld");//5sec
            //obj.writetext("Line No 1");//5sec
            //obj.writetext("Line No 2");//5sec
            //obj.readtext();//10sec     //10sec

            //Console.Write("Please enter the Company :");
            //string company = Console.ReadLine();
            //Console.WriteLine("\nPlease enter the model");
            //string model = Console.ReadLine();

            //IVehicle ObjCompany = null;
            //if (company == "TVS")
            //{
            //    ObjCompany = new TVSvehicle();
            //}
            //else if(company == "HONDA")
            //{
            //    ObjCompany = new Hondavehicle();
            //}

            //DI obj = new DI(ObjCompany);
            //obj.SearchDetails(model);




            //CustomCacheExample objCaCHE = new CustomCacheExample();
            //objCaCHE.SetCacheData("TVSModel1", "Apache");
            //objCaCHE.SetCacheData("TVSM2", "raider");
            //objCaCHE.SetCacheData("HondaM1", "Shine");
            //objCaCHE.SetCacheData("HondaM2", "Unicorn");
            //Console.WriteLine(objCaCHE.GetCacheData("HondaM1"));

            //CURDop objcurd = new CURDop();
            //objcurd.Create(1, "Gokul", "gokul@gmail");
            //objcurd.Create(2, "vijay", "vijay@gmail");
            //objcurd.Create(3, "per1", "per1@gmail");
            //objcurd.Create(4, "per2", "per2@gmail");


            //objcurd.read();
            //objcurd.ReadById(4);
            //objcurd.Update(3,"Alice", "Alice@gmail");
            //objcurd.Delete(4);
            //objcurd.read();

            //CURD_DB_SP obj = new CURD_DB_SP();

            //obj. AddProduct("Chair", 650m);//

            //obj.GetProduct(5);
            //obj.GetAllProducts();
            //// Update
            //obj. UpdateProduct(3, "Updated keyboard", 1000m);

            //// Delete
            //obj. DeleteProduct(5);
            //obj.GetAllProducts();


            //Read_from_Excel obj1 = new Read_from_Excel();

            //obj1.Process_Excel_data();
            // obj = null;

            threading obj3 = new threading();
            obj3.appendthread();
            Console.ReadKey();
        }
};


    public class SubscribeEvent
    {
        public SubscribeEvent()//constructor
        {
            DelegatesNew.evntSampleDelegate += invokeshowEventmessage;
        }


        public void invokedeligates()
        {
            DelegatesNew obj1 = new DelegatesNew();

            obj1.increasecount();

        }
        public  void invokeshowEventmessage(string message)
        {
            Console.WriteLine(message);
        }
    }


    public class subscribeEvent2
    {
        public subscribeEvent2()//constructor
        {
            DelegatesNew.evntSampleDelegate += invokeshowEventmessage;
        }
        public void invokeshowEventmessage(string message)
        {
            Console.WriteLine("subevent2 :"+message);
        }

    }
}
