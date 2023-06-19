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


