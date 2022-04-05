namespace AcheFacilAPI.Aplication.NotificationsErrors

{
    public class ErrorNotification
    {
        public ErrorNotification(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}
