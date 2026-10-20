# CourseRegistrationApp

A Windows Forms desktop application for registering students into programming courses. Built in C# as **Lab 05** of the course **Programming on Windows** (*Lập trình trên Windows*).

The application lets a student enter personal information, choose a course, a study format, and a number of months, then shows the tuition fee and a registration receipt. All data is handled on the form only. There is **no database or file storage**.

---

## Table of Contents

- [Objectives](#objectives)
- [Features](#features)
- [User Interface](#user-interface)
- [Course Data](#course-data)
- [Application Behavior](#application-behavior)
- [Controls and Naming Convention](#controls-and-naming-convention)
- [Tech Stack](#tech-stack)
- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [Grading Rubric](#grading-rubric)
- [Submission](#submission)

---

## Objectives

This project practices the fundamentals of Windows Forms development:

- Creating a Windows Forms App project in C#.
- Designing a UI with the Form Designer, Toolbox, and Properties window.
- Using basic controls: `Label`, `TextBox`, `Button`, `ComboBox`, `RadioButton`, `CheckBox`, `DateTimePicker`, `NumericUpDown`, and `GroupBox`.
- Naming controls with a clear, consistent convention so the code stays readable.
- Handling the events `Click`, `Load`, `SelectedIndexChanged`, and `ValueChanged`.
- Validating user input before processing, and showing results with `MessageBox`.

## Features

- **Course list** loaded into a `ComboBox` when the form starts.
- **Automatic tuition calculation** that updates whenever the course or the number of months changes.
- **Input validation** for required fields (full name, phone number, course).
- **Registration receipt** displayed in a message box with all the entered details.
- **Reset button** that restores the form to its initial state.
- **Exit confirmation** that asks before closing the application.

## User Interface

The main form is titled **ĐĂNG KÝ KHÓA HỌC** (*Course Registration*). It is organized into two `GroupBox` sections and one button area.

| Group | Control | Name | Purpose |
| --- | --- | --- | --- |
| Student information | `TextBox` | `txtHoTen` | Student's full name |
| Student information | `TextBox` | `txtSoDienThoai` | Phone number |
| Student information | `DateTimePicker` | `dtpNgaySinh` | Date of birth |
| Student information | `CheckBox` | `chkNhanEmail` | Opt in to email notifications |
| Course information | `ComboBox` | `cboKhoaHoc` | Select a course |
| Course information | `RadioButton` | `radOnline` | Online study format |
| Course information | `RadioButton` | `radOffline` | In-person study format |
| Course information | `NumericUpDown` | `numSoThang` | Number of months to enroll |
| Course information | `Label` | `lblTongTien` | Displays the total tuition |
| Buttons | `Button` | `btnDangKy` | Register |
| Buttons | `Button` | `btnLamMoi` | Reset the form |
| Buttons | `Button` | `btnThoat` | Exit the program |

**Layout requirements**

- At least two `GroupBox` controls group related information.
- Labels and input fields are aligned in clear rows.
- The three buttons sit in the same row or area.
- Tab order is logical: top to bottom, left to right.
- No default control names such as `textBox1`, `button1`, or `comboBox1`.

## Course Data

| Course | Fee per month |
| --- | --- |
| C# WinForms cơ bản (C# WinForms Basics) | 800,000 VNĐ |
| SQL Server cơ bản (SQL Server Basics) | 700,000 VNĐ |
| Web Frontend cơ bản (Frontend Web Basics) | 750,000 VNĐ |
| Lập trình Python cơ bản (Python Programming Basics) | 650,000 VNĐ |

**Total tuition = monthly fee × number of months**

For example, *C# WinForms cơ bản* for 6 months costs 800,000 × 6 = **4,800,000 VNĐ**.

## Application Behavior

### On form load

- Fill the course `ComboBox` with the course list.
- Select the first course by default.
- Select **Online** as the default study format.
- Set the number of months to a minimum of **1** and a maximum of **12**.
- Display the initial total tuition.

### Register button (`btnDangKy`)

1. Check that the full name is not empty.
2. Check that the phone number is not empty.
3. Check that a course is selected.
4. Calculate the total tuition (monthly fee × months).
5. Show a registration receipt in a `MessageBox` containing:
   - Full name
   - Phone number
   - Date of birth
   - Course
   - Study format (Online / In-person)
   - Number of months
   - Total tuition
   - Email notification status

If validation fails, a warning message is shown and registration does not proceed.

### Reset button (`btnLamMoi`)

- Clear the full name and phone number.
- Set the date of birth back to today.
- Uncheck the email notification option.
- Select the first course again.
- Select **Online** again.
- Set the number of months back to 1.
- Move the cursor back to the full name field.

### Exit button (`btnThoat`)

- Show a confirmation dialog before exiting.
- Close the form only if the user clicks **Yes**.

## Controls and Naming Convention

Control names use a short type prefix followed by a Vietnamese description:

| Prefix | Control type | Example |
| --- | --- | --- |
| `txt` | `TextBox` | `txtHoTen` |
| `dtp` | `DateTimePicker` | `dtpNgaySinh` |
| `chk` | `CheckBox` | `chkNhanEmail` |
| `cbo` | `ComboBox` | `cboKhoaHoc` |
| `rad` | `RadioButton` | `radOnline` |
| `num` | `NumericUpDown` | `numSoThang` |
| `lbl` | `Label` | `lblTongTien` |
| `btn` | `Button` | `btnDangKy` |

## Tech Stack

- **Language:** C#
- **Framework:** Windows Forms (.NET)
- **IDE:** Visual Studio
- **Storage:** none (in-memory only)

## Getting Started

### Prerequisites

- Windows
- Visual Studio with the **.NET desktop development** workload installed

### Run the project

1. Clone or download this repository.
2. Open `CourseRegistrationApp.sln` in Visual Studio.
3. Press **F5** (or click **Start**) to build and run.

## Project Structure

```
CourseRegistrationApp/
├── CourseRegistrationApp.sln
└── CourseRegistrationApp/
    ├── Program.cs              # Application entry point
    ├── Form1.cs                # Event handlers and application logic
    ├── Form1.Designer.cs       # Auto-generated UI layout (edit via Designer)
    └── Form1.resx              # Form resources
```

> The structure above is the default Visual Studio layout. Adjust it if your project contains extra files such as a `Course` class.

## Grading Rubric

| Criteria | Points |
| --- | --- |
| Correct project that builds and runs | 1.0 |
| Complete controls and clear layout | 2.0 |
| Control naming convention | 1.0 |
| Course data loaded on form load | 1.0 |
| Correct tuition when course or months change | 1.5 |
| Register button validates input and shows correct result | 2.0 |
| Reset and Exit buttons work correctly | 1.0 |
| Clean, readable code | 0.5 |
| **Total** | **10.0** |

## Screenshot

<!-- Add a screenshot of the main form here -->
<!-- ![Main form](screenshots/main-form.png) -->

## Author

- **Name:** Phung Ngoc Minh
- **Course:** Programming On Windows
