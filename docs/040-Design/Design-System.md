---
id: DS-001
type: design-system
status: draft
project: ModernFlyouts
created: 2026-02-20
license: MIT (Original Copyright (c) 2020 Shankar)
---

# Design System: Fluent 2 Modernization

## 1. Core Tokens

### Typography

- **Primary**: `Segoe UI Variable`
- **Headings**: `Segoe UI Variable Display`, Semibold
- **Body**: `Segoe UI Variable Text`, Normal

### Geometry

- **Outer Containers**: Corner Radius `8px`
- **Interactive Elements**: Corner Radius `4px` (Buttons, Sliders, Chips)
- **Shadows**: Depth 16-32 for floating effect.

## 2. Materials & Opacity

| Material | Usage | Token/Value |
| :--- | :--- | :--- |
| **Mica Alt** | Main Flyout Backdrop | `iNKORE.MicaAlt` |
| **Immersive Art** | Media Session Background | Opacity: `0.15` (default) -> `0.8` (immersive) |
| **Glass Card** | Overlay for controls | `#20FFFFFF` (Light), `#20000000` (Dark) with `BlurRadius="30"` |

## 3. Immersive Media Component (Spec)

### Background

- **Stretch**: `UniformToFill`
- **Opacity**: `0.8`
- **Overlay**: Dark gradient vignette (Bottom-up) to protect text readability.

### Controls

- **Transport Buttons**: Floating on a semi-transparent glass border.
- **Progress Bar**: Thin, minimal, using accent color glow.

## 4. Motion Principles

- **Scale-Up**: `ElasticEase` (Duration: 300ms, Amplitude: 0.2)
- **Fade**: `CubicEase` (Duration: 200ms)
