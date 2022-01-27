# How to generate the bundle
```dotnet msbuild -t:BundleApp -p:RuntimeIdentifier=osx-x64 -p:UseAppHost=true```