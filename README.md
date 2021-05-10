# CarRentalManagement #
Repo for the learning project built in the Udemy course "Modern Web Development with Blazor and .NET Core 5".  
Built in .NET version 5.
The Model-View-Controller (MVC) design pattern is implemented, with a little spin on the views part. 
The model part is implemented so Entity Framework knows which tables to generate. 
The models are re-used in the controller part of the application where ASP.NET exposes database operations via the so-called HTTP verbs (REST APIs). 
Lastly the view part of the MVC design pattern is implemented with Blazor. The Blazor part of the application consumes the REST APIs exposed by the controller part of the application. The end-user can perform CRUD operations in a user friendly manner without any reloading because of Blazor.

[Live demo](https://carrentalmanagement.azurewebsites.net/ "Live demo")  
[Link to course](https://www.udemy.com/course/modern-web-development-with-blazor-and-net-core-5 "Link to course")

# Stack #
## Front end ##
* Blazor, HTML, CSS, Bootstrap 4 and a little sprinkle of JavaScript.

## Back end ##
* REST API: ASP.NET Controllers
* Authentication and authorization: ASP.NET Core Identity
* Global error handling: ASP.NET HttpInterceptorService
* Database: SQL (SQLite, Generated via a code-first approach with Microsoft's Entity Framework)
* Hosting: Microsoft Azure App Service
