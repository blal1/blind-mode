using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomGame.Friend;

[Token(Token = "0x2000DC3")]
public class FollowerContextCollection : PlayerContextCollection, IReadOnlyDictionary<long, FollowerPlayerContext>, IEnumerable<KeyValuePair<long, FollowerPlayerContext>>, IEnumerable, IReadOnlyCollection<KeyValuePair<long, FollowerPlayerContext>>
{
	[Token(Token = "0x2000DC4")]
	public enum Dir
	{
		[Token(Token = "0x400A05B")]
		Next,
		[Token(Token = "0x400A05C")]
		Back
	}

	[Token(Token = "0x400A051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int cacheReleaseLine;

	[Token(Token = "0x400A052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<long, FollowerPlayerContext> m_FollowerContextMap;

	[Token(Token = "0x400A059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<FollowerPlayerContext> m_ImportTmpList;

	[Token(Token = "0x17000BFD")]
	public long headPcode
	{
		[Token(Token = "0x6005294")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005295")]
		[Address(RVA = "0x980A50", Offset = "0x97FC50", VA = "0x180980A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000BFE")]
	public long headDate
	{
		[Token(Token = "0x6005296")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005297")]
		[Address(RVA = "0x980A40", Offset = "0x97FC40", VA = "0x180980A40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000BFF")]
	public bool isHeadTerminal
	{
		[Token(Token = "0x6005298")]
		[Address(RVA = "0x406E70", Offset = "0x406070", VA = "0x180406E70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005299")]
		[Address(RVA = "0x406E80", Offset = "0x406080", VA = "0x180406E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C00")]
	public long tailPcode
	{
		[Token(Token = "0x600529A")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600529B")]
		[Address(RVA = "0x980A70", Offset = "0x97FC70", VA = "0x180980A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C01")]
	public long tailDate
	{
		[Token(Token = "0x600529C")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600529D")]
		[Address(RVA = "0x980A60", Offset = "0x97FC60", VA = "0x180980A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C02")]
	public bool isTailTerminal
	{
		[Token(Token = "0x600529E")]
		[Address(RVA = "0x3E1DE0", Offset = "0x3E0FE0", VA = "0x1803E1DE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600529F")]
		[Address(RVA = "0x3E1DF0", Offset = "0x3E0FF0", VA = "0x1803E1DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C03")]
	private FollowerPlayerContext System_002ECollections_002EGeneric_002EIReadOnlyDictionary_003CSystem_002EInt64_002CYgomGame_002EFriend_002EFollowerPlayerContext_003E_002EItem
	{
		[Token(Token = "0x60052A0")]
		[Address(RVA = "0x980810", Offset = "0x97FA10", VA = "0x180980810", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C04")]
	public IEnumerable<long> Keys
	{
		[Token(Token = "0x60052A1")]
		[Address(RVA = "0x9809F0", Offset = "0x97FBF0", VA = "0x1809809F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C05")]
	private IEnumerable<FollowerPlayerContext> System_002ECollections_002EGeneric_002EIReadOnlyDictionary_003CSystem_002EInt64_002CYgomGame_002EFriend_002EFollowerPlayerContext_003E_002EValues
	{
		[Token(Token = "0x60052A2")]
		[Address(RVA = "0x980870", Offset = "0x97FA70", VA = "0x180980870", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C06")]
	private int System_002ECollections_002EGeneric_002EIReadOnlyCollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EInt64_002CYgomGame_002EFriend_002EFollowerPlayerContext_003E_003E_002ECount
	{
		[Token(Token = "0x60052A3")]
		[Address(RVA = "0x9807D0", Offset = "0x97F9D0", VA = "0x1809807D0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60052A4")]
	[Address(RVA = "0x980700", Offset = "0x97F900", VA = "0x180980700")]
	public void Import((List<object>, bool) followerDatas, Dir dir, FollowContextCollection followContextCollection, [Optional] Action onReleasedCallback)
	{
	}

	[Token(Token = "0x60052A5")]
	[Address(RVA = "0x97FD40", Offset = "0x97EF40", VA = "0x18097FD40")]
	public void Import(IReadOnlyList<object> friendDatas, bool isTerminal, Dir dir, FollowContextCollection followContextCollection, [Optional] Action onReleasedCallback)
	{
	}

	[Token(Token = "0x60052A6")]
	[Address(RVA = "0x97FB40", Offset = "0x97ED40", VA = "0x18097FB40")]
	public void ImportFollows(FollowContextCollection followContextCollection)
	{
	}

	[Token(Token = "0x60052A7")]
	[Address(RVA = "0x97FAE0", Offset = "0x97ECE0", VA = "0x18097FAE0", Slot = "8")]
	public bool ContainsKey(long key)
	{
		return default(bool);
	}

	[Token(Token = "0x60052A8")]
	[Address(RVA = "0x9808B0", Offset = "0x97FAB0", VA = "0x1809808B0", Slot = "9")]
	public bool TryGetValue(long key, out FollowerPlayerContext value)
	{
		return default(bool);
	}

	[Token(Token = "0x60052A9")]
	[Address(RVA = "0x980740", Offset = "0x97F940", VA = "0x180980740", Slot = "14")]
	private IEnumerator<KeyValuePair<long, FollowerPlayerContext>> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EInt64_002CYgomGame_002EFriend_002EFollowerPlayerContext_003E_003E_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60052AA")]
	[Address(RVA = "0x980920", Offset = "0x97FB20", VA = "0x180980920")]
	public FollowerContextCollection()
	{
	}
}
