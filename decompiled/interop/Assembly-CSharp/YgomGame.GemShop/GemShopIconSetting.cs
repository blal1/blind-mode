using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace YgomGame.GemShop;

[Token(Token = "0x2000D9E")]
public class GemShopIconSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000D9F")]
	public class IconData
	{
		[Token(Token = "0x4009FA1")]
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("thumbId")]
		public int iconId;

		[Token(Token = "0x4009FA2")]
		[FieldOffset(Offset = "0x18")]
		public string thumbFxpId;

		[Token(Token = "0x4009FA3")]
		[FieldOffset(Offset = "0x20")]
		public int effectId;

		[Token(Token = "0x60051D7")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public IconData()
		{
		}
	}

	[Token(Token = "0x4009F9E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string m_ThumbPathFormat;

	[Token(Token = "0x4009F9F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[FormerlySerializedAs("m_ThumbDatas")]
	private IconData[] m_IconDatas;

	[Token(Token = "0x4009FA0")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<int, IconData> m_IconDataMap;

	[Token(Token = "0x60051D2")]
	[Address(RVA = "0x989910", Offset = "0x988B10", VA = "0x180989910")]
	public bool ValidIconId(int iconId)
	{
		return default(bool);
	}

	[Token(Token = "0x60051D3")]
	[Address(RVA = "0x9897B0", Offset = "0x9889B0", VA = "0x1809897B0")]
	private IconData GetIconData(int iconId)
	{
		return null;
	}

	[Token(Token = "0x60051D4")]
	[Address(RVA = "0x9898D0", Offset = "0x988AD0", VA = "0x1809898D0")]
	public string GetIconPath(int iconId)
	{
		return null;
	}

	[Token(Token = "0x60051D5")]
	[Address(RVA = "0x989790", Offset = "0x988990", VA = "0x180989790")]
	public int GetEffectId(int iconId)
	{
		return default(int);
	}

	[Token(Token = "0x60051D6")]
	[Address(RVA = "0x989930", Offset = "0x988B30", VA = "0x180989930")]
	public GemShopIconSetting()
	{
	}
}
