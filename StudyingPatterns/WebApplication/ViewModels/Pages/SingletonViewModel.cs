using WebApplication.Constants.Template;

namespace WebApplication.ViewModels.Pages
{
	/// <inheritdoc />
	/// <summary>
	/// Модель представления для паттерна Singleton.
	/// </summary>
	public sealed class SingletonViewModel : MasterPageViewModel
	{

		public SingletonViewModel() : base("Singleton")
		{
			ViewDataCustom["SingletonActiveItemMenu"] = StyleTemplateConstants.ActiveItemMenuCss;
		}
	}
}