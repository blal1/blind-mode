using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.CardFile;

[Token(Token = "0x20015A9")]
public class CardFileSelector : MonoBehaviour
{
	[Token(Token = "0x400CE3E")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<CardFileDefinition.CardPosition, bool> m_SelectionDict;

	[Token(Token = "0x170014A2")]
	public Dictionary<CardFileDefinition.CardPosition, bool> SelectionDict
	{
		[Token(Token = "0x6008636")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170014A3")]
	public CardFileManager cfManager
	{
		[Token(Token = "0x6008637")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008638")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6008639")]
	public static T Create<T>(CardFileManager cfManager, GameObject root, string name, Action onFinished) where T : CardFileSelector
	{
		return null;
	}

	[Token(Token = "0x600863A")]
	[Address(RVA = "0xCEF250", Offset = "0xCEE450", VA = "0x180CEF250")]
	private void Initialize(Action onFinished)
	{
	}

	[Token(Token = "0x600863B")]
	[Address(RVA = "0xCEF130", Offset = "0xCEE330", VA = "0x180CEF130")]
	public bool GetIsSelection(CardFileDefinition.CardPosition pos)
	{
		return default(bool);
	}

	[Token(Token = "0x600863C")]
	[Address(RVA = "0xCEF190", Offset = "0xCEE390", VA = "0x180CEF190")]
	public bool GetIsSelection(CardFileDefinition.Location loc, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600863D")]
	[Address(RVA = "0xCEF660", Offset = "0xCEE860", VA = "0x180CEF660")]
	public void RebuildPageSelectDict(int page)
	{
	}

	[Token(Token = "0x600863E")]
	[Address(RVA = "0xCEF3C0", Offset = "0xCEE5C0", VA = "0x180CEF3C0")]
	public void RebuildPageSelectDictAllDeselectable()
	{
	}

	[Token(Token = "0x600863F")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public CardFileSelector()
	{
	}
}
