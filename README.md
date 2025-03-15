# Q3-Technology

# Employee Management API Documentation

## Project Overview
The **Employee Management API** is a RESTful web service built with .NET 8, Entity Framework Core, and SQL Server. This API provides CRUD (Create, Read, Update, Delete) functionality for managing employee records.

## Features
✅ CRUD operations for employee management  
✅ Database integration using Entity Framework Core  
✅ Swagger documentation for easy API testing  
✅ Follows RESTful API design principles

---

## Prerequisites
Before running the project, ensure you have the following installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio Code (or Visual Studio 2022)
- SQL Server (Express or Full Edition)
- Postman or Thunder Client (for API testing)

---

## Installation Steps
### 1. Clone the Repository
```bash
git clone https://github.com/callmeprinceyadav/Q3-Technology
cd EmployeeManagementAPI
```

### 2. Install Dependencies
```bash
dotnet restore
```

### 3. Configure Database Connection
Update the **`appsettings.json`** file with your SQL Server connection string:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=EmployeeDB;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```

### 4. Run Database Migration
```bash
dotnet ef migrations add InitialCreate
```

Apply the migration to create the database:
```bash
dotnet ef database update
```

### 5. Run the Application
```bash
dotnet run
```

After running the command, you should see a URL similar to this:
```
https://localhost:5001/swagger/index.html
```

---

## API Endpoints

### 1. **Get All Employees**
**GET** `/api/employees`

### 2. **Get Employee by ID**
**GET** `/api/employees/{id}`

### 3. **Add New Employee**
**POST** `/api/employees`
**Body Example:**
```json
{
  "firstName": "John",
  "lastName": "Doe",
  "email": "john.doe@example.com",
  "dateOfBirth": "1990-05-15",
  "position": "Software Engineer",
  "salary": 75000
}
```

### 4. **Update Employee**
**PUT** `/api/employees/{id}`

### 5. **Delete Employee**
**DELETE** `/api/employees/{id}`

---

## Testing with Postman / Thunder Client
1. Open **Postman** or **Thunder Client**.
2. Use the provided API endpoints for CRUD operations.
3. For POST and PUT requests, provide the appropriate JSON body format.

---

## Common Issues and Solutions
❗ **Error: Database not found**
- Ensure the connection string in `appsettings.json` points to the correct server and database.

❗ **Error: Entity Framework commands not working**
- Run this command to install EF Core tools:
```bash
dotnet tool install --global dotnet-ef
```

❗ **Error: Port already in use**
- Change the port number in the `launchSettings.json` file if there's a conflict.

---

## Future Enhancements
✅ Implement JWT Authentication for secure API access  
✅ Add pagination for employee data  
✅ Improve error handling with proper HTTP status codes  

---

## Contact
For support or questions, please contact [pkryadav9304@gmail.com].

