# SimpleCsvReader 

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
### How to read a CSV file
```csharp
            List<string[]> rows = CsvReader.Read(fileName);
```

```plantuml
@startuml
skinparam shadowing false
hide footbox
participant Program as User
participant SimpleCsvReader
database csvfile
User -> SimpleCsvReader : Read(fileName)
loop all lines 
SimpleCsvReader -> csvfile : Read
SimpleCsvReader <-- csvfile
end
User <-- SimpleCsvReader : List<string[]>
@enduml
```
