# Async_Inn
# Async-Inn

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
 
