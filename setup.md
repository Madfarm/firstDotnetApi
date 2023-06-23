dotnet new webapi

dotnet new gitignore


/////////////// If there is a privacy error when running //////////////////////////////
dotnet dev-certs https --trust
///////////////////////////////////////////////////////////////////////////////////////

remove the "serverReadyAction" section from .vscode/launch.json


in .vscode/task.json,
in the build task add,
"group": {
    "kind": "build"
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




clean up the starter files by deleting,
WeatherForecast.cs and WeatherForecastController.cs


Add your model folder and make models in there

Make a controller folder and create the controllers

## MongoDB Integration
dotnet add package MongoDB.Driver

make a repository file for the database with a class that implements the respository interface

then pass a IMongoClient into the constructor
create a string for the collection and database names
then create a IMongoCollection to store the collection:

private const string databaseName = "whatever database name";
private const string collectionName = "collection name";
private readonly IMongoCollection<Model name> placeholderCollection;

public ConsctructorName(IMongoClient mongoClient)
{
    IMongoDatabase database = mongoClient.GetDatabase(databaseName);
    placeholderCollection = database.GetCollection<Model name>(collectionName);
}


now with that setup we need to grab the database and collection inside the constructor

public 


