namespace FluxArchitecture.Store
{
    public class ActionDispatcher : IActionDispatcher
    {
        private Action<IAction> _registeredActionHandlers;

        public void Subscript(Action<IAction> actionHandler)
        {
            _registeredActionHandlers += actionHandler;
        }
        public void UnSubscript(Action<IAction> actionHandler)
        {
            _registeredActionHandlers -= actionHandler;
        }
        public void Dispatch(IAction action)
        {
            _registeredActionHandlers?.Invoke(action);
        }
    }
}
