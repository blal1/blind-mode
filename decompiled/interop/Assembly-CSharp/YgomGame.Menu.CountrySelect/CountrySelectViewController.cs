using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;

namespace YgomGame.Menu.CountrySelect;

[Token(Token = "0x20013FC")]
public class CountrySelectViewController : CommonScreenViewController
{
	[Token(Token = "0x400C4BC")]
	[FieldOffset(Offset = "0x118")]
	private Action<int> m_resultCallback;

	[Token(Token = "0x400C4BD")]
	[FieldOffset(Offset = "0x120")]
	private IReadOnlyList<int> m_codeList;

	[Token(Token = "0x400C4BE")]
	[FieldOffset(Offset = "0x128")]
	private IReadOnlyList<string> m_nameList;

	[Token(Token = "0x400C4BF")]
	[FieldOffset(Offset = "0x130")]
	private int m_currentIndex;

	[Token(Token = "0x400C4C0")]
	[FieldOffset(Offset = "0x138")]
	private TMP_Text m_currentNameText;

	[Token(Token = "0x6007C54")]
	[Address(RVA = "0xC60830", Offset = "0xC5FA30", VA = "0x180C60830")]
	private void createList(int defaultCountry)
	{
	}

	[Token(Token = "0x6007C55")]
	[Address(RVA = "0xC60150", Offset = "0xC5F350", VA = "0x180C60150", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007C56")]
	[Address(RVA = "0xC60220", Offset = "0xC5F420", VA = "0x180C60220", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6007C57")]
	[Address(RVA = "0xB59690", Offset = "0xB58890", VA = "0x180B59690")]
	private void Start()
	{
	}

	[Token(Token = "0x6007C58")]
	[Address(RVA = "0x543AE0", Offset = "0x542CE0", VA = "0x180543AE0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6007C59")]
	[Address(RVA = "0xB513D0", Offset = "0xB505D0", VA = "0x180B513D0")]
	public CountrySelectViewController()
	{
	}
}
