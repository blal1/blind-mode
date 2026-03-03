using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B59")]
public class PromoCodeInviteSendBehaviour : PromoCodeInviteBehaviourBase, IPromoCodeBehaviourSupportedFooter
{
	[Token(Token = "0x40096B3")]
	[FieldOffset(Offset = "0xF0")]
	private string m_InviteCode;

	[Token(Token = "0x1700094D")]
	public static string actionLabel
	{
		[Token(Token = "0x6004588")]
		[Address(RVA = "0x8EBD10", Offset = "0x8EAF10", VA = "0x1808EBD10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700094E")]
	public override string titleBodyText
	{
		[Token(Token = "0x6004589")]
		[Address(RVA = "0x8EBD70", Offset = "0x8EAF70", VA = "0x1808EBD70", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700094F")]
	public override IPromoCodeBehaviour.Type type
	{
		[Token(Token = "0x600458B")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "21")]
		get
		{
			return default(IPromoCodeBehaviour.Type);
		}
	}

	[Token(Token = "0x600458A")]
	[Address(RVA = "0x8EAFD0", Offset = "0x8EA1D0", VA = "0x1808EAFD0")]
	public PromoCodeInviteSendBehaviour(Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600458C")]
	[Address(RVA = "0x8EB980", Offset = "0x8EAB80", VA = "0x1808EB980", Slot = "34")]
	protected override void OnAssignTemplate(List<InfinityScrollWidget.Source.TemplateInfo> templateInfos)
	{
	}

	[Token(Token = "0x600458D")]
	[Address(RVA = "0x8EBBC0", Offset = "0x8EADC0", VA = "0x1808EBBC0", Slot = "31")]
	protected override void OnSetupScrollWidget(InfinityScrollWidget scrollWidget)
	{
	}

	[Token(Token = "0x600458E")]
	[Address(RVA = "0x8EB1F0", Offset = "0x8EA3F0", VA = "0x1808EB1F0", Slot = "35")]
	protected override void OnAssignData(Dictionary<string, object> detailWork)
	{
	}

	[Token(Token = "0x600458F")]
	[Address(RVA = "0x8EB0A0", Offset = "0x8EA2A0", VA = "0x1808EB0A0", Slot = "33")]
	protected override Action MakeSchemeAction(string scheme, object source)
	{
		return null;
	}
}
