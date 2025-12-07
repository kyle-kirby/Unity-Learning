# 💾 Data Persistence Challenge

This Unity project demonstrates saving and loading data across sessions using JSON.

## Core Idea
- Store player data (name + high score) in a JSON file.
- Load that data when the game starts.
- Update the file whenever a new high score or player name is set.

## How It Works
- Data is saved to:
- `SaveData` class defines what gets stored:
- `HighScore`
- `HighScorePlayer`
- `LastPlayerName`
- `JsonUtility.ToJson()` converts the data to JSON.
- `System.IO.File.WriteAllText()` writes the file.
- `System.IO.File.ReadAllText()` + `JsonUtility.FromJson()` loads it back.

## Usage
- On the **menu scene**, the input field auto-fills with `LastPlayerName`.
- The high score text shows `Best Score : X : Y`.
- On **game start**, the current player name is saved immediately.
- When a new high score is reached, both score and player name are updated.

## Key Scripts
- **SaveData.cs** → Serializable class for JSON storage.
- **MainManager.cs** → Handles saving/loading high score and player name.
- **MenuUIHandler.cs** → Reads save file to pre-fill UI and saves player name on start.
