using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;

namespace YgomGame.Menu.USAStateSelect;

[Token(Token = "0x20013F6")]
public class USAStateSelectViewController : CommonScreenViewController
{
	[Token(Token = "0x400C4A8")]
	[FieldOffset(Offset = "0x118")]
	private Action<int> m_resultCallback;

	[Token(Token = "0x400C4A9")]
	[FieldOffset(Offset = "0x120")]
	private IReadOnlyList<int> m_codeList;

	[Token(Token = "0x400C4AA")]
	[FieldOffset(Offset = "0x128")]
	private IReadOnlyList<string> m_nameList;

	[Token(Token = "0x400C4AB")]
	[FieldOffset(Offset = "0x130")]
	private int m_currentIndex;

	[Token(Token = "0x400C4AC")]
	[FieldOffset(Offset = "0x138")]
	private TMP_Text m_currentNameText;

	[Token(Token = "0x6007C37")]
	[Address(RVA = "0xC6A420", Offset = "0xC69620", VA = "0x180C6A420")]
	private void createList(int defaultState)
	{
	}

	[Token(Token = "0x6007C38")]
	[Address(RVA = "0xC6A5E0", Offset = "0xC697E0", VA = "0x180C6A5E0")]
	private void updateButonText()
	{
	}

	[Token(Token = "0x6007C39")]
	[Address(RVA = "0xC69E10", Offset = "0xC69010", VA = "0x180C69E10", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007C3A")]
	[Address(RVA = "0xC69EE0", Offset = "0xC690E0", VA = "0x180C69EE0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6007C3B")]
	[Address(RVA = "0xB59690", Offset = "0xB58890", VA = "0x180B59690")]
	private void Start()
	{
	}

	[Token(Token = "0x6007C3C")]
	[Address(RVA = "0x543AE0", Offset = "0x542CE0", VA = "0x180543AE0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6007C3D")]
	[Address(RVA = "0xB513D0", Offset = "0xB505D0", VA = "0x180B513D0")]
	public USAStateSelectViewController()
	{
	}
}
