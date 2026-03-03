using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.MDMarkup;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Menu;

[Token(Token = "0x200139E")]
public class NotificationViewController : BaseBlurOverlayViewController, IDynamicChangeDispHeaderSupported
{
	[Token(Token = "0x200139F")]
	internal enum Type
	{
		[Token(Token = "0x400C31A")]
		NOTIFICATION,
		[Token(Token = "0x400C31B")]
		MAINTENANCE,
		[Token(Token = "0x400C31C")]
		BUG
	}

	[Token(Token = "0x20013A0")]
	internal class Data
	{
		[Token(Token = "0x400C31D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal readonly Type type;

		[Token(Token = "0x400C31E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal readonly int id;

		[Token(Token = "0x400C31F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal readonly string category;

		[Token(Token = "0x400C320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal readonly Color categoryColor;

		[Token(Token = "0x400C321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal readonly string date;

		[Token(Token = "0x400C322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal readonly string head;

		[Token(Token = "0x400C323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal readonly string body;

		[Token(Token = "0x400C324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal readonly int sort;

		[Token(Token = "0x400C325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal readonly MDMarkupBannerContext bannerContext;

		[Token(Token = "0x400C326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal bool isAlreadyRead;

		[Token(Token = "0x6007A17")]
		[Address(RVA = "0xC3E6D0", Offset = "0xC3D8D0", VA = "0x180C3E6D0")]
		public Data(Type type, int id, string category, Color categoryColor, string date, string head, string body, int sort, bool isAlreadyRead, MDMarkupBannerContext bannerContext)
		{
		}
	}

	[Token(Token = "0x20013A5")]
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NotificationViewController _003C_003E4__this;

		[Token(Token = "0x170012C3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007A28")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012C4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007A2A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007A25")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStart_003Ed__40(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007A26")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007A27")]
		[Address(RVA = "0xC4E920", Offset = "0xC4DB20", VA = "0x180C4E920", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007A29")]
		[Address(RVA = "0xC4E9B0", Offset = "0xC4DBB0", VA = "0x180C4E9B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20013A6")]
	[CompilerGenerated]
	private sealed class _003CyInitialize_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NotificationViewController _003C_003E4__this;

		[Token(Token = "0x400C338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action onComplete;

		[Token(Token = "0x170012C5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007A2E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012C6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007A30")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007A2B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitialize_003Ed__39(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007A2C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007A2D")]
		[Address(RVA = "0xC517E0", Offset = "0xC509E0", VA = "0x180C517E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007A2F")]
		[Address(RVA = "0xC52050", Offset = "0xC51250", VA = "0x180C52050", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C2FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string SCROLL_LABEL;

	[Token(Token = "0x400C2FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string TXT_CATEGORY_LABEL;

	[Token(Token = "0x400C300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string IMG_CATEGORY_LABEL;

	[Token(Token = "0x400C301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string ROOT_CATEGORY_LABEL;

	[Token(Token = "0x400C302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string ROOT_FOOTER_LABEL;

	[Token(Token = "0x400C303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string TXT_HEAD_LABEL;

	[Token(Token = "0x400C304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string TXT_BODY_LABEL;

	[Token(Token = "0x400C305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string TXT_EMPTY_LABEL;

	[Token(Token = "0x400C306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string BTN_LABEL;

	[Token(Token = "0x400C307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly string BTN_NOTIFICATION_LABEL;

	[Token(Token = "0x400C308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly string BTN_MAINTENANCE_LABEL;

	[Token(Token = "0x400C309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly string BTN_BUG_LABEL;

	[Token(Token = "0x400C30A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly string BTN_CLOSE_LABEL;

	[Token(Token = "0x400C30B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private readonly string BTN_TAP_BACK_LABEL;

	[Token(Token = "0x400C30C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private readonly string IMG_BADGE_LABEL;

	[Token(Token = "0x400C30D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private readonly string IMG_LABEL;

	[Token(Token = "0x400C30E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private readonly string k_ETabGroup;

	[Token(Token = "0x400C30F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private readonly string k_EAnalogDirectionItem;

	[Token(Token = "0x400C310")]
	public const string k_ArgKeyOnClosedCallback = "OnClosedCallback";

	[Token(Token = "0x400C311")]
	public const string k_ArgKeySkipApi = "SkipApi";

	[Token(Token = "0x400C312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private Type currentType;

	[Token(Token = "0x400C313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	[SerializeField]
	private Color defaultCategoryColor;

	[Token(Token = "0x400C314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private IEnumerator m_InitRoutine;

	[Token(Token = "0x400C315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private InfinityScrollView isv;

	[Token(Token = "0x400C316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private List<Data> notificationDatas;

	[Token(Token = "0x400C317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private List<Data> maintenanceDatas;

	[Token(Token = "0x400C318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private List<Data> bugDatas;

	[Token(Token = "0x170012C0")]
	protected override System.Type[] textIds
	{
		[Token(Token = "0x60079FC")]
		[Address(RVA = "0xC407E0", Offset = "0xC3F9E0", VA = "0x180C407E0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012C1")]
	protected override bool defaultBlurOverlay
	{
		[Token(Token = "0x60079FD")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170012C2")]
	protected override bool setSurfaceActiveOnInitialize
	{
		[Token(Token = "0x60079FE")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60079FF")]
	[Address(RVA = "0xC3EA80", Offset = "0xC3DC80", VA = "0x180C3EA80")]
	internal static string GetTypeLabel(Type type)
	{
		return null;
	}

	[Token(Token = "0x6007A00")]
	[Address(RVA = "0xC3EDC0", Offset = "0xC3DFC0", VA = "0x180C3EDC0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007A01")]
	[Address(RVA = "0xC3EFF0", Offset = "0xC3E1F0", VA = "0x180C3EFF0", Slot = "24")]
	protected override void OnTransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x6007A02")]
	[Address(RVA = "0xC3EF30", Offset = "0xC3E130", VA = "0x180C3EF30", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6007A03")]
	[Address(RVA = "0xC3F040", Offset = "0xC3E240", VA = "0x180C3F040", Slot = "10")]
	public override void ProgressUpdate()
	{
	}

	[Token(Token = "0x6007A04")]
	[Address(RVA = "0xC40920", Offset = "0xC3FB20", VA = "0x180C40920")]
	[IteratorStateMachine(typeof(_003CyInitialize_003Ed__39))]
	private IEnumerator yInitialize(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6007A05")]
	[Address(RVA = "0xC3F170", Offset = "0xC3E370", VA = "0x180C3F170")]
	[IteratorStateMachine(typeof(_003CStart_003Ed__40))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6007A06")]
	[Address(RVA = "0xC3E790", Offset = "0xC3D990", VA = "0x180C3E790")]
	private void CallAPIGetList([Optional] Action onSuccess)
	{
	}

	[Token(Token = "0x6007A07")]
	[Address(RVA = "0xC3E930", Offset = "0xC3DB30", VA = "0x180C3E930")]
	private void CallAPINotificationRead(int id, [Optional] Action onFinish)
	{
	}

	[Token(Token = "0x6007A08")]
	[Address(RVA = "0x775A10", Offset = "0x774C10", VA = "0x180775A10")]
	public static void HandleResultCode(Handle handle, [Optional] Action onSuccess, [Optional] Action<NotificationCode> onFailed)
	{
	}

	[Token(Token = "0x6007A09")]
	[Address(RVA = "0xC3EA00", Offset = "0xC3DC00", VA = "0x180C3EA00")]
	private int GetDatasCount(Type type)
	{
		return default(int);
	}

	[Token(Token = "0x6007A0A")]
	[Address(RVA = "0xC3F260", Offset = "0xC3E460", VA = "0x180C3F260")]
	private void UpdateAll()
	{
	}

	[Token(Token = "0x6007A0B")]
	[Address(RVA = "0xC3F920", Offset = "0xC3EB20", VA = "0x180C3F920")]
	private void UpdateNotification(Type type)
	{
	}

	[Token(Token = "0x6007A0C")]
	[Address(RVA = "0xC3F0A0", Offset = "0xC3E2A0", VA = "0x180C3F0A0")]
	private void SetBadge(Type type, bool isAlreadyReadType)
	{
	}

	[Token(Token = "0x6007A0D")]
	[Address(RVA = "0xC402F0", Offset = "0xC3F4F0", VA = "0x180C402F0")]
	private void UpdateScrollView(Type type)
	{
	}

	[Token(Token = "0x6007A0E")]
	[Address(RVA = "0xC3F4A0", Offset = "0xC3E6A0", VA = "0x180C3F4A0")]
	private void UpdateEntityCallback(GameObject go, int index)
	{
	}

	[Token(Token = "0x6007A0F")]
	[Address(RVA = "0xC3EB40", Offset = "0xC3DD40", VA = "0x180C3EB40", Slot = "30")]
	public HeaderViewController.IsDispHeader IsDispContents()
	{
		return default(HeaderViewController.IsDispHeader);
	}

	[Token(Token = "0x6007A10")]
	[Address(RVA = "0xC403B0", Offset = "0xC3F5B0", VA = "0x180C403B0")]
	public NotificationViewController()
	{
	}
}
