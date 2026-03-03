using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.MDMarkup;
using YgomGame.Menu;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.Utility;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B45")]
public class PromoCodesViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported, IPromoCodeBehaviourHandler, IPromoCodeBehaviourFooterHandler
{
	[Token(Token = "0x2000B46")]
	public class SourceContainer
	{
		[Token(Token = "0x400964C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AssetLinkContainer assetLinkContainer;

		[Token(Token = "0x400964D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextGroupLoadHolder textGroupLoadHolder;

		[Token(Token = "0x400964E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WidgetFactory widgetFactory;

		[Token(Token = "0x400964F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MDMarkupGraphFactory mmaFactory;

		[Token(Token = "0x4009650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject templateRoot;

		[Token(Token = "0x600452D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public SourceContainer()
		{
		}
	}

	[Token(Token = "0x2000B47")]
	public enum LaunchMode
	{
		[Token(Token = "0x4009652")]
		SerialCode,
		[Token(Token = "0x4009653")]
		Invite,
		[Token(Token = "0x4009654")]
		InviteSend,
		[Token(Token = "0x4009655")]
		InviteReceive
	}

	[Token(Token = "0x2000B4E")]
	[CompilerGenerated]
	private sealed class _003CyInputCooltimeRoutine_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PromoCodesViewController _003C_003E4__this;

		[Token(Token = "0x400966A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject _003CcoolTimeIcon_003E5__2;

		[Token(Token = "0x17000940")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004540")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000941")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004542")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600453D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInputCooltimeRoutine_003Ed__54(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600453E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600453F")]
		[Address(RVA = "0x8FB7F0", Offset = "0x8FA9F0", VA = "0x1808FB7F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004541")]
		[Address(RVA = "0x8FBD50", Offset = "0x8FAF50", VA = "0x1808FBD50", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000B4F")]
	[CompilerGenerated]
	private sealed class _003CyProgressUpdateRoutine_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400966B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400966C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400966D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PromoCodesViewController _003C_003E4__this;

		[Token(Token = "0x400966E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action onComplete;

		[Token(Token = "0x400966F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IEnumerator _003CbehaviourRoutine_003E5__2;

		[Token(Token = "0x17000942")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004546")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000943")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004548")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004543")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyProgressUpdateRoutine_003Ed__42(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004544")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004545")]
		[Address(RVA = "0x8FBEC0", Offset = "0x8FB0C0", VA = "0x1808FBEC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004547")]
		[Address(RVA = "0x8FC430", Offset = "0x8FB630", VA = "0x1808FC430", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009633")]
	private const string k_VCPath = "PromoCodes/PromoCodes";

	[Token(Token = "0x4009634")]
	private const string k_Args_LaunchMode = "launchMode";

	[Token(Token = "0x4009635")]
	private const string k_AssetLinkContainer = "Definition/PromoCodes/PromoCodesAssetLinkContainer";

	[Token(Token = "0x4009636")]
	private const string k_ELabel_Header_CategoryNameText = "Header/CategoryNameText";

	[Token(Token = "0x4009637")]
	private const string k_ELabel_Header_BodyBorder = "Header/BodyBorder";

	[Token(Token = "0x4009638")]
	private const string k_ELabel_Header_BodyNameText = "Header/BodyNameText";

	[Token(Token = "0x4009639")]
	private const string k_ELabel_Header_ButtonRoot = "Header/HeaderButton";

	[Token(Token = "0x400963A")]
	private const string k_ELabel_Header_Button = "Header/HeaderButton";

	[Token(Token = "0x400963B")]
	private const string k_ELabel_Header_ButtonLabel = "Header/HeaderButton/Text";

	[Token(Token = "0x400963C")]
	private const string k_ELabel_Footer_Root = "Footer";

	[Token(Token = "0x400963D")]
	private const string k_ELabel_Footer_Button = "ButtonTemplate";

	[Token(Token = "0x400963E")]
	private const string k_ELabel_Footer_Text = "TextTemplate";

	[Token(Token = "0x400963F")]
	private const string k_ELabel_CooltimeLoadingIcon = "CooltimeLoadingIcon";

	[Token(Token = "0x4009640")]
	private const string k_OGLabel_ScrollBar_Default = "Default";

	[Token(Token = "0x4009641")]
	private const string k_OGLabel_ScrollBar_OnFooter = "OnFooter";

	[Token(Token = "0x4009642")]
	private const string k_TLabel_CooltimeLoadingIconShow = "Show";

	[Token(Token = "0x4009643")]
	private const string k_BannerPath = "Images/Notification/System/CampaignFriend002_ActionBase";

	[Token(Token = "0x4009644")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private float m_CoolTime;

	[Token(Token = "0x4009645")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private IPromoCodeBehaviour m_Behaviour;

	[Token(Token = "0x4009646")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private IEnumerator m_ProgressUpdateRoutine;

	[Token(Token = "0x4009647")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Coroutine m_InputCooltimeRoutine;

	[Token(Token = "0x4009648")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private GameObject m_TemplateRoot;

	[Token(Token = "0x4009649")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private Dictionary<string, SelectionButton> m_FooterButtonMap;

	[Token(Token = "0x400964A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private int m_FooterButtonCnt;

	[Token(Token = "0x400964B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private List<InputFieldWidget> m_CooltimeWidgetsCache;

	[Token(Token = "0x1700093D")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6004516")]
		[Address(RVA = "0x8EF950", Offset = "0x8EEB50", VA = "0x1808EF950", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700093E")]
	private AssetLinker YgomGame_002EPromoCodes_002EIPromoCodeBehaviourHandler_002EassetLinker
	{
		[Token(Token = "0x6004517")]
		[Address(RVA = "0x8EF8F0", Offset = "0x8EEAF0", VA = "0x1808EF8F0", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700093F")]
	private TextGroupLoadHolder YgomGame_002EPromoCodes_002EIPromoCodeBehaviourHandler_002EtextGroupLoadHolder
	{
		[Token(Token = "0x6004518")]
		[Address(RVA = "0x49BB10", Offset = "0x49AD10", VA = "0x18049BB10", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004511")]
	[Address(RVA = "0x8EE000", Offset = "0x8ED200", VA = "0x1808EE000")]
	public static void OpenInviteWithValidate(int invitationId, LaunchMode launchMode, bool pushOnHome = false, [Optional] Action onSuccess, [Optional] Action onFailed, [Optional] Action onCanceled)
	{
	}

	[Token(Token = "0x6004512")]
	[Address(RVA = "0x8EE8C0", Offset = "0x8EDAC0", VA = "0x1808EE8C0")]
	private static void SelectOpenInviteMode(int invitationId, bool pushOnHome = false, [Optional] Action onSuccess, [Optional] Action onFailed, [Optional] Action onCanceled)
	{
	}

	[Token(Token = "0x6004513")]
	[Address(RVA = "0x8ED930", Offset = "0x8ECB30", VA = "0x1808ED930")]
	private static void OnCompleteOpenInviteApi(Handle h, int invitationId, LaunchMode launchMode, bool pushOnHome = false, [Optional] Action onSuccess, [Optional] Action onFailed)
	{
	}

	[Token(Token = "0x6004514")]
	[Address(RVA = "0x8EE350", Offset = "0x8ED550", VA = "0x1808EE350")]
	public static bool OpenWithValidate(bool pushOnHome = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6004515")]
	[Address(RVA = "0x8EE230", Offset = "0x8ED430", VA = "0x1808EE230")]
	public static bool OpenWithValidate(int promoCodeId, bool pushOnHome = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6004519")]
	[Address(RVA = "0x8ECD70", Offset = "0x8EBF70", VA = "0x1808ECD70")]
	private IPromoCodeBehaviour CreateBehaviour(LaunchMode launchMode)
	{
		return null;
	}

	[Token(Token = "0x600451A")]
	[Address(RVA = "0x8ECE70", Offset = "0x8EC070", VA = "0x1808ECE70")]
	protected static void InnerOpen(LaunchMode launchMode, Dictionary<string, object> args, bool pushOnHome = false)
	{
	}

	[Token(Token = "0x600451B")]
	[Address(RVA = "0x8EDF20", Offset = "0x8ED120", VA = "0x1808EDF20")]
	private static void OnLaunchFailed([Optional] Action callback)
	{
	}

	[Token(Token = "0x600451C")]
	[Address(RVA = "0x8ED4A0", Offset = "0x8EC6A0", VA = "0x1808ED4A0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600451D")]
	[Address(RVA = "0x8EDAC0", Offset = "0x8ECCC0", VA = "0x1808EDAC0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600451E")]
	[Address(RVA = "0x8EE860", Offset = "0x8EDA60", VA = "0x1808EE860", Slot = "10")]
	public override void ProgressUpdate()
	{
	}

	[Token(Token = "0x600451F")]
	[Address(RVA = "0x8EFA90", Offset = "0x8EEC90", VA = "0x1808EFA90")]
	[IteratorStateMachine(typeof(_003CyProgressUpdateRoutine_003Ed__42))]
	private IEnumerator yProgressUpdateRoutine(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6004520")]
	[Address(RVA = "0x8EEFD0", Offset = "0x8EE1D0", VA = "0x1808EEFD0")]
	private void Start()
	{
	}

	[Token(Token = "0x6004521")]
	[Address(RVA = "0x8EDE90", Offset = "0x8ED090", VA = "0x1808EDE90")]
	private void OnLaunchAbortByFailed()
	{
	}

	[Token(Token = "0x6004522")]
	[Address(RVA = "0x8ED880", Offset = "0x8ECA80", VA = "0x1808ED880", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6004523")]
	[Address(RVA = "0x8EF4A0", Offset = "0x8EE6A0", VA = "0x1808EF4A0")]
	private void UpdateHeader()
	{
	}

	[Token(Token = "0x6004524")]
	[Address(RVA = "0x8EF170", Offset = "0x8EE370", VA = "0x1808EF170")]
	private void UpdateFooter()
	{
	}

	[Token(Token = "0x6004525")]
	[Address(RVA = "0x8ECFB0", Offset = "0x8EC1B0", VA = "0x1808ECFB0", Slot = "31")]
	public bool InsertFooter(ElementObjectManager footerEom, string footerLabel, Action buttonAction, bool mute = false, SelectorManager.KeyType shortcutKey = SelectorManager.KeyType.None, [Optional] string footerName)
	{
		return default(bool);
	}

	[Token(Token = "0x6004526")]
	[Address(RVA = "0x8ECE40", Offset = "0x8EC040", VA = "0x1808ECE40")]
	private SelectorManager.KeyType GetFooterShortcutKey(int cnt)
	{
		return default(SelectorManager.KeyType);
	}

	[Token(Token = "0x6004527")]
	[Address(RVA = "0x8EF860", Offset = "0x8EEA60", VA = "0x1808EF860", Slot = "30")]
	private bool YgomGame_002EPromoCodes_002EIPromoCodeBehaviourHandler_002ETryInvokeFooter(string footerName)
	{
		return default(bool);
	}

	[Token(Token = "0x6004528")]
	[Address(RVA = "0x8EEF30", Offset = "0x8EE130", VA = "0x1808EEF30")]
	private void StartInputCooltimeRoutine()
	{
	}

	[Token(Token = "0x6004529")]
	[Address(RVA = "0x8EFA20", Offset = "0x8EEC20", VA = "0x1808EFA20")]
	[IteratorStateMachine(typeof(_003CyInputCooltimeRoutine_003Ed__54))]
	private IEnumerator yInputCooltimeRoutine()
	{
		return null;
	}

	[Token(Token = "0x600452A")]
	[Address(RVA = "0x8EDBA0", Offset = "0x8ECDA0", VA = "0x1808EDBA0")]
	private void OnError(OnErrorBehaviour errorBehaviour, string errorMessage)
	{
	}

	[Token(Token = "0x600452B")]
	[Address(RVA = "0x8EF930", Offset = "0x8EEB30", VA = "0x1808EF930")]
	public PromoCodesViewController()
	{
	}
}
