# (Project Name)

#### (Week Name) Independent Project for Epicodus, 00/00/2016

#### By Shradha Pulla

## Description

Longer succinct description of program.

## Setup/Installation Requirements

This program can only be accessed on a PC with Windows 10, and with Git, Atom, and Sql Server Management Studio (SSMS) installed.

* Clone this repository
* Import the database and test database:
  * Open SSMS
  * Select the following buttons from the top nav bar to open the database scripts file: File>Open>File>"Desktop\RepositoryName\Sql Databases\database_name.sql"
  * Save the database_name.sql file
  * To create the database: click the "!Execute" button on the top nav bar
  * To create the database another way, type the following into the top of the sql file:
    * CREATE DATABASE database_name;
    * GO
  * Refresh SSMS
  * Repeat the above steps to import the test database
* Test the program:
  * Type the following command into PowerShell > dnu restore
  * Next type > dnx test
  * All tests should be passing, if not run dnx test again. Otherwise, fix the errors before launching the program on the browser.
* View the web page:
  * Type following command into PowerShell > dnx kestrel
  * Open Chrome and type in the following address: localhost:5004

## Database Creation Instructions

To build the databases from scratch, type the commands below in the Windows PowerShell:
  * Desktop> SQLCMD -S "Server-Name";
    * 1> CREATE DATABASE database_name;
    * GO
    * USE database_name;
    * GO
  * Exit out of SQLCMD by typing> QUIT
  * Open SSMS, click open Databases folder and check that the database_name database has been created
  * Click "New Query" button on top nav bar (above "!Execute")
  * Type following command into query text space to backup database: BACKUP DATABASE database_name TO DISK = 'C:\Users\[Account-Name]\database_name.bak'
  * Click "!Execute"
  * Right click database_name in the Databases folder: Tasks>Restore>Database
  * Confirm that there is a database to restore in the "Backup sets to restore" option field
  * Under the "Destination" input form, change the database name to: "database_name_test"
  * Click "OK", refresh SSMS, and view the new test database in the Database folder

If SQL is not connected in the PowerShell, open SSMS and click the "New Query" button (in nav bar above "!Execute"). Type commands shown above into the text space, starting from "CREATE DATABASE...".

## Known Bugs

No known bugs.

## Specifications

The program should... | Example Input | Example Output
----- | ----- | -----
--- | --- | ---

## Future Features

HTML | CSS | C#
----- | ----- | -----
--- | --- | ---

## Support and Contact Details

Contact Epicodus for support in running this program.

## Technologies Used

* HTML
* CSS
* Bootstrap
* C#

## Links

Git Hub Repository: https://github.com/pullashradha/

## License

*This software is licensed under the Microsoft ASP.NET license.*

Copyright (c) 2016 Shradha Pulla
