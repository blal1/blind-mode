using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x200044F")]
public class FreeTextFilterCache : MonoBehaviour
{
	[Token(Token = "0x400150E")]
	[FieldOffset(Offset = "0x0")]
	private static FreeTextFilterCache s_Instance;

	[Token(Token = "0x400150F")]
	[FieldOffset(Offset = "0x20")]
	private List<FreeTextFilter> m_ReferencedFilteres;

	[Token(Token = "0x4001510")]
	[FieldOffset(Offset = "0x28")]
	private List<string> m_CachedFreeTexts;

	[Token(Token = "0x4001511")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<string, string> m_FilteredTextMap;

	[Token(Token = "0x4001512")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<string, List<FreeTextFilter>> m_FilterRequests;

	[Token(Token = "0x4001513")]
	[FieldOffset(Offset = "0x40")]
	private readonly int k_CacheReleaseLine;

	[Token(Token = "0x4001514")]
	[FieldOffset(Offset = "0x44")]
	private readonly int k_CacheReleaseCount;

	[Token(Token = "0x1700028E")]
	public IReadOnlyList<FreeTextFilter> referencedFilteres
	{
		[Token(Token = "0x6001B92")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700028F")]
	public IReadOnlyList<string> cachedFreeTexts
	{
		[Token(Token = "0x6001B93")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000290")]
	public IReadOnlyDictionary<string, string> filteredTextMap
	{
		[Token(Token = "0x6001B94")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001B95")]
	[Address(RVA = "0x5E5BD0", Offset = "0x5E4DD0", VA = "0x1805E5BD0")]
	private static FreeTextFilterCache GetInstance()
	{
		return null;
	}

	[Token(Token = "0x6001B96")]
	[Address(RVA = "0x5E5A10", Offset = "0x5E4C10", VA = "0x1805E5A10")]
	private static void DestroyInstance()
	{
	}

	[Token(Token = "0x6001B97")]
	[Address(RVA = "0x5E57D0", Offset = "0x5E49D0", VA = "0x1805E57D0")]
	public static FreeTextFilterCache AssignReference(FreeTextFilter freeTextFilter)
	{
		return null;
	}

	[Token(Token = "0x6001B98")]
	[Address(RVA = "0x5E5D90", Offset = "0x5E4F90", VA = "0x1805E5D90")]
	public void RemoveReference(FreeTextFilter freeTextFilter)
	{
	}

	[Token(Token = "0x6001B99")]
	[Address(RVA = "0x5E5FA0", Offset = "0x5E51A0", VA = "0x1805E5FA0")]
	public void RequestFilter(FreeTextFilter owner, string freeText)
	{
	}

	[Token(Token = "0x6001B9A")]
	[Address(RVA = "0x5E5AF0", Offset = "0x5E4CF0", VA = "0x1805E5AF0")]
	private void ExecuteFilterAsync(string freeText)
	{
	}

	[Token(Token = "0x6001B9B")]
	[Address(RVA = "0x5E6290", Offset = "0x5E5490", VA = "0x1805E6290")]
	public FreeTextFilterCache()
	{
	}
}
