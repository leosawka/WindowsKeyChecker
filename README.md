# **WindowsKeyChecker**

## **Description**

WindowsKeyChecker is a simple Windows desktop application built with WPF and C# that allows users to check their Windows activation status using the ```slmgr``` command. The application provides a user-friendly interface to view:

* Activation status (```/dli```)

* Detailed license information (```/dlv```)

* Expiration date (```/xpr```)

## **Features**

* ✅ Easy-to-use graphical interface.
* ✅ Disables buttons while fetching data to prevent multiple requests.
* ✅ Displays activation details directly in the UI instead of pop-ups.
* ✅ Adjusts window size dynamically based on content.

## **Requirements**

* Windows 10/11

* .NET 8.0 SDK (or later)

## **Installation**

Clone the repository:

 ```
 git clone https://github.com/leosawka/WindowsKeyChecker.git
 cd WindowsKeyChecker
 ```

Build and run the application:

 ```
 dotnet build
 dotnet run --project WindowsKeyChecker.WPF
 ```

## **Usage**
1. Launch the application.
2. Click one of the buttons to retrieve Windows activation information.
3. The results will be displayed directly in the UI.

## **License**
This project is licensed under the MIT License. See LICENSE for details.

## **Contributing**
Pull requests are welcome! If you'd like to contribute, feel free to fork the repository and submit a PR.

## **Author**
Developed by Jairo Leonardo Olivera

## **Disclaimer**
This software is provided "as is," without any warranty. It only reads Windows activation data and does not modify system settings.