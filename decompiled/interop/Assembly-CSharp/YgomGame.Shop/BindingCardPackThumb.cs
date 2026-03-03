using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu.Common;
using YgomSystem.UI;

namespace YgomGame.Shop;

[Token(Token = "0x20009BF")]
public class BindingCardPackThumb : Binding, IAsyncProgressContent, ILoadingIconHandler
{
	[Token(Token = "0x4008D86")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string m_ThumbName;

	[Token(Token = "0x4008D87")]
	[FieldOffset(Offset = "0x30")]
	private Image m_ImageCache;

	[Token(Token = "0x4008D88")]
	[FieldOffset(Offset = "0x38")]
	private IAsyncProgressContent m_AsyncProgressContent;

	[Token(Token = "0x170007D6")]
	public Image targetImage
	{
		[Token(Token = "0x6003B6C")]
		[Address(RVA = "0x80B070", Offset = "0x80A270", VA = "0x18080B070")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007D7")]
	public string thumbName
	{
		[Token(Token = "0x6003B6D")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003B6E")]
		[Address(RVA = "0x80AD80", Offset = "0x809F80", VA = "0x18080AD80")]
		set
		{
		}
	}

	[Token(Token = "0x170007D8")]
	public bool visible
	{
		[Token(Token = "0x6003B6F")]
		[Address(RVA = "0x521190", Offset = "0x520390", VA = "0x180521190", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000042")]
	public event Action onReloadEvent
	{
		[Token(Token = "0x6003B6A")]
		[Address(RVA = "0x80AFD0", Offset = "0x80A1D0", VA = "0x18080AFD0", Slot = "11")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6003B6B")]
		[Address(RVA = "0x80B100", Offset = "0x80A300", VA = "0x18080B100", Slot = "12")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6003B70")]
	[Address(RVA = "0x80ADD0", Offset = "0x809FD0", VA = "0x18080ADD0", Slot = "10")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6003B71")]
	[Address(RVA = "0x80AF50", Offset = "0x80A150", VA = "0x18080AF50", Slot = "4")]
	public override void OnRebind()
	{
	}

	[Token(Token = "0x6003B72")]
	[Address(RVA = "0x80ADF0", Offset = "0x809FF0", VA = "0x18080ADF0", Slot = "5")]
	public override bool OnBinding()
	{
		return default(bool);
	}

	[Token(Token = "0x6003B73")]
	[Address(RVA = "0x80AF90", Offset = "0x80A190", VA = "0x18080AF90", Slot = "8")]
	public void ProgressUpdate()
	{
	}

	[Token(Token = "0x6003B74")]
	[Address(RVA = "0x422F60", Offset = "0x422160", VA = "0x180422F60")]
	public BindingCardPackThumb()
	{
	}
}
