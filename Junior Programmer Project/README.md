# Junior Programmer Project

This project was created as part of the **Unity Junior Programmer Pathway** tutorial series.  
It demonstrates core Unity concepts such as scene management, UI interaction, saving/loading data, and working with singletons.

---

## 🎮 Project Overview
- **Menu System**: A main menu with buttons to start the game, save, load, and exit.
- **Color Picker**: Allows the player to choose a team color, which is saved and loaded across sessions.
- **MainManager Singleton**: Persists data between scenes and ensures only one manager exists.
- **Scene Management**: Switching between menu and gameplay scenes using `SceneManager`.

---

## 🛠 Features Implemented
- **Persistent Data**: Team color is saved to JSON and restored when the game restarts.
- **UI Integration**: Buttons wired to functions for starting, saving, loading, and quitting.
- **Event System**: Handles player input for menu navigation.
- **Script Execution Order**: Ensures UI initializes after managers are ready.

---

## ▶️ How to Run
1. Open the project in **Unity Hub** (Unity 2021 LTS or later recommended).
2. Load the **Menu Scene** and press Play.
3. Select a team color using the color picker.
4. Use the buttons to:
   - **Start New**: Load the gameplay scene.
   - **Save Color**: Save the current team color.
   - **Load Color**: Restore the previously saved color.
   - **Exit**: Quit the application (or stop Play mode in the Editor).


## 🚀 Learning Goals
This project reinforces:
- Working with **singletons** in Unity.
- Using **UI events** and `UnityEvent` callbacks.
- Saving and loading data with **JSON**.
- Managing **scene transitions**.
- Understanding **editor‑only vs runtime code**.
