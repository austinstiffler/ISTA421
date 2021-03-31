#### ASP.NET Chapter 7 Homework
#### Austin Stiffler
#### 22 March, 2021
---

1. The listed requirements for SportsStore are:
  * Online product catalog
  * Shopping cart
  * Checkout
  * Administration area

2. The Startup class is responsible for configuring the ASP.NET Core application.

2. The ConfigureServices method is used to set up objects, known as services, that can be used throughout the application and that are accessed through a feature called *dependency injection*.

2. ASP.NET Core receives HTTP requests and passes them along a *request pipeline*, which is populated with middleware components registered in the Configure method.

2. *View start* tells Razor to use a layout file in the HTML that it generates, reducing the amount of duplication in views.

2. Entity Framework Core is able to generate the schema for the database using the data model classes through a feature called *migrations*.

2. ASP.NET consults the configuration of the Startup class.

1. Paging mechanism is used so that the view displays a smaller number of products on a page, and the user can move from page to page to view the overall catalog.

1. *Dependency injection* makes it possible to easily access services anywhere in the application, including middleware components.

1. The MapDefaultControllerRoute method tells ASP.NET Core how to match URLs to controller classes. The configuration applied by that method declares that the Index action method defined by the Home controller will be used to handle requests.