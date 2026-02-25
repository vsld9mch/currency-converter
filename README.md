# Currency Converter (WinForms)

## Project Overview
This is a desktop application built with Windows Forms that allows users to perform real-time currency conversion. The program features a user-friendly interface to convert values between multiple international and custom currencies with precision.

## Key Features
* **Multi-Currency Support**: Convert between PLN, EUR, USD, and VD.
* **Dual Input Methods**: 
    * Manual input via text boxes.
    * Rapid value adjustment using an integrated horizontal scroll bar (`hScrollBar`).
* **Real-time Conversion**: Calculations update instantly as you change the source amount or switch between currency types.
* **Flexible Logic**: Supports all directions of conversion (e.g., PLN to USD, EUR to VD, etc.) based on predefined exchange rates.
* **Intuitive UI**: Uses radio buttons and group boxes for clear selection of source and target currencies.

## Technical Stack
* **Language**: C#
* **Framework**: .NET Framework 4.7.2 
* **Platform**: Windows Forms (WinForms) 
* [cite_start]**IDE**: Visual Studio 2022 

## How to Run

### Prerequisites
* **Windows OS**
* **.NET Framework 4.7.2 Runtime** or higher.
* **Visual Studio** (if you wish to modify or build from source).

### Instructions
1. **Clone the repository**:
    ```bash
    git clone <your-repository-url>
    ```
2. **Open the project**:
    Locate and open the `project 2.sln` file in Visual Studio.
3. **Build and Run**:
    * Press `F5` or click the **Start** button in Visual Studio to compile and launch the application.
4. **Usage**:
    * Select your **Source Currency** (Waluta źródłowa).
    * Select your **Target Currency** (Waluta docelowa).
    * Enter an amount in the text box or use the scroll bar at the bottom to see the converted result immediately.
