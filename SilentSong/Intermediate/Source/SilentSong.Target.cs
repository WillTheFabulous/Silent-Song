using UnrealBuildTool;

public class SilentSongTarget : TargetRules
{
	public SilentSongTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("SilentSong");
	}
}
