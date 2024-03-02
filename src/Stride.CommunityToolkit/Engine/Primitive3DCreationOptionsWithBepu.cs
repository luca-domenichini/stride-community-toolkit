using Stride.BepuPhysics;
using Stride.BepuPhysics.Definitions.Colliders;

namespace Stride.CommunityToolkit.Engine;

/// <summary>
/// Provides options for creating a primitive entity in a 3D scene.
/// </summary>
public class Primitive3DCreationOptionsWithBepu : PrimitiveCreationOptions
{
    /// <summary>
    /// Gets or sets the size of the primitive model. If null, default dimensions are used.
    /// </summary>
    public Vector3? Size { get; set; }

    /// <summary>
    /// Gets or sets the physics component to be added to the entity.
    /// </summary>
    public ContainerComponent Component { get; set; } = new BodyComponent() { Collider = new CompoundCollider() };
}
