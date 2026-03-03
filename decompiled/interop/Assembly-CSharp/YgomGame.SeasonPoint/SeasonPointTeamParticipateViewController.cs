using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.FreeScroll;

namespace YgomGame.SeasonPoint;

[Token(Token = "0x2000A41")]
public class SeasonPointTeamParticipateViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x40090DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private string L_TeamIdInputArea;

	[Token(Token = "0x40090DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private string L_InputField;

	[Token(Token = "0x40090DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private string L_ButtonDetail;

	[Token(Token = "0x40090DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private InputFieldWidget inputFieldWidget;

	[Token(Token = "0x40090E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private int idMaxLength;

	[Token(Token = "0x40090E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private FreeScrollView m_FreeScrollView;

	[Token(Token = "0x40090E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private ScrollRect m_ScrollRect;

	[Token(Token = "0x17000859")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6003ECD")]
		[Address(RVA = "0x870120", Offset = "0x86F320", VA = "0x180870120", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003ECE")]
	[Address(RVA = "0x86FCD0", Offset = "0x86EED0", VA = "0x18086FCD0")]
	public static void Open([Optional] Action callback)
	{
	}

	[Token(Token = "0x6003ECF")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6003ED0")]
	[Address(RVA = "0x86F750", Offset = "0x86E950", VA = "0x18086F750", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6003ED1")]
	[Address(RVA = "0x86FDF0", Offset = "0x86EFF0", VA = "0x18086FDF0")]
	private void Start()
	{
	}

	[Token(Token = "0x6003ED2")]
	[Address(RVA = "0x86FBD0", Offset = "0x86EDD0", VA = "0x18086FBD0")]
	private void OnValueChanged(string input)
	{
	}

	[Token(Token = "0x6003ED3")]
	[Address(RVA = "0x86F5E0", Offset = "0x86E7E0", VA = "0x18086F5E0")]
	private void OnClickOK(string id)
	{
	}

	[Token(Token = "0x6003ED4")]
	[Address(RVA = "0x86F540", Offset = "0x86E740", VA = "0x18086F540")]
	private void CallAPITeamParticipate(int id)
	{
	}

	[Token(Token = "0x6003ED5")]
	[Address(RVA = "0x870060", Offset = "0x86F260", VA = "0x180870060")]
	public SeasonPointTeamParticipateViewController()
	{
	}
}
