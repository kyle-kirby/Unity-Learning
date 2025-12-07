# Mod The Cube Challenge  (Unity)

## 📌 Overview
This Unity project demonstrates how to dynamically randomize object properties at runtime. Each time the game starts, the cube changes its **color**, **opacity**, **scale**, and **rotation speed** randomly. This exercise focuses on scripting fundamentals, material manipulation, and runtime property changes.

---

## 🎯 What I Learned
- **Randomization in Unity**
  - Using `Random.Range()` and `Random.value` to generate random values for scale, rotation speed, and color.
- **Material and Color Control**
  - Applying color and alpha (opacity) to a material using `Renderer.material.color`.
  - Understanding Unity’s material settings for transparency (Surface Type: Transparent/Fade).
- **Transform Manipulation**
  - Changing position and scale programmatically.
  - Rotating objects continuously using `transform.Rotate()`.
- **Inspector Integration**
  - Exposing variables as `public` and using `[Range()]` for sliders.

---

## ✅ Key Features
- Cube randomizes:
  - **Color** (RGB values)
  - **Opacity** (Alpha channel)
  - **Scale** (Size between 1.0 and 5.0)
  - **Rotation Speed** (Between 50 and 100 degrees per second)

---


## 🚀 Next Steps
- Animate color and opacity over time instead of only randomizing at start.
- Add UI sliders to control properties during gameplay.
- Expand to multiple objects with different random behaviors.

---

## 🛠 Tools Used
- **Unity Version:** [6000.2.10f1]
- **Language:** C#
- **Platform:** PC


---

*This project is part of my Unity learning journey in the Junior Programmer Pathway.*