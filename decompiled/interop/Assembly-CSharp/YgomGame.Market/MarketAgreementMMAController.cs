using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using YgomGame.MDMarkup;
using YgomSystem.UI;

namespace YgomGame.Market;

[Token(Token = "0x2000D1E")]
public class MarketAgreementMMAController : MDMarkupAssetBehaviourControllerBase
{
	[Token(Token = "0x2000D21")]
	[CompilerGenerated]
	private sealed class _003COnPostprocessMMA_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009D8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009D8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009D8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MarketAgreementMMAController _003C_003E4__this;

		[Token(Token = "0x4009D8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IMDMarkupContainerWidget containerWidget;

		[Token(Token = "0x17000B57")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004F2F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B58")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004F31")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F2C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003COnPostprocessMMA_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004F2D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004F2E")]
		[Address(RVA = "0x979500", Offset = "0x978700", VA = "0x180979500", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004F30")]
		[Address(RVA = "0x979660", Offset = "0x978860", VA = "0x180979660", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009D7D")]
	private const string k_MMAPath = "Help/MMA/Market/MMAMarketAgreement";

	[Token(Token = "0x4009D7E")]
	internal const string k_ArgKey_FromShopId = "fromShopId";

	[Token(Token = "0x4009D7F")]
	internal const string k_ArgKey_PopOnSubmit = "popOnSubmit";

	[Token(Token = "0x4009D80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly int m_MarketId;

	[Token(Token = "0x4009D81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int fromShopId;

	[Token(Token = "0x4009D82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool popOnSubmit;

	[Token(Token = "0x4009D83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private TMP_Text m_StateLabel;

	[Token(Token = "0x4009D84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private SelectionButton m_EditButton;

	[Token(Token = "0x4009D85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private TMP_Text m_EditButtonLabel;

	[Token(Token = "0x17000B56")]
	public bool fromShop
	{
		[Token(Token = "0x6004F1A")]
		[Address(RVA = "0x975F00", Offset = "0x975100", VA = "0x180975F00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004F1B")]
	[Address(RVA = "0x975830", Offset = "0x974A30", VA = "0x180975830")]
	public static bool Open(int marketId, [Optional] Dictionary<string, object> args)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F1C")]
	[Address(RVA = "0x975ED0", Offset = "0x9750D0", VA = "0x180975ED0")]
	public MarketAgreementMMAController(int marketId)
	{
	}

	[Token(Token = "0x6004F1D")]
	[Address(RVA = "0x9756E0", Offset = "0x9748E0", VA = "0x1809756E0", Slot = "10")]
	protected override void OnNotificationStackEntry()
	{
	}

	[Token(Token = "0x6004F1E")]
	[Address(RVA = "0x975740", Offset = "0x974940", VA = "0x180975740", Slot = "13")]
	protected override void OnNotificationStackRemove()
	{
	}

	[Token(Token = "0x6004F1F")]
	[Address(RVA = "0x9757A0", Offset = "0x9749A0", VA = "0x1809757A0", Slot = "11")]
	[IteratorStateMachine(typeof(_003COnPostprocessMMA_003Ed__15))]
	protected override IEnumerator OnPostprocessMMA(IMDMarkupContainerWidget containerWidget)
	{
		return null;
	}

	[Token(Token = "0x6004F20")]
	[Address(RVA = "0x975B50", Offset = "0x974D50", VA = "0x180975B50")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x6004F21")]
	[Address(RVA = "0x9751B0", Offset = "0x9743B0", VA = "0x1809751B0")]
	private void OnClickToAgreeButton()
	{
	}

	[Token(Token = "0x6004F22")]
	[Address(RVA = "0x9752E0", Offset = "0x9744E0", VA = "0x1809752E0")]
	private void OnClickToRejectButton()
	{
	}

	[Token(Token = "0x6004F23")]
	[Address(RVA = "0x975DA0", Offset = "0x974FA0", VA = "0x180975DA0")]
	private void RequestEditAgree(bool value, bool fromShop)
	{
	}

	[Token(Token = "0x6004F24")]
	[Address(RVA = "0x975410", Offset = "0x974610", VA = "0x180975410")]
	private void OnCompleted()
	{
	}
}
