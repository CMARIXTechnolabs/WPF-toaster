using System.Windows;
using WPFToastr.ViewModel;

namespace WPFToastr
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			this.DataContext = new MainViewModel();
			InitializeComponent();
		}

		private void Window_Closed(object sender, System.EventArgs e)
		{
			Application.Current.Shutdown();
		}
	}
}
