Steps to reproduce the issue in: https://github.com/dotnet/efcore/issues/30231

1. Clone this repo
2. Open `MyProject.sln` in Visual Studio
3. Open the Nuget Package Manager Console (PMC)
4. At the PMC type the following command:
```
Add-Migration -StartupProject "MyProject.Deploy" -Project "MyProject.Data" "TestMigration"
```
5. Open the `yyyyMMddHHmmss_TestMigration.cs` file, which the migration has created.
6. Notice that the existing index name `IX_ConnectorEntry_Id` will be renamed to `IX_trigger_ConnectorEntry_Id`
