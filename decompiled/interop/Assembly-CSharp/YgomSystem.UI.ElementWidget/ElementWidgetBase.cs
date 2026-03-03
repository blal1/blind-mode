using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI.ElementWidget;

[Token(Token = "0x200060D")]
public class ElementWidgetBase : IAsyncProgressContainer
{
	[Token(Token = "0x4001D1D")]
	[FieldOffset(Offset = "0x10")]
	private List<IAsyncProgressContent> m_AsyncProgressContents;

	[Token(Token = "0x4001D1E")]
	[FieldOffset(Offset = "0x18")]
	public readonly ElementObjectManager eom;

	[Token(Token = "0x170004D6")]
	public IReadOnlyList<IAsyncProgressContent> asyncProgressContents
	{
		[Token(Token = "0x60027AE")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004D7")]
	public GameObject gameObject
	{
		[Token(Token = "0x60027AF")]
		[Address(RVA = "0x6A94A0", Offset = "0x6A86A0", VA = "0x1806A94A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004D8")]
	public Transform transform
	{
		[Token(Token = "0x60027B0")]
		[Address(RVA = "0x6A94C0", Offset = "0x6A86C0", VA = "0x1806A94C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004D9")]
	public virtual bool visible
	{
		[Token(Token = "0x60027B1")]
		[Address(RVA = "0x6A94E0", Offset = "0x6A86E0", VA = "0x1806A94E0", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60027B2")]
		[Address(RVA = "0x6A9580", Offset = "0x6A8780", VA = "0x1806A9580", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x60027B3")]
	[Address(RVA = "0x6A1440", Offset = "0x6A0640", VA = "0x1806A1440")]
	public ElementWidgetBase(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x60027B4")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "9")]
	public virtual void Clear()
	{
	}

	[Token(Token = "0x60027B5")]
	[Address(RVA = "0x6A9370", Offset = "0x6A8570", VA = "0x1806A9370")]
	protected void AssignProgressContent(IAsyncProgressContent progressContent)
	{
	}

	[Token(Token = "0x60027B6")]
	[Address(RVA = "0x6A9510", Offset = "0x6A8710", VA = "0x1806A9510")]
	public static implicit operator bool(ElementWidgetBase exists)
	{
		return default(bool);
	}
}
