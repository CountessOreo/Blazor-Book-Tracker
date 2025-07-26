# 📚 Blazor Book Tracker

**Blazor Book Tracker** is a modern web application for managing and tracking your book collection. Built with Blazor and C#, the app provides an intuitive interface for adding, editing, and organizing books with a clean UI and optional dark mode.

## Features

- Search and view books in grid or card mode
- Add/edit/delete book entries
- Upload and display book cover images
- Modal-based quick actions

## 🛠 Tech Stack

- **Frontend**: Blazor WebAssembly
- **Backend**: ASP.NET Core
- **Database**: Entity Framework Core with SQL Server
- **UI Components**: Syncfusion Blazor Components
- **Other Tools**: C#, .NET 8, JavaScript interop

## Getting Started

### Prerequisites

- [.NET SDK 8+](https://dotnet.microsoft.com/en-us/download)
- SQL Server (Express or LocalDB)
- Visual Studio or VS Code

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/blazor-book-tracker.git
   cd blazor-book-tracker
   ```
2. Set up the database:
```bash
dotnet ef database update
```

3. Run the application:
  ```bash
dotnet run
```

## Screenshots

### Home Page
<img width="1877" height="843" alt="BookList" src="https://github.com/user-attachments/assets/f9286124-94ba-4477-8c19-4a4b27f45c42" />

### Book Cards
<img width="1884" height="691" alt="Card" src="https://github.com/user-attachments/assets/3b29a9e1-64ad-49ba-8770-b0e37443282b" />

### Add Book Form
<img width="563" height="489" alt="AddBook" src="https://github.com/user-attachments/assets/5208cb0d-bdfc-4d19-8e89-4f02ba45693a" />

### Search, Update and Delete
<img width="1879" height="731" alt="ManageBooks" src="https://github.com/user-attachments/assets/32829c78-a263-4d94-9f92-6ac5969ef485" />

## Book Details
<img width="1900" height="885" alt="BookDetails" src="https://github.com/user-attachments/assets/1b7a5c0b-18dd-45e2-afda-ce302a0e0c15" />


## Folder Structure
```bash
BlazorBookTracker/
├── wwwroot/              # Static assets
├── Pages/                # Razor pages (e.g., BookList, AddBook)
├── Components/           # Reusable components (e.g., BookCard, BookActions)
├── Models/               # Data models (Book, Category, etc.)
├── Services/             # Business logic and API calls
└── Data/                 # EF Core DB context and migrations
```
