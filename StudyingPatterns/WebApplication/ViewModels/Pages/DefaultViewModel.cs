using WebApplication.Constants.Template;

namespace WebApplication.ViewModels.Pages
{
	/// <inheritdoc />
	/// <summary>
	/// Модель представления для главной страницы сайта.
	/// </summary>
	public sealed class DefaultViewModel : MasterPageViewModel
	{
		public DefaultViewModel() : base("Главная")
		{
			ViewDataCustom["DefaultActiveItemMenu"] = StyleTemplateConstants.ActiveItemMenuCss;
		}
	}
}