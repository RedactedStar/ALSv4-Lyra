using UnrealBuildTool;

public class ALS : ModuleRules
{
	public ALS(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_3;

		bEnableNonInlinedGenCppWarnings = true;
		
		PublicDependencyModuleNames.AddRange(new string[]
		{
			"LyraGame", "AIModule", "GameplayTags", "GameplayAbilities", "ModularGameplay", "ModularGameplayActors"
		});

		PrivateDependencyModuleNames.AddRange(new[]
		{
			"Core", "CoreUObject", "Engine", "NetCore", "PhysicsCore", "GameplayTags", "AnimGraphRuntime", "RigVM", "ControlRig", "Niagara", "LyraGame"
		});

		if (Target.Type == TargetRules.TargetType.Editor)
		{
			PrivateDependencyModuleNames.AddRange(new[] {"MessageLog"});
		}
	}
}