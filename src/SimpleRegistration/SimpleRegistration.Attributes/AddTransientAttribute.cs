namespace SimpleRegistration.Attributes
{
	using System;

	/// <summary>
	/// Adds a transient service of the specified type.
	/// </summary>
	public sealed class AddTransientAttribute : BaseAttribute
	{
		/// <summary>
		/// Initializes a new instance of the SimpleRegistration.Attributes.AddTransientAttribute class.
		/// </summary>
		/// <param name="serviceType"></param>
		public AddTransientAttribute(Type serviceType) : base(serviceType) { }
	}
}