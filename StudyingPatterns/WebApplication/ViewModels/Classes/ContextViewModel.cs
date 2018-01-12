using System;
using DotVVM.Framework.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace WebApplication.ViewModels.Classes
{
	/// <summary>
	/// Модель представления содержащий контекст страницы
	/// </summary>
	public class ContextViewModel : DotvvmViewModelBase
	{
		private ControllerContext _controllerContext;
		private ViewDataDictionary _viewData;

		/// <summary>
		/// Gets or sets the <see cref="T:Microsoft.AspNetCore.Mvc.ControllerContext" />.
		/// </summary>
		/// <remarks>
		/// <see cref="T:Microsoft.AspNetCore.Mvc.Controllers.IControllerActivator" /> 
		/// activates this property while activating controllers.
		/// If user code directly instantiates a controller, the getter returns an empty
		/// <see cref="T:Microsoft.AspNetCore.Mvc.ControllerContext" />.
		/// </remarks>
		[ControllerContext]
		private ControllerContext ControllerContext => _controllerContext ?? (_controllerContext = new ControllerContext());

		/// <summary>
		/// Gets or sets <see cref="T:Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary" /> 
		/// used by <see cref="T:Microsoft.AspNetCore.Mvc.ViewResult" /> 
		/// and <see cref="P:Microsoft.AspNetCore.Mvc.Controller.ViewBag" />.
		/// </summary>
		/// <remarks>
		/// By default, this property is activated 
		/// when <see cref="T:Microsoft.AspNetCore.Mvc.Controllers.IControllerActivator" /> activates
		///  controllers. However, when controllers are directly instantiated in user code, this property is
		/// initialized with <see cref="T:Microsoft.AspNetCore.Mvc.ModelBinding.EmptyModelMetadataProvider" />.
		/// </remarks>
		[ViewDataDictionary]
		public ViewDataDictionary ViewDataCustom
		{
			get => _viewData ??
			       (_viewData = new ViewDataDictionary(new EmptyModelMetadataProvider(), ControllerContext.ModelState));
			protected set => _viewData = value ?? throw new ArgumentException("Отсутствует ViewData", nameof(ViewDataCustom));
		}
	}
}
