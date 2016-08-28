== Setup ==

1. Install Visual Studio 2015
2. git clone https://github.com/gopalakrishnan-subramani/WebApiWorkshopServer  
   
   or Download the zip from github

3. Restore the packages needed for Nuget (Open Tools->NeGut Package Manager Console)
   NuGet prompts to update the packages, Accept it

4. Build Solution

5. To create DB and seed data 
```
   PM> Update-Database
```

we have below apis, products are taken from wikipedia smart phone page

```
1. /api/products
2. /api/brands
3. /api/cities
4. /api/states
5. /api/contacts
```
