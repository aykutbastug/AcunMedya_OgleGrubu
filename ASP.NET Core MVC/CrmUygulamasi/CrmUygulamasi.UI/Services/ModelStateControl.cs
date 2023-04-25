using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CrmUygulamasi.UI.Services
{
    public static class ModelStateControl
    {
        public static void KontrolEt(INotificationService notificationService, ModelStateDictionary ModelState)
        {
            foreach (var item in ModelState)
            {
                if (item.Value.Errors.Count > 0)
                    notificationService.Notification(NotifyType.Error, item.Value.Errors[0].ErrorMessage);
            }
        }

    }
}
