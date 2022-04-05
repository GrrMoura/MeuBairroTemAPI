

namespace AcheFacilAPI.Aplication.NotificationsErrors
{
    public class Notifier : INotifier
    {
        private List<ErrorNotification> _notificicationErrors;

        public Notifier()
        {
            _notificicationErrors = new List<ErrorNotification>();

        }
        public bool HaveNotification()
        {
            return _notificicationErrors.Any();
        }

        public List<ErrorNotification> GetNotifications()
        {
            return _notificicationErrors;
        }

        public void Handle(ErrorNotification notificicationError)
        {
            _notificicationErrors.Add(notificicationError);
        }

    }
}
