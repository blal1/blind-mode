using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem;

[Serializable]
[Token(Token = "0x2000151")]
public class SelectEnvSetting
{
	[Token(Token = "0x400081C")]
	[FieldOffset(Offset = "0x10")]
	[Tooltip("名前")]
	public string title;

	[Token(Token = "0x400081D")]
	[FieldOffset(Offset = "0x18")]
	[Tooltip("選択肢リスト")]
	public List<RuntimeEnvironment.ServerType> envList;

	[Token(Token = "0x6000879")]
	[Address(RVA = "0xB03EE0", Offset = "0xB030E0", VA = "0x180B03EE0")]
	public SelectEnvSetting()
	{
	}
}
