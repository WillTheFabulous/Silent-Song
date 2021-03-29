// No.

using UnrealBuildTool;
using System.Collections.Generic;

public class ArthursAudioBPsTarget : TargetRules
{
	public ArthursAudioBPsTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "ArthursAudioBPs" } );
	}
}
