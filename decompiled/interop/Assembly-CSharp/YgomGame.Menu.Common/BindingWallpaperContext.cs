using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Serializable]
[Token(Token = "0x2001451")]
public class BindingWallpaperContext
{
	[Token(Token = "0x400C655")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public int id;

	[Token(Token = "0x400C656")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int width;

	[Token(Token = "0x400C657")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int height;

	[Token(Token = "0x400C658")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public BindingGameObjectEx.FitMode fitMode;

	[Token(Token = "0x400C659")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public bool useImage;

	[Token(Token = "0x400C65A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public string tranSettingLabel;

	[Token(Token = "0x400C65B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public bool useSpriteMask;

	[Token(Token = "0x400C65C")]
	[FieldOffset(Offset = "0x31")]
	[SerializeField]
	public bool stopAnimation;

	[Token(Token = "0x17001383")]
	public int wallpaperId
	{
		[Token(Token = "0x6007EA1")]
		[Address(RVA = "0xC6F440", Offset = "0xC6E640", VA = "0x180C6F440")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001384")]
	public int itemId
	{
		[Token(Token = "0x6007EA2")]
		[Address(RVA = "0xC6F400", Offset = "0xC6E600", VA = "0x180C6F400")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001385")]
	public string fullTranSettingLabel
	{
		[Token(Token = "0x6007EA3")]
		[Address(RVA = "0xC6F3B0", Offset = "0xC6E5B0", VA = "0x180C6F3B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007EA4")]
	[Address(RVA = "0xC6F2A0", Offset = "0xC6E4A0", VA = "0x180C6F2A0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6007EA5")]
	[Address(RVA = "0x58A430", Offset = "0x589630", VA = "0x18058A430", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007EA6")]
	[Address(RVA = "0xC6F380", Offset = "0xC6E580", VA = "0x180C6F380")]
	public BindingWallpaperContext()
	{
	}
}
