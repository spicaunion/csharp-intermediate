using System;

namespace Workflow_Engine_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.RegisterActivity(new VideoUploadActivity());
            workflow.RegisterActivity(new VideoEncodeActivity());
            var workflowEngine = new WorkflowEngine(workflow);
            workflowEngine.Run();

            Console.WriteLine("\nPress a key to continue...");
            Console.ReadKey();
        }
    }
}
