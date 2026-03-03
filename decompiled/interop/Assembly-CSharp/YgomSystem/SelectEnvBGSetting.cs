using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem;

[Serializable]
[Token(Token = "0x2000152")]
public class SelectEnvBGSetting
{
	[Token(Token = "0x400081E")]
	[FieldOffset(Offset = "0x10")]
	[Tooltip("対象ブランチ名 (大小文字区別なし, ?=任意の１文字, *=任意の文字列)")]
	public List<string> targetBranchPatterns;

	[Token(Token = "0x400081F")]
	[FieldOffset(Offset = "0x18")]
	[Tooltip("背景色")]
	public Color bgColor;

	[Token(Token = "0x600087A")]
	[Address(RVA = "0xB03D20", Offset = "0xB02F20", VA = "0x180B03D20")]
	public bool IsMatchBranch(string branchName)
	{
		return default(bool);
	}

	[Token(Token = "0x600087B")]
	[Address(RVA = "0xB03BA0", Offset = "0xB02DA0", VA = "0x180B03BA0")]
	public bool IsMatchAnyBranch()
	{
		return default(bool);
	}

	[Token(Token = "0x600087C")]
	[Address(RVA = "0xB03EC0", Offset = "0xB030C0", VA = "0x180B03EC0")]
	public SelectEnvBGSetting()
	{
	}
}
