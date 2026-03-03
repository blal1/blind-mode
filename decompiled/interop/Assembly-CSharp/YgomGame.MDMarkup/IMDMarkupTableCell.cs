using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D03")]
public interface IMDMarkupTableCell
{
	[Token(Token = "0x17000B1A")]
	GameObject gameObject
	{
		[Token(Token = "0x6004E83")]
		get;
	}

	[Token(Token = "0x17000B1B")]
	ElementObjectManager eom
	{
		[Token(Token = "0x6004E84")]
		get;
	}

	[Token(Token = "0x17000B1C")]
	bool borderVisible
	{
		[Token(Token = "0x6004E85")]
		get;
		[Token(Token = "0x6004E86")]
		set;
	}

	[Token(Token = "0x6004E87")]
	void SetAlignment(TextAlignmentOptions alignment);

	[Token(Token = "0x6004E88")]
	void SetSizeRate(float sizeRate, [Optional] RectTransform sourceRect);
}
