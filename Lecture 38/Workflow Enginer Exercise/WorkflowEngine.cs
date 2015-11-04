using System;
using System.Linq;

namespace Workflow_Engine_Exercise
{
    public class WorkflowEngine
    {
        private readonly IWorkflow _workflow;

        public WorkflowEngine(IWorkflow workflow)
        {
            _workflow = workflow;
        }

        public void Run()
        {
            Console.WriteLine("Running workflow ({0} activities):", _workflow.Acitivites.Count());

            var consoleColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;

            foreach (var activity in _workflow.Acitivites)
            {
                activity.Execute();
            }

            Console.ForegroundColor = consoleColor;

            Console.WriteLine("Done!");
        }
    }
}
