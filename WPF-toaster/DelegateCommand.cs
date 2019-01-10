using System;
using System.Windows.Input;

namespace WPFToastr
{
	public class DelegateCommand : ICommand
	{
		#region Variable Declaration

		private readonly Action executeMethod = delegate { };
		private readonly Func<bool> canExecuteMethod;

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="DelegateCommand"/> class.
		/// </summary>
		/// <param name="executeMethod">The execute method.</param>
		public DelegateCommand(Action executeMethod) : this(executeMethod, null) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="DelegateCommand"/> class.
		/// </summary>
		/// <param name="executeMethod">The execute method.</param>
		/// <param name="canExecuteMethod">The can execute method.</param>
		public DelegateCommand(Action executeMethod, Func<bool> canExecuteMethod)
		{
			this.executeMethod = executeMethod;
			this.canExecuteMethod = canExecuteMethod;
		}

		#endregion

		#region Events

		/// <summary>
		/// Occurs when changes occur that affect whether or not the command should execute.
		/// </summary>
		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

		#endregion

		#region Methods

		/// <summary>
		/// Defines the method that determines whether the command can execute in its current state.
		/// </summary>
		/// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
		/// <returns>
		/// true if this command can be executed; otherwise, false.
		/// </returns>
		public bool CanExecute(object parameter)
		{
			return this.canExecuteMethod == null || this.canExecuteMethod();
		}

		/// <summary>
		/// Defines the method to be called when the command is invoked.
		/// </summary>
		/// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
		public void Execute(object parameter)
		{
			this.executeMethod();
		}

		#endregion
	}

	/// <summary>
	/// Command Class DelegateCommand
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class DelegateCommand<T> : ICommand
	{
		#region Variable Declaration

		private readonly Action<T> executeMethod = delegate { };
		private readonly Func<T, bool> canExecuteMethod;

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="DelegateCommand{T}"/> class.
		/// </summary>
		/// <param name="executeMethod">The execute method.</param>
		public DelegateCommand(Action<T> executeMethod) : this(executeMethod, null)
		{

		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DelegateCommand{T}"/> class.
		/// </summary>
		/// <param name="executeMethod">The execute method.</param>
		/// <param name="canExecuteMethod">The can execute method.</param>
		public DelegateCommand(Action<T> executeMethod, Func<T, bool> canExecuteMethod)
		{
			this.executeMethod = executeMethod;
			this.canExecuteMethod = canExecuteMethod;
		}

		#endregion

		#region Events

		/// <summary>
		/// Occurs when changes occur that affect whether or not the command should execute.
		/// </summary>
		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

		#endregion

		#region Methods

		/// <summary>
		/// Defines the method that determines whether the command can execute in its current state.
		/// </summary>
		/// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
		/// <returns>
		/// true if this command can be executed; otherwise, false.
		/// </returns>
		public bool CanExecute(object parameter)
		{
			var tobj = (T)parameter;
			return this.canExecuteMethod == null || this.canExecuteMethod(tobj);
		}

		/// <summary>
		/// Defines the method to be called when the command is invoked.
		/// </summary>
		/// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
		public void Execute(object parameter)
		{
			var tobj = (T)parameter;
			this.executeMethod(tobj);
		}

		#endregion

	}
}
