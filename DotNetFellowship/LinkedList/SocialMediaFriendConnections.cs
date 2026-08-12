using System;

class UserNode
{
    public int UserId;
    public string Name;
    public int Age;

    public int[] FriendIds;
    public int FriendCount;

    public UserNode Next;

    public UserNode(int id, string name, int age)
    {
        UserId = id;
        Name = name;
        Age = age;

        FriendIds = new int[100];
        FriendCount = 0;
    }

    public void AddFriend(int id)
    {
        if (!HasFriend(id))
        {
            FriendIds[FriendCount++] = id;
        }
    }

    public void RemoveFriend(int id)
    {
        for (int i = 0; i < FriendCount; i++)
        {
            if (FriendIds[i] == id)
            {
                for (int j = i; j < FriendCount - 1; j++)
                    FriendIds[j] = FriendIds[j + 1];

                FriendCount--;
                return;
            }
        }
    }

    public bool HasFriend(int id)
    {
        for (int i = 0; i < FriendCount; i++)
        {
            if (FriendIds[i] == id)
                return true;
        }

        return false;
    }
}

class SocialMediaFriendConnections
{
    UserNode head;

    public void AddUser(int id, string name, int age)
    {
        UserNode newUser = new UserNode(id, name, age);

        newUser.Next = head;
        head = newUser;
    }

    private UserNode FindUser(int id)
    {
        UserNode current = head;

        while (current != null)
        {
            if (current.UserId == id)
                return current;

            current = current.Next;
        }

        return null;
    }

    public void AddFriendConnection(int user1, int user2)
    {
        UserNode first = FindUser(user1);
        UserNode second = FindUser(user2);

        if (first == null || second == null)
        {
            Console.WriteLine("User not found");
            return;
        }

        first.AddFriend(user2);
        second.AddFriend(user1);
    }

    public void RemoveFriendConnection(int user1, int user2)
    {
        UserNode first = FindUser(user1);
        UserNode second = FindUser(user2);

        if (first == null || second == null)
            return;

        first.RemoveFriend(user2);
        second.RemoveFriend(user1);
    }

    public void DisplayFriends(int userId)
    {
        UserNode user = FindUser(userId);

        if (user == null)
        {
            Console.WriteLine("User not found");
            return;
        }

        Console.WriteLine($"Friends of {user.Name}:");

        for (int i = 0; i < user.FriendCount; i++)
        {
            UserNode friend = FindUser(user.FriendIds[i]);

            if (friend != null)
                Console.WriteLine(friend.Name);
        }
    }

    public void FindMutualFriends(int user1, int user2)
    {
        UserNode first = FindUser(user1);
        UserNode second = FindUser(user2);

        if (first == null || second == null)
            return;

        Console.WriteLine("Mutual Friends:");

        for (int i = 0; i < first.FriendCount; i++)
        {
            if (second.HasFriend(first.FriendIds[i]))
            {
                UserNode friend = FindUser(first.FriendIds[i]);

                if (friend != null)
                    Console.WriteLine(friend.Name);
            }
        }
    }

    public void SearchByName(string name)
    {
        UserNode current = head;

        while (current != null)
        {
            if (current.Name == name)
            {
                Console.WriteLine(
                    $"ID: {current.UserId}, Name: {current.Name}, Age: {current.Age}"
                );
                return;
            }

            current = current.Next;
        }

        Console.WriteLine("User not found");
    }

    public void CountFriends(int userId)
    {
        UserNode user = FindUser(userId);

        if (user != null)
        {
            Console.WriteLine(
                $"{user.Name} has {user.FriendCount} friends."
            );
        }
    }

    static void Main()
    {
        SocialMediaFriendConnections social =
            new SocialMediaFriendConnections();

        social.AddUser(1, "Sneha", 20);
        social.AddUser(2, "Aman", 21);
        social.AddUser(3, "Riya", 20);
        social.AddUser(4, "Karan", 22);

        social.AddFriendConnection(1, 2);
        social.AddFriendConnection(1, 3);
        social.AddFriendConnection(2, 3);

        social.DisplayFriends(1);

        Console.WriteLine();
        social.FindMutualFriends(1, 2);

        Console.WriteLine();
        social.CountFriends(1);
    }
}