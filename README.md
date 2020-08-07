# SimpleRegistration
SimpleRegistration is a package allowing you to easily add scoped, transient and singleton services by using attribues.

# Get Started
1. Install the Nuget Packages:

    - [SimpleRegistration.Attributes](https://www.nuget.org/packages/SimpleRegistration.Attributes/)  

    - [SimpleRegistration.Extensions](https://www.nuget.org/packages/SimpleRegistration.Extensions/)

2. Decorate your service implementation class:

```csharp
    [AddTransient(typeof(IService1))]
	public class Service1 : IService1
	{
		public string GetMessage() => $"Hello from {nameof(Service1)}";
	}
```
3. Invoke **AddSimpleRegistrationServices()** in StartUp.cs:

```csharp
    public void ConfigureServices(IServiceCollection services)
    {
        ...

        services.AddSimpleRegistrationServices();

        ...
    }
```

4. **Done!**

***

## Questions, problems or something else?

##### There is a bug? Leave an issue on the [issues](https://github.com/ddyakov/SimpleRegistration/issues) page or send a [pull request](https://github.com/ddyakov/SimpleRegistration/pulls) with new features.

##### For questions, do not hesitate to write me an email - *dimitar.dyakov98@gmail.com*

##### Leave a star if you like and find the package helpful!

***

Copyright (c) 2020 Dimitar Dyakov