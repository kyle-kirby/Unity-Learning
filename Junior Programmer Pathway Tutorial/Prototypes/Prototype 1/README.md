# Prototype 1 - Unity Junior Programmer Pathway

## Overview
This is the first prototype from Unity's Junior Programmer Pathway. The goal of this project was to learn the basics of Unity's interface, create a simple playable scene, and implement core gameplay mechanics such as player movement and collision detection.

## Features
- Player character that can move forward, backward, and turn using keyboard input.
- Basic physics interactions using Unity's Rigidbody component.
- Collision detection with obstacles.
- Simple camera follow behavior.

## What I Learned
- How to navigate the Unity Editor and organize a project.
- The difference between **GameObjects**, **Components**, and **Prefabs**.
- How to use **Transform** for position, rotation, and scale.
- Basics of **C# scripting** in Unity:
  - Using `Update()` for frame-based logic.
  - Using `FixedUpdate()` for physics-based logic.
- How to apply **Rigidbody** for physics simulation.
- How to detect collisions using `OnCollisionEnter()` and `OnTriggerEnter()`.
- How to set up a simple camera follow script.

## Challenges
- Understanding when to use `Update()` vs `FixedUpdate()`.
- Getting the player movement smooth while using physics.
- Making sure the camera follows the player without jitter.

## How to Run
1. Open the project in Unity (tested on Unity 2021 LTS or later).
2. Press **Play** in the Editor.
3. Use **WASD** or **Arrow Keys** to move the player.

## Future Improvements
- Add jump functionality.
- Improve camera controls.
- Add a simple UI to display score or instructions.