//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Gameplay.Game.Features.Collision.Components.CollisionIdComponent collisionId { get { return (Gameplay.Game.Features.Collision.Components.CollisionIdComponent)GetComponent(GameComponentsLookup.CollisionId); } }
    public bool hasCollisionId { get { return HasComponent(GameComponentsLookup.CollisionId); } }

    public void AddCollisionId(int newValue) {
        var index = GameComponentsLookup.CollisionId;
        var component = (Gameplay.Game.Features.Collision.Components.CollisionIdComponent)CreateComponent(index, typeof(Gameplay.Game.Features.Collision.Components.CollisionIdComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceCollisionId(int newValue) {
        var index = GameComponentsLookup.CollisionId;
        var component = (Gameplay.Game.Features.Collision.Components.CollisionIdComponent)CreateComponent(index, typeof(Gameplay.Game.Features.Collision.Components.CollisionIdComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveCollisionId() {
        RemoveComponent(GameComponentsLookup.CollisionId);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCollisionId;

    public static Entitas.IMatcher<GameEntity> CollisionId {
        get {
            if (_matcherCollisionId == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CollisionId);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCollisionId = matcher;
            }

            return _matcherCollisionId;
        }
    }
}
