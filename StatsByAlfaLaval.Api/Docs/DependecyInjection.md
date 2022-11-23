### DependencyInjection

#### Why does all some libraries have DependencyInjection.cs?

Imagine if the project would scale up in a short period of time or was much bigger and we would have multiple developers working on different parts of the application. The class would be very handy mostly because we could assign different teams to work in different class libraries, this is actually a thing they do at Microsoft. With DependencyInjection.cs every team can maintain their own register of services.  


