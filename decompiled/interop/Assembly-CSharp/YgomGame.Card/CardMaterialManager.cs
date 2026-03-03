using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace YgomGame.Card;

[Token(Token = "0x2001611")]
public class CardMaterialManager
{
	[Token(Token = "0x400D46E")]
	private const int MAXMATPOOLCOUNT = 64;

	[Token(Token = "0x400D46F")]
	private const int MAXRARENUM = 4;

	[Token(Token = "0x400D470")]
	private const string MASKTEX = "MaskTex";

	[Token(Token = "0x400D471")]
	[FieldOffset(Offset = "0x10")]
	private CardPictureManager m_CardPictureManager;

	[Token(Token = "0x400D472")]
	[FieldOffset(Offset = "0x18")]
	private CardMaskManager m_CardMaskManager;

	[Token(Token = "0x400D473")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<Material, int> m_MatInstanceTable;

	[Token(Token = "0x400D474")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<Material, int> m_CardPictureTaskTable;

	[Token(Token = "0x400D475")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<Material, int> m_CardMaskTaskTable;

	[Token(Token = "0x400D476")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<CardFinishSetting.FinishType, int> m_MatcountStyleidTable;

	[Token(Token = "0x400D477")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<CardFinishSetting.FinishType, Stack<Material>> m_CardMaterialStack;

	[Token(Token = "0x400D478")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<string, CardFinishSetting.FinishType> m_FinishTypeNameTable;

	[Token(Token = "0x17001502")]
	public Dictionary<CardFinishSetting.FinishType, int> matcountStyleidTable
	{
		[Token(Token = "0x6008936")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008935")]
	[Address(RVA = "0xD48940", Offset = "0xD47B40", VA = "0x180D48940")]
	public static CardMaterialManager Create(CardPictureManager cardPictureManager, CardMaskManager cardMaskManager)
	{
		return null;
	}

	[Token(Token = "0x6008937")]
	[Address(RVA = "0xD489E0", Offset = "0xD47BE0", VA = "0x180D489E0")]
	public void GetCardMaterialForMeshRendererAsync(MeshRenderer meshRenderer, int cardId, int styleId, UnityAction onFinished, bool lowRenderQueue)
	{
	}

	[Token(Token = "0x6008938")]
	[Address(RVA = "0xD49010", Offset = "0xD48210", VA = "0x180D49010")]
	public void GetCardMaterialForRawImageAsync(RawImage rawImage, int cardId, int styleId, UnityAction onFinished)
	{
	}

	[Token(Token = "0x6008939")]
	[Address(RVA = "0xD49B20", Offset = "0xD48D20", VA = "0x180D49B20")]
	public int Release(Material mat)
	{
		return default(int);
	}

	[Token(Token = "0x600893A")]
	[Address(RVA = "0xD49860", Offset = "0xD48A60", VA = "0x180D49860")]
	private void Initialize()
	{
	}

	[Token(Token = "0x600893B")]
	[Address(RVA = "0xD4A2B0", Offset = "0xD494B0", VA = "0x180D4A2B0")]
	private bool SetMaskTex(int cardid, int styleId, Material mat)
	{
		return default(bool);
	}

	[Token(Token = "0x600893C")]
	[Address(RVA = "0xD4A200", Offset = "0xD49400", VA = "0x180D4A200")]
	private void SetFrameMask(int cardid, ref Material mat)
	{
	}

	[Token(Token = "0x600893D")]
	[Address(RVA = "0xD4A0F0", Offset = "0xD492F0", VA = "0x180D4A0F0")]
	private void SetCardNameMask(int cardid, Material mat)
	{
	}

	[Token(Token = "0x600893E")]
	[Address(RVA = "0xD4A680", Offset = "0xD49880", VA = "0x180D4A680")]
	private void SetParameterMask(int cardid, ref Material mat)
	{
	}

	[Token(Token = "0x600893F")]
	[Address(RVA = "0xD4A750", Offset = "0xD49950", VA = "0x180D4A750")]
	private void SetStarColorMask(int cardid, int styleid, ref Material mat)
	{
	}

	[Token(Token = "0x6008940")]
	[Address(RVA = "0xD49FF0", Offset = "0xD491F0", VA = "0x180D49FF0")]
	private void SetCardNameColorMask(int cardid, int styleid, ref Material mat)
	{
	}

	[Token(Token = "0x6008941")]
	[Address(RVA = "0xD49E30", Offset = "0xD49030", VA = "0x180D49E30")]
	private void ReturnCardMaterial(Material mat)
	{
	}

	[Token(Token = "0x6008942")]
	[Address(RVA = "0xD49570", Offset = "0xD48770", VA = "0x180D49570")]
	private Material GetCardMaterial(int cardid, int finishid, bool isforui)
	{
		return null;
	}

	[Token(Token = "0x6008943")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardMaterialManager()
	{
	}
}
