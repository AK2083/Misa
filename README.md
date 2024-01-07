# Misa
This class library holds all shared attribute classes for specifying the validity date.

# Installation
Add a github package reference:
```
dotnet nuget add source --username 'username' --password 'gh-token' --store-password-in-clear-text --name github "https://nuget.pkg.github.com/AK2083/index.json"
```
Add this package:
```
dotnet add package Misa --version 'version'
```

# Using
This library is used by specifying the attribute for the respective workflow:

```
[WorkflowValidity("01.01.2023")]
public class Class1
{

}
```