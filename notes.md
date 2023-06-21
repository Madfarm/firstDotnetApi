## Initial Structure
> csproj file      - used to declare how we're going to build this project
> program.cs       - the entry point to the application
> appsettings.json - app config
> appsettings.Dev  - app config for development




## Debugging and Running
Use the run and debug section on vscode

remove the "serverReadyAction" section from the launch.json in .vscode to prevent .net from opening a new browser tab every time you run the code


add this to the task in /.vscode/tasks.json with the label "build"
"group": {
                "kind": "build",
                "isDefault": true
}



final result:
{
    "label": "build",
    "command": "dotnet",
    "type": "process",
    "args": [
        "build",
        "${workspaceFolder}/firstDotnetApi.csproj",
        "/property:GenerateFullPaths=true",
        "/consoleloggerparameters:NoSummary"
    ],
    "problemMatcher": "$msCompile",
    "group": {
        "kind": "build",
        "isDefault": true
    }
}



## Seeing the results of your code
head to the url with /swagger at the end

Swagger is awesome, can't believe it's bundled


## Building
ctrl + shift + b


## Models
For our models, we'll use the Record type because they are built for handling immutable data and offer value equality instead of referential equality

public record Item
{
    public Guid Id { get; init; }
}

the init keyword instead of the set keyword means the value can only be set initially and never modified

strings are a nullable type so make the compiler happy add = null!; at the end like so,
public string Name { get; init; } = null!;

add [Required] attribute from System.ComponentModel.DataAnnotations to make a property required



## Random C# notes
When instantiating an object you can just use new() instead of new Collection<type>()

DateTimeOffset.UtcNow can be used to make datetime object of right now

.Where() can be called by any collection to allow for querying that collection

ex:
string[] names = { "chjris", "asphalt", "sintar" };
names.Where(name => name == "chjris")

.SingleOrDefault() returns the only element in a sequence or a default value if the sequence is empty
- throws an exception if there is more than one element in the sequence


NotFound() will return a Not Found status code that we can return in our api

ActionResult<Type> - lets us return multiple options from a controller action method


click the name of a class then the lightbulb to extract an interface of it


> Extension Methods - allow you to extend the functionality of a class without creating a derived class or implementing an interface - they must be static methods

## Controllers
first import the Mvc namespace,
using Microsoft.AspNetCore.Mvc;

then create a namespace, following naming conventions
ex: namespace Catalog.Controllers


then a class for each controller and this class will implement the ControllerBase interface from the Mvc namespace
ex: public class BookController : ControllerBase

and then add this attribute to that class: [ApiController] and also add an attribute specifying the route: [Route("route name")], you can also use [Route("[controller]")] and it will grab the name from the controller name

[ApiController]
[Route("books")]
public class BooksController :  ControllerBase

for each of our controller methods we define the Http request type to listen for via attributes added to that method
example with a GET request:

[HttpGet]
public IEnumerable<Book> GetBooks()

url params are done as follows
[HttpGet("{id}")]
public Book GetBook(int id)

this is a show route


## Dependency Injection
When a class uses another class, the class being used is called a dependency

Dependency Inversion Principle in C# - instead of having a class depdend directly on another class you can have it depend on an interface that the dependencies implement

we do this to create decoupling and lets us modify dependencies freely - makes more maintainable, readable, and reusable.


## Data Transfer Object
DTO - A Dto lets not expose the actual database entity and control what data the client actually receives

basically we create a second record in its own file and when we're retrieving data we're going to convert each item into that dto

book => new BookDto
{
    Id = book.Id,
    Title = book.Title,
    Price = book.Price
}

 this lets us specify a legal range for values [Range(1, 10000)]





