using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Utility;
using YgomSystem.UI;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C89")]
public class URLSchemeButton
{
	[Token(Token = "0x4009B61")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public string url;

	[Token(Token = "0x4009B62")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public GlobalTextData label;

	[Token(Token = "0x4009B63")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public SelectorManager.KeyType shortcut;

	[Token(Token = "0x4009B64")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public bool interactable;

	[Token(Token = "0x6004BF5")]
	[Address(RVA = "0x94D990", Offset = "0x94CB90", VA = "0x18094D990")]
	public URLSchemeButton()
	{
	}

	[Token(Token = "0x6004BF6")]
	[Address(RVA = "0x94DA30", Offset = "0x94CC30", VA = "0x18094DA30")]
	public URLSchemeButton(string url, string rawLabel, SelectorManager.KeyType shortcut)
	{
	}

	[Token(Token = "0x6004BF7")]
	[Address(RVA = "0x94D290", Offset = "0x94C490", VA = "0x18094D290")]
	public static object ExportJsonObj(List<URLSchemeButton> buttons)
	{
		return null;
	}

	[Token(Token = "0x6004BF8")]
	[Address(RVA = "0x94D5C0", Offset = "0x94C7C0", VA = "0x18094D5C0")]
	public static List<URLSchemeButton> ImportJsonObj(object jsonObj)
	{
		return null;
	}
}
