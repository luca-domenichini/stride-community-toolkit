# Create Project

## Command Line and Visual Studio Code Instructions

The following instructions will guide you through creating a new Stride project using the command line. If you prefer to use Visual Studio Code, you can follow the same steps in the Visual Studio Code Terminal.

> [!Note]
> These instructions are intended for Windows users. While we have successfully build and run code-only projects on Linux, the [setup process is currently more complex](https://github.com/stride3d/stride/issues/2596). We are working on simplifying the process and will provide instructions in the future.

1. **Prerequisites:** Ensure you have all the prerequisites installed. Refer to the [Prerequisites](../getting-started.md) section for more information.
1. **Create a Console App:** Follow the [Microsoft tutorial](https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-6-0) to learn more about creating a new console application. Use the following command:
   ```
   dotnet new console --framework net8.0 --name YourProjectName
   ```
1. **Add NuGet Package:** Execute the following command to add the necessary NuGet package.
   ```
   dotnet add package Stride.CommunityToolkit.Windows --prerelease
   ```
1. **Add NuGet Package:** Execute the following command to add the Physics package.
   ```
   dotnet add package Stride.CommunityToolkit.Bepu --prerelease
   ```
1. **Update Program.cs:** Paste the [example code](#example-code) provided below into your `Program.cs` file.
1. **Build the Project (Optional):** The `dotnet build` command is used to compile your Stride project, generating executable files and checking for any errors in your code. This step is optional as the subsequent `dotnet run` command will automatically build the project if it hasn't been built already. To manually build the project, execute the following command:
   ```bash
   dotnet build
   ```
1. **Run the Project:** The `dotnet run` command will build (if necessary) and execute your project. Run the following command to start your Stride project:

   ```
   dotnet run
   ```
1. **Enjoy Stride:** If everything is set up correctly, you should now be able to run and enjoy your Stride project.

## Visual Studio 2022 and Rider Instructions
 
1. **Create a C# Console Application:** Open Visual Studio 2022 or Rider and create a new C# Console Application targeting .NET 8.
1. **Add NuGet Package:** Search for and add the `Stride.CommunityToolkit.Windows` NuGet package, ensuring you opt for the pre-release version.
   - This package will add all the necessary Stride NuGet packages.
1. **Add NuGet Package:** Search for and add the `Stride.CommunityToolkit.Bepu` NuGet package, ensuring you opt for the pre-release version.
   - This package will add the Bepu Physics library to your project.
1. **Update Program.cs:** Paste the example code (provided below) into your `Program.cs` file.
1. **Run the Project:** Build and run your project using the IDE's run functionality.
1. **Enjoy Stride:** If everything is set up correctly, you should now be able to run and enjoy your Stride project.

## Example Code

The provided C# code example demonstrates the basic usage of the Stride Game Engine.

```csharp
using Stride.CommunityToolkit.Bepu;
using Stride.CommunityToolkit.Engine;
using Stride.CommunityToolkit.Rendering.ProceduralModels;
using Stride.Core.Mathematics;
using Stride.Engine;

using var game = new Game();

game.Run(start: Start);

void Start(Scene rootScene)
{
    game.SetupBase3DScene();

    var entity = game.Create3DPrimitive(PrimitiveModelType.Capsule);

    entity.Transform.Position = new Vector3(0, 8, 0);

    entity.Scene = rootScene;
}
```

1. `using var game = new Game();` creates a new instance of the `Game` class.
1. The `game.Run(start: Start);` line starts the game, and it specifies that the `Start` method should be called when the game begins.
1. `void Start(Scene rootScene)` is the method that is called when the game starts. It takes in a `Scene` object, which represents the game scene that is currently being played.
1. Inside the `Start` method, `game.SetupBase3DScene();` sets up a basic 3D scene.
1. `var entity = game.Create3DPrimitive(PrimitiveModelType.Capsule);` creates a new primitive entity of type `Capsule`, and assigns it to the `entity` variable.
1. `entity.Transform.Position = new Vector3(0, 8, 0);` sets the position of the entity in the 3D space. The position is set to (0, 8, 0), which means the capsule is placed 8 units above the ground.
1. `entity.Scene = rootScene;` adds the entity to the root scene of the game. This step is crucial because assigning the entity to the scene ensures it is rendered and visible in the game. Without this assignment, the entity would not be part of the scene graph, and therefore, it would not appear in the game.

The `Create3DPrimitive()` method creates a Capsule with [rigid body physics](https://doc.stride3d.net/latest/en/manual/physics/rigid-bodies.html). Since the capsule is placed 8 units above the ground, it will fall due to gravity. 

> [!TIP]
> It's important to remove the capsule from memory once it's no longer visible in the scene to free up resources and ensure the CPU isn't unnecessarily calculating physics for it.

![image](https://user-images.githubusercontent.com/4528464/180097697-8352e30c-3750-42f1-aef9-ecd6c8e6255e.png)

## Additional Examples

Explore more examples listed in the menu on the left, categorized by programming language and level of complexity. These examples provide a deeper understanding of how to work with a code-only project in Stride, showcasing various functionalities and implementations.

The examples are organized under the following sections:

- [C# Basic Examples](examples/basic-examples.md): Basic examples demonstrating fundamental concepts using C#.
- [C# Advanced Examples](examples/advance-examples.md): Advanced scenarios and implementations using C#.
- [F# Basic Examples](examples/basic-examples-fs.md): Fundamental concepts demonstrated using F#.
- [VB Basic Examples](examples/basic-examples-vb.md): Fundamental concepts demonstrated using Visual Basic.

To view an example, click on its name in the menu, and you will be navigated to a page with a detailed explanation and code snippets.
