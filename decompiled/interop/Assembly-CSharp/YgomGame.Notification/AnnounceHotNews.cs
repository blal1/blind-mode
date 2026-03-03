using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.MDMarkup;

namespace YgomGame.Notification;

[Token(Token = "0x2000C34")]
public class AnnounceHotNews : HomeAnnounceBehaviourBase
{
	[Token(Token = "0x6004A93")]
	[Address(RVA = "0x930490", Offset = "0x92F690", VA = "0x180930490", Slot = "5")]
	public override bool IsOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6004A94")]
	[Address(RVA = "0x9304F0", Offset = "0x92F6F0", VA = "0x1809304F0", Slot = "4")]
	public override void Open()
	{
	}

	[Token(Token = "0x6004A95")]
	[Address(RVA = "0x930500", Offset = "0x92F700", VA = "0x180930500")]
	public void PushMMA([Optional] Action onClosed, MDMarkupDef.CloseButtonType mmaCloseButtonType = MDMarkupDef.CloseButtonType.ReachLast)
	{
	}

	[Token(Token = "0x6004A96")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public AnnounceHotNews()
	{
	}
}
