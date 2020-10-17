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
participant CsvReader as reader
database csvfile
User -> reader : Read(fileName)
loop all lines 
reader -> csvfile : Read
reader <-- csvfile
end
User <-- reader : List<string[]>
@enduml
```
