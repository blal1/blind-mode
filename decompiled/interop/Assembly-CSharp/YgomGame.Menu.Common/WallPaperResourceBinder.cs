using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x20014A7")]
public class WallPaperResourceBinder : ResourceBinderBase, IItemWallpaperBinder
{
	[Serializable]
	[Token(Token = "0x20014A8")]
	public class WallPaperResourcePathData
	{
		[Token(Token = "0x400C744")]
		[FieldOffset(Offset = "0x10")]
		public string m_WallPaperResourcePath;

		[Token(Token = "0x400C745")]
		[FieldOffset(Offset = "0x18")]
		public string topicsThumbPath;

		[Token(Token = "0x400C746")]
		[FieldOffset(Offset = "0x20")]
		public string itemIconBasePath;

		[Token(Token = "0x400C747")]
		[FieldOffset(Offset = "0x28")]
		public string tranSettingPath;

		[Token(Token = "0x600801E")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public WallPaperResourcePathData()
		{
		}
	}

	[Token(Token = "0x400C743")]
	[FieldOffset(Offset = "0x10")]
	private WallPaperResourcePathData m_WallPaperPath;

	[Token(Token = "0x6008015")]
	[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
	public void Initialize(WallPaperResourcePathData iconPath)
	{
	}

	[Token(Token = "0x6008016")]
	[Address(RVA = "0xC840B0", Offset = "0xC832B0", VA = "0x180C840B0")]
	public string GetIconPath(int itemId)
	{
		return null;
	}

	[Token(Token = "0x6008017")]
	[Address(RVA = "0xC84130", Offset = "0xC83330", VA = "0x180C84130")]
	public string GetTopicsThumbPath(int itemId)
	{
		return null;
	}

	[Token(Token = "0x6008018")]
	[Address(RVA = "0xC841C0", Offset = "0xC833C0", VA = "0x180C841C0")]
	public string GetTranSettingPath(int itemId)
	{
		return null;
	}

	[Token(Token = "0x6008019")]
	[Address(RVA = "0xC83FD0", Offset = "0xC831D0", VA = "0x180C83FD0")]
	public BindingImageEx BindIcon(Image target, int itemId, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x600801A")]
	[Address(RVA = "0xC84020", Offset = "0xC83220", VA = "0x180C84020")]
	public BindingImageEx BindThumb(Image target, int itemId, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x600801B")]
	[Address(RVA = "0xC84060", Offset = "0xC83260", VA = "0x180C84060")]
	public BindingImageEx BindTopicsThumb(Image target, int itemId, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x600801C")]
	[Address(RVA = "0xC84230", Offset = "0xC83430", VA = "0x180C84230", Slot = "4")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemWallpaperBinder_002EBindItem(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x600801D")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public WallPaperResourceBinder()
	{
	}
}
