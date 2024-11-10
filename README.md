**User CDN Web API**
This project is a .NET Core Web API for managing user information. It provides endpoints to perform CRUD operations (Create, Read, Update, Delete) on user data. This project uses Dapper as the ORM for database access, with SQL Server as the database.

Table of Contents
**Features**
**Technologies**
**Setup**
**Database Setup**
**API Endpoints**
**Project Structure**
**Contributing**
**License**

**Features**
RESTful API: Offers CRUD operations for user management.
Dapper ORM: Provides high-performance database operations.
Modular Architecture: Uses services for clean separation of business logic.
Configurable Database Connection: Easy to modify connection settings.
API Documentation: Explore API endpoints using Swagger.

**Technologies**
.NET 6 (or later)
Dapper: Lightweight ORM for data access
SQL Server: Relational Database
Swagger: Integrated API documentation

**Setup**
Prerequisites
.NET 6 SDK
SQL Server (or an equivalent RDBMS)
Postman (for API testing, optional)
  Installation:
  1. Clone the repository:
     - "git clone https://github.com/yourusername/UserManagementAPI.git"
        "cd UserManagementAPI"
  2. Install dependencies:
     - dotnet restore
  3. Set up your connection string:
     - Open appsettings.json.
     - Update the connection string in the ConnectionStrings section:
       - "ConnectionStrings": {"DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=UserManagementDB;Trusted_Connection=True;"}"
  4. Run the application:
     - "dotnet run"
  5. Access Swagger:
     - Open your browser and go to http://localhost:5000/swagger to view the API documentation.
       
**Database Setup**
  1. Open SQL Server Management Studio or your preferred SQL client.
  2. Run the following SQL script to create the Users table:
     - "CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Email NVARCHAR(50),
    PhoneNumber NVARCHAR(15),
    Skillsets NVARCHAR(100),
    Hobby NVARCHAR(100));"

**API Endpoints**
  Base URL: "http://localhost:5000/api/users"
  Endpoints:
    
  Method	Endpoint	        Description	                    Request Body
  GET	    /api/users	      Get all users	                  -
  GET	    /api/users/{id}	  Get a user by ID	              -
  POST	  /api/users	      Create a new user	              { "Username": "", "Email": "", ...}
  PUT	    /api/users/{id}	  Update an existing user by ID	  { "Username": "", "Email": "", ...}
  DELETE	/api/users/{id}	  Delete a user by ID	            -
  
**Project Structure**
  User CDN Web API/
    ├── Controllers/
    │   └── UsersController.cs           # API Controller
    ├── Data/
    │   └── DapperContext.cs             # Database connection setup for Dapper
    ├── Models/
    │   └── User.cs                      # User model
    ├── Services/
    │   ├── IUserService.cs              # Service interface
    │   └── UserService.cs               # Service for CRUD operations
    ├── appsettings.json                 # Configuration settings
    ├── Program.cs                       # Application startup
    └── README.md                        # Project documentation

**Contributing**
  1. Fork the repository.
  2. Create a new branch with your feature: git checkout -b feature-name
  3. Commit your changes: git commit -m "Add feature"
  4. Push to the branch: git push origin feature-name
  5. Open a Pull Request.

**License**
  This project is open-source and available under the MIT License.
