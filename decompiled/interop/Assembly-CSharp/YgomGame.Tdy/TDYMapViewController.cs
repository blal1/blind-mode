using System;
using System.Diagnostics;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.Tdy;

[Token(Token = "0x2000866")]
public class TDYMapViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x400862A")]
	private const string MMA_HELP_PATH = "MDMarkupAsset/Tdy/MDMarkupTdyKizunaMapInfo";

	[Token(Token = "0x400862B")]
	[FieldOffset(Offset = "0xD0")]
	private TDYMapWidget _mapWidget;

	[Token(Token = "0x400862C")]
	[FieldOffset(Offset = "0xD8")]
	private TDYMapValueChangeControl _mapControl;

	[Token(Token = "0x400862D")]
	[FieldOffset(Offset = "0xE0")]
	private TDYMapParam _param;

	[Token(Token = "0x400862E")]
	[FieldOffset(Offset = "0xE8")]
	private Handle _pollingResult;

	[Token(Token = "0x400862F")]
	[FieldOffset(Offset = "0xF0")]
	private bool _errorOccured;

	[Token(Token = "0x4008630")]
	[FieldOffset(Offset = "0xF4")]
	private float _remainedPollingTime;

	[Token(Token = "0x4008631")]
	[FieldOffset(Offset = "0xF8")]
	private float _pollingTimestamp;

	[Token(Token = "0x1700065A")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60032F4")]
		[Address(RVA = "0x752B70", Offset = "0x751D70", VA = "0x180752B70", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60032F5")]
	[Address(RVA = "0x7517F0", Offset = "0x7509F0", VA = "0x1807517F0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60032F6")]
	[Address(RVA = "0x7518F0", Offset = "0x750AF0", VA = "0x1807518F0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60032F7")]
	[Address(RVA = "0x751CD0", Offset = "0x750ED0", VA = "0x180751CD0")]
	private void OnVisibleStart()
	{
	}

	[Token(Token = "0x60032F8")]
	[Address(RVA = "0x751A40", Offset = "0x750C40", VA = "0x180751A40", Slot = "24")]
	protected override void OnTransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x60032F9")]
	[Address(RVA = "0x752AA0", Offset = "0x751CA0", VA = "0x180752AA0")]
	private void Update()
	{
	}

	[Token(Token = "0x60032FA")]
	[Address(RVA = "0x752820", Offset = "0x751A20", VA = "0x180752820")]
	private void UpdatePolling()
	{
	}

	[Token(Token = "0x60032FB")]
	[Address(RVA = "0x751950", Offset = "0x750B50", VA = "0x180751950")]
	private void OnPollingResponse(Handle res)
	{
	}

	[Token(Token = "0x60032FC")]
	[Address(RVA = "0x7525E0", Offset = "0x7517E0", VA = "0x1807525E0")]
	private void OpenHelp()
	{
	}

	[Token(Token = "0x60032FD")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("YGO_DEBUG")]
	private void CreateParamDebug(ref TDYMapParam param)
	{
	}

	[Token(Token = "0x60032FE")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public TDYMapViewController()
	{
	}
}
