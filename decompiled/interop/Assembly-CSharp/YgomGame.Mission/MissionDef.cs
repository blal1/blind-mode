using Il2CppDummyDll;

namespace YgomGame.Mission;

[Token(Token = "0x2000BD1")]
public static class MissionDef
{
	[Token(Token = "0x4009873")]
	internal const int k_GoalPageCellMax = 5;

	[Token(Token = "0x4009874")]
	internal const int k_TemplateIdx_Default = 0;

	[Token(Token = "0x4009875")]
	internal const int k_TemplateIdx_Starting = 1;

	[Token(Token = "0x60047DB")]
	[Address(RVA = "0x8FDA80", Offset = "0x8FCC80", VA = "0x1808FDA80")]
	public static int GetTabIdxByCategory(MissionCategory category)
	{
		return default(int);
	}
}
