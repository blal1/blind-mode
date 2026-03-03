using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Friend;

[Token(Token = "0x2000DC1")]
public class FollowContextCollection : PlayerContextCollection, IReadOnlyDictionary<long, FollowPlayerContext>, IEnumerable<KeyValuePair<long, FollowPlayerContext>>, IEnumerable, IReadOnlyCollection<KeyValuePair<long, FollowPlayerContext>>
{
	[Token(Token = "0x400A04E")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<long, FollowPlayerContext> m_PlayerContextMap;

	[Token(Token = "0x17000BF9")]
	public IEnumerable<long> Keys
	{
		[Token(Token = "0x6005286")]
		[Address(RVA = "0x97F950", Offset = "0x97EB50", VA = "0x18097F950", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BFA")]
	private IEnumerable<FollowPlayerContext> System_002ECollections_002EGeneric_002EIReadOnlyDictionary_003CSystem_002EInt64_002CYgomGame_002EFriend_002EFollowPlayerContext_003E_002EValues
	{
		[Token(Token = "0x6005287")]
		[Address(RVA = "0x97F810", Offset = "0x97EA10", VA = "0x18097F810", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BFB")]
	private int System_002ECollections_002EGeneric_002EIReadOnlyCollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EInt64_002CYgomGame_002EFriend_002EFollowPlayerContext_003E_003E_002ECount
	{
		[Token(Token = "0x6005288")]
		[Address(RVA = "0x97F760", Offset = "0x97E960", VA = "0x18097F760", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000BFC")]
	private FollowPlayerContext System_002ECollections_002EGeneric_002EIReadOnlyDictionary_003CSystem_002EInt64_002CYgomGame_002EFriend_002EFollowPlayerContext_003E_002EItem
	{
		[Token(Token = "0x6005289")]
		[Address(RVA = "0x97F7B0", Offset = "0x97E9B0", VA = "0x18097F7B0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600528A")]
	[Address(RVA = "0x97F550", Offset = "0x97E750", VA = "0x18097F550")]
	public int SearchOnlineSum()
	{
		return default(int);
	}

	[Token(Token = "0x600528B")]
	[Address(RVA = "0x97F170", Offset = "0x97E370", VA = "0x18097F170")]
	public void Import(IReadOnlyDictionary<string, object> followPlayers)
	{
	}

	[Token(Token = "0x600528C")]
	[Address(RVA = "0x97F680", Offset = "0x97E880", VA = "0x18097F680")]
	public void Sort()
	{
	}

	[Token(Token = "0x600528D")]
	[Address(RVA = "0x97F110", Offset = "0x97E310", VA = "0x18097F110", Slot = "8")]
	public bool ContainsKey(long key)
	{
		return default(bool);
	}

	[Token(Token = "0x600528E")]
	[Address(RVA = "0x97F860", Offset = "0x97EA60", VA = "0x18097F860", Slot = "9")]
	public bool TryGetValue(long key, out FollowPlayerContext value)
	{
		return default(bool);
	}

	[Token(Token = "0x600528F")]
	[Address(RVA = "0x97F6D0", Offset = "0x97E8D0", VA = "0x18097F6D0", Slot = "14")]
	private IEnumerator<KeyValuePair<long, FollowPlayerContext>> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EInt64_002CYgomGame_002EFriend_002EFollowPlayerContext_003E_003E_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6005290")]
	[Address(RVA = "0x97F8D0", Offset = "0x97EAD0", VA = "0x18097F8D0")]
	public FollowContextCollection()
	{
	}
}
