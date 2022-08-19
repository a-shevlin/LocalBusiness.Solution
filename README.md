# Local Business API

#### By _**Alex Shevlin**_ 

#### _An API for keeping track of Local Businesses._  

---

## Table of Contents

**[Technologies Used](#technologies-used)  
[Description](#description)  
[Technology Requirements](#technology-requirements)  
[Setup and Installation](#setupinstallation-requirements)  
[Known Bugs](#known-bugs)  
[License](#license)  
[Known Bugs](#known-bugs)**

---

## Technologies Used

* _C#_
* _.NET_
* _MySQL Workbench_
* _EntityFrameWork_
* _Swagger_

## Description

_An API created for use by an animal shelter to keep track of local businesses in the Portland area._

---
## Setup/Installation Requirements

* Install *`Microsoft .NET SDK`*
* Clone this project and place files in a folder named `LocalBusiness.Solution`
    <pre>LocalBusiness.Solution
    └── LocalBusiness</pre>

<details>
<summary><strong>SQL Workbench Configuration</strong></summary>
<ol>
<li>Create an appsettings.json file in the "LocalBusiness" directory of the project*  
   <pre>LocalBusiness.Solution
   └── LocalBusiness
    └── appsettings.json</pre>
<li> Insert the following code** : <br>

<pre>{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=local_business;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}</pre>
<small>*note: you must include your password in the code block section labeled "YOUR-PASSWORD-HERE".</small><br>
<small>**note: if you plan to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore before doing so.</small>

<li>Once "appsettings.json" file has been created, run
the command: <strong>$ dotnet ef database update</strong>
</details>

<details>
<summary><strong>To Run</strong></summary>
Navigate to  
   <pre>LocalBusiness.Solution
   └── <strong>LocalBusiness</strong>

First run ```$ dotnet restore``` in the console
Then run ```$ dotnet build```
Finally run ```$ dotnet run```
</pre>
Calls can be made to the API in Postman with the address "http://localhost:5000/api/LocalBusinesses"
</details>
<br>

This program was built using *`Microsoft .NET SDK 6.0`*, and may not be compatible with other versions. Your milage may vary.

---

## Review API Endpoints

- Base URL: `http://localhost:5000`
- Add HTTP Requests to the end of the Base URL to query the API

#### HTTP Requests
```
GET /api/LocalBusinesses
POST /api/LocalBusinesses
GET /api/LocalBusinesses/{id}
PUT /api/LocalBusinesses/{id}
DELETE /api/LocalBusinesses/{id}
```

#### Sample JSON
```
{
  "businessId": 1,
  "name": "FOMO Chicken",
  "type": "Food Cart",
  "genre": "Korean",
  "address": "113 SE 28th Ave, Portland, OR 97214",
  "description": "Fried Chicken Food Cart devoted to Korean and American Southern Flavors",
  "price": 2
}
```

#### Swagger Instructions
This API uses [Swagger](https://swagger.io/tools/swagger-ui/) REST API Documentation
- Navigate to the following url to access Swagger:
```
http://localhost:5000/index.html
```
  - NOTE: the program must be running to access Swagger
The "LocalBusiness" tab contains example GET, POST, PUT, and DELETE queries
- To Test a query, find the tab for the query type and click the "Try It Out" button located in the top right corner of the card
  - This will allow inputs in the tab's form fields
  - Enter your query in the form field(s) and click the "Execute" button to view the server responses
***

## Known Bugs

* _No known bugs_

## License

[GNU](/LICENSE-GNU)

Copyright (c) 2022 Alex Shevlin