# SimpleCsvReader

[![Build status](https://ci.appveyor.com/api/projects/status/ay934do7k2p649c2/branch/master?svg=true)](https://ci.appveyor.com/project/cointoss1973/simplecsvreader/branch/master)
[![Build status](https://github.com/cointoss1973/SimpleCsvReader/workflows/.NET/badge.svg)](https://github.com/cointoss1973/SimpleCsvReader/actions)

A library for read csv file, simple.

## Usage

```cs
    // Read all rows from csv
    List<string[]> rows = CsvReader.Read(fileName);
```