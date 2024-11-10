CREATE DATABASE CDNUsersDB;
USE CDNUsersDB;
-- Create Users Table
    CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Email NVARCHAR(50),
    PhoneNumber NVARCHAR(15),
    Skillsets NVARCHAR(100),
    Hobby NVARCHAR(100)
);

