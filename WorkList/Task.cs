using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkList
{
    public class Task
    {
        static double defaultTaskDeadlineTimeSlot = 1.0;
        public int id { get; set; }
        public bool isDone { get; set; }
        public String task { get; set; }
        public DateTime dt { get; set; }
        public bool isRead { get; set; }
        public String delayReason { get; set; }

        public TimeSpan totalTaskTime { get; set; }
        public int pomodoros { get; set; }
        public Task()
        {
            dt = System.DateTime.Now.AddHours(defaultTaskDeadlineTimeSlot);
        }
        public Task(int id, String task)
        {
            this.id = id;
            this.task = task;
        }

    }
}
