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
---------------------------------------------------------------------------------------------------------------------------------------
2022-11-20 At 12:48PM started with the second part of the project
modified the database name
added migration to default project EdaMonicaBookStore.Access
name of the migration: 20221120174744_AddDefaultIdentityMigration.cs
updated migration and I am getting an error
Error Number:2714,State:6,Class:16
There is already an object named 'AspNetRoles' in the database.
--------------------------------------------------------------------------------------------------------------------
2022-11-23,5:00 PMstarted working on the project
not succeeded. lot of errors
7:00Pm closing
---------------------------------------------------------------------------------------------------------------
2022-11-24 At 10:30 AM started working I repository added comments
hope it goes well
-------------------------------------------------------------------------------------------------------------------
2022-11-25 at 9:00 started, created IUnitOfWork.s, UnitOfWork.cs and I repository files and content added
Fixed Errors, this took a while
I am proceeding
In_Layout.cshtml <a class="nav-link text-dark" asp-area="Admin" asp-controller="Category" asp-action="Index">Category</a> ,this change is made and ran the application to see the change
-------------------------------------------------------------------------------------------------------------------------
2022-11-27 1:30PM
Created in Views>Shared created _CreaeAndBackToListButton.cshtml
Created in Views>Shared created _EditAndBackToListButton.cshtml
Upsertt.html is modified
asp-action="Upsert" is added to index.cshtml and applications is run
I don't see the desired output
@section Scripts code added
Update POST added but I donot know if i have done this correctly
I have 2 errors.
2022-11-27 At 4:19PM, I have finished the assignment part-2 with 2 errors. 
changes pushed to git hub
----------------------------------------------------------------------------------------------------------------------------
2022-11-27   9:00PM started with Assignment part-3
To Models folder added CoverType.cs
 folders for Repository and IRepository  are created
 Hope I am going in the right direction
 CoverType Repository Class and Irepository Interface are completed 
 I am committing changes to github
 ---------------------------------------------------------------------------------------------------------------------------------------
 2022-11-28 12:10 I think I have finished 3.1 of Assignment2
 Migration for CoverType is added 20221128180818_AddCoverTypeToDb
 --------------------------------------------------------------------------------------------------------------------------------------------
 2022-11-29 1:30 started working on the project
 Assignment-3 part-1 Worked on CoverType.controller.cs and Prodcts 
 Migration for product is installend in package Managet Console
 While installing migrations i committed couple of mistakes one in the "selection of Default project" and the secondone, using wrong migration command
 Errors fixed and migration is done
 Migration for product is: 20221129201210_AddProductTODb.cs,Databse updated.
 pushing the changes to Github
 Now the time is 3:20PM. on 11/29/2022
---------------------------------------------------------------------------------------------------------------------------------------------
AT 4:23 on !1/29/2022
 Migration added to validation 
 The Migration for validation is 20221129203207_AddValidationToProduct.cs
 IProductRepository Interface and ProductRepository are created and  ProductRepository updated
 updated
 -----------------------------------------------------------------------------------------------------------------------------------
 2022-12-04 At 2:30 PM started with the Assignment-2 Part-3, Section-2, 

 In Areas, Adminc Controller, ProductController.cs is created and content is filled in
 In ViewModel in the project folder ProductVM.cs is created 
 Microsoft.AspNetCoreMvc.ViewFeatures package is installed
 In ProductController.cs, API calls are modified to include the Catefory and CoverType properties
 I have some errors both in ProductVM.cs and ProductController.cs these are to be fixed.
 I am in the same place where I have started, I am not able to proceed because there is some build in error 
 I am thinking of closing because I have no outcome at all
 2022-12-04, Now the time is 9:19PM
 -----------------------------------------------------------------------------------------------------------------------------------------
 2022-11-05 10:00PM started working with the Assignment-2 Section-2,
 I had many errors and I tried and fixed them
 created ProductVM.cs once again and data updated in productController.cs 
 and I ahve an error still
 ------------------------------------------------------------------------------------------------------------------------------------
 AT 1:08PM 2022-12-05
 Created CoverType folder and added Index.cshtml and Upsert.html
 In www.root, product.js, and cover.js are added 
 tested the app

