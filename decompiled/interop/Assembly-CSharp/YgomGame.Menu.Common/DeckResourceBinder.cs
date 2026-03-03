using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001466")]
public class DeckResourceBinder : ResourceBinderBase, IItemDeckCaseBinder, IItemStructureBinder, IItemDeckLimitBinder
{
	[Serializable]
	[Token(Token = "0x2001467")]
	public class DeckPathData
	{
		[Token(Token = "0x400C699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ResourceBindingPathSetting.ItemPathData m_DeckCasePath;

		[Token(Token = "0x400C69A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ResourceBindingPathSetting.ItemPathData m_OpenCasePath;

		[Token(Token = "0x400C69B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ResourceBindingPathSetting.ItemPathData m_DeckLimitPath;

		[Token(Token = "0x6007F22")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public DeckPathData()
		{
		}
	}

	[Token(Token = "0x400C698")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private DeckPathData m_Data;

	[Token(Token = "0x6007F0B")]
	[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
	public void Initialize(DeckPathData data)
	{
	}

	[Token(Token = "0x6007F0C")]
	[Address(RVA = "0xC74A50", Offset = "0xC73C50", VA = "0x180C74A50")]
	public int GetDeckIconNumberFromStructureId(int structureId)
	{
		return default(int);
	}

	[Token(Token = "0x6007F0D")]
	[Address(RVA = "0xC74B40", Offset = "0xC73D40", VA = "0x180C74B40")]
	public string GetStructureBoxIconPath(int structureId)
	{
		return null;
	}

	[Token(Token = "0x6007F0E")]
	[Address(RVA = "0xC74C10", Offset = "0xC73E10", VA = "0x180C74C10")]
	public string GetStructureBoxOpenIconPath(int structureId)
	{
		return null;
	}

	[Token(Token = "0x6007F0F")]
	[Address(RVA = "0xC74820", Offset = "0xC73A20", VA = "0x180C74820")]
	public StructureBoxWidget BindStructureBoxWidget(ElementObjectManager eom, int structureId, [Optional] Sprite deckSprite, [Optional] Sprite openedDeckSprite, [Optional] Sprite[] monsterSprites)
	{
		return null;
	}

	[Token(Token = "0x6007F10")]
	[Address(RVA = "0xC746D0", Offset = "0xC738D0", VA = "0x180C746D0")]
	public BindingImageEx BindStructureBoxIcon(Image target, int id, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007F11")]
	[Address(RVA = "0xC74680", Offset = "0xC73880", VA = "0x180C74680")]
	public BindingImageEx BindStructureBoxIcon(GameObject target, int id, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007F12")]
	[Address(RVA = "0xC74720", Offset = "0xC73920", VA = "0x180C74720")]
	public BindingImageEx BindStructureBoxOpenIcon(Image target, int id, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007F13")]
	[Address(RVA = "0xC75050", Offset = "0xC74250", VA = "0x180C75050")]
	private int caseIDtoIconNumber(int caseID)
	{
		return default(int);
	}

	[Token(Token = "0x6007F14")]
	[Address(RVA = "0xC748C0", Offset = "0xC73AC0", VA = "0x180C748C0")]
	public string GetDeckCaseIconPath(int caseID, bool isLarge = false, bool isReverse = false)
	{
		return null;
	}

	[Token(Token = "0x6007F15")]
	[Address(RVA = "0xC749B0", Offset = "0xC73BB0", VA = "0x180C749B0")]
	public string GetDeckCaseOpenIconPath(int caseID, bool isLarge = false)
	{
		return null;
	}

	[Token(Token = "0x6007F16")]
	[Address(RVA = "0xC74210", Offset = "0xC73410", VA = "0x180C74210")]
	public BindingImageEx BindDeckCaseIcon(Image target, int id, bool async = true, bool isLarge = false, bool isReverse = false)
	{
		return null;
	}

	[Token(Token = "0x6007F17")]
	[Address(RVA = "0xC74270", Offset = "0xC73470", VA = "0x180C74270")]
	public BindingImageEx BindDeckCaseOpenIcon(Image target, int id, bool async = true, bool isLarge = false)
	{
		return null;
	}

	[Token(Token = "0x6007F18")]
	[Address(RVA = "0xC74150", Offset = "0xC73350", VA = "0x180C74150")]
	public BindingImageEx BindDeckCaseIcon(GameObject target, int id, bool async = true, bool isLarge = false, bool isReverse = false)
	{
		return null;
	}

	[Token(Token = "0x6007F19")]
	[Address(RVA = "0xC742C0", Offset = "0xC734C0", VA = "0x180C742C0")]
	public DeckCaseWidget BindDeckCaseWidget(GameObject rootObj, int caseId, int protectorId, string deckName, int[] pickupCards, int[] pickupDecos, bool opened, bool isLarge = false, bool isDestroyTweens = false)
	{
		return null;
	}

	[Token(Token = "0x6007F1A")]
	[Address(RVA = "0xC743C0", Offset = "0xC735C0", VA = "0x180C743C0")]
	public PublicDeckCaseWidget BindPublicDeckCaseWidget(GameObject rootObj, int caseId, int pickupCard)
	{
		return null;
	}

	[Token(Token = "0x6007F1B")]
	[Address(RVA = "0xC744A0", Offset = "0xC736A0", VA = "0x180C744A0")]
	public SearchCategoryWidget BindSearchCategoryWidget(GameObject rootObj, int categoryId, string categoryName)
	{
		return null;
	}

	[Token(Token = "0x6007F1C")]
	[Address(RVA = "0xC74D90", Offset = "0xC73F90", VA = "0x180C74D90", Slot = "4")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemDeckCaseBinder_002EBindItem(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x6007F1D")]
	[Address(RVA = "0xC74CE0", Offset = "0xC73EE0", VA = "0x180C74CE0", Slot = "5")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemDeckCaseBinder_002EBindItemLarge(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x6007F1E")]
	[Address(RVA = "0xC74FC0", Offset = "0xC741C0", VA = "0x180C74FC0", Slot = "6")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemStructureBinder_002EBindItem(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x6007F1F")]
	[Address(RVA = "0xC74F00", Offset = "0xC74100", VA = "0x180C74F00", Slot = "7")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemDeckLimitBinder_002EBindItem(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x6007F20")]
	[Address(RVA = "0xC74E40", Offset = "0xC74040", VA = "0x180C74E40", Slot = "8")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemDeckLimitBinder_002EBindItemLarge(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x6007F21")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DeckResourceBinder()
	{
	}
}
