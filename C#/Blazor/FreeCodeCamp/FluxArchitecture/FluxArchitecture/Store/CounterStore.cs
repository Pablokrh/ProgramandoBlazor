﻿namespace FluxArchitecture.Store
{
    public class CounterState
    {
        public int Count { get; }

        public CounterState(int count)
        {
            Count = count;
        }
    }

    public class CounterStore
    {
        private CounterState _state;
        private readonly IActionDispatcher actionDispatcher;


        public CounterStore(IActionDispatcher actionDispatcher) 
        {

            _state = new CounterState(0);
            this.actionDispatcher = actionDispatcher;
            this.actionDispatcher.Subscript(HandleActions);
        }

        public CounterState GetState()
        {
            return _state;
        }

        private void HandleActions(IAction action)
        {
            switch (action.Name)
            {
                case IncrementAction.INCREMENT:
                    IncrementCount();
                    break;

                case DecrementAction.DECREMENT:
                    DecrementCount();
                    break;
                default:
                    break;
            }


        }

        private void IncrementCount()
        {
            var count=this._state.Count;
            count++;
            this._state=new CounterState(count);
            BroadcastStateChange();
        }

        private void DecrementCount()
        {
            var count = this._state.Count;
            count--;
            this._state = new CounterState(count);
            BroadcastStateChange();
        }

        ///////////////////////
        //Acá entra el patrón Observer
        private Action _listeners;

        public void AddStateChangeListener(Action listener)
        {
            _listeners += listener;
        }
        public void RemoveStateChangeListener(Action listener)
        {
            _listeners = listener;
        }

        private void BroadcastStateChange()
        {
            _listeners.Invoke();
        }

    }
}
