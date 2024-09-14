using System.Numerics;
using Content.Server.Actions;
using Content.Server.GameTicking;
using Content.Server.Store.Components;
using Content.Server.Store.Systems;
using Content.Shared.Alert;
using Content.Shared.Damage;
using Content.Shared.DoAfter;
using Content.Shared.Examine;
using Content.Shared.Eye;
using Content.Shared.FixedPoint;
using Content.Shared.Interaction;
using Content.Shared.Maps;
using Content.Shared.Mobs.Systems;
using Content.Shared.Physics;
using Content.Shared.Popups;
using Content.Shared.Revenant;
using Content.Shared.Revenant.Components;
using Content.Shared.StatusEffect;
using Content.Shared.Store.Components;
using Content.Shared.Stunnable;
using Content.Shared.Tag;
using Robust.Server.GameObjects;
using Robust.Shared.Prototypes;
using Robust.Shared.Random;
using Content.Shared.PAI;


namespace Content.Server.PAI.PAIAbilities;

public sealed partial class PAIAbilitiesSystem : EntitySystem
{
    [Dependency] private readonly StoreSystem _store = default!;
    [Dependency] private readonly ActionsSystem _action = default!;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<PAIAbilitiesComponent, PAIShopActionEvent>(OnShop);
        SubscribeLocalEvent<PAIAbilitiesComponent, PAIDirectivesActionEvent>(OpenDirectivesAction);
    }

    private void OnShop(EntityUid uid, PAIAbilitiesComponent component, PAIShopActionEvent args)
    {
        if (!TryComp<StoreComponent>(uid, out var store))
            return;
        _store.ToggleUi(uid, uid, store);
    }

    private void OpenDirectivesAction(EntityUid uid, PAIAbilitiesComponent component, PAIDirectivesActionEvent args)
    {
        if (!TryComp<PAIComponent>(uid, out var pai))
            return;

    }
}

