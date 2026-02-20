---
id: DR-001
type: design-research
status: draft
project: ModernFlyouts
created: 2026-02-20
license: MIT (Original Copyright (c) 2020 Shankar)
---

# Design Research: ModernFlyouts Fluent 2 Evolution

## 1. Visual Direction: "Liquid Glass"

The core aesthetic for 2026 Windows customization centers around **Mica Alt** and **Variable Opacity**.

### Key Visual Elements

- **Backdrop**: [Mica Alt](https://learn.microsoft.com/en-us/windows/apps/design/style/mica) for the main container. It provides a deeper, more intentional tint that harmonizes with the desktop wallpaper without being purely transparent.
- **Surface**: Subtle **Glassmorphism** for control regions (e.g., media playback sliders) using semi-transparent overlays.
- **Corners**: Consistent **8px** for containers and **4px** for interactive elements (buttons, chips).
- **Typography**: `Segoe UI Variable` with optical sizing — Display for headings, Text for summaries.

## 2. Competitive Benchmarking (2026)

| Product | Key UX Pattern | Aesthetic |
| :--- | :--- | :--- |
| **Windows 11 System** | Smooth snapping, consistent materials | Clean, System-Integrated |
| **BeWidgets** | High customizability, Bento-grid layouts | Modular, Playful |
| **Vivetool UI** | Extreme minimalism, monochrome + accent | Utility-focused, Pro |

## 3. Targeted Micro-interactions

1. **Fluid Expansion**: Flyout doesn't just "appear"; it expands using a spring-based scale animation (Scale 0.95 -> 1.0).
2. **Material Transition**: When the window loses focus, Mica Alt subtly shifts to a solid desaturated color to indicate background state.
3. **Accent Glow**: Buttons have a subtle inner glow matching the system accent color on hover.

## 4. Design-of-the-Year Goals

- **Zero Inconsistency**: Every single element (sliders, buttons, text) must use tokens from the `iNKORE` theme.
- **Depth Hierarchy**: Use Z-depth (shadows) together with materials to create a clear "floating" feel.
- **Accessibility**: AA contrast compliance even when background is semi-transparent.

## 6. Immersive Album Art Patterns (User Focused)

Based on feedback, the design will prioritize the **Album Art** as the visual anchor.

### Immersive Strategies

- **Full-bleed Background**: The flyout background will be an "Adaptive Ambient" layer. Instead of a simple blur, it will use a high-quality, lightly blurred version of the album art that fills the entire container.
- **Aurora Mesh**: For low-resolution covers, use the colors to generate an [Aurora Gradient](https://microsoft.github.io/fluent-ui-react-native/docs/design/aurora) mesh.
- **Glassmorphic Overlays**: Content (text, buttons) will sit on "Glass" cards (high transparency, high blur) to ensure readability without obscuring the background.
- **Parallax Motion**: Subtle movement of the background image during media transitions to create depth.

## 7. Visual Concept v2 (Immersive)

![Fluent 2 Immersive Concept](file:///C:/Users/nguye/.gemini/antigravity/brain/a24f8573-9846-4038-a250-96049a74df83/concept_fluent2_immersive_final_1771590054300.png)
*Conceptual target: Immersive album art background with floating glassmorphic controls.*
