using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Friend;

[Token(Token = "0x2000DC9")]
public class PlayerContextCollection : IReadOnlyList<IPlayerContext>, IEnumerable<IPlayerContext>, IEnumerable, IReadOnlyCollection<IPlayerContext>
{
	[Token(Token = "0x400A06F")]
	[FieldOffset(Offset = "0x10")]
	protected readonly List<IPlayerContext> m_PlayerContexts;

	[Token(Token = "0x17000C2B")]
	public IPlayerContext this[int index]
	{
		[Token(Token = "0x60052EB")]
		[Address(RVA = "0x994380", Offset = "0x993580", VA = "0x180994380", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C2C")]
	public int Count
	{
		[Token(Token = "0x60052EC")]
		[Address(RVA = "0x994340", Offset = "0x993540", VA = "0x180994340", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60052ED")]
	[Address(RVA = "0x9941C0", Offset = "0x9933C0", VA = "0x1809941C0", Slot = "6")]
	public IEnumerator<IPlayerContext> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60052EE")]
	[Address(RVA = "0x994240", Offset = "0x993440", VA = "0x180994240", Slot = "7")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60052EF")]
	[Address(RVA = "0x9942C0", Offset = "0x9934C0", VA = "0x1809942C0")]
	public PlayerContextCollection()
	{
	}
}
