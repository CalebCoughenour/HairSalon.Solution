# Claire's Cuttery

#### By Caleb Coughenour

#### This is a hair salon webpage built using C#/ASP.NET

## Technologies Used

* C#
* HTML
* CSS
* SQL Workbench
* ASP.NET
* Entity Framework
* REPL
* MVC

## Description

This webpage was programmed using C#, ASP.NET & Entity. It is a hair salon that allows the user to add stylists with a specialty. The user can then add a customer to that stylist. This is done using the SQL Workbench for the database with two tables, one for stylists and the other for customers.

## Required

* [REPL](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-5.0.401-windows-x64-installer) - restart terminal after install
* .NET (install using "dotnet tool install -g dotnet-script" in console)
    - Configure Bash environment variables by running "echo 'export PATH=$PATH:~/.dotnet/tools' >> ~/.bash_profile" in your gitbash terminal
* [SQL Workbench](https://downloads.mysql.com/archives/get/p/25/file/mysql-installer-web-community-8.0.19.0.msi)
    - You will need to include your password in the appsettings.json file

## Setup/Installation Requirements

* Copy the git repository url from the "code" drop down on this github page
* Open a shell program & navigate to your desktop
* Clone the repository using the copied URL and the "git clone" command
* In the shell program, navigate to the root directory of the newly created file called "HairSalon.Solution"
* From the root directory, navigate to the directory named "HairSalon"
* In this directory create a file named "appsettings.json"
* Add the following code to the newly created .json file
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=caleb_coughenour;uid=root;pwd=[YOUR-PASSWORD];"
  }
}
```
* In the HairSalon directory type "dotnet run" to start the program
* Open a web browser and plug "http://localhost:5000/" into the URL bar

## Known Bugs

* No known issues

## License

[MIT](LICENSE)

Copyright (c) 5/20/22 Caleb Coughenour