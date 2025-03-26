# 🎮 Let's Play — Game Client & Mini-Games

## 📘 Overview

This repository contains the client-side interface and mini-games for the project Let's Play, developed for the course CE2103 — Algoritmos y Estructura de Datos II at Instituto Tecnológico de Costa Rica.

The project includes two games:
- **BP Game**: A table-top strategy game with obstacles and scoring logic
- **Genetic Puzzle**: An image puzzle solver using genetic algorithms

All visual elements are implemented using **Unity**, while the core logic and player interaction are processed via a **C++ socket-based server**.

---

## 🎮 Game Modes

### 🏓 BP Game
- Inspired by football mechanics
- Supports player vs. player and player vs. AI
- AI uses **backtracking** to find shortest paths
- Uses **pathfinding** to route the ball around obstacles

### 🧩 Genetic Puzzle
- Loads and splits an image into shuffled tiles
- Uses **genetic algorithms** to evolve the correct arrangement
- Approximates the original image based on tile matching

---

## 🛠️ Technologies

- **Engine**: Unity 2020.3.7f1
- **Launcher**: Unity Hub 2.4.3
- **IDE**: Visual Studio Community 2019
- **Platform**: Windows 10
- **Communication**: TCP/IP socket to the game server

---

## 📎 Related

Backend server logic repository:  
🔗 [Let's Play — Game Server](https://github.com/MAU143429/LetsPlay-Server-CE-2103)
