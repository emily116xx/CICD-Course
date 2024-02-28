USE TravelManager;
GO
CREATE TABLE Users (
    UserID INT PRIMARY KEY,
    UserName NVARCHAR(50),
    Email NVARCHAR(100),
    Password NVARCHAR(50)
);
-- Drop the Email column from the Users table
ALTER TABLE Users
DROP COLUMN Email;
