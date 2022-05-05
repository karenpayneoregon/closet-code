# Bogus 

[Bogus](https://github.com/bchavez/Bogus) is a C# library to assist with creating mocked data for testing purposes. This library also works with [FluentValidation](https://github.com/FluentValidation/FluentValidation) which we will discuss.

See code in BogusOperations.cs for a simple example. The json below was produced in BogusOperations.cs and called as follows. Argument 1, how many people to generate, argument 2, if true display json version of the list while false indicates not to display the json.

```csharp
var results = BogusOperations.PeopleList(1, true);
```

</br>

Read comments in code for `Residents` being `null`.

```json
[
  {
    "Id": 1,
    "FirstName": "Isaiah",
    "LastName": "Wuckert",
    "Addresses": [
      {
        "Id": 1,
        "Street": "5163 Cummings Groves",
        "PostalCode": "59534-2591",
        "Residents": null
      },
      {
        "Id": 2,
        "Street": "824 Leannon Mountains",
        "PostalCode": "03202",
        "Residents": null
      },
      {
        "Id": 3,
        "Street": "98839 Madelynn Parks",
        "PostalCode": "65580",
        "Residents": null
      },
      {
        "Id": 4,
        "Street": "920 Gleichner Unions",
        "PostalCode": "20186",
        "Residents": null
      }
    ],
    "ContactDevices": [
      {
        "Id": 1,
        "DeviceType": {
          "Id": 4,
          "Description": "Work email"
        },
        "DeviceTypeId": 1,
        "Value": "(733) 959-9376 x038"
      }
    ]
  }
]

```