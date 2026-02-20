# Task Breakdown: Fluent Design 2 Modernization

This document breaks down the modernization into atomic, manageable tasks.

## 1. Foundation & Dependencies (P0)

- [x] Task 1.1: Removal of legacy `ModernWpfUI` packages from all projects.
- [x] Task 1.2: Addition of `iNKORE.UI.WPF.Modern` NuGet package.
- [x] Task 1.3: Update global xmlns namespaces in all XAML files (Search & Replace).
- [x] Task 1.4: Update C# namespace imports (`using ModernWpf;` to `using iNKORE.UI.WPF.Modern;`).
- [x] Task 1.5: Initialize `ThemeResources` and `XamlControlsResources` in `App.xaml`.
- [x] Task 1.6: Set `Segoe UI Variable` as the global font in `App.xaml`.

## 2. Window Branding & Materials (P0)

- [x] Task 2.1: Implement Mica backdrop in `SettingsWindow.xaml`.
- [x] Task 2.2: Implement Mica/Mica Alt materials in `FlyoutWindow.cs`.
- [x] Task 2.3: Verify interop transparency in `BandWindow.cs`.

## 3. UI Refinement (P1)

- [/] Task 3.1: Standardize `FlyoutView.xaml` corner radius to 8px.
- [ ] Task 3.2: Update control brushes to Fluent 2 color tokens in `App.xaml`.
- [ ] Task 3.3: Replace legacy SegMDL2 icons with Fluent System Icons in primary flyouts.
- [x] Task 3.4: Resolve XAML/C# compilation errors caused by iNKORE namespace restructures.

## 4. Animation & Interactions (P1)

- [ ] Task 4.1: Implement `ElasticEase` animations for Flyout entry/exit.
- [ ] Task 4.2: Add subtle "Press" and "Hover" scaling effects to flyout items.

## 5. Verification & Testing

- [ ] Task 5.1: Regression test for all Flyout types (Audio, Media, etc.).
- [ ] Task 5.2: Verify Windows 10 vs Windows 11 visual fallbacks.
- [ ] Task 5.3: Performance audit (CPU/GPU usage with materials).
