using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x20003F6")]
public class PropertyContainer : MonoBehaviour, IReadOnlyDictionary<string, string>, IEnumerable<KeyValuePair<string, string>>, IEnumerable, IReadOnlyCollection<KeyValuePair<string, string>>
{
	[Serializable]
	[Token(Token = "0x20003F7")]
	public class PropertyInfo
	{
		[Token(Token = "0x40013C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string label;

		[Token(Token = "0x40013C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string property;

		[Token(Token = "0x17000265")]
		public KeyValuePair<string, string> keyValuePair
		{
			[Token(Token = "0x6001964")]
			[Address(RVA = "0x5D2B10", Offset = "0x5D1D10", VA = "0x1805D2B10")]
			get
			{
				return default(KeyValuePair<string, string>);
			}
		}

		[Token(Token = "0x6001963")]
		[Address(RVA = "0x5D2A90", Offset = "0x5D1C90", VA = "0x1805D2A90")]
		public PropertyInfo Copy()
		{
			return null;
		}

		[Token(Token = "0x6001965")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public PropertyInfo()
		{
		}
	}

	[Token(Token = "0x40013C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<PropertyInfo> propertyList;

	[Token(Token = "0x17000260")]
	public IEnumerable<string> Keys
	{
		[Token(Token = "0x6001956")]
		[Address(RVA = "0x5D2850", Offset = "0x5D1A50", VA = "0x1805D2850", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000261")]
	public IEnumerable<string> Values
	{
		[Token(Token = "0x6001957")]
		[Address(RVA = "0x5D2970", Offset = "0x5D1B70", VA = "0x1805D2970", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000262")]
	public int Count
	{
		[Token(Token = "0x6001958")]
		[Address(RVA = "0x5D26C0", Offset = "0x5D18C0", VA = "0x1805D26C0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000263")]
	public bool IsReadOnly
	{
		[Token(Token = "0x6001959")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000264")]
	public string this[string label]
	{
		[Token(Token = "0x600195A")]
		[Address(RVA = "0x5D2700", Offset = "0x5D1900", VA = "0x1805D2700", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600195B")]
	[Address(RVA = "0x5D2320", Offset = "0x5D1520", VA = "0x1805D2320", Slot = "4")]
	public bool ContainsKey(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x600195C")]
	[Address(RVA = "0x5D2610", Offset = "0x5D1810", VA = "0x1805D2610", Slot = "5")]
	public bool TryGetValue(string key, out string value)
	{
		return default(bool);
	}

	[Token(Token = "0x600195D")]
	[Address(RVA = "0x5D2500", Offset = "0x5D1700", VA = "0x1805D2500")]
	public float GetValueOrDefault(string key, float defaultVal = 0f)
	{
		return default(float);
	}

	[Token(Token = "0x600195E")]
	[Address(RVA = "0x5D2480", Offset = "0x5D1680", VA = "0x1805D2480")]
	public int GetValueOrDefault(string key, int defaultVal = 0)
	{
		return default(int);
	}

	[Token(Token = "0x600195F")]
	[Address(RVA = "0x5D2580", Offset = "0x5D1780", VA = "0x1805D2580")]
	public string GetValueOrDefault(string key, [Optional] string defaultVal)
	{
		return null;
	}

	[Token(Token = "0x6001960")]
	[Address(RVA = "0x5D2340", Offset = "0x5D1540", VA = "0x1805D2340", Slot = "10")]
	public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6001961")]
	[Address(RVA = "0x5D2340", Offset = "0x5D1540", VA = "0x1805D2340", Slot = "11")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6001962")]
	[Address(RVA = "0x5D2640", Offset = "0x5D1840", VA = "0x1805D2640")]
	public PropertyContainer()
	{
	}
}
