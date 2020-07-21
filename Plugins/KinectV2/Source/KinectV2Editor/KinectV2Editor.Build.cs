using System.IO;
using UnrealBuildTool;

public class KinectV2Editor : ModuleRules
{
    public KinectV2Editor(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PrivateIncludePaths.Add(Path.Combine(ModuleDirectory, "Private"));

        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Public"));

        PublicDependencyModuleNames.AddRange(
            new string[] { 
				"Core", 
				"CoreUObject", 
				"Engine", 
				"Slate",
				"BlueprintGraph",
                "AnimGraph",
                "AnimGraphRuntime",
                "KinectV2"
			}
        );

        PrivateDependencyModuleNames.AddRange(
            new string[] {
				"SlateCore",
				"UnrealEd",
                "GraphEditor",
			}
        );

        /*CircularlyReferencedDependentModules.AddRange(
            new string[] {
                "UnrealEd",
                "GraphEditor",
            }
        ); */

    }
}