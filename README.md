# DataWarehouse
📦 Data Warehouse Management System

A Windows Forms–based application designed to collect, store, and manage student data across various departments such as Academics, Chaplaincy, Hostel, and Performance. The system centralizes all student information into a Data Warehouse, enabling easy retrieval, analysis, and reporting.

📌 Project Overview

The Data Warehouse Management System (DWMS) is built to automate and streamline the process of gathering student-related data from different units of an institution. It integrates all records—academic details, hostel information, chaplaincy details, performance reports, and more—into a unified Data Warehouse for effective decision-making.

This application provides:
✔ Data entry forms
✔ Automated validation
✔ Multi-table transactions
✔ Student performance aggregation
✔ Visualization through summary pages
✔ Centralized data storage in SQL Server
✔ A user-friendly interface built with WinForms and Guna UI

🏗️ Key Modules
1. Student Registration (Stud.cs)

This module:

Collects core student details such as name, registration number, age, gender, scholarship status, etc.

Inserts data into multiple warehouse tables using transactions:

StudentT (student bio data)

CourseT (registered course)

Performance (grade or academic score)

Prevents duplicate registration numbers.

Displays a fading slideshow background for visual appeal.

2. Chaplaincy Records (ChaplAdd.cs)

This module:

Captures student participation in chapel activities from 100–500 level.

Determines if a student holds a chaplaincy position.

Records demerit points if applicable.

Dynamically reveals input fields (like 500-level dropdowns) based on matric number and options selected.

Stores all chaplaincy data in the ChaplainT table.

3. Hostel Management (NewH.cs)

This module:

Stores hostel room allocations for each academic level (100–500 level).

Keeps track of hostel demerits.

Updates the FinanceT table to reflect whether a student is owing for damages in each level.

Saves the student’s permanent exit date from the hostel.

Redirects users to a view page after successful input.

🗂️ Database Design (Data Warehouse)

The system uses a SQL Server database (big Data.mdf) consisting of warehouse tables such as:

Table	Description
StudentT	Core student data
CourseT	Student course records
Performance	Grades/academic performance
ChaplainT	Chapel and behaviour records
HostelT	Hostel allocations and demerits
FinanceT	Payment and clearance status

Each module inserts data into the Data Warehouse following a star-schema-like pattern for easy reporting.

🖥️ Technologies Used

C# (.NET Framework, Windows Forms)

SQL Server / LocalDB

Guna UI 2 for enhanced interface design

Timers & animations for UI transitions

Parameterized SQL queries for security

Transactions for multi-table write operations

🚀 Features

Centralized storage of all student data

Smooth UI with transitions and animations

Dynamic form content based on user inputs

Realtime validation and error checks

Multi-module data entry

Automatic database updates for financial status

Easy navigation and visibility of records

Secure data insertion using SQL parameters

📷 Screenshots

Add your screenshots here (Student Entry Form, Chaplaincy Form, Hostel Form, Summary Page, etc.)

🛠️ How to Run

Clone the repository

Open the solution in Visual Studio

Restore NuGet packages

Ensure big Data.mdf is in the project folder

Run the application

✨ Future Enhancements

Add reporting dashboard

Integrate Power BI for visual analytics

Add user authentication

Export student warehouse data to PDF

Add SMS/email notification system

👨‍💻 Author

Michael Abraham
Data Engineer & Software Developer
