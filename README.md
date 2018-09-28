## MSBuild Settings

```bash
dotnet pack src/MyApp /p:Version=10.0.0

dotnet publish src/MyApp -r rhel.6-x64 -o publish
dotnet publish src/MyApp -r rhel.6-x64 -o publish -c release

dotnet msbuild src/MyApp -p:Configuration=Release -t:Publish
dotnet msbuild src/MyApp -p:Configuration=Release -t:Clean
dotnet msbuild src/MyApp -p:Configuration=Release -t:Pack
dotnet msbuild src/MyApp -p:Configuration=Release -t:Rebuild

dotnet msbuild src/MyApp -pp | grep "Target Name="

dotnet msbuild src/MyApp -t:GenerateAssemblyInfo /p:Version=10.10.0
cat src/MyApp/obj/Debug/netcoreapp2.1/MyApp.AssemblyInfo.cs
```