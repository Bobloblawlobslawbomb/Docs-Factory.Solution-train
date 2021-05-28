# Claires Stylist/Client Tracker

#### A Brief Description.
_Un outil pour Madame Claire pour voir les clients de chacun de ses stylistes._

An MVC 'one-to-many' example project that allows Claire to track her stylists and their clients. 

### By Giancarlo Vigneri
---
## Technologies Used

>* _VS Code_
>* _Html_
>* _CSS_
>* _C#_
>* _.NET 5 SDK_
>* _ASP.NET_
>* _Bootstrap_

---
## Description 
The program will allow someone named Claire who owns a salon to see a list of their stylists and their specialities as well as a list of clients associated with said stylist. Claires can also add/delete new/old stylists. Clients also have similar functionality as well as being associated with a particular stylist. 

---

## Installation Requirements/Setup

### Requirements:

- [MySQL Community Server](https://dev.mysql.com/downloads/file/?id=484914)
- [MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391)
- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VS Code](https://code.visualstudio.com/)
- A command line interface like Terminal or [GitBash](https://gitforwindows.org/) to run and interact with the console app.

### Further Setup:

> To setup the MySQL database:
>* Carefully follow [these steps from LearnHowToProgram.com](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) to install both __MySQL Server 8.0.19__ and __MySQL Workbench__.
>* Ensure the MySQL server is running by opening Terminal or Windows Powershell and entering the command `mysql -uroot -pepicodus`
>* If you set up MySQL Server with a different username and/or password, the command will be `mysql -u[YourUsername] -p[YourPassword]` (omit the square brackets'[ ]')

#### Importing `giancarlo_vigneri.sql` _(the included database .sql file)_:
> (note: these instructions are only applicable after one has cloned the git repository: "https://github.com/Bobloblawlobslawbomb/HairSalon.Solution" -- see 'Running the Program' instructions below)
> 1) Open __MySQL Workbench__.
> 2) In the Navigator > Administration window, select Data Import/Restore.
> 3) In Import Options select Import from Self-Contained File.
> 4) Navigate to `giancarlo_vigneri.sql`.
> 5) Under Default Schema to be Imported To, select the New button.
> 6) Enter the name of the database.
>    - In this case: `hair_salon`.
> 7) Click Ok.
> 8) Click Start Import.
> 9) Reopen the Navigator > Schemas tab. Right click and select Refresh All. _Our new test database will appear._

### Running the Program:
> 1) Clone the repository: "https://github.com/Bobloblawlobslawbomb/HairSalon.Solution"
> 2) Navigate to the 'HairSalon.Solution/' directory on your computer
> 3) Open with your favorite text editor (Visual Studio Code, is a pretty sweet one)
> 4) To run the web app:
>   - Navigate to `HairSalon.Solution/HairSalon` in your command line
>   - Run the command `touch appsettings.json`
    - open the newly created "appsettings.json" file
    - add the following code to the .json file:
>   ```
>   {
>       "ConnectionStrings": {
>       "DefaultConnection": "Server=localhost;Port=3306;database=>> hair_salon;uid=[YOUR USERNAME];pwd=[YOUR PASSWORD];"
>       }
>    }
>    ```
   >*_NOTE: make sure that [YOUR USERNAME] and [YOUR PASSWORD] match the database username and password of your local MySQL server (omit the square brackets. Also note: port 3306 is the default)_
> - Run the command `dotnet restore` to restore the dependencies that are listed in `HairSalon.csproj`
>  - Run the command `dotnet build` to build the project and its dependencies into a set of binaries.
> - Finally, run the command `dotnet run` to run the project!
> - Note: `dotnet run` also restores and builds the project, so you can use this single command to start the console app.

## Known Bugs

* _Background image does not display via css styling_

#### Background Image
> Photo by: [Guilherme Petri](https://images.unsplash.com/photo-1521590832167-7bcbfaa6381f?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1050&q=80)
> Via: [Unsplash](https://unsplash.com/)
---

## License [GPL] (https://choosealicense.com/licenses/gpl-3.0/)
_if you do run into any issues or have questions, ideas, or concerns; I would greatly encourage you to send feedback or make a contribution to the code_

---

## Contact Information
_Contact Giancarlo Vigneri at: bobloblaw.vigneri@gmail.com_ 

(What do you call a good hair stylist? A shear delight.)