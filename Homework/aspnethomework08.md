#### ASP.NET Chapter 8 Homework
#### Austin Stiffler
#### 29 March, 2021
---

1. 
  * Enhance the Index action method in the HomeController class so that it can filter the Product objects in the repository
  * Revisit and enhance the URL scheme
  * Create a category list that will go into the sidebar of the site, highlighting the current category and linking to others

2. 
  * catpage, page, category, pagination
  * Routes are applied in the order in which they are defined in order to run properly

3. 
  * Yes
  * For middleware

4. A *view component* is a C# class that provides a small amount of reusable application logic with the ability to select and display Razor partial views. You use them to create items.

1. InvokeAsync

1. It will note the need to provide a value for this parameter and inspect the configuration in the Startup class to determine which implementation object should be used.

1. Use parameter names that match the input elements in the HTML forms produced by the ProductSummary.cshtml view. This allows ASP.NET Core to associate incoming form POST variables with those parameters.

1. The PathAndQuery extension method operates on the HttpRequest class, which ASP.NET Core uses to describe an HTTP request. The extension method generates a URL that the browser will be returned to after the cart has been updated, taking into account the query string, if there is one.

1. *Session state* enables you to store and retrieve values for a user as the user navigates ASP.NET pages in a Web application.

1. 
  * Int, string, and byte value. 
  * Yes, you need to define extension methods to an interface which provides acces to the session state data to serialize the objects into JSON and convert them back.