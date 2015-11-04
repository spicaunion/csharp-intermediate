using System.Collections.Generic;

namespace Workflow_Engine_Exercise
{
    public class Workflow : IWorkflow
    {
        private readonly IList<IActivity> _activities = new List<IActivity>();

        public IEnumerable<IActivity> Acitivites
        {
            get { return _activities; }
        }

        public void RegisterActivity(IActivity activity)
        {
            _activities.Add(activity);
        }
    }
}
