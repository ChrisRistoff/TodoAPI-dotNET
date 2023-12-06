\c real_estate_db

DELETE FROM areas;

INSERT INTO areas (name, description, schools, shops, kindergardens) VALUES
('Greenfield', 'A peaceful and family-friendly area.', 'Greenfield Primary, Riverside High', 'Greenfield Mall, Local Market', 'Sunny Days Kindergarten, Little Steps'),
('Lakeside', 'Beautiful views and vibrant community.', 'Lakeside School, Mountain View High', 'Lakeside Shopping Center, Organic Foods Market', 'Happy Tots, Kids Adventure Kindergarten'),
('Downtown', 'Busy and bustling city life.', 'City School, Central High', 'Downtown Plaza, 24/7 Supermarket', 'Urban Kids, Future Leaders Kindergarten');

DELETE FROM houses;

INSERT INTO houses (areaId, postedOn, description, price, address, postcode, sqrFeet, rooms, bathrooms, parkingSpaces, furnished) VALUES
(1, '2023-01-01', 'Cozy family home with a large backyard.', 250000, '123 Maple Street', '12345', 2000, 3, 2, 1, 0),
(1, '2023-01-15', 'Modern home near the park.', 300000, '456 Oak Avenue', '12345', 2500, 4, 3, 2, 1),
(2, '2023-02-01', 'Lakeside apartment with stunning views.', 350000, '789 Lake Road', '23456', 1500, 2, 2, 1, 1),
(3, '2023-02-20', 'Downtown apartment, perfect for city living.', 400000, '101 Main Street', '34567', 1000, 1, 1, 0, 1);
