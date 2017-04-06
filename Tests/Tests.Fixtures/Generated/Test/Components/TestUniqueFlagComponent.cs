//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestContext {

    public TestEntity uniqueFlagEntity { get { return GetGroup(TestMatcher.UniqueFlag).GetSingleEntity(); } }

    public bool isUniqueFlag {
        get { return uniqueFlagEntity != null; }
        set {
            var entity = uniqueFlagEntity;
            if(value != (entity != null)) {
                if(value) {
                    CreateEntity().isUniqueFlag = true;
                } else {
                    DestroyEntity(entity);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    static readonly UniqueFlagComponent uniqueFlagComponent = new UniqueFlagComponent();

    public bool isUniqueFlag {
        get { return HasComponent(TestComponentsLookup.UniqueFlag); }
        set {
            if(value != isUniqueFlag) {
                if(value) {
                    AddComponent(TestComponentsLookup.UniqueFlag, uniqueFlagComponent);
                } else {
                    RemoveComponent(TestComponentsLookup.UniqueFlag);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher {

    static Entitas.Core.IMatcher<TestEntity> _matcherUniqueFlag;

    public static Entitas.Core.IMatcher<TestEntity> UniqueFlag {
        get {
            if(_matcherUniqueFlag == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentsLookup.UniqueFlag);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherUniqueFlag = matcher;
            }

            return _matcherUniqueFlag;
        }
    }
}
