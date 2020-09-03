#VidlyVideoForVS2019
The first version of this application was written as part of completing "The Complete ASP.Net MVC Course" taught by Mosh Hamedani.  The application herein is prepared using Visual Studio 2019, Microsoft ASP.Net 2.2.2 and Entity Framework 6.2.0.  Front end technologies include Bootsrap, JavaScript, and jQuery.  Beyond the course materials, conntent and site functionality has been significantly expanded as described below.  

Additional information about the application:

1.  The application allows the user to register, search for movies, and secure movies for rental.  

2.  The application is written in ASP.NET MVC framework.  

3.  The Entity Framework is used for code-first data migrations.  

4.  The application was orignally written as a back-end solution for a video store with support for inventory tracking and customere management.  

5.  The applicaiton now provides a comprehensive framework for a video streaming company; administrators, employees, and customers.  

6.  Whether customer, employee, or administrator, when a user is validated their rights are confirmed and priveledges allowed as follows. 

7.  Customers can browse movies and choose "Watch Movie" option on any movie in the collection.  

8.  Employees can watch movies, assist in managing customer accounts, and add new customers.  However, with respect to customer accounts, only administrators can edit or delete a customer accoupnt.  

9.  In additions to rights of customers and employees, administrators can delete or edit customer accounts in addition to addding, deleting or editing movies in the collection.  

10. Validations of form input provided at all levels is performed using jQuery validate in coordination with data annotations in the Model classes.  

11. Views are modified using JavaScript and jQuery once a user has registered.  

12.  Screen shots have been include in a '/ScreenShots' folder in the root directory.  

13.  The images and content added to the application are either expressly intended for public use or distributed free of restriction on reuse.  

14.  A barebones RESTful Web API was developed with the application and can be found in the Controllers portion of the application.  

15.  This appliction would be best run as a Visual Studio 2019 solution using the following usernames and passwords: 

     Username:  admin@vidly.com     Password: Employee#1
	 Username:  employee@vidly.com  Password: Employee#2
	 Username:  customer@vidly.com  Password: Customer#1

"The Complete ASP.Net MVC Course" by Mosh Hamedani is available at https://www.udemy.com/course/the-complete-aspnet-mvc-5-course 
