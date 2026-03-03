using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;

namespace YgomGame.Menu;

[Token(Token = "0x20012F4")]
public class LanguageSelectViewController : CommonScreenViewController
{
	[Token(Token = "0x400BE73")]
	[FieldOffset(Offset = "0x118")]
	private List<string> m_langCodeList;

	[Token(Token = "0x400BE74")]
	[FieldOffset(Offset = "0x120")]
	private List<string> m_langNameList;

	[Token(Token = "0x400BE75")]
	[FieldOffset(Offset = "0x128")]
	private int m_currentIndex;

	[Token(Token = "0x400BE76")]
	[FieldOffset(Offset = "0x130")]
	private TMP_Text m_currentLangText;

	[Token(Token = "0x400BE77")]
	[FieldOffset(Offset = "0x138")]
	private Action<string> m_resultCallback;

	[Token(Token = "0x17001267")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60075BE")]
		[Address(RVA = "0xBC2230", Offset = "0xBC1430", VA = "0x180BC2230", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60075BF")]
	[Address(RVA = "0xBC1F50", Offset = "0xBC1150", VA = "0x180BC1F50")]
	private void createLanguageList()
	{
	}

	[Token(Token = "0x60075C0")]
	[Address(RVA = "0xBC18A0", Offset = "0xBC0AA0", VA = "0x180BC18A0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60075C1")]
	[Address(RVA = "0xBC18D0", Offset = "0xBC0AD0", VA = "0x180BC18D0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60075C2")]
	[Address(RVA = "0xB59690", Offset = "0xB58890", VA = "0x180B59690")]
	private void Start()
	{
	}

	[Token(Token = "0x60075C3")]
	[Address(RVA = "0x543AE0", Offset = "0x542CE0", VA = "0x180543AE0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60075C4")]
	[Address(RVA = "0xB513D0", Offset = "0xB505D0", VA = "0x180B513D0")]
	public LanguageSelectViewController()
	{
	}
}
