using System.Collections.Generic;

namespace Workflow_Engine_Exercise
{
    public interface IWorkflow
    {
        IEnumerable<IActivity> Acitivites { get; }
        void RegisterActivity(IActivity activity);
    }
}
