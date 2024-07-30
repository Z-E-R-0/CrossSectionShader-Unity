# Cross-Section Shader for Unity

![Cross-Section Shader Example](https://gamesnavneet.s3.eu-north-1.amazonaws.com/Git+Data/CrossShaderGif.gif)

## Overview

The **Cross-Section Shader** for Unity is a versatile tool designed to visualize cross-sections of 3D models. Created using Unity's Shader Graph, this shader clips objects along a defined plane, revealing their internal structures. It's perfect for applications in games, education, and visualization, providing a powerful way to explore complex models interactively.

## Features

- **Dynamic Plane Detection:** The shader detects the plane's normal and position, allowing for real-time adjustments.
- **Material Clipping:** Enables the clipping of specified materials, revealing internal details of the 3D objects.
- **Customizable Properties:** Easily adjust the plane's position and normal vector to control the cross-section.

## Getting Started

### Prerequisites

- Unity 2021.1 or newer
- Shader Graph package installed

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/cross-section-shader.git
2. Open Test Scene.
3. Use the shader and materials into your Unity scene.

 ### Usage

1. Create a Material:

2. In Unity, navigate to Assets > Create > Material.
   Select the Cross-Section Shader from the shader dropdown menu.

3. Apply the Material to the Object that you want to Clip

4. Assign the newly created material to the object(s) you want to clip.

5. Adjust Plane Properties:
   Use the properties in the Material Inspector to modify the plane's position and normal vector.
   For dynamic control, use scripting to adjust these properties at runtime.
  


