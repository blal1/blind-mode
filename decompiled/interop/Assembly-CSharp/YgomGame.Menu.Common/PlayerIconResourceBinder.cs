using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200148D")]
public class PlayerIconResourceBinder : ResourceBinderBase, IItemIconBinder, IItemIconFrameBinder
{
	[Serializable]
	[Token(Token = "0x200148E")]
	public class PlayerIconPathData
	{
		[Token(Token = "0x400C6DA")]
		[FieldOffset(Offset = "0x10")]
		public ResourceBindingPathSetting.ItemPathData m_PlayerIconBasePath;

		[Token(Token = "0x400C6DB")]
		[FieldOffset(Offset = "0x18")]
		public ResourceBindingPathSetting.ItemPathData m_PlayerFramePath;

		[Token(Token = "0x400C6DC")]
		[FieldOffset(Offset = "0x20")]
		public string m_PlayerFrameMatPath;

		[Token(Token = "0x400C6DD")]
		[FieldOffset(Offset = "0x28")]
		public string m_RankIconPath;

		[Token(Token = "0x400C6DE")]
		[FieldOffset(Offset = "0x30")]
		public string m_RankIconBGPath;

		[Token(Token = "0x400C6DF")]
		[FieldOffset(Offset = "0x38")]
		public string m_RateIconPath;

		[Token(Token = "0x400C6E0")]
		[FieldOffset(Offset = "0x40")]
		public string m_RateIconPrefabPath;

		[Token(Token = "0x400C6E1")]
		[FieldOffset(Offset = "0x48")]
		public string m_RateIconBGPath;

		[Token(Token = "0x400C6E2")]
		[FieldOffset(Offset = "0x50")]
		public string m_EventRankIconPath;

		[Token(Token = "0x400C6E3")]
		[FieldOffset(Offset = "0x58")]
		public string m_PlayerIconBlankPath;

		[Token(Token = "0x400C6E4")]
		[FieldOffset(Offset = "0x60")]
		public string m_PlayerFrameMatDefaultPath;

		[Token(Token = "0x6007FBF")]
		[Address(RVA = "0xC78540", Offset = "0xC77740", VA = "0x180C78540")]
		public PlayerIconPathData()
		{
		}
	}

	[Token(Token = "0x200148F")]
	public enum Size
	{
		[Token(Token = "0x400C6E6")]
		SMALL,
		[Token(Token = "0x400C6E7")]
		LARGE
	}

	[Token(Token = "0x400C6D9")]
	[FieldOffset(Offset = "0x10")]
	private PlayerIconPathData m_PathData;

	[Token(Token = "0x6007FA2")]
	[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
	public void Initialize(PlayerIconPathData pathData)
	{
	}

	[Token(Token = "0x6007FA3")]
	[Address(RVA = "0xC79090", Offset = "0xC78290", VA = "0x180C79090")]
	public string GetPlayerIconBasePath(int id, bool isLarge = false)
	{
		return null;
	}

	[Token(Token = "0x6007FA4")]
	[Address(RVA = "0xC79230", Offset = "0xC78430", VA = "0x180C79230")]
	public string GetPlayerIconFramePath(int id, bool isLarge = false)
	{
		return null;
	}

	[Token(Token = "0x6007FA5")]
	[Address(RVA = "0xC791C0", Offset = "0xC783C0", VA = "0x180C791C0")]
	public string GetPlayerIconFrameMatPath(int id)
	{
		return null;
	}

	[Token(Token = "0x6007FA6")]
	[Address(RVA = "0xC79360", Offset = "0xC78560", VA = "0x180C79360")]
	public string GetPlayerIconRankPath(int id, Size size = Size.SMALL)
	{
		return null;
	}

	[Token(Token = "0x6007FA7")]
	[Address(RVA = "0xC79460", Offset = "0xC78660", VA = "0x180C79460")]
	public string GetPlayerIconRatePath(int id, Size size = Size.SMALL)
	{
		return null;
	}

	[Token(Token = "0x6007FA8")]
	[Address(RVA = "0xC79540", Offset = "0xC78740", VA = "0x180C79540")]
	public string GetPlayerIconRatePath(Size size = Size.SMALL)
	{
		return null;
	}

	[Token(Token = "0x6007FA9")]
	[Address(RVA = "0xC79110", Offset = "0xC78310", VA = "0x180C79110")]
	public string GetPlayerIconEventRankPath(int id, Size size = Size.SMALL)
	{
		return null;
	}

	[Token(Token = "0x6007FAA")]
	[Address(RVA = "0xC792B0", Offset = "0xC784B0", VA = "0x180C792B0")]
	public string GetPlayerIconRankBGPath(int id, Size size)
	{
		return null;
	}

	[Token(Token = "0x6007FAB")]
	[Address(RVA = "0xC79410", Offset = "0xC78610", VA = "0x180C79410")]
	public string GetPlayerIconRateBGPath(int id)
	{
		return null;
	}

	[Token(Token = "0x6007FAC")]
	[Address(RVA = "0xC78E50", Offset = "0xC78050", VA = "0x180C78E50")]
	public BindingProfileFrameIcon BindPlayerIcon(GameObject target, int baseID, int frameID, bool fitParentSize = false, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007FAD")]
	[Address(RVA = "0xC78610", Offset = "0xC77810", VA = "0x180C78610")]
	public BindingProfileFrameIcon BindPlayerIconBase(GameObject target, int baseID, bool fitParentSize = false, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007FAE")]
	[Address(RVA = "0xC788E0", Offset = "0xC77AE0", VA = "0x180C788E0")]
	public BindingProfileFrameIcon BindPlayerIconFrame(GameObject target, int frameID, bool async = true, bool isLarge = false)
	{
		return null;
	}

	[Token(Token = "0x6007FAF")]
	[Address(RVA = "0xC785C0", Offset = "0xC777C0", VA = "0x180C785C0")]
	public BindingProfileFrameIcon BindPlayerIconBaseLarge(Image target, int baseID, bool async = true, bool isLarge = false)
	{
		return null;
	}

	[Token(Token = "0x6007FB0")]
	[Address(RVA = "0xC78890", Offset = "0xC77A90", VA = "0x180C78890")]
	public BindingProfileFrameIcon BindPlayerIconFrameLarge(Image target, int frameID, bool async = true, bool isLarge = false)
	{
		return null;
	}

	[Token(Token = "0x6007FB1")]
	[Address(RVA = "0xC789E0", Offset = "0xC77BE0", VA = "0x180C789E0")]
	public BindingGameObjectEx BindPlayerIconRank(GameObject target, int rank, int tier, bool async = true, Size size = Size.SMALL, bool fitPrefabScale = true)
	{
		return null;
	}

	[Token(Token = "0x6007FB2")]
	[Address(RVA = "0xC78CC0", Offset = "0xC77EC0", VA = "0x180C78CC0")]
	public BindingGameObjectEx BindPlayerIconRate(GameObject target, int rank, bool async = true, Size size = Size.SMALL, bool fitPrefabScale = true)
	{
		return null;
	}

	[Token(Token = "0x6007FB3")]
	[Address(RVA = "0xC78910", Offset = "0xC77B10", VA = "0x180C78910")]
	public BindingImageEx BindPlayerIconRankBG(Image target, int id, Size size = Size.SMALL, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007FB4")]
	[Address(RVA = "0xC78C40", Offset = "0xC77E40", VA = "0x180C78C40")]
	public BindingImageEx BindPlayerIconRateBG(Image target, int id, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007FB5")]
	[Address(RVA = "0xC78630", Offset = "0xC77830", VA = "0x180C78630")]
	public BindingGameObjectEx BindPlayerIconEventRank(GameObject target, int rank, int tier, bool async = true, Size size = Size.SMALL, bool fitPrefabScale = true)
	{
		return null;
	}

	[Token(Token = "0x6007FB6")]
	[Address(RVA = "0xC79650", Offset = "0xC78850", VA = "0x180C79650")]
	private void SetEventTier(int tier, ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6007FB7")]
	[Address(RVA = "0xC79730", Offset = "0xC78930", VA = "0x180C79730")]
	private void SetTier(int tier, ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6007FB8")]
	[Address(RVA = "0xC795C0", Offset = "0xC787C0", VA = "0x180C795C0")]
	private void ResetAnchor(RectTransform rt)
	{
	}

	[Token(Token = "0x6007FB9")]
	[Address(RVA = "0xC78E80", Offset = "0xC78080", VA = "0x180C78E80")]
	private void FitPrefabScale(GameObject parent, GameObject go)
	{
	}

	[Token(Token = "0x6007FBA")]
	[Address(RVA = "0xC798A0", Offset = "0xC78AA0", VA = "0x180C798A0", Slot = "4")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemIconBinder_002EBindItem(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x6007FBB")]
	[Address(RVA = "0xC799C0", Offset = "0xC78BC0", VA = "0x180C799C0", Slot = "6")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemIconFrameBinder_002EBindItem(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x6007FBC")]
	[Address(RVA = "0xC79810", Offset = "0xC78A10", VA = "0x180C79810", Slot = "5")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemIconBinder_002EBindItemLarge(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x6007FBD")]
	[Address(RVA = "0xC79930", Offset = "0xC78B30", VA = "0x180C79930", Slot = "7")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemIconFrameBinder_002EBindItemLarge(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x6007FBE")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public PlayerIconResourceBinder()
	{
	}
}
