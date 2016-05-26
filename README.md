## Dependency Injection Example

I built this example using ASP.NET 4.5 and MVC 5, utilising Entity Framework 6 and SQL Compact (SQLite's EF6 provider
doesn't support creating tables). I have utilised dependency injection (with the Autofac framework) as it's a great 
way to structure a project to allow for growth. I've also used AutoMapper for mapping between my models & view models. 
Glimpse (http://localhost:50900/Glimpse.axd to enable it) has been configured for debugging purposes.

The site supports Add / Edit, I use a Base Model to enforce all tables that will be added to have DateCreated / DateModified /
DateDeleted properties, as well as a virtual boolean IsDeleted to quickly determine if an object is marked as deleted.

Check it out, give it a spin and see how you go.