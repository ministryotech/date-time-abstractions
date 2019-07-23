# Introduction
This project provides a DateTimeAccessor class, with matching interface, which allows you to obtain the current DateTime object. This allows you to inject the accessor through Dependency Injection and mock the return value for accurate testing.

This allows you to replace the following code (which cannot be tested)...

    class MyClass
    {
      public DateTime GetSeconds()
        => DateTime.Now.Second;            
    }

with this (which can, by mocking `IDateTimeAccessor` and returning a specific value for 'Now')...

    class MyClass
    {
      private readonly IDateTimeAccessor dateTimeAccessor;
    
      public MyClass(IDateTimeAccessor dateTimeAccessor)
      {
        this.dateTimeAccessor = dateTimeAcessor;
      }
    
      public DateTime GetSeconds()
        => dateTimeAccessor.Now.Second;            
    }
    
## Supporting Functions
In addition to the core date time accessor, this library also provides a static `DateTimeHelper` class which provides the following DateTime conversion features as extension methods to the DateTime class...

- **ToGmtTime()**
- **FromGmtTime()**
- **To UnixEpochTime()**
- **FromUnixEpochTime()**

# The Ministry of Technology Open Source Products
Welcome to The Ministry of Technology open source products. All open source Ministry of Technology products are distributed under the MIT License for maximum re-usability. Details on more of our products and services can be found on our website at http://www.minotech.co.uk

Our other open source repositories can be found here...

* [https://github.com/ministryotech](https://github.com/ministryotech)
* [https://github.com/tiefling](https://github.com/tiefling)

Newer content prefers Github. Bitbucket is no longer actively used.

### Where can I get it?
You can download the package for this project from any of the following package managers...

- **NUGET** - [https://www.nuget.org/packages/Ministry.DateTimeAccessor/](https://www.nuget.org/packages/Ministry.DateTimeAccessor/)

### Contribution guidelines
If you would like to contribute to the project, please contact me.

### Who do I talk to?
* Keith Jackson - keith@minotech.co.uk
