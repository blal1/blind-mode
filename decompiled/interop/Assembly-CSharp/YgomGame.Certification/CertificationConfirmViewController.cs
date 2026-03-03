using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Certification;

[Token(Token = "0x20014B0")]
public class CertificationConfirmViewController : BaseMenuViewController, IDynamicHeaderCustomSupported, IDynamicChangeDispHeaderSupported
{
	[Token(Token = "0x20014B1")]
	public class Content
	{
		[Token(Token = "0x400C78B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly int grade;

		[Token(Token = "0x400C78C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string writingTerm;

		[Token(Token = "0x400C78D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly string practicalTerm;

		[Token(Token = "0x400C78E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly CertificationUtil.ProgressState progressState;

		[Token(Token = "0x400C78F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public readonly bool isAnimation;

		[Token(Token = "0x600804A")]
		[Address(RVA = "0xC978E0", Offset = "0xC96AE0", VA = "0x180C978E0")]
		public Content(int grade, string writingTerm, string practicalTerm, CertificationUtil.ProgressState progressState, bool isAnimation)
		{
		}
	}

	[Token(Token = "0x20014B2")]
	[CompilerGenerated]
	private sealed class _003CyCompleteAnimation_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CertificationConfirmViewController _003C_003E4__this;

		[Token(Token = "0x170013B0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600804E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170013B1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008050")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600804B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyCompleteAnimation_003Ed__32(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600804C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600804D")]
		[Address(RVA = "0xC9B490", Offset = "0xC9A690", VA = "0x180C9B490", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600804F")]
		[Address(RVA = "0xC9B600", Offset = "0xC9A800", VA = "0x180C9B600", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C778")]
	private const string k_PREF_PATH = "Certification/CertificationConfirm";

	[Token(Token = "0x400C779")]
	private const string k_ArgsKeyContent = "Content";

	[Token(Token = "0x400C77A")]
	private const string k_ArgsKeyViewStyleOverride = "viewStyleOverride";

	[Token(Token = "0x400C77B")]
	private const string k_ArgsKeyAction = "Action";

	[Token(Token = "0x400C77C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelButton;

	[Token(Token = "0x400C77D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelText;

	[Token(Token = "0x400C77E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelTextMax;

	[Token(Token = "0x400C77F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelTextChallenging;

	[Token(Token = "0x400C780")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelTextExistReward;

	[Token(Token = "0x400C781")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelImage;

	[Token(Token = "0x400C782")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string k_ELabelBG;

	[Token(Token = "0x400C783")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string k_ELabelProductNameText;

	[Token(Token = "0x400C784")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string k_ELabelTemplatePractical;

	[Token(Token = "0x400C785")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string k_ELabelTemplateWriting;

	[Token(Token = "0x400C786")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly string k_TweenLabelDefault;

	[Token(Token = "0x400C787")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly string k_TweenLabelComplete;

	[Token(Token = "0x400C788")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly string k_TweenLabelAnimate;

	[Token(Token = "0x400C789")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Content m_Content;

	[Token(Token = "0x400C78A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private Action m_OnFinish;

	[Token(Token = "0x170013AE")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6008039")]
		[Address(RVA = "0xC72C20", Offset = "0xC71E20", VA = "0x180C72C20", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013AF")]
	protected override int outGameBgId
	{
		[Token(Token = "0x600803A")]
		[Address(RVA = "0xC72C00", Offset = "0xC71E00", VA = "0x180C72C00", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600803B")]
	[Address(RVA = "0xC71990", Offset = "0xC70B90", VA = "0x180C71990")]
	public static void Open(ViewControllerManager vcm, Content content, ViewStyle viewStyle, [Optional] Action onFinish)
	{
	}

	[Token(Token = "0x600803C")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600803D")]
	[Address(RVA = "0xC71710", Offset = "0xC70910", VA = "0x180C71710", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x600803E")]
	[Address(RVA = "0xC71950", Offset = "0xC70B50", VA = "0x180C71950", Slot = "24")]
	protected override void OnTransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x600803F")]
	[Address(RVA = "0xC71750", Offset = "0xC70950", VA = "0x180C71750", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6008040")]
	[Address(RVA = "0xC713A0", Offset = "0xC705A0", VA = "0x180C713A0")]
	private void InitView()
	{
	}

	[Token(Token = "0x6008041")]
	[Address(RVA = "0xC72160", Offset = "0xC71360", VA = "0x180C72160")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x6008042")]
	[Address(RVA = "0xC71C80", Offset = "0xC70E80", VA = "0x180C71C80")]
	private void UpdateState()
	{
	}

	[Token(Token = "0x6008043")]
	[Address(RVA = "0xC72CF0", Offset = "0xC71EF0", VA = "0x180C72CF0")]
	[IteratorStateMachine(typeof(_003CyCompleteAnimation_003Ed__32))]
	private IEnumerator yCompleteAnimation()
	{
		return null;
	}

	[Token(Token = "0x6008044")]
	[Address(RVA = "0x5EA820", Offset = "0x5E9A20", VA = "0x1805EA820")]
	private bool IsOverlay()
	{
		return default(bool);
	}

	[Token(Token = "0x6008045")]
	[Address(RVA = "0xC72970", Offset = "0xC71B70", VA = "0x180C72970", Slot = "28")]
	private HeaderViewController.IsDispHeader YgomGame_002EMenu_002EIDynamicChangeDispHeaderSupported_002EIsDispContents()
	{
		return default(HeaderViewController.IsDispHeader);
	}

	[Token(Token = "0x6008046")]
	[Address(RVA = "0xC72980", Offset = "0xC71B80", VA = "0x180C72980")]
	public CertificationConfirmViewController()
	{
	}
}
