## Project Demonstration Video

Check out the project demonstration video by clicking [here](docs/Demo_Video/page.html). 

# Running Visual Studio Files in Windows.xaml and Window.xaml.cs

This repository contains files created in Visual Studio that can be run in a Windows Presentation Foundation (WPF) application using the `Windows.xaml` and `Window.xaml.cs` files. Below are the instructions to set up and run the application.

## Prerequisites

To run the Visual Studio files in this repository, you will need the following installed on your system:

1. **Windows Operating System**: The WPF application runs on Windows, so ensure that you have a compatible version of Windows installed.

2. **Visual Studio**: Download and install Visual Studio, preferably the latest stable version available.

## Getting Started

Follow these steps to get the application up and running:

1. **Clone the Repository**: Start by cloning this GitHub repository to your local machine using the following command:

2. **Open the Project**: Launch Visual Studio and open the solution file (`YourProject.sln`) located in the root of the cloned repository.

3. **Restore NuGet Packages**: Once the solution is open, right-click on the solution in the Solution Explorer and select "Restore NuGet Packages." This will ensure that all required packages are installed for the project.

4. **Build the Solution**: Next, build the solution by right-clicking on the solution again and selecting "Build."

5. **Set Startup Project**: In case there are multiple projects in the solution, make sure to set the WPF application (`YourWpfApp`) as the startup project. Right-click on the WPF project in Solution Explorer and select "Set as Startup Project."

6. **Run the Application**: Press `F5` or use the "Start Debugging" button to run the application. This will open the WPF application, and you can interact with the user interface created in `Windows.xaml` and the code-behind in `Window.xaml.cs`.

7. **Interact with the Application**: Once the application is running, you can interact with it by clicking buttons, entering text, or performing any other actions based on the design of the application.

8. **Stop Debugging**: To stop the application, press `Shift + F5` or use the "Stop Debugging" button.

## Customizing the Application

Feel free to modify and customize the application to suit your needs. The XAML files (`Windows.xaml`) handle the user interface design, while the C# code-behind file (`Window.xaml.cs`) contains the application logic.

## Troubleshooting

If you encounter any issues while setting up or running the application, here are a few common troubleshooting steps:

- Make sure you have installed the required prerequisites mentioned in the "Prerequisites" section.

- Double-check that the solution builds successfully without any errors or warnings.

- Verify that the correct WPF project is set as the startup project.

- Check the Output window in Visual Studio for any error messages or exceptions.

- If the application crashes, check the call stack in the Debug window to identify the location of the issue.

- If you encounter a specific error or problem, try searching for a solution online or refer to the repository's issue section for possible resolutions.

## Contribution

If you find any bugs or want to enhance the application, feel free to create a pull request with your changes. We appreciate any contributions that can make this project better.

## License

The code in this repository is licensed under the [MIT License](LICENSE). Make sure to review and comply with the license terms when using or modifying the code.

---

Thank you for using our Visual Studio files in Windows.xaml and Window.xaml.cs! If you have any questions or need further assistance, feel free to contact us or open an issue in the repository. Happy coding!
