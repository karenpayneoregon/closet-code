# About

Demonstrates basic use of [Matcher.AddExclude](https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.filesystemglobbing.matcher.addexclude?view=dotnet-plat-ext-6.0) and [Matcher.AddInclude](https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.filesystemglobbing.matcher.addinclude?view=dotnet-plat-ext-6.0) for [file globbing](https://docs.microsoft.com/en-us/dotnet/core/extensions/file-globbing).

Objective, to get all files under the current Visual Studio solution which are at the root folder and below.

Files to include, all .cs file excluding those with Assembly or Designer in their names.

Setup to search for all .cs files in the include array then in the exclude array add exclusions.

```csharp
string[] include = { "**/*.cs" };
string[] exclude = { "**/*Assembly*.cs", "**/*Designer*.cs" };
await GlobbingOperations.Asynchronous(path, include, exclude);
```

Backend code

- Add and exclude patterns are added to the Matcher. Note that there are also methods for adding bothin inclusions and exclusions e.g. [AddExclude](https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.filesystemglobbing.matcher.addexclude?view=dotnet-plat-ext-6.0) and [AddInclude](https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.filesystemglobbing.matcher.addinclude?view=dotnet-plat-ext-6.0).
- Code is wrapped in a Task to keep the application responsive when working with larger directories.
- Rather than wait for a method to return, results are passed in an event to the caller.
- Upon completion an event is fired to notify the caller.

```csharp
    public static async Task Asynchronous(string parentFolder, string[] patterns, string[] excludePatterns)
    {

        List<FileMatchItem> list = new();

        Matcher matcher = new();
        matcher.AddIncludePatterns(patterns);
        matcher.AddExcludePatterns(excludePatterns);

        await Task.Run(async () =>
        {
            await Task.Delay(1);
            foreach (string file in matcher.GetResultsInFullPath(parentFolder))
            {
                TraverseFileMatch?.Invoke(new FileMatchItem(file));
            }
        });

        Done?.Invoke("Finished");

    }
}
```

## Sample patterns

| Value        | Description     |
|:------------- |:-------------|
| *.txt|All files with .txt file extension. |
| *.\* | All files with an extension|
| * | All files in top-level directory.|
| .*	| File names beginning with '.'.|
| *word\*| All files with 'word' in the filename.|
| readme.*| All files named 'readme' with any file extension.|
| styles/*.css| All files with extension '.css' in the directory 'styles/'.|
| scripts/*/\*| All files in 'scripts/' or one level of subdirectory under 'scripts/'.|
| images*/*| All files in a folder with name that is or begins with 'images'.|
| **/\*| All files in any subdirectory.|
| dir/**/\*| All files in any subdirectory under 'dir/'.|
| ../shared/*| All files in a diretory named "shared" at the sibling level to the base directory|

## See also

- [MatcherExtensions Class](https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.filesystemglobbing.matcherextensions?view=dotnet-plat-ext-6.0)
- [FilePatternMatch Struct](https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.filesystemglobbing.filepatternmatch?view=dotnet-plat-ext-6.0)
- [PatternMatchingResult Class](https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.filesystemglobbing.patternmatchingresult?view=dotnet-plat-ext-6.0)
