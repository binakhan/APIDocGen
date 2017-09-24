# Project Title

Sample Web API project using Swashbuckle to generate Swagger documentation

## Getting Started

* Works on new projects as well as existing APIs.

1. Open "Package Manager Console" by selecting Tools -> NuGet Package Manager -> Package Manager Console.
2. Run the following command on the Console. Before running the command make sure the correct project is selected in "Default Project" in the console.
	Install-Package Swashbuckle -Version 5.6.0 
   Make sure to get the latest version of Swashbuckle. For this check the link: https://www.nuget.org/packages/Swashbuckle
3. Check the Swagger.config file of this project and copy the file in your API.
4. Open the Properties of your API project and select "Build" option. Go to the bottom and check "XML Documentation file". Update the path of the XML document. 
5. Paste the path in Swagger.config: 
						c.IncludeXmlComments(string.Format(@"{0}bin\API.xml",
                           System.AppDomain.CurrentDomain.BaseDirectory));
6. Build the project and run.
7. The documentation can be found at "<BaseURL>/swagger/ui/index".
8. To view the Swagger JSON go to "<BaseURL>/swagger/docs/v1".

### Prerequisites

The project has been developed on Visual Studio 2017 with .NET Framework.

## Acknowledgments

* https://www.nuget.org/packages/Swashbuckle
* http://wmpratt.com/swagger-and-asp-net-web-api-part-1/

