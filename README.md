# CarRentalSystem

## Overview

CarRentalSystem is a web-based application that allows users to rent cars. It offers features such as browsing available cars, making reservations, user registration and login, and managing reservations.

![image](https://github.com/user-attachments/assets/55f8b277-b06a-4d24-ac32-c3bece253239)
![image](https://github.com/user-attachments/assets/aa3b8eca-3c61-45a9-b791-13b722e8c31a)
![image](https://github.com/user-attachments/assets/be71da8f-9a0a-4602-bfa5-8972d9b41eaa)





## Features

- **User Authentication**: Sign up, log in, and manage user profiles.
- **Car Browsing**: View available cars with details such as make, model, year, and price per day.
- **Reservations**: Users can reserve cars for specific dates.
- **Admin Panel**: Admin users can manage cars, reservations, and users.
- **Responsive Design**: The application is fully responsive, offering a smooth experience on both desktop and mobile devices.

## Tech Stack

- **Frontend**: ASP.NET Core MVC
- **Backend**: C# (.NET Core)
- **Database**: SQL Server (or other relational databases)
- **CSS Framework**: Bootstrap 5 for styling
- **JavaScript**: jQuery (for dynamic features)

## Getting Started

Follow these steps to get a local copy of the project up and running:

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 5.0 or later)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or any other database compatible with Entity Framework Core

### Setup

1. Clone the repository:

    ```bash
    git clone https://github.com/yourusername/CarRentalSystem.git
    ```

2. Navigate into the project directory:

    ```bash
    cd CarRentalSystem
    ```

3. Restore the NuGet packages:

    ```bash
    dotnet restore
    ```

4. Apply database migrations:

    ```bash
    dotnet ef database update
    ```

5. Run the application:

    ```bash
    dotnet run
    ```

6. Visit the application in your browser at `http://localhost:5000`.

## Database Seeding

The project comes with sample data for cars and users. To seed the database with initial data, you can run the following command:

```bash
dotnet ef database update
