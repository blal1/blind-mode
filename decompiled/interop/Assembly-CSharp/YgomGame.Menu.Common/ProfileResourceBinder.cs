using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001493")]
public class ProfileResourceBinder : ResourceBinderBase, IItemProfileTagBinder
{
	[Serializable]
	[Token(Token = "0x2001494")]
	public class ProfileResource
	{
		[Token(Token = "0x400C6F7")]
		[FieldOffset(Offset = "0x10")]
		public ResourceBindingPathSetting.ItemPathData m_ProfileTagIconPath;

		[Token(Token = "0x6007FCC")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ProfileResource()
		{
		}
	}

	[Token(Token = "0x400C6F6")]
	[FieldOffset(Offset = "0x10")]
	private ProfileResource m_PathData;

	[Token(Token = "0x6007FC6")]
	[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
	public void Initialize(ProfileResource path)
	{
	}

	[Token(Token = "0x6007FC7")]
	[Address(RVA = "0xC79AA0", Offset = "0xC78CA0", VA = "0x180C79AA0")]
	public string GetProfileTagIconPath(bool isLarge = false)
	{
		return null;
	}

	[Token(Token = "0x6007FC8")]
	[Address(RVA = "0xC79A50", Offset = "0xC78C50", VA = "0x180C79A50")]
	public BindingImageEx BindIcon(Image target, bool async = true, bool isLarge = false)
	{
		return null;
	}

	[Token(Token = "0x6007FC9")]
	[Address(RVA = "0xC79B70", Offset = "0xC78D70", VA = "0x180C79B70", Slot = "4")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemProfileTagBinder_002EBindItem(GameObject target, int consumeId)
	{
		return null;
	}

	[Token(Token = "0x6007FCA")]
	[Address(RVA = "0xC79AE0", Offset = "0xC78CE0", VA = "0x180C79AE0", Slot = "5")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemProfileTagBinder_002EBindItemLarge(GameObject target, int consumeId)
	{
		return null;
	}

	[Token(Token = "0x6007FCB")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ProfileResourceBinder()
	{
	}
}
