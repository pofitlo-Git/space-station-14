using Content.Server.Ghost.Roles;
using Content.Server.Ghost.Roles.Components;
using Content.Server.Instruments;
using Content.Server.Kitchen.Components;
using Content.Shared.Interaction.Events;
using Content.Shared.Mind.Components;
using Content.Shared.PAI;
using Content.Shared.Popups;
using Robust.Shared.Random;
using System.Text;
using Robust.Shared.Player;
using Content.Shared.UserInterface;
using Content.Shared.StatusIcon;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;

namespace Content.Server.Roles;
public sealed class RoleChangeNameSystem : EntitySystem
{
    [Dependency] private readonly MetaDataSystem _metaData = default!;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<RoleChangeNameComponent, MindAddedMessage>(OnMindAdded);

       // SubscribeLocalEvent<RoleChangeNameComponent, NameChangedMessage>(OnNameChanged);

    }

    private void OnMindAdded(EntityUid uid, RoleChangeNameComponent component, MindAddedMessage args)
    {
        var val = "TEST";
        _metaData.SetEntityName(uid, val);
    }

    //private void OnNameChanged(EntityUid uid, RoleChangeNameComponent comp, NameChangedMessage args)
    //{
    //    //if (!TryComp<IdCardComponent>(uid, out var idCard))
    //       // return;

    //    _metaData.SetEntityName(uid, args.Name);
    //}

}


