using System;

namespace Workflow_Engine_Exercise
{
    public class VideoUploadActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading video...");
        }
    }
}
