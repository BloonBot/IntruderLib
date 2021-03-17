# IntruderLib

C# library for the Intruder Rest API.

## Installation

Use the latest [release](https://github.com/BloonBot/IntruderLib/releases) or clone and build it yourself.

## Usage

```csharp
// Create a new instance
IntruderAPI intruderAPI = new IntruderAPI();

try {
    // Fetch an agent
    LeveledAgent agent = await intruderAPI.GetAgentAsync(...);
}
catch (APIException ex)
{
    // Do something with the exception
}
```

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License

This project is licensed under the MIT License - see [LICENSE](LICENSE) for details.
