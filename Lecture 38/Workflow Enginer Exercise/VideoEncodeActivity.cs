using System;

namespace Workflow_Engine_Exercise
{
    public class VideoEncodeActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Encoding video...");
        }
    }
}
