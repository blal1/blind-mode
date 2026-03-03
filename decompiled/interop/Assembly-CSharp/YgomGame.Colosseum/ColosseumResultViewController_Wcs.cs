using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001CAE")]
public class ColosseumResultViewController_Wcs : ColosseumResultViewController
{
	[Token(Token = "0x401004A")]
	protected const string KEY_LOGO_ID = "LogoId";

	[Token(Token = "0x600B9BA")]
	[Address(RVA = "0x54CBC0", Offset = "0x54BDC0", VA = "0x18054CBC0", Slot = "28")]
	protected override string GetBgPath()
	{
		return null;
	}

	[Token(Token = "0x600B9BB")]
	[Address(RVA = "0x54CA20", Offset = "0x54BC20", VA = "0x18054CA20")]
	public static Dictionary<string, object> GetArgs(string tournamentName, AwardType awardType, int dispOrder, int logoId, [Optional] UnityAction onFinish)
	{
		return null;
	}

	[Token(Token = "0x600B9BC")]
	[Address(RVA = "0x54CE40", Offset = "0x54C040", VA = "0x18054CE40", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600B9BD")]
	[Address(RVA = "0x54CFE0", Offset = "0x54C1E0", VA = "0x18054CFE0", Slot = "24")]
	protected override void OnTransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x600B9BE")]
	[Address(RVA = "0x54D1E0", Offset = "0x54C3E0", VA = "0x18054D1E0", Slot = "29")]
	protected override void SetCupImage(ElementObjectManager targetEom, bool existNumLogo, AwardType awardType, ColosseumUtil.PlayMode kind, int logoId = -1)
	{
	}

	[Token(Token = "0x600B9BF")]
	[Address(RVA = "0x54CCD0", Offset = "0x54BED0", VA = "0x18054CCD0", Slot = "30")]
	protected override string GetCupName(bool existNumLogo, AwardType awardType, int logoId = -1)
	{
		return null;
	}

	[Token(Token = "0x600B9C0")]
	[Address(RVA = "0x54CDB0", Offset = "0x54BFB0", VA = "0x18054CDB0")]
	private string GetTweenLavel(AwardType awardType)
	{
		return null;
	}

	[Token(Token = "0x600B9C1")]
	[Address(RVA = "0x54D2B0", Offset = "0x54C4B0", VA = "0x18054D2B0")]
	public ColosseumResultViewController_Wcs()
	{
	}
}
