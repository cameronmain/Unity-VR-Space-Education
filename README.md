# Unity VR Educational Experience

![Gameplay Image](https://cameronmain.com/wp-content/uploads/2023/10/Screenshot003-768x432.png)

## Project Overview

The aim of this project was to create an interactive, educational virtual reality experience crafted for children to explore and learn about the planets in our solar system. Developed with Unity and the XR toolkit, this project provides an immersive learning experience that culminates in a quiz to test the player's acquired knowledge.

## Features

- **Planetary Exploration**: Traverse through our solar system and interact with each planet to discover fascinating facts.
- **Educational Content**: Engage with informative content that encourages learning in a fun & interactive manner.
- **Knowledge Assessment**: A final quiz to test and reinforce the learning achieved throughout the exploration.
- **Accessible Interaction**: Designed with user-friendly controls to provide a seamless experience for young explorers.



## Scripts

The core logic of the game is encapsulated in various C# scripts that handle different aspects like planet interaction, quiz management, UI, and audio control. Here's a brief overview:

- `PlanetController`: Manages the interaction with planets using XR controllers.
- `QuizManager`: Handles the logic for generating and evaluating quiz questions.
- `QuestionsAndAnswers`: Data structure for holding the quiz questions and answers.
- `UIAndAudioController`: Manages the UI updates and audio playback based on player interaction.
- `PlanetInstantiator`: Controls the instantiation of planets and triggers the cutscene playback.
- `PlanetAnimate`: Applies animation effects to the planets.
- `Planet`: Holds information about a planet including its name, description, and associated audio.

## Installation

1. Clone the repository or download the zip file.
2. Open the project in Unity.
3. Build and run the project on a supported XR device.


## Licensing Information

### Code

The source code of this project is licensed under the [MIT License](https://opensource.org/licenses/MIT). You are free to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the software, provided that you give appropriate credit, provide a link to the license, and indicate if changes were made.

### Models and Assets

Please be advised that while the source code is licensed under the MIT License, the 3D models, textures, and other associated assets **are not**. These assets are proprietary and come with their own licensing terms. Redistribution, copying, or any other form of use of these assets outside the context of this project is strictly prohibited unless explicitly granted by the original asset creators or rights holders. Always consult individual licenses accompanying each asset or model for specific terms and conditions. Unauthorised use or distribution of these proprietary assets may result in legal consequences.

## Tools

- [Unity 2022.3.7f](https://unity.com/)
- [Unity XR Interaction Toolkit](https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@0.10/manual/index.html)
