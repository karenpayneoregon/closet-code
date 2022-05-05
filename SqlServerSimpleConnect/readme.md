Simple example for connecting to a SQL-Server database with a timeout. On failure we lose the reason code but end result is we can't connect.


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
