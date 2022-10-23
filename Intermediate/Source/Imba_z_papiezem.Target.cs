using UnrealBuildTool;

public class Imba_z_papiezemTarget : TargetRules
{
	public Imba_z_papiezemTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Imba_z_papiezem");
	}
}
