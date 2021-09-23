# Conference Rooms Management Application - .NET C# Project
## Windows Forms Application with C#

## Project Overview
This project is a conference rooms booking application.  
Users can sign up an account and log in to use the application.
It includes creating a new booking, altering an existing booking, deleting a booking, and searching/viewing booking record.  

If without login, users can only creating a new booking, and searching/viewing booking record.  

## The App Structures
The program will be made up off three forms. 

### First form - Main Form
It includes below functions:
1. Creating an account
2. Logging in an account
3. If without login, users can enter required information. Then they will be directed to the **create booking form**.
4. If with login, users will be directed to the **alter booking form**.
 
### Second form - Create Booking Form
This form includes greeting to the user, and Date, Time, Conference Rooms fields for the user to choose.  
There is a table to show the availability of each room based on the day and time picked by the user. It is **dynamic** changing.  
Users will not be able to select a room that is unavailable.

### Third form - Alter Booking Form
It includes below functions:
1. Search booking record by entering name or email
2. A booking information table to show the bookig record list
3. Edit an existing record by selecting a record from the Booking Information table
4. Cancel an existing booking record by entering the booking ID
5. The booking information list will be updated accordingly after altering or deleting booking.

**Notice: Users can only edit or delete their own record. It is not allowed to alter other users record.**. 
