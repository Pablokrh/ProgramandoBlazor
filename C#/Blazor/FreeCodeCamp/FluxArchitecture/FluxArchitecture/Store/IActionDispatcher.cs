namespace FluxArchitecture.Store
{
    public interface IActionDispatcher
    {
        void Dispatch(IAction action);
        void Subscript(Action<IAction> actionHandler);
        void UnSubscript(Action<IAction> actionHandler);
    }
}