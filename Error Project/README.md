# Unity Error Challenge Overview

## Purpose
This project documents common Unity errors and how they were resolved while building a simple script (`CongratScript.cs`) and attempting a WebGL build in Unity 6.3.

## Key Issues & Fixes
- **Top-level statements error (CS8805)**  
  - Cause: Code written outside of a class.  
  - Fix: Wrap all code inside a `MonoBehaviour` class with `Start()` and `Update()` methods.

- **NullReferenceException**  
  - Cause: Variables (like `List<>` or Inspector references) not initialized or assigned.  
  - Fix: Initialize lists with `new List<>()` and assign objects in the Inspector.

- **ParticleSystem not playing**  
  - Cause: ParticleSystem reference not set or emission disabled.  
  - Fix: Drag the ParticleSystem into the script field in the Inspector and enable emission.

- **WebGL build failure after Unity 6.3 update**  
  - Cause: WebGL Build Support module not correctly installed for Unity 6.3.  
  - Fix: Reinstall Unity 6.3 with WebGL Build Support selected, then switch platform to WebGL in Build Settings.

## Final Script Behavior
- Cycles through a list of messages (`"Congratulations"` → `"All Errors Fixed"` → repeat).  
- Displays text updates every 1.5 seconds.  
- Plays particle effects when the script starts.

## Lessons Learned
- Always initialize collections before use.  
- Assign public fields in the Inspector to avoid null references.  
- Unity scripts must be wrapped in classes that inherit from `MonoBehaviour`.  
- Each Unity version requires its own build support modules (WebGL, Android, iOS, etc.).

## Next Steps
- Add visual polish (fade-in/out transitions).  
- Restart particle effects each time the text changes.  
