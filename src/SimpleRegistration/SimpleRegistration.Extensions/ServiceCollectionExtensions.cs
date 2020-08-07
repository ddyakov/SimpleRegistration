namespace SimpleRegistration.Extensions
{
	using System;
	using System.Linq;
	using System.Reflection;

	using Microsoft.Extensions.DependencyInjection;
	
	using SimpleRegistration.Attributes;

	/// <summary>
	/// Extension methods for adding services to an Microsoft.Extensions.DependencyInjection.IServiceCollection.
	/// </summary>
	public static class ServiceCollectionExtensions
	{
		private const string AttributeClassSuffix = "Attribute";

		/// <summary>
		/// Adds services to an Microsoft.Extensions.DependencyInjection.IServiceCollection depending on the SimpleRegistration.Attributes classes.
		/// </summary>
		/// <param name="services"></param>
		/// <returns></returns>
		public static IServiceCollection AddSimpleRegistrationServices(this IServiceCollection services)
		{
			var callingAssembly = Assembly.GetCallingAssembly();

			var allAssemblies = callingAssembly
				.GetReferencedAssemblies()
				.Append(callingAssembly.GetName())
				.ToList();

			var assembliesTypes = allAssemblies
				.Select(Assembly.Load)
				.SelectMany(assembly => assembly.GetTypes())
				.Where(type => type.IsDefined(typeof(BaseAttribute)) && type.IsClass && !type.IsAbstract)
				.ToList();

			if (!assembliesTypes.Any())
			{
				return services;
			}

			foreach (var implementationType in assembliesTypes)
			{
				var customAttribute = implementationType.GetCustomAttribute<BaseAttribute>();

				var methodName = customAttribute
					.GetType()
					.Name
					.Replace(AttributeClassSuffix, string.Empty);

				typeof(ServiceCollectionServiceExtensions)
					.GetMethod(methodName, new Type[] { typeof(IServiceCollection), typeof(Type), typeof(Type) })
					.Invoke(null, new object[] { services, customAttribute.ServiceType, implementationType });
			}

			return services;
		}
	}
}
