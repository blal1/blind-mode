using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Mission;

[Token(Token = "0x2000BF9")]
public class GoalContext
{
	[Token(Token = "0x4009949")]
	[FieldOffset(Offset = "0x10")]
	public readonly int idx;

	[Token(Token = "0x400994A")]
	[FieldOffset(Offset = "0x14")]
	public readonly int requirement;

	[Token(Token = "0x400994B")]
	[FieldOffset(Offset = "0x18")]
	public readonly bool isPeriod;

	[Token(Token = "0x400994C")]
	[FieldOffset(Offset = "0x1C")]
	public readonly int itemCategory;

	[Token(Token = "0x400994D")]
	[FieldOffset(Offset = "0x20")]
	public readonly int itemId;

	[Token(Token = "0x400994E")]
	[FieldOffset(Offset = "0x24")]
	public readonly int itemCount;

	[Token(Token = "0x400994F")]
	[FieldOffset(Offset = "0x28")]
	public bool isRewardUnlocked;

	[Token(Token = "0x4009950")]
	[FieldOffset(Offset = "0x29")]
	public bool recievedIconVisible;

	[Token(Token = "0x60048D9")]
	[Address(RVA = "0x919030", Offset = "0x918230", VA = "0x180919030")]
	public MissionGoalWidget.GoalType GetGoalType(MissionContext missionContext)
	{
		return default(MissionGoalWidget.GoalType);
	}

	[Token(Token = "0x60048DA")]
	[Address(RVA = "0x9190D0", Offset = "0x9182D0", VA = "0x1809190D0")]
	public GoalContext(int idx, Dictionary<string, object> data, Dictionary<string, object> master)
	{
	}

	[Token(Token = "0x60048DB")]
	[Address(RVA = "0x919070", Offset = "0x918270", VA = "0x180919070")]
	public void Import(Dictionary<string, object> data)
	{
	}
}
