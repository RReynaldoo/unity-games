# Unity 3D Games: Software Engineering (Rutgers–Newark, Spring 2026)

Two 3D games I built in **Unity 6.3** with **C#**, based on projects from *Sams Teach Yourself Unity 2018 Game Development in 24 Hours*. A big part of the work was migrating the 2018 material to Unity 6.3: replacing store assets that no longer exist, enabling legacy compatibility settings, and fixing textures and code that broke in the newer engine.

This repository contains the **C# scripts I wrote**. The full Unity projects (over 200 MB each, mostly engine files and textbook assets) aren't included.

## Chaos Ball
An arena game: the player pushes four colored balls into their matching corners while faster "chaos balls" get in the way.

| Script | Purpose |
|---|---|
| [GameManager.cs](chaos-ball/GameManager.cs) | Watches all four goals and shows a "Game Over" screen once every ball is in its corner. |
| [GoalScript.cs](chaos-ball/GoalScript.cs) | Detects when the ball of the matching color enters its goal. |
| [VelocityScript.cs](chaos-ball/VelocityScript.cs) | Gives balls their starting velocity so they keep moving around the arena. |

## Amazing Racer
A first-person race across a sculpted 3D terrain to a finish zone, with a live timer and water hazards that send you back to the start.

| Script | Purpose |
|---|---|
| [GameManager.cs](amazing-racer/GameManager.cs) | Runs the race timer, spawns and respawns the player, and handles finishing and restarting. |
| [FinishZone.cs](amazing-racer/FinishZone.cs) | Detects when the player reaches the finish line. |
| [PlayerRespawn.cs](amazing-racer/PlayerRespawn.cs) | Sends the player back to the spawn point if they fall into water. |
