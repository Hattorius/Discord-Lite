# Discord Lite (Abandoned)
**Discord Lite** aimed to be a lightweight alternative to Discord, designed to reduce CPU usage and enhance performance. The primary focus was to create an efficient and resource-friendly chat application with a similar look and feel to the original Discord app, built on the Avalonia framework to support Windows, OSX, and Linux. However, the project was eventually abandoned for several reasons.

## Why Discord Lite?
Discord is known to consume CPU and memory resources, causing performance issues on some computers. Many users have experienced lag when running Discord alongside resource-intensive applications or games. This project was initiated to address these performenace concerns.

## Objectives
The core objectives of Discord Lite were as follows:
 - **Decrease Resource Usage**: Significantly reduce CPU and memory usage to ensure a smoother experience, particularly for users with less powerful hardware.
 - **User-Friendly Interface**: Maintain a user-friendly interface, resembling Discord as closely as possible, to make the transition to Discord Lite seamless for existing Discord users.

Please note that the primary goal of this project was to improve performance, not to introduce new features or provide ways to bypass Discord's premium Nitro features.

## Abandoned Due to Technical Challenges
### Login
Initially, the project aimed to provide an email and password login method similar to the Discord app. However, it was discovered that Discord uses hCaptcha for authentication. Due to the lack of cross-platform `WebView` controls for Avalonia, this approach was abandoned.

An alternative approach was considered, involving launching a headless session to solve hCaptcha puzzles and present the results to the user. Unfortunately, this method encountered obstacles, including hcatcha detection and ongoing changes in hCaptcha's encryption methods, making it an impractical solution.

To address these authentication challenges, the project would have needed to implement JA3 fingerprinting and TLS cipher spoofing. This would have allowed Discord Lite to bypass the hCaptcha checks. However, such methods could raise ethical and legal concerns. It should also be noted that implementing JA3 and TLS cipher spoofing would be a complex and sensitive task, especially in an open-source project. I had the concern that such implementation, once made open source, could potentially be used for unethical purposes or violate legal standards.

The final approach, which was considered redundant and not user-friendly, required users to manually copy and paste their Discord authentication token into the program.

### Performance
While Discord Lite did show promising results in reducing CPU usage by up to 70%, it exhibited a substantial spike in resource consumption (up to 3000% relative to Discord) during the login process. This spike made the application's performance unpredictable and less desirable.

## Why the Project Was Abandoned
In the end, Discord Lite was discontinued for the following reasons:
 - **Inadequate Performance Improvement**: Despite the initial goal of reducing CPU usage, the spike in resource consumption during login and data parsing negated the performance gains.
 - **Complex Authentication**: The need to require users to input their Discord token made the application less user-friendly and less secure.
 - **Hurdles with hCaptcha**: The evolving nature of hCaptcha encryption and the difficulty in implementing hCaptcha solving methods made the project impractical and unsustainable.

Although there were attempts and proof of concepts, it was concluded that continuing Discord Lite was not worth the effort.

*Please note that this project is abandoned and no longer maintained.*
