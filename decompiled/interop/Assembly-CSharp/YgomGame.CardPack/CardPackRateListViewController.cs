using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.CardPack.RateMMAData;
using YgomGame.Menu;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.CardPack;

[Token(Token = "0x2001529")]
public class CardPackRateListViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x400CB74")]
	private const string k_ArgPackId = "packId";

	[Token(Token = "0x400CB75")]
	private const string k_ArgShopId = "shopId";

	[Token(Token = "0x400CB76")]
	private const string k_ArgKey_SkipRequest = "skipRequest";

	[Token(Token = "0x170013F4")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60082C6")]
		[Address(RVA = "0xCBAED0", Offset = "0xCBA0D0", VA = "0x180CBAED0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013F5")]
	protected override int outGameBgId
	{
		[Token(Token = "0x60082C7")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60082C8")]
	[Address(RVA = "0xCBA0F0", Offset = "0xCB92F0", VA = "0x180CBA0F0")]
	public static void HandleGetProbabilityResultCode(Handle h, [Optional] Action onSuccess)
	{
	}

	[Token(Token = "0x60082C9")]
	[Address(RVA = "0xCBAB90", Offset = "0xCB9D90", VA = "0x180CBAB90")]
	public static void Open(int packId, int shopId, bool skipRequest = false, [Optional] Dictionary<string, object> args, [Optional] ViewControllerManager manager)
	{
	}

	[Token(Token = "0x60082CA")]
	[Address(RVA = "0xCBAA20", Offset = "0xCB9C20", VA = "0x180CBAA20", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60082CB")]
	[Address(RVA = "0xCBAB70", Offset = "0xCB9D70", VA = "0x180CBAB70", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60082CC")]
	[Address(RVA = "0xCBA170", Offset = "0xCB9370", VA = "0x180CBA170")]
	private void LaunchMDMarkupAsset()
	{
	}

	[Token(Token = "0x60082CD")]
	[Address(RVA = "0xCB9F40", Offset = "0xCB9140", VA = "0x180CB9F40")]
	private IMMAData CreateMMAData(Dictionary<string, object> mmaData)
	{
		return null;
	}

	[Token(Token = "0x60082CE")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public CardPackRateListViewController()
	{
	}
}
