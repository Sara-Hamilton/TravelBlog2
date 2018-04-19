# Travel Blog

##### A travel blog built with Visual Studio MVC and C#.  04/19/18

## By Andy Grossberg, Hamza Naeem, Sara Hamilton, Cameron Anderson, and Kayla Ondracek

# Description
This is an Epicodus practice project for week 1 of the .NET course.  Its purpose is to display understanding of Visual Studio MVC and Migrations.  

## Functionality
### User Stories
* a user can
  * create a location
  * create a person
  * create an experience
  * associate a person with an experience
  * associate a location with an experience
  * edit locations, persons, and experiences
  * delete locations, persons, and experiences

### Models
  * Location
  * Person
  * Experience

## Technologies Used
* HTML
* CSS
* Bootstrap
* Visual Studio
* C#
* .NET
* MySql
* MAMP

## Run the Application  

  * _Clone the github respository_
  ```
  $ git clone https://github.com/agro23/TravelBlog/commit/f87440397982176eda7fefe4ba026098cc9e6edc
  ```

  * _Install the .NET Framework and MAMP_

    .NET Core 1.1 SDK (Software Development Kit)

    .NET runtime.

    MAMP

    See https://www.learnhowtoprogram.com/c/getting-started-with-c/installing-c for instructions and links.

* _Start the Apache and MySql Servers in MAMP_

   move into the directory
   ```
   $ cd TravelBlog/TravelBlog
   ```

*  _Setup the database_

  ```
  dotnet ef database update
  ```
*  _Run the program_
  ```
  dotnet restore
  dotnet run
  ```


### License

*MIT License*

Copyright (c) 2018 **_Andy Grossberg, Hamza Naeem, Sara Hamilton, Cameron Anderson, and Kayla Ondracek_**

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
