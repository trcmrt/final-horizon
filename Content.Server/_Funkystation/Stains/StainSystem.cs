using Content.Shared._Funkystation.Stains.Components;
using Content.Shared._Funkystation.Stains.Systems;
using Content.Shared.Chemistry.Components;
using Content.Shared.Tag;
using Robust.Shared.Prototypes;

namespace Content.Server._Funkystation.Stains;

public sealed class StainSystem : SharedStainSystem
{
    [Dependency] private readonly TagSystem _tag = null!;
    private static readonly ProtoId<TagPrototype> DNASolutionScannable = "DNASolutionScannable"; // FH Fix literal value

    protected override void OnStained(Entity<StainableComponent> ent, Entity<SolutionComponent> solution)
    {
        base.OnStained(ent, solution);

        _tag.AddTag(ent.Owner, DNASolutionScannable); // FH Fix literal value
    }
}
