# Async_Inn

## Name:- Haneen alhamdan
## Date:- 4/14/2022


## ERD

![Screenshot (230)](https://user-images.githubusercontent.com/98957434/163301056-4a759f4c-7364-49a0-8c92-03d212989b5b.png)


## Explanation ERD

### There are 6 tables : -

* Hotel 
Rela :- one-to many with Hotel room
hotel-id (primary key), name, city, state, address

* Hotel room
Rela :- one-to many with Layout-room
hotel room-id (primary key), hotel-id (foreign keys) ,nickname ,room-number ,price, room layout, location

* Room
Rela :- one-to many with Hotel Layout-room
 room-id (primary key),Seahawks Snooze, Restful Rainier, pet friendly
 
* Layout-room
Rela :- many-to-one with room
Rela :- one-to many Room-amenities
layout room-id (primary key), one bedroom, two bedroom, studio

* Room-amenities
Room-amenities(primary key), air conditioning, coffee maker, ocean view, mini bar

* Amenities
 Rela :- one-to many Room-amenities
amenities-id (primary key), room-id (foreign keys), Room-amenities-id (composite key)
 
 *******************************************************************************************
 *******************************************************************************************
 
 Using Dependency Injection, I refactored my Hotels, Rooms, HotelsRooms and Amenities Controllers to depend on an interface rather than the DbContext.

Built an interface for each of the controllers that contain the required method signatures to all for CRUD operations to the database directly.

Updated each of the controllers to inject the interface rather than the DBContext.

Created a service for each of the controllers that implement the appropriate interface. Built out the logic to satisfy the interface by making the appropriate calls to the db for each action.

Updated me Controller to use the appropriate method from the interface rather than the DBContext directly.


********************************************************************************************
********************************************************************************************
 
 ## Endpoints
 
 ### Amenity
 * GET: api/Amenities
 * GET: api/Amenities/{id}
 * PUT: api/Amenities/{id}	
 * POST: api/Amenities	
 * DELETE: api/Amenities/{id}

### HotelRooms
* GET: api/HotelRooms
* GET: api/HotelRooms/{hotelId}/Rooms/{roomNumber}
* PUT: api/HotelRooms/{hotelId}/Rooms/{roomNumber}
* POST: api/HotelRooms/{hotelId}/Rooms	to add a room to a hotel
* DELETE: api/HotelRooms/{hotelId}/Rooms/{roomNumber}

### Hotel
* GET: api/Hotels	
* GET: api/Hotels/{id}	
* PUT: api/Hotels/{id}	
* POST: api/Hotels	
* DELETE: api/Hotels/{id}

### Room
* GET: api/Rooms	
* GET: api/Rooms/{id}	
* PUT: api/Rooms/{id}	
* POST: api/Rooms	
* POST: api/Rooms/{roomId}/Amenity/{amenityId}	
* DELETE: api/Rooms/{id}	
* DELETE: api/Rooms/{roomId}/Amenity/{amenityId}
