using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.Network;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B57")]
public class PromoCodeInviteReceiveBehaviour : PromoCodeInviteBehaviourBase
{
	[Token(Token = "0x40096AC")]
	private const int k_CodeSuccessStep_RefreshView = 0;

	[Token(Token = "0x40096AD")]
	private const int k_CodeSuccessStep_RewardDialog = 1;

	[Token(Token = "0x40096AE")]
	private const int k_CodeSuccessStep_ResultMessageDialog = 2;

	[Token(Token = "0x40096AF")]
	private const int k_CodeSuccessStep_RewardAction = 3;

	[Token(Token = "0x1700094A")]
	public static string actionLabel
	{
		[Token(Token = "0x6004578")]
		[Address(RVA = "0x8EAFE0", Offset = "0x8EA1E0", VA = "0x1808EAFE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700094B")]
	public override IPromoCodeBehaviour.Type type
	{
		[Token(Token = "0x6004579")]
		[Address(RVA = "0x44E380", Offset = "0x44D580", VA = "0x18044E380", Slot = "21")]
		get
		{
			return default(IPromoCodeBehaviour.Type);
		}
	}

	[Token(Token = "0x1700094C")]
	public override string titleBodyText
	{
		[Token(Token = "0x600457A")]
		[Address(RVA = "0x8EB040", Offset = "0x8EA240", VA = "0x1808EB040", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600457B")]
	[Address(RVA = "0x8E9C90", Offset = "0x8E8E90", VA = "0x1808E9C90")]
	private string MakeInputGuideText(int invitationId, PromoCodeFormat format, int length)
	{
		return null;
	}

	[Token(Token = "0x600457C")]
	[Address(RVA = "0x8EAFD0", Offset = "0x8EA1D0", VA = "0x1808EAFD0")]
	public PromoCodeInviteReceiveBehaviour(Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600457D")]
	[Address(RVA = "0x8EA540", Offset = "0x8E9740", VA = "0x1808EA540", Slot = "34")]
	protected override void OnAssignTemplate(List<InfinityScrollWidget.Source.TemplateInfo> templateInfos)
	{
	}

	[Token(Token = "0x600457E")]
	[Address(RVA = "0x8EAEA0", Offset = "0x8EA0A0", VA = "0x1808EAEA0", Slot = "31")]
	protected override void OnSetupScrollWidget(InfinityScrollWidget scrollWidget)
	{
	}

	[Token(Token = "0x600457F")]
	[Address(RVA = "0x8E9E50", Offset = "0x8E9050", VA = "0x1808E9E50", Slot = "35")]
	protected override void OnAssignData(Dictionary<string, object> detailWork)
	{
	}

	[Token(Token = "0x6004580")]
	[Address(RVA = "0x8EA750", Offset = "0x8E9950", VA = "0x1808EA750")]
	private void OnCodeDecided(string inviteCode)
	{
	}

	[Token(Token = "0x6004581")]
	[Address(RVA = "0x8EA9B0", Offset = "0x8E9BB0", VA = "0x1808EA9B0")]
	private void OnCodeSendResult(Handle h)
	{
	}

	[Token(Token = "0x6004582")]
	[Address(RVA = "0x8EABB0", Offset = "0x8E9DB0", VA = "0x1808EABB0")]
	private void OnCodeSuccess(Dictionary<string, object> resultWork, int step = 0)
	{
	}

	[Token(Token = "0x6004583")]
	[Address(RVA = "0x8EA830", Offset = "0x8E9A30", VA = "0x1808EA830")]
	private void OnCodeFailed(Dictionary<string, object> resultWork, InvitationCode resultCode)
	{
	}
}
