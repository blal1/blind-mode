using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001450")]
public class BindingStructure : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
{
	[Token(Token = "0x400C650")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int m_ItemId;

	[Token(Token = "0x400C651")]
	[FieldOffset(Offset = "0x24")]
	private uint m_PrefCrc;

	[Token(Token = "0x400C652")]
	[FieldOffset(Offset = "0x28")]
	private DeckCaseWidget m_DeckCaseWidget;

	[Token(Token = "0x400C653")]
	[FieldOffset(Offset = "0x30")]
	private bool m_WidgetDirty;

	[Token(Token = "0x17001381")]
	public int itemId
	{
		[Token(Token = "0x6007E95")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007E96")]
		[Address(RVA = "0xC6F250", Offset = "0xC6E450", VA = "0x180C6F250")]
		set
		{
		}
	}

	[Token(Token = "0x17001382")]
	public bool visible
	{
		[Token(Token = "0x6007E97")]
		[Address(RVA = "0x521190", Offset = "0x520390", VA = "0x180521190", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x140000A3")]
	public event Action onReloadEvent
	{
		[Token(Token = "0x6007E98")]
		[Address(RVA = "0xC6F110", Offset = "0xC6E310", VA = "0x180C6F110", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6007E99")]
		[Address(RVA = "0xC6F1B0", Offset = "0xC6E3B0", VA = "0x180C6F1B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6007E9A")]
	[Address(RVA = "0xC6E790", Offset = "0xC6D990", VA = "0x180C6E790", Slot = "7")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6007E9B")]
	[Address(RVA = "0xC6E700", Offset = "0xC6D900", VA = "0x180C6E700")]
	public static BindingStructure Binding(GameObject target, int itemId)
	{
		return null;
	}

	[Token(Token = "0x6007E9C")]
	[Address(RVA = "0xC6E840", Offset = "0xC6DA40", VA = "0x180C6E840")]
	private void SourceChange()
	{
	}

	[Token(Token = "0x6007E9D")]
	[Address(RVA = "0xC6E880", Offset = "0xC6DA80", VA = "0x180C6E880")]
	private void Update()
	{
	}

	[Token(Token = "0x6007E9E")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	public void ProgressUpdate()
	{
	}

	[Token(Token = "0x6007E9F")]
	[Address(RVA = "0xC6E810", Offset = "0xC6DA10", VA = "0x180C6E810")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007EA0")]
	[Address(RVA = "0x51AA40", Offset = "0x519C40", VA = "0x18051AA40")]
	public BindingStructure()
	{
	}
}
