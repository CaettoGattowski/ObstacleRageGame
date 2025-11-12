// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ObstacleRageCourse : ModuleRules
{
	public ObstacleRageCourse(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ObstacleRageCourse",
			"ObstacleRageCourse/Variant_Platforming",
			"ObstacleRageCourse/Variant_Platforming/Animation",
			"ObstacleRageCourse/Variant_Combat",
			"ObstacleRageCourse/Variant_Combat/AI",
			"ObstacleRageCourse/Variant_Combat/Animation",
			"ObstacleRageCourse/Variant_Combat/Gameplay",
			"ObstacleRageCourse/Variant_Combat/Interfaces",
			"ObstacleRageCourse/Variant_Combat/UI",
			"ObstacleRageCourse/Variant_SideScrolling",
			"ObstacleRageCourse/Variant_SideScrolling/AI",
			"ObstacleRageCourse/Variant_SideScrolling/Gameplay",
			"ObstacleRageCourse/Variant_SideScrolling/Interfaces",
			"ObstacleRageCourse/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
