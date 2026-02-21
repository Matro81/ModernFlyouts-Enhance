# Privacy Policy for ModernFlyouts Enhance

**Effective Date:** February 21, 2026

ModernFlyouts Enhance ("we," "our," or "the app") is an open-source Desktop application designed to replace the default Windows flyouts. We are committed to protecting your privacy. This Privacy Policy explains our practices regarding the collection, use, and disclosure of your information.

## 1. Information Collection and Use

**We do not collect, store, or transmit any personal data.**

ModernFlyouts Enhance operates entirely locally on your Windows machine. The application:

- **Does not** collect telemetry data.
- **Does not** track your usage habits.
- **Does not** collect or transmit your media history (e.g., songs played, videos watched).
- **Does not** require you to create an account or provide personal information.

## 2. External Services and Network Requests

While the app operates locally, it may make network requests in the following specific scenarios:

- **Update Checks**: If the "Auto-check for updates" feature is enabled in the app's settings, ModernFlyouts Enhance will periodically connect to the GitHub API (api.github.com) to check for newer versions of the application. This request only contains basic information required by GitHub (such as your IP address and user-agent) to facilitate the connection.
- **Media Album Art**: When displaying media controls, the application reads the album art metadata provided by the Windows operating system (via `GlobalSystemMediaTransportControlsSessionManager`). If the media source (e.g., Spotify, web browser) provides an external URL for the album art instead of a local file, the app may download that image directly to display it.

We do not track or log these requests.

## 3. Open Source Transparency

ModernFlyouts Enhance is fully open-source. Anyone can review our source code to verify that the application behaves exactly as described in this policy. You can inspect the code at our official repository: [https://github.com/Matro81/ModernFlyouts-Enhance](https://github.com/Matro81/ModernFlyouts-Enhance).

## 4. Changes to This Privacy Policy

We may update our Privacy Policy from time to time. If any changes occur that affect how your data is handled, we will notify you by updating this page and revising the "Effective Date" at the top.

## 5. Contact Us

If you have any questions or suggestions about our Privacy Policy, please open an issue on our GitHub repository:
[https://github.com/Matro81/ModernFlyouts-Enhance/issues](https://github.com/Matro81/ModernFlyouts-Enhance/issues)
