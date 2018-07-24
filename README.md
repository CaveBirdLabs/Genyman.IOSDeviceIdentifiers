# CaveBirdLabs.Genyman.IOSDeviceIdentifiers
Generates an extension method to convert iOS Hardware Identifiers to Pretty Names
## Getting Started
CaveBirdLabs.Genyman.IOSDeviceIdentifiers is a **[genyman](http://genyman.net)** code generator. If you haven't installed **genyman** run following command:
```
dotnet tool install -g genyman
```
_Genyman is a .NET Core Global tool and thereby you need .NET Core version 2.1 installed._
## New Configuration file 
```
genyman new CaveBirdLabs.Genyman.IOSDeviceIdentifiers
```
## Sample Configuration file 
```
{
    "genyman": {
        "packageId": "CaveBirdLabs.Genyman.IOSDeviceIdentifiers",
        "info": "This is a Genyman configuration file - https://genyman.github.io/docs/"
    },
    "configuration": {
        "namespace": "YourNamespace"
    }
}
```
## Documentation 
### Class Configuration
| Name | Type | Req | Description |
| --- | --- | :---: | --- |
| Namespace | String |  | The target namespace for the class |
