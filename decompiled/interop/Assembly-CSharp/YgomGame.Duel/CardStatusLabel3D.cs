using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x20019E7")]
public class CardStatusLabel3D
{
	[Token(Token = "0x20019E8")]
	private enum StatusType
	{
		[Token(Token = "0x400EF74")]
		Monster,
		[Token(Token = "0x400EF75")]
		Magic,
		[Token(Token = "0x400EF76")]
		PendulumCard
	}

	[Token(Token = "0x20019E9")]
	private enum StateIconType
	{
		[Token(Token = "0x400EF78")]
		DISABLE,
		[Token(Token = "0x400EF79")]
		UNATTACKABLE,
		[Token(Token = "0x400EF7A")]
		TRUNER
	}

	[Token(Token = "0x20019EB")]
	[CompilerGenerated]
	private sealed class _003CUpdatePowerPointProcess_003Ed__136 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400EF7D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400EF7E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400EF7F")]
		[FieldOffset(Offset = "0x20")]
		public CardStatusLabel3D _003C_003E4__this;

		[Token(Token = "0x170019B4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600A740")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170019B5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A742")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A73D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CUpdatePowerPointProcess_003Ed__136(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600A73E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600A73F")]
		[Address(RVA = "0xF43FB0", Offset = "0xF431B0", VA = "0x180F43FB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A741")]
		[Address(RVA = "0xF44070", Offset = "0xF43270", VA = "0x180F44070", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400EEFF")]
	public const int UNINITIALIZEDVALUE = 0;

	[Token(Token = "0x400EF00")]
	public const int UNINITIALIZEDATKDEF = -1;

	[Token(Token = "0x400EF01")]
	private const int STATUSICONCOUNT = 5;

	[Token(Token = "0x400EF02")]
	private const string LABEL_EO_TR_STATUSLABEL = "StatusLabelRoot";

	[Token(Token = "0x400EF03")]
	private const string LABEL_EO_TR_OVERLAYUNITS = "MonsterMaterialsRoot";

	[Token(Token = "0x400EF04")]
	private const string LABEL_EO_TR_POWERPOINT = "CardAttackBody";

	[Token(Token = "0x400EF05")]
	private const string LABEL_EO_TR_ATTRBUTE = "CardAttribute";

	[Token(Token = "0x400EF06")]
	private const string LABEL_EO_TR_ATTRBUTEOUTLINE = "IconAttributeChange";

	[Token(Token = "0x400EF07")]
	private const string LABEL_EO_TR_LINKNUM = "LinkCount";

	[Token(Token = "0x400EF08")]
	private const string LABEL_EO_TR_LAVELRANK = "CardLevel";

	[Token(Token = "0x400EF09")]
	private const string LABEL_EO_TR_PENDULUM = "CardPendulumBody";

	[Token(Token = "0x400EF0A")]
	private const string LABEL_EO_TR_PENDULUM_L = "PendulumLeft";

	[Token(Token = "0x400EF0B")]
	private const string LABEL_EO_TR_PENDULUMTEXT_L = "TextPendulumLeftRoot";

	[Token(Token = "0x400EF0C")]
	private const string LABEL_EO_TR_PENDULUM_R = "PendulumRight";

	[Token(Token = "0x400EF0D")]
	private const string LABEL_EO_TR_PENDULUMTEXT_R = "TextPendulumRightRoot";

	[Token(Token = "0x400EF0E")]
	private const string LABEL_EO_TR_TYPE = "CardType";

	[Token(Token = "0x400EF0F")]
	private const string LABEL_EO_TR_TYPEICONOUTLINE = "IconTypeChange";

	[Token(Token = "0x400EF10")]
	private const string LABEL_EO_TR_TUNERICON = "TunerIconRoot";

	[Token(Token = "0x400EF11")]
	private const string LABEL_EO_TR_TUNERICONOUTLINE = "TunerIconOutline";

	[Token(Token = "0x400EF12")]
	private const string LABEL_EO_TR_MAGICTYPE = "MagicTypeBase";

	[Token(Token = "0x400EF13")]
	private const string LABEL_EO_TR_COUNTER = "CardCounter";

	[Token(Token = "0x400EF14")]
	private const string LABEL_EO_TR_LINKMARKERROOT = "LinkMarkerRoot";

	[Token(Token = "0x400EF15")]
	private const string LABEL_EO_TR_LINKMARKER = "LinkMarker";

	[Token(Token = "0x400EF16")]
	private const string LABEL_EO_TR_DEFAULTSHOW = "DefaultShow";

	[Token(Token = "0x400EF17")]
	private const string LABEL_EO_TR_DEFAULTHIDE = "DefaultHide";

	[Token(Token = "0x400EF18")]
	private const string LABEL_EO_TR_SWITCHTWEENROOT = "FieldCardChangeIcon";

	[Token(Token = "0x400EF19")]
	private const string LABEL_EO_TR_STATEICONNROOT = "StatusIcon";

	[Token(Token = "0x400EF1A")]
	private const string LABEL_EO_TXT_POWERPOINT = "TextPowerPoint";

	[Token(Token = "0x400EF1B")]
	private const string LABEL_EO_TXT_OVERLAYUNITS = "TextMonsterMaterials";

	[Token(Token = "0x400EF1C")]
	private const string LABEL_EO_TXT_LINKNUM = "TextLinkCount";

	[Token(Token = "0x400EF1D")]
	private const string LABEL_EO_TXT_LAVELRANK = "TextLevel";

	[Token(Token = "0x400EF1E")]
	private const string LABEL_EO_TXT_PENDULUM_L = "TextPendulumLeft";

	[Token(Token = "0x400EF1F")]
	private const string LABEL_EO_TXT_PENDULUM_R = "TextPendulumRight";

	[Token(Token = "0x400EF20")]
	private const string LABEL_EO_TXT_COUNTER = "TextCounter";

	[Token(Token = "0x400EF21")]
	private const string LABEL_EO_IMG_ATTRIBUTE = "IconAttribute";

	[Token(Token = "0x400EF22")]
	private const string LABEL_EO_IMG_LEVELICON = "IconLevel";

	[Token(Token = "0x400EF23")]
	private const string LABEL_EO_IMG_TYPEICON = "IconType";

	[Token(Token = "0x400EF24")]
	private const string LABEL_EO_IMG_MAGICTYPE = "MagicType";

	[Token(Token = "0x400EF25")]
	private const string LABEL_EO_IMG_MAGICTYPEOUTLINE = "MagicTypeChange";

	[Token(Token = "0x400EF26")]
	private const string LABEL_EO_IMG_COUNTER = "IconCounter";

	[Token(Token = "0x400EF27")]
	private const string LABEL_EO_IMG_STATUS = "IconStatus";

	[Token(Token = "0x400EF28")]
	private const string LABEL_EO_COUNTER_ICON = "IconCommonCounter";

	[Token(Token = "0x400EF29")]
	private const string LABEL_EO_COUNTER_READY = "IconCommonCounterBaseReady";

	[Token(Token = "0x400EF2A")]
	private const string LABEL_EO_COUNTER_UNREADY = "IconCommonCounterBaseUnready";

	[Token(Token = "0x400EF2B")]
	private const string LABEL_EO_COUNTER_TEXT = "TextCommonCounter";

	[Token(Token = "0x400EF2C")]
	private const string LABEL_TW_SCALEOUT = "ScaleOut";

	[Token(Token = "0x400EF2D")]
	private const string LABEL_TW_SCALEIN = "ScaleIn";

	[Token(Token = "0x400EF2E")]
	private const string LABEL_TW_CHANGECOUNTER = "ChangeCounter";

	[Token(Token = "0x400EF2F")]
	private const string LABEL_TW_CHANGEATTRIBUTE = "ChangeAttribute";

	[Token(Token = "0x400EF30")]
	private const string LABEL_TW_ATTACK = "Attack";

	[Token(Token = "0x400EF31")]
	private const string LABEL_TW_DEFENCE = "Defense";

	[Token(Token = "0x400EF32")]
	private const string LABEL_TW_SHOWLABEL = "ShowLabel";

	[Token(Token = "0x400EF33")]
	private const string LABEL_TW_HIDELABEL = "HideLabel";

	[Token(Token = "0x400EF34")]
	[FieldOffset(Offset = "0x0")]
	public static List<CardStatusLabel3D> m_LabelPool;

	[Token(Token = "0x400EF35")]
	[FieldOffset(Offset = "0x10")]
	private CardRoot m_CardRoot;

	[Token(Token = "0x400EF36")]
	[FieldOffset(Offset = "0x18")]
	private Transform m_RootStatesLabel;

	[Token(Token = "0x400EF37")]
	[FieldOffset(Offset = "0x20")]
	private Transform m_RootOverlayUnits;

	[Token(Token = "0x400EF38")]
	[FieldOffset(Offset = "0x28")]
	private Transform m_RootPowerPoint;

	[Token(Token = "0x400EF39")]
	[FieldOffset(Offset = "0x30")]
	private Transform m_RootArribute;

	[Token(Token = "0x400EF3A")]
	[FieldOffset(Offset = "0x38")]
	private Transform m_RootLinkNum;

	[Token(Token = "0x400EF3B")]
	[FieldOffset(Offset = "0x40")]
	private Transform m_RootLinkMarker;

	[Token(Token = "0x400EF3C")]
	[FieldOffset(Offset = "0x48")]
	private Transform m_RootLavelRank;

	[Token(Token = "0x400EF3D")]
	[FieldOffset(Offset = "0x50")]
	private Transform m_RootPendulum;

	[Token(Token = "0x400EF3E")]
	[FieldOffset(Offset = "0x58")]
	private Transform m_RootPendulumL;

	[Token(Token = "0x400EF3F")]
	[FieldOffset(Offset = "0x60")]
	private Transform m_RootPendulumTextL;

	[Token(Token = "0x400EF40")]
	[FieldOffset(Offset = "0x68")]
	private Transform m_RootPendulumR;

	[Token(Token = "0x400EF41")]
	[FieldOffset(Offset = "0x70")]
	private Transform m_RootPendulumTextR;

	[Token(Token = "0x400EF42")]
	[FieldOffset(Offset = "0x78")]
	private Transform m_RootType;

	[Token(Token = "0x400EF43")]
	[FieldOffset(Offset = "0x80")]
	private Transform m_RootMagicType;

	[Token(Token = "0x400EF44")]
	[FieldOffset(Offset = "0x88")]
	private Transform m_RootCounter;

	[Token(Token = "0x400EF45")]
	[FieldOffset(Offset = "0x90")]
	private Transform m_RootDefaultShow;

	[Token(Token = "0x400EF46")]
	[FieldOffset(Offset = "0x98")]
	private Transform m_RootDefaultHide;

	[Token(Token = "0x400EF47")]
	[FieldOffset(Offset = "0xA0")]
	private Transform m_RootStateIcons;

	[Token(Token = "0x400EF48")]
	[FieldOffset(Offset = "0xA8")]
	private Transform m_RootTunerIcon;

	[Token(Token = "0x400EF49")]
	[FieldOffset(Offset = "0xB0")]
	private Transform m_OutlineMagicType;

	[Token(Token = "0x400EF4A")]
	[FieldOffset(Offset = "0xB8")]
	private Transform m_OutlineTunerIcon;

	[Token(Token = "0x400EF4B")]
	[FieldOffset(Offset = "0xC0")]
	private Transform m_OutlineArribute;

	[Token(Token = "0x400EF4C")]
	[FieldOffset(Offset = "0xC8")]
	private Transform m_OutlineMonsterTypeIcon;

	[Token(Token = "0x400EF4D")]
	[FieldOffset(Offset = "0xD0")]
	private TextMeshPro m_TmpPower;

	[Token(Token = "0x400EF4E")]
	[FieldOffset(Offset = "0xD8")]
	private TextMeshPro m_TmpOverlayUnits;

	[Token(Token = "0x400EF4F")]
	[FieldOffset(Offset = "0xE0")]
	private TextMeshPro m_TmpLinkNum;

	[Token(Token = "0x400EF50")]
	[FieldOffset(Offset = "0xE8")]
	private TextMeshPro m_TmpLavelRank;

	[Token(Token = "0x400EF51")]
	[FieldOffset(Offset = "0xF0")]
	private TextMeshPro m_TmpPendulumL;

	[Token(Token = "0x400EF52")]
	[FieldOffset(Offset = "0xF8")]
	private TextMeshPro m_TmpPendulumR;

	[Token(Token = "0x400EF53")]
	[FieldOffset(Offset = "0x100")]
	private TextMeshPro m_TmpCounter;

	[Token(Token = "0x400EF54")]
	[FieldOffset(Offset = "0x108")]
	private SpriteRenderer m_SrLavelRank;

	[Token(Token = "0x400EF55")]
	[FieldOffset(Offset = "0x110")]
	private SpriteRenderer m_SrAttribute;

	[Token(Token = "0x400EF56")]
	[FieldOffset(Offset = "0x118")]
	private SpriteRenderer m_SrTypeIcon;

	[Token(Token = "0x400EF57")]
	[FieldOffset(Offset = "0x120")]
	private SpriteRenderer m_SrMagicTypeIcon;

	[Token(Token = "0x400EF58")]
	[FieldOffset(Offset = "0x128")]
	private SpriteRenderer m_SrCounter;

	[Token(Token = "0x400EF59")]
	[FieldOffset(Offset = "0x130")]
	private SpriteRenderer m_RootCommonCounterIcon;

	[Token(Token = "0x400EF5A")]
	[FieldOffset(Offset = "0x138")]
	private SpriteRenderer m_CommonCounterReady;

	[Token(Token = "0x400EF5B")]
	[FieldOffset(Offset = "0x140")]
	private SpriteRenderer m_CommonCounterUnready;

	[Token(Token = "0x400EF5C")]
	[FieldOffset(Offset = "0x148")]
	private TextMeshPro m_TmpCommonCounterText;

	[Token(Token = "0x400EF5D")]
	[FieldOffset(Offset = "0x150")]
	private int prevCommonCounterCount;

	[Token(Token = "0x400EF5E")]
	[FieldOffset(Offset = "0x154")]
	private bool m_AtkInitialized;

	[Token(Token = "0x400EF5F")]
	[FieldOffset(Offset = "0x155")]
	private bool m_DefInitialized;

	[Token(Token = "0x400EF60")]
	[FieldOffset(Offset = "0x156")]
	private bool m_Visible;

	[Token(Token = "0x400EF61")]
	[FieldOffset(Offset = "0x158")]
	private int m_ShowAtk;

	[Token(Token = "0x400EF62")]
	[FieldOffset(Offset = "0x15C")]
	private int m_ShowDef;

	[Token(Token = "0x400EF63")]
	[FieldOffset(Offset = "0x160")]
	private bool m_IsAttack;

	[Token(Token = "0x400EF64")]
	[FieldOffset(Offset = "0x168")]
	private Tween m_TwChangeCounter;

	[Token(Token = "0x400EF65")]
	[FieldOffset(Offset = "0x170")]
	private Tween m_TwChangeAttribute;

	[Token(Token = "0x400EF66")]
	[FieldOffset(Offset = "0x178")]
	private Tween m_TwAtkToDef;

	[Token(Token = "0x400EF67")]
	[FieldOffset(Offset = "0x180")]
	private Tween m_TwDefToAtk;

	[Token(Token = "0x400EF68")]
	[FieldOffset(Offset = "0x188")]
	private Tween m_TwShowLabel;

	[Token(Token = "0x400EF69")]
	[FieldOffset(Offset = "0x190")]
	private Tween m_TwHideLabel;

	[Token(Token = "0x400EF6A")]
	[FieldOffset(Offset = "0x198")]
	private int m_CurrentCounterIndex;

	[Token(Token = "0x400EF6B")]
	[FieldOffset(Offset = "0x1A0")]
	protected List<Transform> m_RotateItemList;

	[Token(Token = "0x400EF6C")]
	[FieldOffset(Offset = "0x1A8")]
	protected Dictionary<int, int> m_MarkerPosTable;

	[Token(Token = "0x400EF6D")]
	[FieldOffset(Offset = "0x1B0")]
	private ElementObjectManager m_RootSwitchTween;

	[Token(Token = "0x400EF6E")]
	[FieldOffset(Offset = "0x1B8")]
	private bool m_LinkMarkerShowing;

	[Token(Token = "0x400EF6F")]
	[FieldOffset(Offset = "0x1BC")]
	private int m_CurrentAttrIndex;

	[Token(Token = "0x400EF70")]
	[FieldOffset(Offset = "0x1C0")]
	public bool ShowFullStatus;

	[Token(Token = "0x400EF72")]
	[FieldOffset(Offset = "0x1C8")]
	private Action m_CommonCounterUpdateCallback;

	[Token(Token = "0x170019B0")]
	private int m_SlhFontSize
	{
		[Token(Token = "0x600A709")]
		[Address(RVA = "0xF35D20", Offset = "0xF34F20", VA = "0x180F35D20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170019B1")]
	private int m_ActiveFontSize
	{
		[Token(Token = "0x600A70A")]
		[Address(RVA = "0xF35C40", Offset = "0xF34E40", VA = "0x180F35C40")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170019B2")]
	private int m_InactiveFontSize
	{
		[Token(Token = "0x600A70B")]
		[Address(RVA = "0xF35CB0", Offset = "0xF34EB0", VA = "0x180F35CB0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170019B3")]
	public static bool visibleAll
	{
		[Token(Token = "0x600A70C")]
		[Address(RVA = "0xF35D90", Offset = "0xF34F90", VA = "0x180F35D90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A70D")]
		[Address(RVA = "0xF35DE0", Offset = "0xF34FE0", VA = "0x180F35DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600A706")]
	[Address(RVA = "0xF32A60", Offset = "0xF31C60", VA = "0x180F32A60")]
	public static void ResetLabelPool()
	{
	}

	[Token(Token = "0x600A707")]
	[Address(RVA = "0xF32970", Offset = "0xF31B70", VA = "0x180F32970")]
	public static void RemoveLabel(CardRoot cardRoot)
	{
	}

	[Token(Token = "0x600A708")]
	[Address(RVA = "0xF2FFF0", Offset = "0xF2F1F0", VA = "0x180F2FFF0")]
	public static CardStatusLabel3D Create(CardRoot cardroot)
	{
		return null;
	}

	[Token(Token = "0x600A70E")]
	[Address(RVA = "0xF30C70", Offset = "0xF2FE70", VA = "0x180F30C70")]
	private void InitComponent()
	{
	}

	[Token(Token = "0x600A70F")]
	[Address(RVA = "0xF32070", Offset = "0xF31270", VA = "0x180F32070")]
	private void InitRotationList()
	{
	}

	[Token(Token = "0x600A710")]
	[Address(RVA = "0xF31DE0", Offset = "0xF30FE0", VA = "0x180F31DE0")]
	public void InitParameters()
	{
	}

	[Token(Token = "0x600A711")]
	[Address(RVA = "0xF308F0", Offset = "0xF2FAF0", VA = "0x180F308F0")]
	public void InitCommonCounter()
	{
	}

	[Token(Token = "0x600A712")]
	[Address(RVA = "0xF2FCB0", Offset = "0xF2EEB0", VA = "0x180F2FCB0")]
	private void CounterUpdate(SummonCountSetting.SummonCountInfo info)
	{
	}

	[Token(Token = "0x600A713")]
	[Address(RVA = "0xF30370", Offset = "0xF2F570", VA = "0x180F30370")]
	public void DisposeCommonCounter()
	{
	}

	[Token(Token = "0x600A714")]
	[Address(RVA = "0xF35340", Offset = "0xF34540", VA = "0x180F35340")]
	[IteratorStateMachine(typeof(_003CUpdatePowerPointProcess_003Ed__136))]
	private IEnumerator UpdatePowerPointProcess()
	{
		return null;
	}

	[Token(Token = "0x600A715")]
	[Address(RVA = "0xF34270", Offset = "0xF33470", VA = "0x180F34270")]
	private void UpdateLevelRank()
	{
	}

	[Token(Token = "0x600A716")]
	[Address(RVA = "0xF33190", Offset = "0xF32390", VA = "0x180F33190")]
	private void UpdateAttribute()
	{
	}

	[Token(Token = "0x600A717")]
	[Address(RVA = "0xF2F9A0", Offset = "0xF2EBA0", VA = "0x180F2F9A0")]
	private void ChangeAttribute()
	{
	}

	[Token(Token = "0x600A718")]
	[Address(RVA = "0xF35990", Offset = "0xF34B90", VA = "0x180F35990")]
	private void UpdtaeLink()
	{
	}

	[Token(Token = "0x600A719")]
	[Address(RVA = "0xF35820", Offset = "0xF34A20", VA = "0x180F35820")]
	private void UpdateType()
	{
	}

	[Token(Token = "0x600A71A")]
	[Address(RVA = "0xF346E0", Offset = "0xF338E0", VA = "0x180F346E0")]
	private void UpdateMagicType()
	{
	}

	[Token(Token = "0x600A71B")]
	[Address(RVA = "0xF35660", Offset = "0xF34860", VA = "0x180F35660")]
	private void UpdateTunerIcon()
	{
	}

	[Token(Token = "0x600A71C")]
	[Address(RVA = "0xF34D80", Offset = "0xF33F80", VA = "0x180F34D80")]
	private void UpdatePendulumScale()
	{
	}

	[Token(Token = "0x600A71D")]
	[Address(RVA = "0xF34BE0", Offset = "0xF33DE0", VA = "0x180F34BE0")]
	private void UpdateOverlayUnits()
	{
	}

	[Token(Token = "0x600A71E")]
	[Address(RVA = "0xF34000", Offset = "0xF33200", VA = "0x180F34000")]
	private void UpdateCounter()
	{
	}

	[Token(Token = "0x600A71F")]
	[Address(RVA = "0xF344B0", Offset = "0xF336B0", VA = "0x180F344B0")]
	private void UpdateLinkMarker()
	{
	}

	[Token(Token = "0x600A720")]
	[Address(RVA = "0xF353B0", Offset = "0xF345B0", VA = "0x180F353B0")]
	private void UpdateStateIcons()
	{
	}

	[Token(Token = "0x600A721")]
	[Address(RVA = "0xF2FB10", Offset = "0xF2ED10", VA = "0x180F2FB10")]
	private void ChangeCounter()
	{
	}

	[Token(Token = "0x600A722")]
	[Address(RVA = "0xF2FC90", Offset = "0xF2EE90", VA = "0x180F2FC90")]
	private int ChangePowerPoint(int powernow, int powertarget)
	{
		return default(int);
	}

	[Token(Token = "0x600A723")]
	[Address(RVA = "0xF30400", Offset = "0xF2F600", VA = "0x180F30400")]
	private string GetPowerPointString(int powershow, int powerorg, bool active)
	{
		return null;
	}

	[Token(Token = "0x600A724")]
	[Address(RVA = "0xF34FF0", Offset = "0xF341F0", VA = "0x180F34FF0")]
	private void UpdatePowerPointImpl()
	{
	}

	[Token(Token = "0x600A725")]
	[Address(RVA = "0xF30540", Offset = "0xF2F740", VA = "0x180F30540")]
	private SpriteRenderer GetStateIcon(int index)
	{
		return null;
	}

	[Token(Token = "0x600A726")]
	[Address(RVA = "0xF2F770", Offset = "0xF2E970", VA = "0x180F2F770")]
	private bool AddStateIcon(StateIconType icontype, int iconindex)
	{
		return default(bool);
	}

	[Token(Token = "0x600A727")]
	[Address(RVA = "0xF305D0", Offset = "0xF2F7D0", VA = "0x180F305D0")]
	private Color GetValueColor(int valuedisp, int valueorg)
	{
		return default(Color);
	}

	[Token(Token = "0x600A728")]
	[Address(RVA = "0xF32850", Offset = "0xF31A50", VA = "0x180F32850")]
	private void LinkMarkerZoomIn()
	{
	}

	[Token(Token = "0x600A729")]
	[Address(RVA = "0xF328E0", Offset = "0xF31AE0", VA = "0x180F328E0")]
	private void LinkMarkerZoomOut()
	{
	}

	[Token(Token = "0x600A72A")]
	[Address(RVA = "0xF32C40", Offset = "0xF31E40", VA = "0x180F32C40")]
	private void SetLinkMarkerShineEnable(bool enable)
	{
	}

	[Token(Token = "0x600A72B")]
	[Address(RVA = "0xF33F10", Offset = "0xF33110", VA = "0x180F33F10")]
	public void UpdateCommonCounter()
	{
	}

	[Token(Token = "0x600A72C")]
	[Address(RVA = "0xF327A0", Offset = "0xF319A0", VA = "0x180F327A0")]
	private void Initialize(CardRoot cardroot)
	{
	}

	[Token(Token = "0x600A72D")]
	[Address(RVA = "0xF33700", Offset = "0xF32900", VA = "0x180F33700")]
	public void UpdateCardStatues()
	{
	}

	[Token(Token = "0x600A72E")]
	[Address(RVA = "0xF2F880", Offset = "0xF2EA80", VA = "0x180F2F880")]
	public void AtkDefSwitch()
	{
	}

	[Token(Token = "0x600A72F")]
	[Address(RVA = "0xF30250", Offset = "0xF2F450", VA = "0x180F30250")]
	public void DefAtkSwitch()
	{
	}

	[Token(Token = "0x600A730")]
	[Address(RVA = "0xF307D0", Offset = "0xF2F9D0", VA = "0x180F307D0")]
	public void Hide(bool immediate = false)
	{
	}

	[Token(Token = "0x600A731")]
	[Address(RVA = "0xF32E90", Offset = "0xF32090", VA = "0x180F32E90")]
	public void Show(bool immediate = false)
	{
	}

	[Token(Token = "0x600A732")]
	[Address(RVA = "0xF32FC0", Offset = "0xF321C0", VA = "0x180F32FC0")]
	public void StopAllTween()
	{
	}

	[Token(Token = "0x600A733")]
	[Address(RVA = "0xF33090", Offset = "0xF32290", VA = "0x180F33090")]
	public void StopStateChangeTween()
	{
	}

	[Token(Token = "0x600A734")]
	[Address(RVA = "0xF33050", Offset = "0xF32250", VA = "0x180F33050")]
	public void StopShowHideTween()
	{
	}

	[Token(Token = "0x600A735")]
	[Address(RVA = "0xF32AF0", Offset = "0xF31CF0", VA = "0x180F32AF0")]
	public void RotateStatueLabel(Quaternion rotation)
	{
	}

	[Token(Token = "0x600A736")]
	[Address(RVA = "0xF30640", Offset = "0xF2F840", VA = "0x180F30640")]
	public static void HideAll(bool immediate = false)
	{
	}

	[Token(Token = "0x600A737")]
	[Address(RVA = "0xF32D00", Offset = "0xF31F00", VA = "0x180F32D00")]
	public static void ShowAll(bool immediate = false)
	{
	}

	[Token(Token = "0x600A738")]
	[Address(RVA = "0xF35B70", Offset = "0xF34D70", VA = "0x180F35B70")]
	public CardStatusLabel3D()
	{
	}
}
