# XyConstruction

Dashboard for big construction company with 2 charts 
using DevExtreme with detail view on double-click.

## Getting Started

You need to build this project in MS Visual Studio. I used MS Visual Studio 2022.

### Build / Run

A step by step guide that will tell you how to get WebApp running.

```
$ Open XYConstruction.sln

The things you need before build WebApp.

* install/update NuGet packages :
* DevExtreme.AspNet.Core 
* DevExtreme.AspNet.Data
* Microsoft.Data.SqlClient
* MySql.Data

$ Check XyConstruct/Models/DataRepository.cs and rewrite 
  in connectionString [Uid=testovacie] and [Pwd=Test1234] 
  to get data form online database, or try another metod in comments.
$ Build project
$ Release project
```

## Overview

```
$ Dashboard with Revenue info and contacts to headquarters for each country
$ Revenue info contain two charts 
  -> Total Revenue per Country & Revenue distribution by projects
$ After double-click on any bar in Total Revenue chart 
  you receive detail in second chart with Country and projects data.
```


## Additional Informations

```
Responsive design for mobile devices: 
  change text format, hide legend and labels on small screen,.. 
User friendly design:
  Simple clean design with few features:
  Back button after detailed view
  Export button for print charts
  Tooltips
```
