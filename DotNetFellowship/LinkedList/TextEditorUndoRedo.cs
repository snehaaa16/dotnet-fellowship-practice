using System;

class TextStateNode
{
    public string Text;

    public TextStateNode Previous;
    public TextStateNode Next;

    public TextStateNode(string text)
    {
        Text = text;
    }
}

class TextEditorUndoRedo
{
    TextStateNode head;
    TextStateNode tail;
    TextStateNode current;

    int count = 0;
    const int MAX_HISTORY = 10;

    public void AddState(string text)
    {
        TextStateNode newNode = new TextStateNode(text);

        // Remove redo states
        if (current != tail)
        {
            current.Next = null;
            tail = current;
        }

        if (head == null)
        {
            head = tail = current = newNode;
            count = 1;
            return;
        }

        tail.Next = newNode;
        newNode.Previous = tail;

        tail = newNode;
        current = newNode;

        count++;

        if (count > MAX_HISTORY)
        {
            head = head.Next;
            head.Previous = null;
            count--;
        }
    }

    public void Undo()
    {
        if (current != null && current.Previous != null)
        {
            current = current.Previous;
        }
        else
        {
            Console.WriteLine("Nothing to undo");
        }
    }

    public void Redo()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
        }
        else
        {
            Console.WriteLine("Nothing to redo");
        }
    }

    public void DisplayCurrentState()
    {
        if (current != null)
            Console.WriteLine($"Current Text: {current.Text}");
        else
            Console.WriteLine("No text");
    }

    public void DisplayHistory()
    {
        TextStateNode temp = head;

        while (temp != null)
        {
            Console.WriteLine(temp.Text);
            temp = temp.Next;
        }
    }

    static void Main()
    {
        TextEditorUndoRedo editor =
            new TextEditorUndoRedo();

        editor.AddState("");
        editor.AddState("Hello");
        editor.AddState("Hello World");
        editor.AddState("Hello World!");

        Console.WriteLine("Current:");
        editor.DisplayCurrentState();

        editor.Undo();

        Console.WriteLine("\nAfter Undo:");
        editor.DisplayCurrentState();

        editor.Redo();

        Console.WriteLine("\nAfter Redo:");
        editor.DisplayCurrentState();

        Console.WriteLine("\nHistory:");
        editor.DisplayHistory();
    }
}