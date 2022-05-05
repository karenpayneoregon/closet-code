# About

Create a new folder via a MS-Build Task in the project file

```xml
<Target Name="MakeLogFolder" AfterTargets="Build">
	<MakeDir Directories="$(OutDir)Logs" />
</Target>
```