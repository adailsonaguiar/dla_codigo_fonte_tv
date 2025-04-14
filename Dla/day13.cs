public class Task
{
    public string name { get; set; }
    public int priority { get; set; }
}

public class DequeTasks
{
    private List<Task> queue = new List<Task>();

    public void AddToEnd(Task task)
    {
        queue.Add(task);
    }

    public void AddToStart(Task task)
    {
        queue.Insert(0, task);
    }


    public void SolveTask()
    {
        queue.RemoveAt(0);
    }

    public void ChangePriorityTask(string name, int priority)
    {
        Task task = queue.FirstOrDefault(t => t.name == name);

        if (task == null)
        {
            return;
        }

        task.priority = priority;
        int taskIndex = queue.IndexOf(task);

        if (taskIndex == -1)
        {
            return;
        }

        queue.RemoveAt(taskIndex);

        queue.Add(task);
    }

    public void increasePositionTask(string name)
    {
        Task task = queue.FirstOrDefault(t => t.name == name);
        if (task == null)
        {
            return;
        }

        int taskIndex = queue.IndexOf(task);

        if (taskIndex == -1)
        {
            return;
        }

        queue.RemoveAt(taskIndex);

        queue.Insert(taskIndex + 1, task);
    }

    public void decreasePositionTask(string name)
    {
        Task task = queue.FirstOrDefault(t => t.name == name);
        if (task == null)
        {
            return;
        }

        int taskIndex = queue.IndexOf(task);

        if (taskIndex == -1)
        {
            return;
        }

        queue.RemoveAt(taskIndex);

        queue.Insert(taskIndex - 1, task);
    }
}