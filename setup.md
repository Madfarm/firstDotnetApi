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

