using System;

namespace AdvancedCSFinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------Question 1-------------------------------

            ValueTypeCollection<int> IntCollection = new ValueTypeCollection<int>();
            IntCollection.Add(34);
            IntCollection.Add(24);
            IntCollection.Add(33);
            IntCollection.Add(27);
            IntCollection.Add(86);
            Console.WriteLine(IntCollection.GetValueByIndex(2));


            //-----------Question 2-------------------------------
            DoTest test1 = new DoTest();
            NotifyStudent notifySt = new NotifyStudent();

            test1.TestDone += notifySt.TestTimeOver;
            test1.TestCompleted();

        }
    }
}
