using Radzen;

namespace AP1_P1_Jose_angel_Vargas_Polanco.Extenciones
{
    public static class Notificationes
    {
       public static void ShowNotification(this NotificationService notifier, string mensaje, NotificationSeverity severity = NotificationSeverity.Success)
        {
            var message = new NotificationMessage
            {
                Severity = severity,
                Summary = mensaje
            };

            notifier.Notify(message);
        }

    }
}