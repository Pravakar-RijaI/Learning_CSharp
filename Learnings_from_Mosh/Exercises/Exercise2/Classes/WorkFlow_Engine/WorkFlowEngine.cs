using System;

namespace Classes
{
    public class WorkFlowEngine
    {
        public void Run(IWorkFlow workflow)
        {
            foreach (IActivity workFlow in workflow.GetActivities())
            {
                workFlow.Execute();
            }
        }
    }
}
