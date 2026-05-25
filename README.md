# Surprise Task: Teleport Swap Prototype

**Author:** Harsh Kashyap  
**Framework:** Unity 2022 (2D)

## 📌 Objective
A playable Unity 2D prototype showcasing a custom "Teleport Swap" puzzle/action mechanic. 

## 🎮 Core Mechanic & Controls
The player shoots a kinetic projectile. When the projectile collides with a valid target, the player and the target instantaneously swap positions in 2D space. 

* **Movement:** `W` `A` `S` `D`
* **Aim:** `Mouse`
* **Shoot / Swap:** `Left-Click` (Target the Blue Square tagged "Swappable")

## 🛠️ Credits & Contributions (Programmer Track)
As per the task allowances for the programming domain, this prototype focuses entirely on clean codebase architecture and mechanic implementation over visual polish. 

**What I created:**
* `PlayerController.cs`: Handles WASD movement.
* `SwapBullet.cs`: Handles kinematic projectile movement and the spatial swapping logic via `OnTriggerEnter2D`.
* **Scene Architecture:** Created the custom tag database (`Swappable`), set up the Prefabs, and configured the Kinematic Rigidbody triggers to ensure bug-free teleportation without clipping.

**External Assets & Resources:**
* **AI Assistance:** Gemini AI was utilized for helping me write majority of the the C# swapping code. 
* **Visuals:** No third-party or external art assets were used. All visuals (Player, Projectile, Target, Environment) are standard Unity Default 2D Primitives.
* **Audio:** No external audio was used.