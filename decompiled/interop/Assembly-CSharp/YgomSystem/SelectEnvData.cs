using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem;

[Token(Token = "0x2000153")]
public class SelectEnvData : ScriptableObject
{
	[Token(Token = "0x4000820")]
	[FieldOffset(Offset = "0x18")]
	public List<SelectEnvSetting> envSettingList;

	[Token(Token = "0x4000821")]
	[FieldOffset(Offset = "0x20")]
	public List<SelectEnvBGSetting> bgSettingList;

	[Token(Token = "0x600087D")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	public SelectEnvData()
	{
	}
}
