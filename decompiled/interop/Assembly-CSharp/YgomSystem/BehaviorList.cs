using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomSystem;

[Token(Token = "0x2000155")]
public class BehaviorList
{
	[Token(Token = "0x4000824")]
	[FieldOffset(Offset = "0x10")]
	private List<Behavior> _behaviors;

	[Token(Token = "0x4000825")]
	[FieldOffset(Offset = "0x18")]
	private HashSet<Behavior> _deleteList;

	[Token(Token = "0x6000884")]
	[Address(RVA = "0xAF1B50", Offset = "0xAF0D50", VA = "0x180AF1B50")]
	public void Register(Behavior b)
	{
	}

	[Token(Token = "0x6000885")]
	[Address(RVA = "0xAF1C00", Offset = "0xAF0E00", VA = "0x180AF1C00")]
	public void Update(float deltaTime)
	{
	}

	[Token(Token = "0x6000886")]
	[Address(RVA = "0xAF1A50", Offset = "0xAF0C50", VA = "0x180AF1A50")]
	public Behavior Find(string name)
	{
		return null;
	}

	[Token(Token = "0x6000887")]
	[Address(RVA = "0xAF19D0", Offset = "0xAF0BD0", VA = "0x180AF19D0")]
	public void AllKill()
	{
	}

	[Token(Token = "0x6000888")]
	[Address(RVA = "0xAF1EB0", Offset = "0xAF10B0", VA = "0x180AF1EB0")]
	public BehaviorList()
	{
	}
}
