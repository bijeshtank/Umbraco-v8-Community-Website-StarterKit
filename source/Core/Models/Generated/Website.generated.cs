//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.8.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Our.Umbraco.NonProfitFramework.Core.Models
{
	/// <summary>Website</summary>
	[PublishedModel("website")]
	public partial class Website : PublishedContentModel, ISettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const string ModelTypeAlias = "website";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Website, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Website(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Footer Navigation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("footerNavigation")]
		public global::System.Collections.Generic.IEnumerable<global::AaronSadler.MegaNavV8.Core.Models.MeganavV8Item> FooterNavigation => this.Value<global::System.Collections.Generic.IEnumerable<global::AaronSadler.MegaNavV8.Core.Models.MeganavV8Item>>("footerNavigation");

		///<summary>
		/// Main Navigation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("mainNavigation")]
		public global::System.Collections.Generic.IEnumerable<global::AaronSadler.MegaNavV8.Core.Models.MeganavV8Item> MainNavigation => this.Value<global::System.Collections.Generic.IEnumerable<global::AaronSadler.MegaNavV8.Core.Models.MeganavV8Item>>("mainNavigation");

		///<summary>
		/// Redir
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent UmbracoInternalRedirectId => global::Our.Umbraco.NonProfitFramework.Core.Models.Settings.GetUmbracoInternalRedirectId(this);
	}
}
