# Async-Inn
Author: Ameilia Valdes, 1/25/2021
![ERD Image]()

1. The Location table will hold each hotel location. It has collumns for primary key, name, city, state, address, phone number and number of rooms for each location. It has a one to many relationship with the Room table, because one location can have many rooms.
2. The LocationRoom table is a join table with a payload that is the price of each room. It uses the Location ID and Room ID as foreign keys and has a third collumn that is the price. 
3. The Room table has a primary room id, and collumns for the room number, a pet friendly bool, and an enumerable nickname of the room. This table is joined to the LAyout by Nickname table using the room layout table.
4. The Layout by Nickname talbe has a primary key, and collums for the room Id, brought in as a foreign key, a collumn for ammenities, how many bedrooms it has, and the actual nickname. This table is joined to the room table with the RoomLayout table. This table has a many to many relationship with rooms, because many rooms can have a variety of nicknames.
5. The RoomLayout table joins the room and layout tables using their primary ID keys as composite keys. This will assure that the room has the data it needs from it's nickname(ammenities, number of bedrooms), which will be used later for determining the price of the room.

1/26/2021

Today we wired up our database, models and controllers.

1/27/2021

Today we refactored so that we are accessing our database using interfaces instead of directly in each controller. We added repository classes that use these interfaces to handle the CRUD interaction with our database, whereas before our controllers were handling them directly. We injected these repository dependancies to our app to change the way handle data flow in and out of our database.