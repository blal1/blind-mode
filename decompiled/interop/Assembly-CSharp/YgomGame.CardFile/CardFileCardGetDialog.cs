using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.Timeline;

namespace YgomGame.CardFile;

[Token(Token = "0x2001583")]
public class CardFileCardGetDialog : BaseMenuViewController, IBokeSupported
{
	[Token(Token = "0x2001584")]
	private enum GetDialogStatus
	{
		[Token(Token = "0x400CD7C")]
		Start,
		[Token(Token = "0x400CD7D")]
		Get,
		[Token(Token = "0x400CD7E")]
		Complete,
		[Token(Token = "0x400CD7F")]
		Max
	}

	[Token(Token = "0x2001585")]
	[CompilerGenerated]
	private sealed class _003CDelaySelect_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400CD80")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400CD81")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400CD82")]
		[FieldOffset(Offset = "0x20")]
		public CardFileCardGetDialog _003C_003E4__this;

		[Token(Token = "0x17001483")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600856E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001484")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008570")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600856B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CDelaySelect_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600856C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600856D")]
		[Address(RVA = "0xCE1A10", Offset = "0xCE0C10", VA = "0x180CE1A10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600856F")]
		[Address(RVA = "0xCE1AE0", Offset = "0xCE0CE0", VA = "0x180CE1AE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400CD6C")]
	[FieldOffset(Offset = "0xD0")]
	private readonly Dictionary<GetDialogStatus, string> m_StatusLabel;

	[Token(Token = "0x400CD6D")]
	private const string PREFAB_PATH_CARDFILE_CARDGETDIALOG = "CardFile/CardFileCardGetDialog";

	[Token(Token = "0x400CD6E")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelTextNum;

	[Token(Token = "0x400CD6F")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelTextRate;

	[Token(Token = "0x400CD70")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelButtonOK;

	[Token(Token = "0x400CD71")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string k_ArgsLabelkey1;

	[Token(Token = "0x400CD72")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string k_ArgsLabelkey2;

	[Token(Token = "0x400CD73")]
	[FieldOffset(Offset = "0x10")]
	private static readonly string k_ArgsLabelkey3;

	[Token(Token = "0x400CD74")]
	[FieldOffset(Offset = "0x18")]
	private static readonly string k_ArgsLabelkey4;

	[Token(Token = "0x400CD75")]
	[FieldOffset(Offset = "0xF0")]
	private LabeledPlayableController m_TLDialog;

	[Token(Token = "0x400CD76")]
	[FieldOffset(Offset = "0xF8")]
	private bool m_IsPlayAnim;

	[Token(Token = "0x400CD77")]
	[FieldOffset(Offset = "0xFC")]
	private int m_BeforeHaveNum;

	[Token(Token = "0x400CD78")]
	[FieldOffset(Offset = "0x100")]
	private int m_AfterHaveNum;

	[Token(Token = "0x400CD79")]
	[FieldOffset(Offset = "0x104")]
	private int m_CompleteNum;

	[Token(Token = "0x400CD7A")]
	[FieldOffset(Offset = "0x108")]
	private Action m_FinishedAction;

	[Token(Token = "0x6008561")]
	[Address(RVA = "0x540540", Offset = "0x53F740", VA = "0x180540540", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6008562")]
	[Address(RVA = "0xCCFC20", Offset = "0xCCEE20", VA = "0x180CCFC20", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6008563")]
	[Address(RVA = "0xCCFF20", Offset = "0xCCF120", VA = "0x180CCFF20")]
	public static void Open(int beforeHaveNum, int afterHaveNum, int maxNum, Action callback)
	{
	}

	[Token(Token = "0x6008564")]
	[Address(RVA = "0xCCF8B0", Offset = "0xCCEAB0", VA = "0x180CCF8B0")]
	private void InitializeSetting()
	{
	}

	[Token(Token = "0x6008565")]
	[Address(RVA = "0xCD0100", Offset = "0xCCF300", VA = "0x180CD0100")]
	private void Start()
	{
	}

	[Token(Token = "0x6008566")]
	[Address(RVA = "0xCD0200", Offset = "0xCCF400", VA = "0x180CD0200")]
	private void Update()
	{
	}

	[Token(Token = "0x6008567")]
	[Address(RVA = "0xCCF840", Offset = "0xCCEA40", VA = "0x180CCF840")]
	[IteratorStateMachine(typeof(_003CDelaySelect_003Ed__22))]
	private IEnumerator DelaySelect()
	{
		return null;
	}

	[Token(Token = "0x6008568")]
	[Address(RVA = "0xCD0600", Offset = "0xCCF800", VA = "0x180CD0600")]
	public CardFileCardGetDialog()
	{
	}
}
