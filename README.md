# <h1 align = "center"> Saint Hairon © Salon

![Preview](./HairSalon/wwwroot/img/preview.png)

#### _Database Basics, Indepedent Project for Epicodus, 07.31.2020_

#### By _**Christine Augustine**_

## Description

This application is a MVC web application to help Hairon manage their stylists and their clients. Hairon should be able to add a list of stylists working at the salon, and for each stylist, add clients who see that stylist. The stylists have specific specialties, so each client can only see (belong to) a single stylist.


### Installing and Configuring MySQL

1. Start by downloading the MySQL Community Server .dmg file [HERE](https://dev.mysql.com/downloads/file/?id=484914). Click the download icon. Use the *No thanks, just start my download link*.
2. Follow along with the Install, once on the configuation make sure you:
- Use Legacy Password Encryption.
- Set a unique password
3. Once finished, open your terminal and enter the command echo `export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`. This will save this path in .bash_profile, which is where our terminal is configured.
4. Next, download the MySQL Workbench .dmg file [HERE](https://dev.mysql.com/downloads/file/?id=484391). Again, use the *No thanks, just start my download link*.
5.Install MySQL Workbench to Applications folder.

### Recreating the Local Database

1. Open **MySQL Workbench**, select Local 3306 and enter your password
2. Use this query selection to create the database:
```
CREATE DATABASE `christine_augustine`; 

USE `christine_augustine`;

CREATE TABLE `clients` (
  `ClientId` int(11) NOT NULL AUTO_INCREMENT,
  `StylistId` int(11) NOT NULL,
  `Name` varchar(255) DEFAULT NULL,
  `Service` varchar(255) DEFAULT NULL,
  `Appointment` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ClientId`)
);

CREATE TABLE `stylists` (
  `StylistId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(225) DEFAULT NULL,
  `ServicesOffered` varchar(225) DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
);
```

## Specifications

User is greeted with a splash Welcome page. 

| Behavior   |   Input   |  Output | 
|----------|:-------------:|------:|
| User clicks on `Stylists from navigation bar`| n/a | User is presented with a list of current stylists (if there is any). If there is no Stylists, the page will display "No stylists added yet". The user will also have the option to ADD a Stylist
| User clicks on available Stylist Name | Click: 'Luna' | Stylist Details will appear: Name, Services Offered, Clients. User will have the option to: Edit Stylist, Delete Stylist

## Known Bugs

N/A

## Support and contact details

_Please feel free to contact the author through GitHub **[christinereina](https://github.com/christinereina)** with any feedback, questions or concerns._


## Technologies Used

* C# 
* .NET-Core 2.2
* ASP.NET Core MVC
* MySQL
* Entity Framework Core
* Visual Studio Code
* Git Version Control 
* GitHub

### Special Thanks

This web application was highly inspired by Beyonce's film, ['Black is King'](https://beyonce.com/) and uses different images from her film. Also, this application was stylistically inspired by [Saint Heron](https://www.saintheron.com/).

### License

*This site is licensed under the MIT license.*

Copyright (c) 2020 **Christine Augustine**
