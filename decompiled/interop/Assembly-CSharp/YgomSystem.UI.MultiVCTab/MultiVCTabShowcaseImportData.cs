using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI.MultiVCTab;

[Serializable]
[Token(Token = "0x20005D8")]
public class MultiVCTabShowcaseImportData
{
	[Token(Token = "0x4001C08")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private MultiVCTabImportSettingData[] settingData;

	[Token(Token = "0x4001C09")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, object> m_Data;

	[Token(Token = "0x6002634")]
	[Address(RVA = "0x698A30", Offset = "0x697C30", VA = "0x180698A30")]
	public MultiVCTabImportSettingData[] GetSettingData()
	{
		return null;
	}

	[Token(Token = "0x6002635")]
	[Address(RVA = "0x698630", Offset = "0x697830", VA = "0x180698630")]
	public Dictionary<string, object> GetReplayData()
	{
		return null;
	}

	[Token(Token = "0x6002636")]
	[Address(RVA = "0x6983B0", Offset = "0x6975B0", VA = "0x1806983B0")]
	public void AddData(MultiVCTabImportSettingData data)
	{
	}

	[Token(Token = "0x6002637")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public MultiVCTabShowcaseImportData()
	{
	}
}
