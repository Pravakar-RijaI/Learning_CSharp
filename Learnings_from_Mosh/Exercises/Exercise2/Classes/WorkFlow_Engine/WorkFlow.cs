using System;
using System.Collections.Generic;

namespace Classes
{
    public class WorkFlow : IWorkFlow
    {
        private readonly List<IActivity> _activities;

        public WorkFlow()
        {
             _activities = new List<IActivity>();
        }

        public void AddActivity(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void RemoveActivity(IActivity activity)
        {
            _activities.Remove(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }

    }
}
