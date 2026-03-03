using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Friend;

[Token(Token = "0x2000DBF")]
public class BlockContextCollection : PlayerContextCollection, IReadOnlyDictionary<long, BlockPlayerContext>, IEnumerable<KeyValuePair<long, BlockPlayerContext>>, IEnumerable, IReadOnlyCollection<KeyValuePair<long, BlockPlayerContext>>
{
	[Token(Token = "0x400A04C")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<long, BlockPlayerContext> m_PlayerContextMap;

	[Token(Token = "0x17000BF5")]
	private IEnumerable<long> System_002ECollections_002EGeneric_002EIReadOnlyDictionary_003CSystem_002EInt64_002CYgomGame_002EFriend_002EBlockPlayerContext_003E_002EKeys
	{
		[Token(Token = "0x6005279")]
		[Address(RVA = "0x97E1F0", Offset = "0x97D3F0", VA = "0x18097E1F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BF6")]
	private IEnumerable<BlockPlayerContext> System_002ECollections_002EGeneric_002EIReadOnlyDictionary_003CSystem_002EInt64_002CYgomGame_002EFriend_002EBlockPlayerContext_003E_002EValues
	{
		[Token(Token = "0x600527A")]
		[Address(RVA = "0x97E240", Offset = "0x97D440", VA = "0x18097E240", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BF7")]
	private int System_002ECollections_002EGeneric_002EIReadOnlyCollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EInt64_002CYgomGame_002EFriend_002EBlockPlayerContext_003E_003E_002ECount
	{
		[Token(Token = "0x600527B")]
		[Address(RVA = "0x97E140", Offset = "0x97D340", VA = "0x18097E140", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000BF8")]
	private BlockPlayerContext System_002ECollections_002EGeneric_002EIReadOnlyDictionary_003CSystem_002EInt64_002CYgomGame_002EFriend_002EBlockPlayerContext_003E_002EItem
	{
		[Token(Token = "0x600527C")]
		[Address(RVA = "0x97E190", Offset = "0x97D390", VA = "0x18097E190", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600527D")]
	[Address(RVA = "0x97DC80", Offset = "0x97CE80", VA = "0x18097DC80")]
	public void Import(IReadOnlyDictionary<string, object> followPlayers)
	{
	}

	[Token(Token = "0x600527E")]
	[Address(RVA = "0x97E060", Offset = "0x97D260", VA = "0x18097E060")]
	public void Sort()
	{
	}

	[Token(Token = "0x600527F")]
	[Address(RVA = "0x97DC20", Offset = "0x97CE20", VA = "0x18097DC20", Slot = "8")]
	public bool ContainsKey(long key)
	{
		return default(bool);
	}

	[Token(Token = "0x6005280")]
	[Address(RVA = "0x97E290", Offset = "0x97D490", VA = "0x18097E290", Slot = "9")]
	public bool TryGetValue(long key, out BlockPlayerContext value)
	{
		return default(bool);
	}

	[Token(Token = "0x6005281")]
	[Address(RVA = "0x97E0B0", Offset = "0x97D2B0", VA = "0x18097E0B0", Slot = "14")]
	private IEnumerator<KeyValuePair<long, BlockPlayerContext>> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EInt64_002CYgomGame_002EFriend_002EBlockPlayerContext_003E_003E_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6005282")]
	[Address(RVA = "0x97E300", Offset = "0x97D500", VA = "0x18097E300")]
	public BlockContextCollection()
	{
	}
}
