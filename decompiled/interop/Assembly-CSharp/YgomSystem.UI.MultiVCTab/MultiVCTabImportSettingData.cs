using System;
using Il2CppDummyDll;

namespace YgomSystem.UI.MultiVCTab;

[Serializable]
[Token(Token = "0x20005D7")]
public class MultiVCTabImportSettingData
{
	[Token(Token = "0x4001C05")]
	[FieldOffset(Offset = "0x10")]
	public string key;

	[Token(Token = "0x4001C06")]
	[FieldOffset(Offset = "0x18")]
	public KeyValueString[] stringDictionary;

	[Token(Token = "0x4001C07")]
	[FieldOffset(Offset = "0x20")]
	public KeyValueList[] listDictionary;

	[Token(Token = "0x6002633")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public MultiVCTabImportSettingData()
	{
	}
}
