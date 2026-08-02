# ✈️ Travel Blog Platform

[![ASP.NET MVC](https://img.shields.io/badge/ASP.NET_MVC-C%23-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![SQL Server](https://img.shields.io/badge/Microsoft_SQL_Server-CC2927?logo=microsoft-sql-server&logoColor=white)](https://www.microsoft.com/en-us/sql-server)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

A web application where users can share their travel experiences, write blog posts, and leave comments.
Built with the ASP.NET MVC framework, it includes an admin panel for managing blog posts, comments, and contact messages. Designed for travel enthusiasts, the platform features a clean, user-friendly interface.

## 📑 Table of Contents

- [Features](#-features)
- [Tech Stack](#-tech-stack)
- [Project Structure](#-project-structure)
- [Getting Started](#-getting-started)

## ✨ Features

- **Blog Management:** Add, update, and delete blog posts through the admin panel.
- **Comment Management:** List, edit, and delete user comments.
- **Contact Messages:** View and delete messages submitted by users.
- **Authentication:** Secure login system protecting access to the admin panel.
- **User-Friendly Interface:** A modern, clean design focused on user experience.

## 🛠 Tech Stack

| Category | Technology |
|---|---|
| **Backend** | ASP.NET MVC (C#) |
| **Database** | Microsoft SQL Server |
| **Frontend** | HTML, CSS, JavaScript |
| **Authentication** | Forms Authentication |
| **Other** | Google Maps API |

## 📂 Project Structure

```
travel-blog-aspnet-mvc/
├── Controllers/
│   ├── AboutController.cs      → Manages the About page
│   ├── AdminController.cs      → Admin panel operations for blogs, comments, and contact messages
│   ├── BlogController.cs       → Lists blog posts and displays post details
│   ├── ContactController.cs    → Manages the contact page and messages
│   ├── LoginController.cs      → Login and logout operations
│   └── DefaultController.cs    → Home page and other static pages
│
├── Views/
│   ├── Admin/                  → Views for the admin panel (blog list, comment list, etc.)
│   ├── Blog/                   → Views for blog posts and comments
│   ├── Login/Login.cshtml      → Login page
│   └── Default/                → Home page and other static pages
│
├── Models/                     → Database models (Blog, Comments, Contact, etc.)
└── web.config                  → Database connection string and Forms Authentication settings
```

## 🚀 Getting Started

1. Clone the repository:

```bash
git clone https://github.com/sedanurpeker/travel-blog-aspnet-mvc.git
```

2. Set up the database:
   - Create a database named `TravelTripDB` on Microsoft SQL Server.
   - Update the connection string in `web.config` with your own settings.

3. Run the project:
   - Open the project in Visual Studio.
   - Run it with IIS Express or your own server.
