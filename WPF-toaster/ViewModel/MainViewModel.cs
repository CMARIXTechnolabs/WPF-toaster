using Notifications.Wpf;
using System.Windows.Input;

namespace WPFToastr.ViewModel
{
	public class MainViewModel
	{

		public MainViewModel()
		{
			this.SuccessNotificationCommand = new DelegateCommand<object>(this.SuccessNotificationMethod);
			this.InformationNotificationCommand = new DelegateCommand<object>(this.InformationNotificationMethod);
			this.WarningNotificationCommand = new DelegateCommand<object>(this.WarningNotificationMethod);
			this.ErrorNotificationCommand = new DelegateCommand<object>(this.ErrorNotificationMethod);
		}

		public ICommand SuccessNotificationCommand { get; set; }
		public ICommand InformationNotificationCommand { get; set; }
		public ICommand WarningNotificationCommand { get; set; }
		public ICommand ErrorNotificationCommand { get; set; }


		private void SuccessNotificationMethod(object obj)
		{
			

			this.ShowNotification(NotificationType.Success, "Sample Notification", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
		}

		private void InformationNotificationMethod(object obj)
		{
			this.ShowNotification(NotificationType.Information, "Sample Notification", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
		}

		private void WarningNotificationMethod(object obj)
		{
			this.ShowNotification(NotificationType.Warning, "Sample Notification", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
		}

		private void ErrorNotificationMethod(object obj)
		{
			this.ShowNotification(NotificationType.Error, "Sample Notification", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
		}

		private void ShowNotification(NotificationType type, string title, string message)
		{
			var notificationManager = new NotificationManager();

			notificationManager.Show(new NotificationContent
			{
				Title = title,
				Message = message,
				Type = type
			});
		}
	}
}
