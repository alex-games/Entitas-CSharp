//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly GameBoardElementComponent gameBoardElementComponent = new GameBoardElementComponent();

    public bool isGameBoardElement {
        get { return HasComponent(GameComponentsLookup.GameBoardElement); }
        set {
            if(value != isGameBoardElement) {
                if(value) {
                    AddComponent(GameComponentsLookup.GameBoardElement, gameBoardElementComponent);
                } else {
                    RemoveComponent(GameComponentsLookup.GameBoardElement);
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

    static Entitas.Core.IMatcher<GameEntity> _matcherGameBoardElement;

    public static Entitas.Core.IMatcher<GameEntity> GameBoardElement {
        get {
            if(_matcherGameBoardElement == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GameBoardElement);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGameBoardElement = matcher;
            }

            return _matcherGameBoardElement;
        }
    }
}
