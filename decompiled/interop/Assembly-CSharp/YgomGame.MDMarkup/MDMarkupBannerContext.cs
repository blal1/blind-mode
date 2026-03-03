using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C87")]
public class MDMarkupBannerContext
{
	[Token(Token = "0x4009B55")]
	private const string k_JKeyPrefPath = "prefPath";

	[Token(Token = "0x4009B56")]
	private const string k_JKeyPrefArgsJson = "prefArgsJson";

	[Token(Token = "0x4009B57")]
	[FieldOffset(Offset = "0x10")]
	public string prefPath;

	[Token(Token = "0x4009B58")]
	[FieldOffset(Offset = "0x18")]
	[TextArea]
	public string prefArgsJson;

	[Token(Token = "0x4009B59")]
	[FieldOffset(Offset = "0x20")]
	public Dictionary<string, object> prefArgs;

	[Token(Token = "0x17000A6A")]
	public bool isValid
	{
		[Token(Token = "0x6004BE5")]
		[Address(RVA = "0x935B00", Offset = "0x934D00", VA = "0x180935B00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004BE6")]
	[Address(RVA = "0x9357D0", Offset = "0x9349D0", VA = "0x1809357D0")]
	public object ExportJsonObj()
	{
		return null;
	}

	[Token(Token = "0x6004BE7")]
	[Address(RVA = "0x9358A0", Offset = "0x934AA0", VA = "0x1809358A0")]
	public void ImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004BE8")]
	[Address(RVA = "0x935740", Offset = "0x934940", VA = "0x180935740")]
	public void CopyTo(MDMarkupBannerContext other, bool deep = false)
	{
	}

	[Token(Token = "0x6004BE9")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public MDMarkupBannerContext()
	{
	}
}
