using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Serializable]
[Token(Token = "0x2000EF4")]
public class DuelLiveShowcaseImportData
{
	[Token(Token = "0x400A57E")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, object> m_Data;

	[Token(Token = "0x6005AA7")]
	[Address(RVA = "0xA0C460", Offset = "0xA0B660", VA = "0x180A0C460")]
	public Dictionary<string, object> GetReplayData()
	{
		return null;
	}

	[Token(Token = "0x6005AA8")]
	[Address(RVA = "0xA0C1E0", Offset = "0xA0B3E0", VA = "0x180A0C1E0")]
	public void AddData(DuelLiveImportSettingData data)
	{
	}

	[Token(Token = "0x6005AA9")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelLiveShowcaseImportData()
	{
	}
}
