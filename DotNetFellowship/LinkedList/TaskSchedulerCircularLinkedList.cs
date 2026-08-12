using System;

class TaskNode
{
    public int TaskId;
    public string TaskName;
    public int Priority;
    public string DueDate;
    public TaskNode Next;

    public TaskNode(int id, string name, int priority, string dueDate)
    {
        TaskId = id;
        TaskName = name;
        Priority = priority;
        DueDate = dueDate;
    }
}

class TaskSchedulerCircularLinkedList
{
    TaskNode head;
    TaskNode tail;

    public void AddAtBeginning(int id, string name, int priority, string dueDate)
    {
        TaskNode newNode = new TaskNode(id, name, priority, dueDate);

        if (head == null)
        {
            head = tail = newNode;
            newNode.Next = head;
            return;
        }

        newNode.Next = head;
        head = newNode;
        tail.Next = head;
    }

    public void AddAtEnd(int id, string name, int priority, string dueDate)
    {
        TaskNode newNode = new TaskNode(id, name, priority, dueDate);

        if (head == null)
        {
            head = tail = newNode;
            newNode.Next = head;
            return;
        }

        tail.Next = newNode;
        tail = newNode;
        tail.Next = head;
    }

    public void AddAtPosition(int position, int id, string name, int priority, string dueDate)
    {
        if (position == 1)
        {
            AddAtBeginning(id, name, priority, dueDate);
            return;
        }

        if (head == null)
        {
            Console.WriteLine("Invalid position");
            return;
        }

        TaskNode current = head;

        for (int i = 1; i < position - 1; i++)
        {
            current = current.Next;

            if (current == head)
            {
                Console.WriteLine("Invalid position");
                return;
            }
        }

        TaskNode newNode = new TaskNode(id, name, priority, dueDate);

        newNode.Next = current.Next;
        current.Next = newNode;

        if (current == tail)
            tail = newNode;
    }

    public void RemoveById(int id)
    {
        if (head == null)
            return;

        TaskNode current = head;
        TaskNode previous = tail;

        do
        {
            if (current.TaskId == id)
            {
                if (current == head)
                    head = head.Next;

                if (current == tail)
                    tail = previous;

                previous.Next = current.Next;

                if (current == head && current.Next == current)
                    head = tail = null;

                if (tail != null)
                    tail.Next = head;

                return;
            }

            previous = current;
            current = current.Next;

        } while (current != head);

        Console.WriteLine("Task not found");
    }

    public void Display()
    {
        if (head == null)
            return;

        TaskNode current = head;

        do
        {
            Console.WriteLine(
                $"ID: {current.TaskId}, Task: {current.TaskName}, Priority: {current.Priority}, Due: {current.DueDate}"
            );

            current = current.Next;

        } while (current != head);
    }

    public void SearchByPriority(int priority)
    {
        if (head == null)
            return;

        TaskNode current = head;

        do
        {
            if (current.Priority == priority)
                Console.WriteLine(current.TaskName);

            current = current.Next;

        } while (current != head);
    }

    public void ViewCurrentTask()
    {
        if (head != null)
            Console.WriteLine($"Current Task: {head.TaskName}");
    }

    public void MoveNext()
    {
        if (head != null)
        {
            head = head.Next;
            tail = tail.Next;
        }
    }

    static void Main()
    {
        TaskSchedulerCircularLinkedList tasks =
            new TaskSchedulerCircularLinkedList();

        tasks.AddAtEnd(1, "Study", 1, "12-08-2026");
        tasks.AddAtEnd(2, "Assignment", 2, "13-08-2026");
        tasks.AddAtBeginning(3, "Revision", 1, "14-08-2026");

        Console.WriteLine("Tasks:");
        tasks.Display();

        tasks.ViewCurrentTask();

        tasks.MoveNext();

        Console.WriteLine("\nAfter Move:");
        tasks.ViewCurrentTask();
    }
}