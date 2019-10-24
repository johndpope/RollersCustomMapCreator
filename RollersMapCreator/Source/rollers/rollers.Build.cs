// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class rollers : ModuleRules
{
	public rollers(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" , "Steamworks" ,"UMG","OnlineSubsystemUtils",                                                              "Slate", "SlateCore", "HTTP", "Json", "JsonUtilities", "MoviePlayer",
                                                             "PakFile", "Sockets","StreamingFile",  "NetworkFile",
                                                               });

		PrivateDependencyModuleNames.AddRange(new string[] { "PakFile", "StreamingFile", "NetworkFile" });

        DynamicallyLoadedModuleNames.Add("OnlineSubsystemSteam");

        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        //PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
    }
}

