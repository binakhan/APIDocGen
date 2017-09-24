# Project Title

Sample Web API project using Swashbuckle to generate Swagger documentation

## Getting Started

* Works on new projects as well as existing APIs.

For new projects:
1. Install "ASP.NET and Web Tools 2012.2 Update" https://go.microsoft.com/fwlink/?LinkId=282650. This update integrates help pages into the Web API project template.
2. Create a new Project with "Web API" Project Template. The template has Help Pages already added.

For existing projects:
1. Open "Package Manager Console" by selecting Tools -> NuGet Package Manager -> Package Manager Console.
2. Run the following command on the Console. Before running the command make sure the correct project is selected in "Default Project" in the console.
	Install-Package Microsoft.AspNet.WebApi.HelpPage
3. This command, amongst other things, adds an Area in the project by the name of "HelpPage".
4. Open Global.asax. Add reference to System.Web.Mvc if not already there. Add the following line in Application_Start,
	AreaRegistration.RegisterAllAreas();
   if not already there.
5. 

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

