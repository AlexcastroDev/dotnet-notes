namespace EventRoom {
    class Room {
        public event Action? OnEnter;
        public event Action? OnExit;

        public void Enter() {
            OnEnter?.Invoke();
        }

        public void Exit() {
            OnExit?.Invoke();
        }
    }
}