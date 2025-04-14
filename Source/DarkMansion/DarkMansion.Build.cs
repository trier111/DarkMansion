// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class DarkMansion : ModuleRules
{
	public DarkMansion(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
