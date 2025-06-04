# cSharp-Project
# Real Estate Manager – C# WinForms App
A desktop real estate management system built in C#, where each employee can log in and manage their own list of properties – add, view, and delete – with secure user-based filtering and local JSON storage.

# Features
- Login with username and password
- Add new properties with name, address, type, and price
- View only properties created by the logged-in user
- Delete properties (owned by current user only)
- JSON-based data persistence
- Clean architecture with separation of concerns (OOP)

# Tech Stack
- C# (.NET Framework)
- Windows Forms (WinForms)
- JSON Serialization (via `Newtonsoft.Json`)
- Object-Oriented Programming
- 
# Project Structure
/NEW_PROJECT
│
├── LoginForm.cs # Login screen logic
├── HomeForm.cs # Main menu and navigation
├── AddPropertyForm.cs # Form to add new properties
├── ViewPropertiesForm.cs # Form to view/delete properties
│
├── Property.cs # Base class and derived types (Apartment, Office, etc.)
├── PropertyManager.cs # Handles business logic and property storage
├── JsonDataManager.cs # Implements file I/O for properties.json
├── IDataManager.cs # Interface for data persistence
│
├── Constants.cs # App-wide constants (e.g., min price)
├── PropertyType.cs # Enum: Apartment, PrivateHouse, Office
├── /Properties/ # Form designer resources
└── properties.json # Local JSON file storing all property data

yaml
Copy
Edit

# How to Run
1. Open the project in **Visual Studio**
2. Run the application (F5)
3. Enter any valid username (letters only) and numeric password (e.g., `1234`)
4. Use the interface to add, view, and delete your own properties

# Notes
- Only the logged-in user's properties are visible and manageable.
- All property data is saved to a local JSON file (`properties.json`).
- This is a local desktop application; no server or database required.

# About This Project
This project was developed as part of a student exercise in C# and object-oriented programming. It demonstrates the use of WinForms, data encapsulation, inheritance, interfaces, and simple persistent storage techniques.
