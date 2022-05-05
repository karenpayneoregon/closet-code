Open `appsettings.json`, place `your` connection string in `Development` property

```json
{
  "ConnectionsConfiguration": {
    "ActiveEnvironment": "Development",
    "Development": "Data Source=.\\SQLEXPRESS;Initial Catalog=NorthWind2020;Integrated Security=True",
    "Stage": "Stage connection string goes here",
    "Production": "Prod connection string goes here"
  }
}
```

Uses NuGet package [ConfigurationLibrary](https://www.nuget.org/packages/ConfigurationLibrary/) (I wrote it)
