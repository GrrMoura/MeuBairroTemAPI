namespace AcheFacilAPI.Aplication.NotificationsErrors

{
    public interface INotifier
    {
        bool HaveNotification();
        List<ErrorNotification> GetNotifications();
        void Handle(ErrorNotification errorNotification);
    }
}
