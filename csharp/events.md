# Events

The event in C#, is a way to notify the subscribers that something happened.

```csharp
class Room {
    public event Action OnEnter;
    public event Action OnExit;

    public void Enter() {
        OnEnter?.Invoke();
    }

    public void Exit() {
        OnExit?.Invoke();
    }
}
```

The `Action` is a delegate that can be used to reference a method that returns void and has no parameters.

```csharp
class Program {
    static void Main(string[] args) {
        var room = new Room();

        room.OnEnter += () => Console.WriteLine("Enter");
        room.OnExit += () => Console.WriteLine("Exit");
    }
}
```

The `+=` operator is used to subscribe to an event. The `-=`, to unsubscribe.

```csharp
class Program {
    static void Main(string[] args) {
        var room = new Room();

        room.OnEnter += () => Console.WriteLine("Enter");
        room.OnExit += () => Console.WriteLine("Exit");

        room.Enter();
        room.Exit();
    }
}
```

The `?.` operator is used to invoke the event. It will only invoke the event if there are subscribers.

```
Enter
Exit
```
