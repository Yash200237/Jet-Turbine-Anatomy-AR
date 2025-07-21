# Jet Turbine Anatomy AR

An interactive Augmented Reality (AR) application built with Unity that provides an immersive educational experience for learning about jet turbine anatomy and components.

## 📱 App Screenshots

### Home Screen
<img src="Docs/HomeScreen.jpg" alt="Home Screen" width="300" height="500">

*Clean and intuitive home interface with easy navigation to start the AR simulation*

### AR Simulation in Action
<img src="Docs/ARScene.jpg" alt="AR Scene" width="300" height="500">

*Interactive 3D jet turbine model placed in real environment through AR*

### Live Demo
<img src="Docs/Demo.gif" alt="Demo" width="300" height="500">

*Real-time demonstration of the AR experience and component interaction*

## 🎯 Overview

This AR application allows users to visualize and interact with a detailed 3D model of a jet turbine in augmented reality. Users can explore different components, toggle visibility of parts, and gain a deeper understanding of how jet turbines work - making it an excellent educational tool for engineering students, aviation enthusiasts, and professionals.

## ✨ Features

- **Interactive 3D Model**: Detailed jet turbine model with individually selectable components
- **Component Toggling**: Show/hide specific parts to understand internal structure
- **AR Visualization**: View the turbine in your real environment through AR
- **Educational Interface**: Clean and intuitive UI designed for learning
- **Scene Management**: Smooth navigation between home screen and simulation
- **Real-time Interaction**: Touch controls for seamless component exploration

## 🛠️ Technical Stack

- **Engine**: Unity 3D
- **Platform**: Android (ARCore)
- **AR Framework**: Unity XR Foundation & ARCore XR Plugin
- **Language**: C#
- **UI**: Unity UI & TextMeshPro

## 📋 Requirements

### Minimum System Requirements
- **Android**: 7.0 (API level 24) or higher
- **RAM**: 3GB minimum, 4GB recommended
- **Storage**: 500MB free space
- **Camera**: Rear-facing camera required for AR functionality
- **ARCore**: Device must support ARCore ([Check compatibility](https://developers.google.com/ar/devices))

### Development Requirements
- Unity 2021.3 LTS or later
- Android SDK
- ARCore XR Plugin
- Visual Studio or similar IDE

## 🚀 Installation

### For Users
1. Download the APK from the releases section
2. Enable "Install from Unknown Sources" in Android settings
3. Install the APK on your ARCore-compatible device
4. Launch the app and follow on-screen instructions

### For Developers
1. Clone the repository:
   ```bash
   git clone https://github.com/Yash200237/Jet-Turbine-Anatomy-AR.git
   ```
2. Open the project in Unity (2021.3 LTS or later)
3. Install required packages via Package Manager:
   - AR Foundation
   - ARCore XR Plugin
   - TextMeshPro
4. Build and deploy to your Android device

## 🎮 How to Use

1. **Launch the App**: Open the application on your device (see Home Screen above)
2. **Start Simulation**: Tap "Start Simulation" from the clean home interface
3. **AR Setup**: Point your camera at a flat surface and wait for plane detection
4. **Place Model**: Tap on the detected surface to place the jet turbine model
5. **Interact**: Use the UI buttons to toggle different turbine components (as shown in AR Scene)
6. **Explore**: Move around the model to view it from different angles

## 🏗️ Project Structure

```
Jet Turbine Simulation/
├── Assets/
│   ├── Scripts/
│   │   ├── MeshToggler.cs      # Handles component visibility toggling
│   │   └── SceneController.cs   # Manages scene transitions
│   ├── Models/                  # 3D jet turbine models and components
│   ├── Materials/              # Materials and shaders
│   ├── Scenes/                 # Unity scenes (Home, JetTurbine)
│   └── UI/                     # User interface elements
├── Packages/                   # Unity package dependencies
└── Docs/                       # Documentation and demo files
    ├── HomeScreen.jpg          # Home screen interface
    ├── ARScene.jpg             # AR simulation screenshot
    └── Demo.gif                # Live demonstration
```

## 🔧 Key Components

### Scripts
- **MeshToggler.cs**: Controls the visibility of individual turbine components
- **SceneController.cs**: Manages navigation between different scenes and app lifecycle

### Core Features
- **Component Isolation**: Each turbine part can be toggled independently
- **AR Tracking**: Stable placement and tracking of the 3D model
- **Intuitive Controls**: Simple tap-to-toggle interface
- **Professional UI**: Clean design optimized for educational use

## 🌟 Educational Applications

This AR application is particularly valuable for:

- **Engineering Education**: Visualizing complex mechanical systems in 3D space
- **Aviation Training**: Understanding jet engine components and assembly
- **STEM Learning**: Interactive 3D models enhance comprehension and retention
- **Technical Presentations**: Professional demonstrations of turbine technology
- **Self-Directed Learning**: Explore at your own pace with intuitive controls
- **Classroom Integration**: Perfect for interactive lessons and group learning

## 🚀 Future Enhancement Opportunities

This project can be extended with additional features:

### Educational Enhancements
- **Component Information**: Detailed descriptions and specifications for each part
- **Animation System**: Show turbine operation and airflow visualization
- **Assembly Mode**: Step-by-step assembly/disassembly process
- **Multiple Engine Types**: Different turbine designs (turbofan, turbojet, turboprop)
- **Cutaway Views**: Internal component visualization
- **Performance Metrics**: Real-time data display during operation

### Technical Improvements
- **Multi-language Support**: Localization for global educational use
- **Voice Narration**: Audio explanations for enhanced learning
- **Quiz System**: Interactive assessments and knowledge testing
- **Progress Tracking**: Save user progress and learning milestones
- **Offline Mode**: Download content for use without internet
- **Cloud Sync**: Save progress across devices

### Platform Expansion
- **iOS Support**: ARKit implementation for iPhone/iPad users
- **Web AR**: Browser-based version for wider accessibility
- **VR Mode**: Virtual reality support for immersive experiences
- **Cross-platform**: Windows Mixed Reality and other AR platforms
- **Desktop Version**: Non-AR version for computers and tablets

### Advanced Features
- **Collaborative Mode**: Multiple users viewing the same model
- **Remote Teaching**: Teacher-student interaction capabilities
- **3D Printing Integration**: Export models for physical prototypes
- **Simulation Mode**: Working turbine with realistic physics

## 🤝 Contributing

Contributions are welcome! Here's how you can help:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

### Areas for Contribution
- New turbine models and components
- Educational content and animations
- UI/UX improvements
- Performance optimizations
- Documentation and tutorials
- Localization and accessibility features

## 📄 License

This project is available for educational and non-commercial use. Please see the LICENSE file for more details.

## 👨‍💻 Author

**Yash** - [@Yash200237](https://github.com/Yash200237)

## 📞 Support

If you have questions or need support:
- Open an issue on GitHub
- Project Link: [https://github.com/Yash200237/Jet-Turbine-Anatomy-AR](https://github.com/Yash200237/Jet-Turbine-Anatomy-AR)

## 🙏 Acknowledgments

- Unity Technologies for the development platform
- Google for ARCore technology
- The open-source community for inspiration and resources

---

**Educational Impact**: This AR application transforms traditional learning by making complex engineering concepts tangible and interactive, fostering better understanding and engagement in STEM education. The intuitive interface and realistic 3D visualization provide an unparalleled learning experience for students and professionals alike.

**Perfect for**: Universities, technical schools, aviation academies, engineering workshops, and anyone passionate about understanding how jet engines work.
