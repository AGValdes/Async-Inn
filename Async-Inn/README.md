# Async-Inn
Author: Ameilia Valdes, 1/25/2021

## Overview
This application is a RESTful API server that will manage the assets in hotels. It has the ability to modify and manage rooms, amenities, and new hotel locations as they are built. 

## Entity Relationships
![ERD Image](assets/Async_Inn_Erd.png)

1. The Location table will hold each hotel location. It has collumns for primary key, name, city, state, address, phone number and number of rooms for each location. It has a one to many relationship with the Room table, because one location can have many rooms.
2. The LocationRoom table is a join table with a payload that is the price of each room. It uses the Location ID and Room ID as foreign keys and has a third collumn that is the price. 
3. The Room table has a primary room id, and collumns for the room number, a pet friendly bool, and an enumerable nickname of the room. This table is joined to the LAyout by Nickname table using the room layout table.
4. The Layout by Nickname talbe has a primary key, and collums for the room Id, brought in as a foreign key, a collumn for ammenities, how many bedrooms it has, and the actual nickname. This table is joined to the room table with the RoomLayout table. This table has a many to many relationship with rooms, because many rooms can have a variety of nicknames.
5. The RoomLayout table joins the room and layout tables using their primary ID keys as composite keys. This will assure that the room has the data it needs from it's nickname(ammenities, number of bedrooms), which will be used later for determining the price of the room.



## Identity

Identity is a microdoft framework that allows for user authentication. It provides a means for storing user login information and provides built in methods for registering and logging in a user. 

## Implementation of Identity
First, we create an ApplicationUser class, which inherits from the built-in class IdentityUser. We then added it to our database context, and migrated those changes so that our ApplicaitonUser table would be added to our database and store the user's identity. We then registered the Identity service in our StartUp file, in our ConfigureServices method. We also added a new IdentityUSerService, which implements the interface IUserService, which contains methods for registering and logging in a user. These services are called in the AccountController attached to corresponding post routes, using both inbound and outbound DTO's to refine inputs and data outputs. The request bodies and responses of each request are illustrated below:
### Requests for /api/Users/Register Post Route:
![Image of a Good Register Request](./assets/Register.RequestBody.png)
![Image of a Bad  Register Request](./assets/Register.Request.Bad.png)
### Responses for Register Post Requests:
![Image of Response after Good Request](./assets/Register.Response.png)
![Image of Response after a Bad Request](./assets/Register.Response.Bad.png)
### Requests for /api/Users/Login Post Route:
![Image of a Good Login Request](./assets/Login.Request.Body.Auth.png)
![Image of a Bad Login Request](./assets/Login.Request.Body.UnAuth.png)
## Responses for Login Post Request
![Image of Response after a Good Request](./assets/Login.Response.Auth.png)
![Image of a Response after a Bad Request](./assets/Login.Response.UnAuth.png)

## Getting Started 
This Api is deployed on Azure at: (Link to Deployed API)[https://async-inn.azurewebsites.net/index.html]

## Change Log

1/26/2021

Today we wired up our database, models and controllers.

1/27/2021

Today we refactored so that we are accessing our database using interfaces instead of directly in each controller. We added repository classes that use these interfaces to handle the CRUD interaction with our database, whereas before our controllers were handling them directly. We injected these repository dependancies to our app to change the way handle data flow in and out of our database.

2/2/2021
Below is a link to the deployed API, where you can view documentation of all routes.
(Link to Deployed API)[https://async-inn.azurewebsites.net/index.html]



