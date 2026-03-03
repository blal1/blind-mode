using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.DiceRally;

[Token(Token = "0x2000F98")]
public class DiceRallySpace
{
	[Token(Token = "0x400A939")]
	[FieldOffset(Offset = "0x10")]
	public int index;

	[Token(Token = "0x400A93A")]
	[FieldOffset(Offset = "0x14")]
	public int target;

	[Token(Token = "0x400A93B")]
	[FieldOffset(Offset = "0x18")]
	public int cardId;

	[Token(Token = "0x400A93C")]
	[FieldOffset(Offset = "0x1C")]
	public int premiumId;

	[Token(Token = "0x400A93D")]
	[FieldOffset(Offset = "0x20")]
	public int id;

	[Token(Token = "0x400A93E")]
	[FieldOffset(Offset = "0x24")]
	public int rarityUpCount;

	[Token(Token = "0x400A93F")]
	[FieldOffset(Offset = "0x28")]
	public float size;

	[Token(Token = "0x400A940")]
	[FieldOffset(Offset = "0x2C")]
	public bool isConnect;

	[Token(Token = "0x400A941")]
	[FieldOffset(Offset = "0x2D")]
	public bool isClear;

	[Token(Token = "0x400A942")]
	[FieldOffset(Offset = "0x2E")]
	public bool isRarityUp;

	[Token(Token = "0x400A943")]
	[FieldOffset(Offset = "0x2F")]
	public bool isPremium;

	[Token(Token = "0x400A944")]
	[FieldOffset(Offset = "0x30")]
	public string popDesc;

	[Token(Token = "0x400A945")]
	[FieldOffset(Offset = "0x38")]
	public string titleDesc;

	[Token(Token = "0x400A946")]
	[FieldOffset(Offset = "0x40")]
	public string detailDesc;

	[Token(Token = "0x400A947")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 pos;

	[Token(Token = "0x400A948")]
	[FieldOffset(Offset = "0x50")]
	public GameObject obj;

	[Token(Token = "0x400A949")]
	[FieldOffset(Offset = "0x58")]
	public GameObject iconHolder;

	[Token(Token = "0x400A94A")]
	[FieldOffset(Offset = "0x60")]
	public GameObject popIconHolder;

	[Token(Token = "0x400A94B")]
	[FieldOffset(Offset = "0x68")]
	public GameObject defaultBG;

	[Token(Token = "0x400A94C")]
	[FieldOffset(Offset = "0x70")]
	public GameObject clearBG;

	[Token(Token = "0x400A94D")]
	[FieldOffset(Offset = "0x78")]
	public GameObject rewardGroup;

	[Token(Token = "0x400A94E")]
	[FieldOffset(Offset = "0x80")]
	public SelectionButton sb;

	[Token(Token = "0x400A94F")]
	[FieldOffset(Offset = "0x88")]
	public Action decideCallback;

	[Token(Token = "0x400A950")]
	[FieldOffset(Offset = "0x90")]
	public ElementObjectManager rarityEom;

	[Token(Token = "0x400A951")]
	[FieldOffset(Offset = "0x98")]
	public Dictionary<string, object> result;

	[Token(Token = "0x400A952")]
	[FieldOffset(Offset = "0xA0")]
	public DiceRallyUtil.Category category;

	[Token(Token = "0x400A953")]
	[FieldOffset(Offset = "0xA4")]
	public int subCategory;

	[Token(Token = "0x400A954")]
	[FieldOffset(Offset = "0xA8")]
	public DiceRallyUtil.CardCategory rarity;

	[Token(Token = "0x400A955")]
	[FieldOffset(Offset = "0xB0")]
	public DiceRallySpace child;

	[Token(Token = "0x400A956")]
	[FieldOffset(Offset = "0xB8")]
	public DiceRallySpace parent;

	[Token(Token = "0x400A957")]
	[FieldOffset(Offset = "0xC0")]
	public DiceRallyReward reward;

	[Token(Token = "0x6005EA6")]
	[Address(RVA = "0xA36580", Offset = "0xA35780", VA = "0x180A36580")]
	public DiceRallySpace(int index, int id, DiceRallyUtil.Category category, int subCategory, Vector2 pos, int target, int cardId, int premiumId, int rarityUpCount, bool isPremium)
	{
	}

	[Token(Token = "0x6005EA7")]
	[Address(RVA = "0xA364A0", Offset = "0xA356A0", VA = "0x180A364A0")]
	public bool IsExistChild()
	{
		return default(bool);
	}

	[Token(Token = "0x6005EA8")]
	[Address(RVA = "0xA36510", Offset = "0xA35710", VA = "0x180A36510")]
	public bool IsExistParent()
	{
		return default(bool);
	}
}
