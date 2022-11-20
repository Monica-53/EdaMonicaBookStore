2022-10-21 1243
Built the initial default application
prepend my name - 'MonicaBookStore'
Individual Account Authentication
Added Razor runtime - just for fun! ;
Hit create and then reviewed the default app.
1246
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Second attempt started from scratch 
2022-11-10 11:30a.m
Created a newproject and named MonicarBookStore
Indicvidual Account Authentication
Added Razor runtime
Hit Create and then reviewed the default
in launchSettings.json comment sslport
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
2022-11-11:45am
_viewsStzrt.cshtml,migrations are checked following the instructions
in startup.cs options=>options.SignIn.RequireConfirmedAccount=true is removed
create a gitrepository with Repository Name Monicar and make it public
Go to Bootswatch.com
Goto wwwroor and replace the existing bootstrap.css this is done following lib>bootstrap>dist>css these steps
replace the existing site.css file found in the main css folder
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------A
add stylesheets and scripts to _Layout.cshtml from CSS_JS.txt file
To the Navbar a drop down is added.
drop down is working
-------------------------------------------------------------------------------------------------------------------------------------------
2022-11-10 Add and modify 
Three projects are added and named as MonicarBook.DataAccess,MonicarBooksModels, MonicaBooksUtility
Installed required Nuget packages in MonicarDataAccess
Migrations folder deleted
name space is modified, At this point I have errors
Deleted class1.cs from all the folders
I could not build the project because of errors
I continued with the remaining steps inspite of errors 
Added required references
Changed ErrorViewModels.cs to .Models.ViewModels
tried rebuikding the project but could not run it due to errors
I am clsoing at this point
It is 2:00 PM
--------------------------------------------------------------------------------------------------------------------------------------
2022-11-11 12:15PM
I tried fixing the errors occured the daybefore
I could fix the errors and proceeded with the remaining steps
In the utility project a class SD.cs created
project reference to the main project added
In the DataAccess project project references to Models and utility are added
1:00PM Add a "Customers" area to areas is done
HomeController.cs moved to the Area>Customer>Controllerfolder and Data and Models are deleted in controller folder
namespace is modified in HomeController
Ran the application 
It does not give me the desired output 
--------------------------------------------------------------------------------------------------------------------------------------------
Since my project which I created did niot give me the output
3rd attempt
2022-11-11 at 10:50PM
created a new project named MonicBookStore
checked startup.cs and option=>statement followed by it are removed
10:59PM creating a Git Repository
Git Repository created and pushed.
------------------------------------------------------------------------------------------------------------------------------
11:04PM started with 1.1 Review
views/shared/_Layout.cshtml in footer a small change is made
Remaining files are checked in views/shared
11:12 Debugging 1.2 started
--------------------------------------------------------------------------------------------------------------------------------
11:30PM Bootswatch.com
downloaded united theme and replaced the originalbootstrap.css in wwwroot with downloaded version 
existing site.css is replaced with the code given
I have warnings after site.css code is replaced
view/Shared>_Layout.cshtml the file name is changed from min.css to bootstrap.css
Additional properties added in the footer
I relaxed for sometime
---------------------------------------------------------------------------------------------------------------------------------
12:00AM 2022-11-12 continued with the project
Hope I get it correctly this time
_LoginPartial.cshtml removed references to text-dark
Ran project to see the changes
_Layout.cshtml additional stylesheets and scripts are added from the CSS_Js.txtfile
A dropdown added to the NavBardropdown changed to the Content Management
Ran the application to check if the dropdown is working
so far so good
12:54 AM Committed the changes 
-------------------------------------------------------------------------------------------------------------------------------------------
2022-11-12 2:30PM I switched back with the project created second time and decided to continue with it because my third attempt project was not giving output correctly
I started with the second part of the project I rebuild the solution it did not give me any 
In package Manager Console add-migration AddDefaultIdentitypeMigration choosingMonicarBooks.DataAccess
I have an error saying "Exception has been thrown by the target of an invocation." how to fix this?

MissingMethodException: Method not found: 'Boolean Microsoft.EntityFrameworkCore.Migrations.IMigrationsModelDiffer.HasDifferences(Microsoft.EntityFrameworkCore.Metadata.IModel, Microsoft.EntityFrameworkCore.Metadata.IModel)'.
Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore.DatabaseErrorPageMiddleware.Invoke(HttpContext httpContext)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
2022-11-18 At 1:27 I think i have finished part-1 and committed the changes
-------------------------------------------------------------------------------------------------------------------------------2022-11-18 3:43
2022-11-18 3:44PM started with the second part
packagemanager console add-migration AdddefaultIdentityMigration
20221118150935_AddDefaultIdentityMigration.cs
updated databse
checked for errors
i follwed all steps almost finished part-1
everything working well. not to get errors i rechecked step by step and noticed my database name entered wrongly so uninstalled all steps.
-----------------------------------------------------------------------------------------------------------------------------------------
2022-11-20 10:00AM
Restarted assignment-2 and rebuild the solution but i have errors because i didi not remove categories which i entered in AddDncontext.cs, i correctted and
rebuilt the solution and everything seems okay.
changed Database name and installed migration
