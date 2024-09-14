using System.Numerics;
using Content.Shared.Alert;
using Content.Shared.FixedPoint;
using Content.Shared.Store;
using Content.Shared.Whitelist;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Shared.PAI;

[RegisterComponent, NetworkedComponent]
public sealed partial class PAIAbilitiesComponent : Component
{

    [DataField] public EntityUid? Action;
}

