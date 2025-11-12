namespace MyServerManagement.StateStore
{
    public class TorontoOnlineServersStore : Observer
    {
        private int _numServersOnline;

        public int GetNumberServersOnline()
        {
            return _numServersOnline;
        }

        public void SetNumbersServersOnline(int number)
        {
            _numServersOnline = number;
            base.BroadcastStateChange(); //notify all listeners who are subscribed this state store
        }

    }
}
