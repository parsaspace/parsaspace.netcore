# Parsaspace.NET-Core
   Parsaspace .Net cross platform integration library
## Requirements
    ASP.NET Core 2  or later.
## Installation
  Install from [nuget](https://www.nuget.org/packages/parsaspace.netcore/)
  ### package manager
    Install-Package  parsaspace.netcore -Version 1.0.0
  ### .NET CLI
    dotnet add package parsaspace.netcore
    
## Get ListFile

```c#
          try 
            {
               parsaspace.netcore.v1 parsaspace = new parsaspace.netcore.v1("your token");
               var file = await  parsaspace.GetFileList("your domain", "/");
               foreach (var item in file.List)
               {
                Console.WriteLine(item.Name);
               }
            }
            catch (parsaspace.netcore.Exceptions.ApiException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (parsaspace.netcore.Exceptions.ConnectionException ex)
            {
                Console.WriteLine(ex.Message);
            }  
```


            

  
