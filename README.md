# My Template Repo

Some starter files files I usually put into a new Git repository . Feel free to copy/reuse, but do review the settings so that they
work the way you want to - this applies especially to [.editorconfig](#anker-1).

I usually work in Visual Studio/Visual Studio Code/GitHub and the files reflect that. It may not be great fit for you.

The "Demo" project is just there to have something to test the pipelin on. Don't copy that one :)

## File explanation

* [_global.json_](https://learn.microsoft.com/en-us/dotnet/core/tools/global-json) - Specifices the version of the .NET sdk used. Used by the dotnet cli tools as well ass the GitHub action actions/setup-dotnet@v4

* <a name="anker-1">_[.editorconfig](https://editorconfig.org/)_</a> - Some commom settings for tab/spaces etc supported by some editors (Visual Studio Code requres a plugin)

* .gitignore - Bacause .....
* .gitattributes -  Standarize line endings
