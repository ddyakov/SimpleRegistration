namespace SimpleRegistration.Attributes
{
	using System;

	/// <summary>
	/// Adds a scoped service of the specified type.
	/// </summary>
	public sealed class AddScopedAttribute : BaseAttribute
	{
		/// <summary>
		/// Initializes a new instance of the SimpleRegistration.Attributes.AddScopedAttribute class.
		/// </summary>
		/// <param name="serviceType"></param>
		public AddScopedAttribute(Type serviceType) : base(serviceType) { }
	}
}