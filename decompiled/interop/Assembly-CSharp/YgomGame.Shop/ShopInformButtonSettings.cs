using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Shop;

[Token(Token = "0x2000937")]
public class ShopInformButtonSettings : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000938")]
	public class Data
	{
		[Token(Token = "0x4008A4D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string m_Label;

		[Token(Token = "0x4008A4E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ShopInformButtonData[] m_InfoButtonDatas;

		[Token(Token = "0x17000732")]
		public string label
		{
			[Token(Token = "0x60037C7")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000733")]
		public ShopInformButtonData[] infoButtonDatas
		{
			[Token(Token = "0x60037C8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60037C9")]
		[Address(RVA = "0x7CE6A0", Offset = "0x7CD8A0", VA = "0x1807CE6A0")]
		public Data(string label)
		{
		}
	}

	[Token(Token = "0x4008A4A")]
	internal const string k_Path = "Definition/Shop/ShopSettings";

	[Token(Token = "0x4008A4B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Data[] m_Datas;

	[Token(Token = "0x4008A4C")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, Data> m_DataMap;

	[Token(Token = "0x60037C5")]
	[Address(RVA = "0x7DBE40", Offset = "0x7DB040", VA = "0x1807DBE40")]
	public ShopInformButtonData[] Find(string label)
	{
		return null;
	}

	[Token(Token = "0x60037C6")]
	[Address(RVA = "0x7DC040", Offset = "0x7DB240", VA = "0x1807DC040")]
	public ShopInformButtonSettings()
	{
	}
}
