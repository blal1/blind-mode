using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Shop;

[Token(Token = "0x200093B")]
public class ShopProductWorkSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200093C")]
	public class Data
	{
		[Serializable]
		[Token(Token = "0x200093D")]
		public class PathValue
		{
			[Token(Token = "0x4008A64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string m_Path;

			[Token(Token = "0x4008A65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private string m_Value;

			[Token(Token = "0x4008A66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private bool m_UseJsonPath;

			[Token(Token = "0x17000744")]
			public string path
			{
				[Token(Token = "0x60037E9")]
				[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000745")]
			public string value
			{
				[Token(Token = "0x60037EA")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000746")]
			public bool useJsonPath
			{
				[Token(Token = "0x60037EB")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60037EC")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public PathValue()
			{
			}
		}

		[Token(Token = "0x4008A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private PathValue[] m_MatchSources;

		[Token(Token = "0x4008A63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PathValue[] m_Outputs;

		[Token(Token = "0x17000742")]
		public PathValue[] matchSources
		{
			[Token(Token = "0x60037E6")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000743")]
		public PathValue[] outputs
		{
			[Token(Token = "0x60037E7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60037E8")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public Data()
		{
		}
	}

	[Token(Token = "0x4008A5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<Data> m_Datas;

	[Token(Token = "0x4008A60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<string, Data[]> m_KeyToMatchSourcesMap;

	[Token(Token = "0x4008A61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<Data> m_SourcesSearcher;

	[Token(Token = "0x60037DE")]
	[Address(RVA = "0x7DDDC0", Offset = "0x7DCFC0", VA = "0x1807DDDC0")]
	private Data[] FindMatchSourcesFromKey(string key)
	{
		return null;
	}

	[Token(Token = "0x60037DF")]
	[Address(RVA = "0x7DE4B0", Offset = "0x7DD6B0", VA = "0x1807DE4B0")]
	private bool MatchValue(object productVal, string serializeVal)
	{
		return default(bool);
	}

	[Token(Token = "0x60037E0")]
	[Address(RVA = "0x7DE310", Offset = "0x7DD510", VA = "0x1807DE310")]
	private bool MatchData(Dictionary<string, object> productData, Data data)
	{
		return default(bool);
	}

	[Token(Token = "0x60037E1")]
	[Address(RVA = "0x7DE0A0", Offset = "0x7DD2A0", VA = "0x1807DE0A0")]
	private string FindOutputValue(Dictionary<string, object> productData, string key)
	{
		return null;
	}

	[Token(Token = "0x60037E2")]
	[Address(RVA = "0x7DDC80", Offset = "0x7DCE80", VA = "0x1807DDC80")]
	public bool FindBoolValue(Dictionary<string, object> productData, string key, bool defaultValue = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60037E3")]
	[Address(RVA = "0x7DDD20", Offset = "0x7DCF20", VA = "0x1807DDD20")]
	public int FindIntValue(Dictionary<string, object> productData, string key, int defaultValue = 0)
	{
		return default(int);
	}

	[Token(Token = "0x60037E4")]
	[Address(RVA = "0x7DE2D0", Offset = "0x7DD4D0", VA = "0x1807DE2D0")]
	public string FindStringValue(Dictionary<string, object> productData, string key, [Optional] string defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60037E5")]
	[Address(RVA = "0x7DE710", Offset = "0x7DD910", VA = "0x1807DE710")]
	public ShopProductWorkSetting()
	{
	}
}
