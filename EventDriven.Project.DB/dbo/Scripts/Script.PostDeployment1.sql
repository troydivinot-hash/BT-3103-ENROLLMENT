/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.
--------------------------------------------------------------------------------------
*/


-- Insert records into User table
INSERT INTO [dbo].[User]
(
[Username], 
[Password])
VALUES('admin','admin')


-- Insert records into Client table
INSERT INTO [dbo].[Client] (Firstname, Lastname, MobileNumber, Gender, Address, Birthdate)
VALUES 
('John', 'Doe', '123-456-7890', 'Male', '123 Main St, Springfield', '1985-03-25'),
('Jane', 'Smith', '234-567-8901', 'Female', '456 Elm St, Shelbyville', '1990-07-12'),
('Michael', 'Johnson', '345-678-9012', 'Male', '789 Oak St, Capital City', '1978-11-05'),
('Emily', 'Davis', '456-789-0123', 'Female', '101 Pine St, Ogdenville', '2000-01-15'),
('David', 'Wilson', '567-890-1234', 'Male', '202 Birch St, North Haverbrook', '1995-06-20'),
('Sarah', 'Brown', '678-901-2345', 'Female', '303 Maple St, Springfield', '1982-02-10'),
('Robert', 'Taylor', '789-012-3456', 'Male', '404 Cedar St, Shelbyville', '1988-09-15'),
('Linda', 'Martinez', '890-123-4567', 'Female', '505 Walnut St, Capital City', '1992-04-30'),
('James', 'Anderson', '901-234-5678', 'Male', '606 Ash St, Ogdenville', '1980-12-01'),
('Patricia', 'Thomas', '012-345-6789', 'Female', '707 Fir St, North Haverbrook', '1975-07-18');

-- Insert records into Account table
INSERT INTO [dbo].[Account] (ClientId, Balance, ModifiedDate)
VALUES 
(1, 1000.00, GETDATE()),
(2, 2500.50, GETDATE()),
(3, 500.75, GETDATE()),
(4, 3000.00, GETDATE()),
(5, 750.25, GETDATE()),
(6, 1200.00, GETDATE()),
(7, 2000.00, GETDATE()),
(8, 1800.75, GETDATE()),
(9, 150.00, GETDATE()),
(10, 5000.00, GETDATE());


