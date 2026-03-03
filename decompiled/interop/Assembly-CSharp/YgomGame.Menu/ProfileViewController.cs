using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Duel;
using YgomGame.Menu.Common;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Menu;

[Token(Token = "0x200135D")]
public class ProfileViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x200135E")]
	private enum ProfileMenu
	{
		[Token(Token = "0x400C13E")]
		OVERVIEW,
		[Token(Token = "0x400C13F")]
		REPLAY,
		[Token(Token = "0x400C140")]
		DATA
	}

	[Token(Token = "0x200135F")]
	private enum ButtonType
	{
		[Token(Token = "0x400C142")]
		EDIT,
		[Token(Token = "0x400C143")]
		REPLAY,
		[Token(Token = "0x400C144")]
		DATA,
		[Token(Token = "0x400C145")]
		FOLLOW,
		[Token(Token = "0x400C146")]
		BLOCK,
		[Token(Token = "0x400C147")]
		CARDFILE
	}

	[Token(Token = "0x2001360")]
	private class TitleArea : MonoBehaviour
	{
		[Token(Token = "0x400C14A")]
		[FieldOffset(Offset = "0x30")]
		private bool isInitialized;

		[Token(Token = "0x400C14B")]
		[FieldOffset(Offset = "0x38")]
		private GameObject m_CautionNewBadge;

		[Token(Token = "0x400C14C")]
		[FieldOffset(Offset = "0x40")]
		private ExtendedTextMeshProUGUI m_CautionBtnText;

		[Token(Token = "0x400C14D")]
		[FieldOffset(Offset = "0x48")]
		private SelectionButton m_CautionButton;

		[Token(Token = "0x1700129D")]
		public ElementObjectManager m_Eom
		{
			[Token(Token = "0x6007845")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007846")]
			[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x1700129E")]
		public ElementObjectManager m_CautionEom
		{
			[Token(Token = "0x6007847")]
			[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007848")]
			[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x1700129F")]
		public Action onClickCautionButtonCallback
		{
			[Token(Token = "0x6007849")]
			[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600784A")]
			[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600784B")]
		[Address(RVA = "0xC26D40", Offset = "0xC25F40", VA = "0x180C26D40")]
		private void Awake()
		{
		}

		[Token(Token = "0x600784C")]
		[Address(RVA = "0xC26D90", Offset = "0xC25F90", VA = "0x180C26D90")]
		public void InitializeElements()
		{
		}

		[Token(Token = "0x600784D")]
		[Address(RVA = "0xC26F80", Offset = "0xC26180", VA = "0x180C26F80")]
		public void SetCautionButtonNewBadge(bool isOn)
		{
		}

		[Token(Token = "0x600784E")]
		[Address(RVA = "0xC27020", Offset = "0xC26220", VA = "0x180C27020")]
		public void SetCautionButtonText(string label)
		{
		}

		[Token(Token = "0x600784F")]
		[Address(RVA = "0xC26D50", Offset = "0xC25F50", VA = "0x180C26D50")]
		public void DispCautionButton(bool disp)
		{
		}

		[Token(Token = "0x6007850")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public TitleArea()
		{
		}
	}

	[Token(Token = "0x2001367")]
	[CompilerGenerated]
	private sealed class _003CDelayedInvokeCallback_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C164")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C165")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C166")]
		[FieldOffset(Offset = "0x20")]
		public Action action;

		[Token(Token = "0x170012A0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600786D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012A1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600786F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600786A")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CDelayedInvokeCallback_003Ed__40(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600786B")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600786C")]
		[Address(RVA = "0xBCCD00", Offset = "0xBCBF00", VA = "0x180BCCD00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600786E")]
		[Address(RVA = "0xC27AB0", Offset = "0xC26CB0", VA = "0x180C27AB0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C11D")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string MATE_TRANSFORM_SETTING_PATH;

	[Token(Token = "0x400C11E")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string BTN_MENU_TMP_LABEL;

	[Token(Token = "0x400C11F")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string ROOT_TITLEAREA_LABEL;

	[Token(Token = "0x400C120")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string ROOT_MENU_LABEL;

	[Token(Token = "0x400C121")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string ROOT_OVERVIEW_LABEL;

	[Token(Token = "0x400C122")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string ROOT_FOOTERAREA_LABEL;

	[Token(Token = "0x400C123")]
	[FieldOffset(Offset = "0x100")]
	private readonly string IMG_NEWBADGE_LABEL;

	[Token(Token = "0x400C124")]
	[FieldOffset(Offset = "0x108")]
	private readonly string IMG_CERTIFICATION_LABEL;

	[Token(Token = "0x400C125")]
	[FieldOffset(Offset = "0x110")]
	private readonly string IMG_REPLAY_LABEL;

	[Token(Token = "0x400C126")]
	[FieldOffset(Offset = "0x118")]
	private readonly string IMG_FOLLOW_LABEL;

	[Token(Token = "0x400C127")]
	[FieldOffset(Offset = "0x120")]
	private readonly string TMP_BTN_LABEL;

	[Token(Token = "0x400C128")]
	[FieldOffset(Offset = "0x128")]
	private readonly string TMP_TXT_LABEL;

	[Token(Token = "0x400C129")]
	[FieldOffset(Offset = "0x130")]
	private readonly string OBJ_MATE_LABEL;

	[Token(Token = "0x400C12A")]
	[FieldOffset(Offset = "0x138")]
	private readonly string CARDFILE_LABEL;

	[Token(Token = "0x400C12B")]
	[FieldOffset(Offset = "0x140")]
	private GameObject rootMenu;

	[Token(Token = "0x400C12C")]
	[FieldOffset(Offset = "0x148")]
	private GameObject rootOverview;

	[Token(Token = "0x400C12D")]
	[FieldOffset(Offset = "0x150")]
	private GameObject tmpGO;

	[Token(Token = "0x400C12E")]
	[FieldOffset(Offset = "0x158")]
	private long pcode;

	[Token(Token = "0x400C12F")]
	[FieldOffset(Offset = "0x160")]
	private bool isFollowed;

	[Token(Token = "0x400C130")]
	[FieldOffset(Offset = "0x161")]
	private bool isMine;

	[Token(Token = "0x400C131")]
	[FieldOffset(Offset = "0x162")]
	private bool isDispCardFile;

	[Token(Token = "0x400C132")]
	[FieldOffset(Offset = "0x168")]
	private MateTransformSetting m_ModelLocateSettings;

	[Token(Token = "0x400C133")]
	[FieldOffset(Offset = "0x170")]
	private DefinitionSetting matchingDefine;

	[Token(Token = "0x400C134")]
	[FieldOffset(Offset = "0x178")]
	private Character2D chara;

	[Token(Token = "0x400C135")]
	[FieldOffset(Offset = "0x180")]
	private int charaId;

	[Token(Token = "0x400C136")]
	[FieldOffset(Offset = "0x184")]
	private bool isNeedCharaCreate;

	[Token(Token = "0x400C137")]
	[FieldOffset(Offset = "0x188")]
	private List<GameObject> menuGOs;

	[Token(Token = "0x400C138")]
	[FieldOffset(Offset = "0x190")]
	private GameObject followButton;

	[Token(Token = "0x400C139")]
	[FieldOffset(Offset = "0x198")]
	private ProfileCard profileCard;

	[Token(Token = "0x400C13A")]
	[FieldOffset(Offset = "0x1A0")]
	private GameObject cardFileBadge;

	[Token(Token = "0x400C13B")]
	[FieldOffset(Offset = "0x1A8")]
	private Image imageCertification;

	[Token(Token = "0x400C13C")]
	[FieldOffset(Offset = "0x1B0")]
	private TitleArea m_TitleArea;

	[Token(Token = "0x1700129C")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600782C")]
		[Address(RVA = "0xBFA150", Offset = "0xBF9350", VA = "0x180BFA150", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600782D")]
	[Address(RVA = "0xBF7610", Offset = "0xBF6810", VA = "0x180BF7610", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x600782E")]
	[Address(RVA = "0xBF73B0", Offset = "0xBF65B0", VA = "0x180BF73B0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600782F")]
	[Address(RVA = "0xBF7A70", Offset = "0xBF6C70", VA = "0x180BF7A70", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6007830")]
	[Address(RVA = "0xBF69C0", Offset = "0xBF5BC0", VA = "0x180BF69C0")]
	[IteratorStateMachine(typeof(_003CDelayedInvokeCallback_003Ed__40))]
	private IEnumerator DelayedInvokeCallback(Action action)
	{
		return null;
	}

	[Token(Token = "0x6007831")]
	[Address(RVA = "0xBF6FE0", Offset = "0xBF61E0", VA = "0x180BF6FE0")]
	private void InitMenuButtons()
	{
	}

	[Token(Token = "0x6007832")]
	[Address(RVA = "0xBF81F0", Offset = "0xBF73F0", VA = "0x180BF81F0")]
	private void SetButton(ButtonType type)
	{
	}

	[Token(Token = "0x6007833")]
	[Address(RVA = "0xBF67E0", Offset = "0xBF59E0", VA = "0x180BF67E0")]
	private void CallFriendFollow(long pcode, int delete, ElementObjectManager eom, ButtonType type)
	{
	}

	[Token(Token = "0x6007834")]
	[Address(RVA = "0xBF7FE0", Offset = "0xBF71E0", VA = "0x180BF7FE0")]
	private void SetButtonIcons(ElementObjectManager eom, ButtonType type)
	{
	}

	[Token(Token = "0x6007835")]
	[Address(RVA = "0xBF7780", Offset = "0xBF6980", VA = "0x180BF7780")]
	private void OnClickBlock()
	{
	}

	[Token(Token = "0x6007836")]
	[Address(RVA = "0xBF9690", Offset = "0xBF8890", VA = "0x180BF9690")]
	private void UpdateProfile(Dictionary<string, object> profileDic)
	{
	}

	[Token(Token = "0x6007837")]
	[Address(RVA = "0xBF94A0", Offset = "0xBF86A0", VA = "0x180BF94A0")]
	private void UpdateItem()
	{
	}

	[Token(Token = "0x6007838")]
	[Address(RVA = "0xBF7F40", Offset = "0xBF7140", VA = "0x180BF7F40")]
	private void PlayMateMotion()
	{
	}

	[Token(Token = "0x6007839")]
	[Address(RVA = "0xBF6A30", Offset = "0xBF5C30", VA = "0x180BF6A30")]
	private void InitMateSettings(MateTransformSetting modelLocateSettings)
	{
	}

	[Token(Token = "0x600783A")]
	[Address(RVA = "0xBF9EA0", Offset = "0xBF90A0", VA = "0x180BF9EA0")]
	public ProfileViewController()
	{
	}
}
