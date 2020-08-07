namespace SimpleRegistration.Attributes
{
	using System;

	/// <summary>
	/// Adds a singleton service of the specified type.
	/// </summary>
	public sealed class AddSingletonAttribute : BaseAttribute
	{
		/// <summary>
		///  Initializes a new instance of the SimpleRegistration.Attributes.AddSingletonAttribute class.
		/// </summary>
		/// <param name="serviceType"></param>
		public AddSingletonAttribute(Type serviceType) : base(serviceType) { }
	}
}