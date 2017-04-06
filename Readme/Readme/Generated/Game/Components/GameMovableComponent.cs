//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly MovableComponent movableComponent = new MovableComponent();

    public bool isMovable {
        get { return HasComponent(GameComponentsLookup.Movable); }
        set {
            if(value != isMovable) {
                if(value) {
                    AddComponent(GameComponentsLookup.Movable, movableComponent);
                } else {
                    RemoveComponent(GameComponentsLookup.Movable);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.Core.IMatcher<GameEntity> _matcherMovable;

    public static Entitas.Core.IMatcher<GameEntity> Movable {
        get {
            if(_matcherMovable == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Movable);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMovable = matcher;
            }

            return _matcherMovable;
        }
    }
}
