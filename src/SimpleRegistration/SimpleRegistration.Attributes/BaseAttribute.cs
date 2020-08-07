namespace SimpleRegistration.Attributes
{
	using System;

	/// <summary>
	/// Represents the base class for SimpleRegistration attributes.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public abstract class BaseAttribute : Attribute
	{
		/// <summary>
		/// Initializes a new instance of the SimpleRegistration.Attributes.BaseAttribute class.
		/// </summary>
		/// <param name="serviceType"></param>
		public BaseAttribute(Type serviceType) => ServiceType = serviceType ?? throw new ArgumentNullException(nameof(serviceType));

		/// <summary>
		/// The type of the service to register.
		/// </summary>
		public Type ServiceType { get; }
	}
}