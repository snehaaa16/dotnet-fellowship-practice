using System;

class ProcessNode
{
    public int ProcessId;
    public int BurstTime;
    public int RemainingTime;
    public int Priority;

    public ProcessNode Next;

    public ProcessNode(int id, int burstTime, int priority)
    {
        ProcessId = id;
        BurstTime = burstTime;
        RemainingTime = burstTime;
        Priority = priority;
    }
}

class RoundRobinScheduling
{
    ProcessNode head;
    ProcessNode tail;

    public void AddProcess(int id, int burstTime, int priority)
    {
        ProcessNode newNode =
            new ProcessNode(id, burstTime, priority);

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

    public void RemoveProcess(int id)
    {
        if (head == null)
            return;

        ProcessNode current = head;
        ProcessNode previous = tail;

        do
        {
            if (current.ProcessId == id)
            {
                if (current == head)
                    head = head.Next;

                if (current == tail)
                    tail = previous;

                previous.Next = current.Next;

                if (tail != null)
                    tail.Next = head;

                return;
            }

            previous = current;
            current = current.Next;

        } while (current != head);
    }

    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("No processes");
            return;
        }

        ProcessNode current = head;

        do
        {
            Console.WriteLine(
                $"P{current.ProcessId} - Remaining: {current.RemainingTime}"
            );

            current = current.Next;

        } while (current != head);
    }

    public void Run(int timeQuantum)
    {
        if (head == null)
            return;

        int totalProcesses = Count();
        int[] waitingTimes = new int[100];
        int[] turnaroundTimes = new int[100];
        int[] burstTimes = new int[100];

        ProcessNode temp = head;

        do
        {
            burstTimes[temp.ProcessId] = temp.BurstTime;
            temp = temp.Next;
        } while (temp != head);

        int currentTime = 0;

        while (head != null)
        {
            ProcessNode current = head;

            do
            {
                if (current.RemainingTime > 0)
                {
                    int executionTime =
                        Math.Min(timeQuantum, current.RemainingTime);

                    current.RemainingTime -= executionTime;
                    currentTime += executionTime;

                    Console.WriteLine(
                        $"Executed P{current.ProcessId} for {executionTime} units"
                    );

                    if (current.RemainingTime == 0)
                    {
                        turnaroundTimes[current.ProcessId] = currentTime;

                        waitingTimes[current.ProcessId] =
                            currentTime - burstTimes[current.ProcessId];

                        int id = current.ProcessId;

                        current = current.Next;
                        RemoveProcess(id);

                        break;
                    }
                }

                current = current.Next;

            } while (head != null && current != head);

            Console.WriteLine("\nRemaining Processes:");
            Display();
            Console.WriteLine();
        }

        double totalWaiting = 0;
        double totalTurnaround = 0;

        for (int i = 0; i < waitingTimes.Length; i++)
        {
            if (burstTimes[i] > 0)
            {
                totalWaiting += waitingTimes[i];
                totalTurnaround += turnaroundTimes[i];
            }
        }

        Console.WriteLine(
            $"Average Waiting Time: {totalWaiting / totalProcesses}"
        );

        Console.WriteLine(
            $"Average Turnaround Time: {totalTurnaround / totalProcesses}"
        );
    }

    private int Count()
    {
        if (head == null)
            return 0;

        int count = 0;
        ProcessNode current = head;

        do
        {
            count++;
            current = current.Next;
        } while (current != head);

        return count;
    }

    static void Main()
    {
        RoundRobinScheduling scheduler =
            new RoundRobinScheduling();

        scheduler.AddProcess(1, 5, 1);
        scheduler.AddProcess(2, 3, 2);
        scheduler.AddProcess(3, 4, 1);

        Console.WriteLine("Initial Processes:");
        scheduler.Display();

        Console.WriteLine("\nRound Robin Execution:");
        scheduler.Run(2);
    }
}