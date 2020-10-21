# SimpleCsvReader 

"SimpleCsvReader" is a .NET library that reads a CSV file.

## Introduction
SimpleCsvReader provide only CsvReader class.
```plantuml
@startuml
skinparam shadowing false
package SimpleCsvReader <<rectangle>>{
    class CsvReader {
        + Read(fileName)
    }
}
@enduml
```


## Usage
### Read a CSV file
```csharp
            List<string[]> rows = CsvReader.Read(fileName);
```

```plantuml
@startuml
skinparam shadowing false
hide footbox
participant CsvReader as reader
database csvfile
[-> reader : Read(fileName)
loop all lines 
reader -> csvfile : Read
reader <-- csvfile
end
[<-- reader : List<string[]>
@enduml
```
