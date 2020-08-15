using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

namespace AdvancedCSFinalExam
{
    class EventsQuestion
    {
    }

    public class QuestionPaper : EventArgs
    {
        public string argString { get; set; }
    }


    public class DoTest
    {
        public delegate void DoTestEventHandler(object o, EventArgs e);
        public event DoTestEventHandler TestDone;

        public void DoSpecificTest()
        {
            Console.WriteLine("Test has been completed");
            TestCompleted();
        }

        public void TestCompleted()
        {
            TestDone(this, EventArgs.Empty);
        }
    }

    public class NotifyStudent
    {
        public void TestTimeOver(object o, EventArgs e)
        {
            Console.WriteLine("Test time over");
        }
    }
}
