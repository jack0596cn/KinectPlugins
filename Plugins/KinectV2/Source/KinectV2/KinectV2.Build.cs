//------------------------------------------------------------------------------
// 
//     The Kinect for Windows APIs used here are preliminary and subject to change
// 
//------------------------------------------------------------------------------
using System.IO;

namespace UnrealBuildTool.Rules
{
    public class KinectV2 : ModuleRules
    {
        //public KinectV2(TargetInfo Target)
        public KinectV2(ReadOnlyTargetRules Target) : base(Target)
        {
            PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

            PrivateIncludePaths.Add(Path.Combine(ModuleDirectory, "Private"));

            PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Public"));

            PublicDependencyModuleNames.AddRange(
                new string[]
			    {
                   	
                    "CoreUObject",				
                    "Core",
                    "Engine",
                    "InputDevice",
                    //"MSSpeech",
                    "InputCore",
                        "K4WLib",
                        //"AnimGraphRuntime", "UnrealEd", "KismetWidgets", "KismetCompiler", "BlueprintGraph", "GraphEditor", "Kismet"
                    // "Slate"
				    // ... add other public dependencies that you statically link with here ...
                    //"Core", "CoreUObject", "InputCore", "Slate", "Engine", "AssetTools", "UnrealEd", // for FAssetEditorManager "KismetWidgets", "KismetCompiler", "BlueprintGraph", "GraphEditor", "Kismet", // for FWorkflowCentricApplication "PropertyEditor", "EditorStyle", "Slate", "SlateCore", "Sequencer", "DetailCustomizations", "Settings", "RenderCore",
			    }
                );

            PrivateDependencyModuleNames.AddRange(
                new string[]
			    { 
                    "CoreUObject",
				    "Core",
                    "Engine",
                    "InputDevice",
				    // ... add private dependencies that you statically link with here ...
			    }
                );





            /// AddThirdPartyPrivateStaticDependencies(Target, "K4WLib");

            /*   if (UEBuildConfiguration.bBuildEditor == true)
            {
                //@TODO: Needed for the triangulation code used for sprites (but only in editor mode)
                //@TOOD: Try to move the code dependent on the triangulation code to the editor-only module
                //  PrivateDependencyModuleNames.AddRange(new string [] {"UnrealEd","ContentBrowser"});
            } */


        }
    }
}