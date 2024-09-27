# My Template Repo

The files I usually put into a new Git repository bacause they are usefull and gives some consistency. Feel free to copy,
but please review the settings so thay they work the way you want to - [.editorconfig](#anker-1) is important.

I usually work on dotnet in Visual Studio/Visual Studio Code/GitHub so this repo is tailored to that expecience.

The "Demo" project is just there to have something to test the pipelin on. Don't copy that one :)


[global.json](def) - Specifices the version of the .NET sdk used. Used by the dotnet cli tools as well ass the GitHub action actions/setup-dotnet@v4

<a name="anker-1">[.editorconfig](def2)</a> - Some commom settings for tab/spaces etc supported by some editors (Visual Studio Code requres a plugin
)
[def]: https://learn.microsoft.com/en-us/dotnet/core/tools/global-json
[def2]: https://editorconfig.org/

.gitignore - Duh ..  Every git repo needs one
.gitattributes -  Standadize end
