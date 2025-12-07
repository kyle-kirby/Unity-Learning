# Unity Junior Programmer Pathway
## Prototype 3 & Challenge 3  

### 📌 Overview  
This repository contains two projects completed as part of the **Unity Junior Programmer Pathway**:  
- **Prototype 3**: Focused on player movement and physics-based interactions.  
- **Challenge 3**: Built upon Prototype 3 concepts with additional mechanics and creative customization.  

---

### ✅ What I Learned  

#### **1. Rigidbody & Physics**  
- How to use **Rigidbody** for realistic movement and apply forces using `AddForce()`.   

#### **2. Gravity & Jump Mechanics**  
- Implementing jump logic with conditions like `isOnGround` and `gameOver`.  
- Learned the importance of resetting gravity instead of multiplying it every scene reload.  
- Using **collision detection** (`OnCollisionEnter`) to manage grounded state.  

#### **3. Animations & Particle Effects**  
- Triggering animations with `Animator.SetTrigger()` and `Animator.SetBool()`.  
- Adding **particle systems** for visual feedback (dirt when running, explosion on crash).  

#### **4. Audio Integration**  
- Playing sound effects with `AudioSource.PlayOneShot()` for jump and crash events.  

#### **5. Game State Management**  
- Handling game-over conditions and stopping player actions when the game ends.  

#### **6. Challenge 3 Enhancements**  
- Extended Prototype 3 by adding new obstacles and mechanics.  
- Customized particle effects and audio for a more polished experience.  
- Practiced debugging common issues like gravity stacking and inconsistent jump behavior.  

---

### 🛠 Technologies Used  
- **Unity** (C# scripting)  
- **Animator** for character animations  
- **Particle System** for visual effects  
- **AudioSource** for sound integration  

---

### 🚀 Key Takeaways  
- Always **set gravity explicitly** instead of multiplying it to avoid cumulative changes.  
- Use **tags** and collision detection for clean game logic.  
- Modularize code for readability and maintainability.  