# ToDo List Backend API Project


## Project Description
This Project is a full stack web side project that developed for todo list transactions.Developed by using Layered Architecture and repository design pattern. 


## Techs
- **Backend:** ASP.NET Core, C#, Entity Framework
- **Frontend:** HTML, CSS, JS, Bootstrap
- **Database:** SQL Server
- **API:** RESTful API

## Project Architecture

- **Layers:**
  - **Presentation Layer (UI)**
  - **API**
  - **Entity Layer** 
  - **Business Logic Layer (BLL)** 
  - **Data Access Layer (DAL)**


## Setup Directions

### Requirements:
- .NET SDK
-  NPM
- SQL Server

### Steps:
1. Clone the repository:
   ```bash
   git clone https://github.com/aeren23/ASP.net-Core-Web-TodoList-Project
   ```

2. Run Backend:
   ```bash
   cd backend
   dotnet restore
   dotnet run
   ```

3. Run Frontend:
   ```bash
   cd frontend
   npm install
   npm start
   ```

## 7. **API Documentation**
API Documentation

```markdown
## API Documentation

### Endpoints:
- **GET** /api/Task
  - Description: Gets Tasks.
  - Example Response:
    ```json
     [
      {
        "id": 9,
        "content": "Do Something",
        "date": "2024-06-30T00:00:00"
      }
    ]
    ```

     

