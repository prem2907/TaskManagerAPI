# 🧠 Task Manager API (.NET 6)

## 📌 Project Overview
This is a simple **Task Management Web API** built using **ASP.NET Core (.NET 6)** and **Entity Framework Core**. It supports full CRUD operations on tasks, stores data in-memory, and uses **Swagger UI** for testing. Built as part of a real-world developer challenge to simulate backend work in a short timeframe.

---

## 🛠️ Tech Stack
- **Backend:** ASP.NET Core Web API (C#)
- **Data Layer:** Entity Framework Core (InMemory Provider)
- **Testing Tool:** Swagger (via Swashbuckle)
- **IDE:** Visual Studio Code / Visual Studio
- **Version Control:** Git + GitHub

---

## 🚀 How to Run Locally

### ✅ Prerequisites
- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- Git & Terminal / Command Prompt

### 📥 Clone the Repository
```bash
git clone https://github.com/your-username/TaskManagerAPI.git
cd TaskManagerAPI
```

### ▶️ Run the Project
```bash
dotnet restore
dotnet run
```
Then visit:
```
http://localhost:5137/swagger
```
To test all API endpoints.

---

## 📂 Project Structure
| Folder/File               | Description |
|--------------------------|-------------|
| `Models/Task.cs`         | Task model with fields: Id, Title, Description, DueDate, IsComplete |
| `Services/TaskService.cs`| Handles task data using in-memory storage |
| `Controllers/TaskController.cs` | All API endpoints logic |
| `Program.cs`             | DI configuration + Swagger setup |

---

## 🔧 API Endpoints & Examples

### ➕ Create Task
**POST** `/api/tasks`
```json
{
  "title": "Buy groceries",
  "description": "Milk, Bread, Eggs",
  "dueDate": "2025-05-01T00:00:00",
  "isComplete": false
}
```
Returns: `201 Created`

### 📄 Get All Tasks
**GET** `/api/tasks`
Returns: List of task objects

### 📌 Get Single Task
**GET** `/api/tasks/{id}`
Returns: `200 OK` or `404 Not Found`

### ✏️ Update Task
**PUT** `/api/tasks/{id}`
```json
{
  "title": "Buy groceries",
  "description": "Updated items",
  "dueDate": "2025-05-02T00:00:00",
  "isComplete": true
}
```

### 🗑️ Delete Task
**DELETE** `/api/tasks/{id}`
Returns: `204 No Content` or `404 Not Found`

---

## ⚠️ Validations & Errors
- ✅ Title is required → `400 Bad Request`
- ❌ Non-existent ID → `404 Not Found`
- ✅ Success Creation → `201 Created`
- ✅ Successful Deletion → `204 No Content`

---

## 🚧 Assumptions & Notes
- Data is stored in-memory (resets on restart)
- Task ID is auto-generated
- Only backend is implemented (no UI)

---

## 🎥 Video Walkthrough
A 5–10 minute screen recording has been shared showing:
- Code walkthrough (Model, Controller, Service)
- CRUD operations in Swagger
- Explanation of structure and setup

▶️ [Click here to watch the video walkthrough](https://www.loom.com/share/7f44d3db979449aa9ec7e77e58df3d74?sid=a66cf650-2058-4045-9fbd-0e3c0dad23e5)

---

## 🤝 Contributing & Contact
Feel free to fork this repository and improve it!

📧 Contact: [prem.kumar.soni2907@gmail.com](mailto:prem.kumar.soni2907@gmail.com)

---

Made with ❤️ by **Prem Kumar Soni**  
#TaskManagerAPI
