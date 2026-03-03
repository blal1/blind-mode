using System;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B90")]
public class WidgetFactory
{
	[Token(Token = "0x4009739")]
	[FieldOffset(Offset = "0x10")]
	private AssetLinkContainer m_AssetLinkContainer;

	[Token(Token = "0x1700097D")]
	public bool isReady
	{
		[Token(Token = "0x6004683")]
		[Address(RVA = "0x8FC730", Offset = "0x8FB930", VA = "0x1808FC730")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004684")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public WidgetFactory(GameObject owner)
	{
	}

	[Token(Token = "0x6004685")]
	[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
	public void Setup(AssetLinkContainer assetLinkContainer)
	{
	}

	[Token(Token = "0x6004686")]
	[Address(RVA = "0x8FC610", Offset = "0x8FB810", VA = "0x1808FC610")]
	public void LoadWidgetPref(string linkerLabel, Action<GameObject> onComplete)
	{
	}

	[Token(Token = "0x6004687")]
	[Address(RVA = "0x8FC520", Offset = "0x8FB720", VA = "0x1808FC520")]
	public IWidget CreateWidget(GameObject source, Type widgetType)
	{
		return null;
	}
}
