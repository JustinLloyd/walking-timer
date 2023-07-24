# 🚶‍♂️ Walking Timer

![Walking Timer Interface](url-to-your-image) 

Walking Timer is a simple stopwatch application developed by Justin Lloyd for timing daily walks. It's a Windows desktop application designed to help users monitor their daily walking sessions effectively. 

The application tracks not only the total time spent on walks, but also breaks down the information into daily and session logs, allowing the users to understand their walking habits in greater depth. 

> 🖥️ **Display Requirements:** Walking Timer is primarily designed for a touch-screen interface with a resolution of 1920x1080. The application's user interface and performance may not be optimal on display resolutions that don't match this specification. Please ensure your device's display settings are compatible for the best user experience.

This project is protected under copyright, all rights reserved to [Justin Lloyd](https://justin-lloyd.com) 2022.

## 🏗️ Code Structure

The codebase of Walking Timer consists of several classes: `DayLog`, `SessionLog`, `WalkingLog`, and `Form1`.

- **`DayLog`**: Represents a log for a day's walk. It includes multiple sessions, each associated with certain parameters such as total laps, speed, steps, and total time.

- **`SessionLog`**: Represents a log for a single walking session. It includes the start time, duration, and a status indicating whether the session is closed or not.

- **`WalkingLog`**: Represents the overall walking log. It includes multiple day logs.

- **`Form1`**: The main form class where the user interface logic resides. It handles timer start/pause, session end, adding/removing laps, end of day actions, and session reset. It also calculates estimated distance, steps, and speed based on the current lap count. The data gets stored and retrieved from a JSON file named "walking_log.json".

## 🖥️ User Interface

The application comes with a user-friendly interface featuring:

- **Start/Pause Button**: Starts the session if it's currently paused, and pauses it if it's running. 

- **Add Lap/Remove Lap Buttons**: Allows users to manually increase or decrease the lap count.

- **End Session Button**: Ends the current session, calculates the total time spent in the session, and updates the session log.

- **End of Day Button**: Ends the current day's log, adds the session elapsed time to the total elapsed time, updates the session and day logs, and resets the elapsed times and lap counter for a new day.

- **Reset Button**: Resets the current session's elapsed time.

## 🚀 Getting Started

1. Clone the repository to your local machine.
2. Ensure you have .NET framework installed.
3. Open the solution in Visual Studio.
4. Build and run the application.
