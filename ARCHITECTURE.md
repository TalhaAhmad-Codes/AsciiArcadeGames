
# Architecture (Example)

```py
ArcadeGames/
│
├── Engine/                    # Core engine (reusable)
│   ├── Core/                  # Game loop, base classes
│   ├── Rendering/             # Console rendering logic
│   ├── Input/                 # Keyboard handling
│   ├── Physics/               # (optional) movement/collision
│   └── Utils/                 # Helpers
│
├── Games/                     # Each game is isolated
│   ├── Snake/
│   │   ├── SnakeGame.cs
│   │   ├── SnakeLogic.cs
│   │   └── SnakeRenderer.cs
│   │
│   ├── Pong/
│   └── Tetris/
│
├── Core/                      # Shared abstractions
│   ├── Interfaces/
│   │   ├── IGame.cs
│   │   ├── IRenderer.cs
│   │   └── IInputHandler.cs
│   └── Enums/
│
├── Infrastructure/            # External stuff
│   ├── Data/
│   │   ├── GameDbContext.cs
│   │   └── Repositories/
│   └── Services/
│       └── SaveLoadService.cs
│
├── UI/                        # Menus, navigation
│   └── MenuManager.cs
│
└── Program.cs                 # Entry point (very thin)
```
