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

