---
id: RS-001
type: research-analysis
status: completed
project: ModernFlyouts
created: 2026-02-20
license: MIT (Original Copyright (c) 2020 Shankar)
---

# Analysis: Fluent Design 2 Modernization for ModernFlyouts

## 1. Overview

This research explores the current landscape (2026) of Fluent Design 2 and its implementation in WPF applications, specifically targeting the modernization of ModernFlyouts.

## 2. Key Insights

### 2.1 Fluent Design 2 Principles

- **Natural & Flexible**: Use of tokens instead of hardcoded values.
- **Focus & Intentionality**: Reduced visual noise, emphasizing content.
- **Materiality**: Adoption of "Liquid Glass" (Mica, Mica Alt, Acrylic) to create depth and hierarchy.

### 2.2 UI Library Comparison

| Library | Best For | Pros | Cons |
| :--- | :--- | :--- | :--- |
| **iNKORE.UI.WPF.Modern** | **Full Modernization** | Successor to ModernWpf, pure WPF, Mica/Acrylic support, Fluent 2 styles. | Docs are work-in-progress. |
| **WPF-UI** | High-performance components | Great navigation/snackbar components, widely used. | Might require more effort to match "Pure Fluent" look. |
| **Native .NET 9 Fluent** | Basic Win11 look | No external dependencies, system-wide accent support. | Limited Backdrop (Mica) support without P/Invoke. |

### 2.3 Window Materials (The "Wow Factor")

- **Mica Alt**: Recommended for the main flyout backdrop to provide a premium, deep tinted look.
- **Acrylic**: Use for transient elements (context menus, tooltips) or secondary panels if applicable.
- **Fallback Logic**: Mandatory solid color fallbacks for Windows 10 < 22000 and high-performance modes.

### 2.4 Motion & Interactions

- **Spring Animations**: Use `ElasticEase` with fine-tuned `Springiness` for flyout entry/exit.
- **Connected Animations**: Use the Community Toolkit `AttachedProperties` for smooth transitions between media session views.

## 3. Implementation Patterns

- **Resource Management**: Use the new `ThemeMode` property in .NET 9 combined with `iNKORE`'s `ThemeResources`.
- **Typography**: Force `Segoe UI Variable` globally.
- **Geometry**: Standardize on **8px** corner radius for main flyout and **4px** for buttons.

## 4. References

- [[docs/090-Archive/developer_guide.md|Original Developer Guide]]
- [Microsoft Design Guidelines 2026]
- [iNKORE GitHub Repository]
