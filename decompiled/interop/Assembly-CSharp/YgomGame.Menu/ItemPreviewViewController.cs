using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomGame.Bg;
using YgomGame.CardFile;
using YgomGame.Coin;
using YgomGame.Duel;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x20012E9")]
public class ItemPreviewViewController : BaseMenuViewController, IDynamicChangeDispHeaderSupported
{
	[Token(Token = "0x20012EA")]
	private enum RootIconType
	{
		[Token(Token = "0x400BE38")]
		None,
		[Token(Token = "0x400BE39")]
		S,
		[Token(Token = "0x400BE3A")]
		M,
		[Token(Token = "0x400BE3B")]
		L,
		[Token(Token = "0x400BE3C")]
		LL,
		[Token(Token = "0x400BE3D")]
		Protector
	}

	[Token(Token = "0x20012EB")]
	private struct CameraSettings
	{
		[Token(Token = "0x400BE3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float xMax;

		[Token(Token = "0x400BE3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float xMin;

		[Token(Token = "0x400BE40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float yMax;

		[Token(Token = "0x400BE41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float yMin;

		[Token(Token = "0x400BE42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float fov;

		[Token(Token = "0x400BE43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float nearClip;

		[Token(Token = "0x400BE44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float farClip;

		[Token(Token = "0x600759C")]
		[Address(RVA = "0xBBA2E0", Offset = "0xBB94E0", VA = "0x180BBA2E0")]
		public CameraSettings(float xMax_, float xMin_, float yMax_, float yMin_, float fov_, float nearClip_, float farClip_)
		{
		}
	}

	[Token(Token = "0x20012F2")]
	[CompilerGenerated]
	private sealed class _003CWallPaperBack_003Ed__119 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BE6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BE6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BE6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ItemPreviewViewController _003C_003E4__this;

		[Token(Token = "0x17001265")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60075BA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001266")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60075BC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60075B7")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CWallPaperBack_003Ed__119(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60075B8")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60075B9")]
		[Address(RVA = "0xBD2810", Offset = "0xBD1A10", VA = "0x180BD2810", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60075BB")]
		[Address(RVA = "0xBD2990", Offset = "0xBD1B90", VA = "0x180BD2990", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400BDE2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string MATE_TRANSFORM_SETTING_PATH;

	[Token(Token = "0x400BDE3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string ROOT_ICON_S_LABEL;

	[Token(Token = "0x400BDE4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string ROOT_ICON_M_LABEL;

	[Token(Token = "0x400BDE5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string ROOT_ICON_L_LABEL;

	[Token(Token = "0x400BDE6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string ROOT_ICON_LL_LABEL;

	[Token(Token = "0x400BDE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string ROOT_ICON_PROTECTOR_LABEL;

	[Token(Token = "0x400BDE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string ROOT_ICON_EFFECT_LABEL;

	[Token(Token = "0x400BDE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string ROOT_MATE_LABEL;

	[Token(Token = "0x400BDEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string ROOT_FIELD_LABEL;

	[Token(Token = "0x400BDEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string ROOT_TAG_LABEL;

	[Token(Token = "0x400BDEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly string ROOT_TAG_IMAGE_LABEL;

	[Token(Token = "0x400BDED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly string ROOT_WALLPAPER_LABEL;

	[Token(Token = "0x400BDEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly string TEXT_ITEM_NUM_LABEL;

	[Token(Token = "0x400BDEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly string TEXT_ITEM_NAME_LABEL;

	[Token(Token = "0x400BDF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private readonly string TEXT_ITEM_CATEGORY_LABEL;

	[Token(Token = "0x400BDF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private readonly string TEXT_ITEM_DESC_LABEL;

	[Token(Token = "0x400BDF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private readonly string TMP_TAG_LABEL;

	[Token(Token = "0x400BDF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private readonly string TXT_TAG_LABEL;

	[Token(Token = "0x400BDF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private readonly string BTN_LABEL;

	[Token(Token = "0x400BDF5")]
	public const string k_ArgKeyIsPeriod = "isPeriod";

	[Token(Token = "0x400BDF6")]
	public const string k_ArgKeyItemId = "itemId";

	[Token(Token = "0x400BDF7")]
	public const string k_ArgKeyItemCategory = "itemCategory";

	[Token(Token = "0x400BDF8")]
	public const string k_ArgKeyItemNum = "itemNum";

	[Token(Token = "0x400BDF9")]
	public const string k_ArgKeyFieldIds = "fieldIds";

	[Token(Token = "0x400BDFA")]
	public const string k_ArgKeyOpenAsDialog = "openAsDialog";

	[Token(Token = "0x400BDFB")]
	public const string k_ArgKeyCoin = "coin";

	[Token(Token = "0x400BDFC")]
	public const string k_ArgKeyField = "field";

	[Token(Token = "0x400BDFD")]
	public const string k_ArgKeyFieldOpposite = "fieldOpposite";

	[Token(Token = "0x400BDFE")]
	public const string k_ArgKeyAvatarBase = "avatarBase";

	[Token(Token = "0x400BDFF")]
	public const string k_ArgKeyAvatarBaseOpposite = "avatarBaseOpposite";

	[Token(Token = "0x400BE00")]
	public const string k_ArgKeyFieldObj = "fieldObj";

	[Token(Token = "0x400BE01")]
	public const string k_ArgKeyFieldObjOpposite = "fieldObjOpposite";

	[Token(Token = "0x400BE02")]
	public const string k_ArgKeyAvatar = "avatar";

	[Token(Token = "0x400BE03")]
	public const string k_ArgKeyAvatarOpposite = "avatarOpposite";

	[Token(Token = "0x400BE04")]
	public const string k_ArgKeyCardFileCompleteStatus = "CardFileCompleteStatus";

	[Token(Token = "0x400BE05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private readonly string k_ELabelRoot3D;

	[Token(Token = "0x400BE06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private readonly string k_ELabelFieldLocator;

	[Token(Token = "0x400BE07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private readonly string k_ELabelScreenTouchButton;

	[Token(Token = "0x400BE08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private readonly string k_ELabelBadgeLocator;

	[Token(Token = "0x400BE09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private bool m_IsPeriod;

	[Token(Token = "0x400BE0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	private int m_ItemId;

	[Token(Token = "0x400BE0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private int m_ItemCategory;

	[Token(Token = "0x400BE0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private Dictionary<string, object> m_FieldArgs;

	[Token(Token = "0x400BE0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private int m_ItemNum;

	[Token(Token = "0x400BE0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	private bool m_IsCoin;

	[Token(Token = "0x400BE0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private int m_CardFileCompleteStatus;

	[Token(Token = "0x400BE10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private TextMeshProUGUI m_ItemNumText;

	[Token(Token = "0x400BE11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private TextMeshProUGUI m_ItemNameText;

	[Token(Token = "0x400BE12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private TextMeshProUGUI m_ItemDescText;

	[Token(Token = "0x400BE13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private TextMeshProUGUI m_ItemCategoryText;

	[Token(Token = "0x400BE14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private SelectionButton m_CancelButton;

	[Token(Token = "0x400BE15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private Character2D chara;

	[Token(Token = "0x400BE16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private ItemPreview2D itemPreview;

	[Token(Token = "0x400BE17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private Transform m_RootField;

	[Token(Token = "0x400BE18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private Transform m_Root3D;

	[Token(Token = "0x400BE19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private BgPreview m_BgActor;

	[Token(Token = "0x400BE1A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private Vector2 m_ScreenBaseRate;

	[Token(Token = "0x400BE1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private Vector2 m_DragStartVec;

	[Token(Token = "0x400BE1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private GameObject currentWallpaperGo;

	[Token(Token = "0x400BE1D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private GameObject m_BadgeLocator;

	[Token(Token = "0x400BE1E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private TimelineObject m_TimelineObject;

	[Token(Token = "0x400BE1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private CameraSettings fieldCameraSettings;

	[Token(Token = "0x400BE20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
	private CameraSettings fieldPartsCameraSettings;

	[Token(Token = "0x400BE21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private CameraSettings avatarBaseCameraSettings;

	[Token(Token = "0x400BE22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
	private CameraSettings CoinCameraSettings;

	[Token(Token = "0x400BE23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	private CameraSettings cardFileCameraSettings;

	[Token(Token = "0x400BE24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
	private float x_AxisMax;

	[Token(Token = "0x400BE25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	private float x_AxisMin;

	[Token(Token = "0x400BE26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2BC")]
	private float y_AxisMax;

	[Token(Token = "0x400BE27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	private float y_AxisMin;

	[Token(Token = "0x400BE28")]
	private const float m_MoveAmountDirectionalKey = 5f;

	[Token(Token = "0x400BE29")]
	private const float m_MoveAmountAnalogKey = 5f;

	[Token(Token = "0x400BE2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C4")]
	private float m_MoveAmountTouch;

	[Token(Token = "0x400BE2B")]
	private const float m_MoveAmountTouchMobile = 128f;

	[Token(Token = "0x400BE2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	private bool isInitialized;

	[Token(Token = "0x400BE2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C9")]
	private bool m_ItemEffectVisible;

	[Token(Token = "0x400BE2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2CC")]
	private RootIconType m_ItemIconType;

	[Token(Token = "0x400BE2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	private Texture2D m_TargetTexture;

	[Token(Token = "0x400BE30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	private Material materialCoinhighlight;

	[Token(Token = "0x400BE31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	private Material materialCoinStar;

	[Token(Token = "0x400BE32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	private Material materialCoin01;

	[Token(Token = "0x400BE33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	private CoinSettings coinSettings;

	[Token(Token = "0x400BE34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	private List<string> loadRequestPathList;

	[Token(Token = "0x400BE35")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	private int compCount;

	[Token(Token = "0x17001263")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600755C")]
		[Address(RVA = "0xBC1750", Offset = "0xBC0950", VA = "0x180BC1750", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001264")]
	public CardFileController cfc
	{
		[Token(Token = "0x6007573")]
		[Address(RVA = "0x49BED0", Offset = "0x49B0D0", VA = "0x18049BED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6007574")]
		[Address(RVA = "0x49C5D0", Offset = "0x49B7D0", VA = "0x18049C5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600755B")]
	[Address(RVA = "0xBBA3A0", Offset = "0xBB95A0", VA = "0x180BBA3A0")]
	private void ApplaySettings(Camera camera, CameraSettings cameraSettings)
	{
	}

	[Token(Token = "0x600755D")]
	[Address(RVA = "0xBBDE20", Offset = "0xBBD020", VA = "0x180BBDE20")]
	public static void Open([Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600755E")]
	[Address(RVA = "0xBBD180", Offset = "0xBBC380", VA = "0x180BBD180", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600755F")]
	[Address(RVA = "0xBBD6C0", Offset = "0xBBC8C0", VA = "0x180BBD6C0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6007560")]
	[Address(RVA = "0xBBE6C0", Offset = "0xBBD8C0", VA = "0x180BBE6C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6007561")]
	[Address(RVA = "0xBBD2F0", Offset = "0xBBC4F0", VA = "0x180BBD2F0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6007562")]
	[Address(RVA = "0xBBCB80", Offset = "0xBBBD80", VA = "0x180BBCB80")]
	private void InitMateController()
	{
	}

	[Token(Token = "0x6007563")]
	[Address(RVA = "0xBBCA40", Offset = "0xBBBC40", VA = "0x180BBCA40")]
	private void InitCoinController()
	{
	}

	[Token(Token = "0x6007564")]
	[Address(RVA = "0xBBC580", Offset = "0xBBB780", VA = "0x180BBC580")]
	private void InitCardFileCameraController(bool isReverseX = false, bool isReverseY = false)
	{
	}

	[Token(Token = "0x6007565")]
	[Address(RVA = "0xBBC110", Offset = "0xBBB310", VA = "0x180BBC110")]
	private void InitCameraController(bool isReverse = false)
	{
	}

	[Token(Token = "0x6007566")]
	[Address(RVA = "0xBBA690", Offset = "0xBB9890", VA = "0x180BBA690")]
	private void BindItem()
	{
	}

	[Token(Token = "0x6007567")]
	[Address(RVA = "0xBBA5D0", Offset = "0xBB97D0", VA = "0x180BBA5D0")]
	private void BindItemIconRoot(GameObject itemIconRoot, bool visible, bool isPeriod, int itemCategory, int itemId)
	{
	}

	[Token(Token = "0x6007568")]
	[Address(RVA = "0xBBB0B0", Offset = "0xBBA2B0", VA = "0x180BBB0B0")]
	private void BindTag()
	{
	}

	[Token(Token = "0x6007569")]
	[Address(RVA = "0xBBCD10", Offset = "0xBBBF10", VA = "0x180BBCD10")]
	private void InitMateSettings()
	{
	}

	[Token(Token = "0x600756A")]
	[Address(RVA = "0xBBDF20", Offset = "0xBBD120", VA = "0x180BBDF20")]
	private void PlayMateMotion()
	{
	}

	[Token(Token = "0x600756B")]
	[Address(RVA = "0xBBA420", Offset = "0xBB9620", VA = "0x180BBA420")]
	private void BindField(Dictionary<string, object> fieldArgs)
	{
	}

	[Token(Token = "0x600756C")]
	[Address(RVA = "0xBBBD70", Offset = "0xBBAF70", VA = "0x180BBBD70")]
	private void CreateField(Dictionary<string, object> fieldArgs)
	{
	}

	[Token(Token = "0x600756D")]
	[Address(RVA = "0xBBBAA0", Offset = "0xBBACA0", VA = "0x180BBBAA0")]
	private void CreateFieldParts()
	{
	}

	[Token(Token = "0x600756E")]
	[Address(RVA = "0xBBDF80", Offset = "0xBBD180", VA = "0x180BBDF80")]
	private void PreLoadCoin()
	{
	}

	[Token(Token = "0x600756F")]
	[Address(RVA = "0xBBB1A0", Offset = "0xBBA3A0", VA = "0x180BBB1A0")]
	private void CheckAllTaskCompleted()
	{
	}

	[Token(Token = "0x6007570")]
	[Address(RVA = "0xBBB2B0", Offset = "0xBBA4B0", VA = "0x180BBB2B0")]
	private void CreateCoin()
	{
	}

	[Token(Token = "0x6007571")]
	[Address(RVA = "0xBBE100", Offset = "0xBBD300", VA = "0x180BBE100")]
	private void SetupMeshRender(GameObject target, bool isHead)
	{
	}

	[Token(Token = "0x6007572")]
	[Address(RVA = "0xBBE360", Offset = "0xBBD560", VA = "0x180BBE360")]
	private void SetupParticleMaterial(ElementObjectManager eom, int coinid)
	{
	}

	[Token(Token = "0x6007575")]
	[Address(RVA = "0xBBB1C0", Offset = "0xBBA3C0", VA = "0x180BBB1C0")]
	private void CreateCardFile()
	{
	}

	[Token(Token = "0x6007576")]
	[Address(RVA = "0xBBCDA0", Offset = "0xBBBFA0", VA = "0x180BBCDA0")]
	private void LodPrefab(string prefPath, Vector3 modelPos, Vector3 modelRot, Vector3 modelScale, Vector3 camPos, Vector3 camRot, int renderTexW = 256, int renderTexH = 256, float imageW = -1f, float imageH = -1f)
	{
	}

	[Token(Token = "0x6007577")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "28")]
	public HeaderViewController.IsDispHeader IsDispContents()
	{
		return default(HeaderViewController.IsDispHeader);
	}

	[Token(Token = "0x6007578")]
	[Address(RVA = "0xBBD4E0", Offset = "0xBBC6E0", VA = "0x180BBD4E0", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6007579")]
	[Address(RVA = "0xBC1080", Offset = "0xBC0280", VA = "0x180BC1080")]
	[IteratorStateMachine(typeof(_003CWallPaperBack_003Ed__119))]
	private IEnumerator WallPaperBack()
	{
		return null;
	}

	[Token(Token = "0x600757A")]
	[Address(RVA = "0xBBCF10", Offset = "0xBBC110", VA = "0x180BBCF10")]
	private void MoveCamera(Vector3 movePos, bool isReverseX = false, bool isReverseY = false)
	{
	}

	[Token(Token = "0x600757B")]
	[Address(RVA = "0xBBD9F0", Offset = "0xBBCBF0", VA = "0x180BBD9F0")]
	private void OnDrag(SelectionItem.DragStatus dragStatus, Vector2 vec, bool isReverseX = false, bool isReverseY = false)
	{
	}

	[Token(Token = "0x600757C")]
	[Address(RVA = "0xBBDD70", Offset = "0xBBCF70", VA = "0x180BBDD70")]
	private void OnInputKeyUp(bool isReverseX = false, bool isReverseY = false)
	{
	}

	[Token(Token = "0x600757D")]
	[Address(RVA = "0xBBDB60", Offset = "0xBBCD60", VA = "0x180BBDB60")]
	private void OnInputKeyDown(bool isReverseX = false, bool isReverseY = false)
	{
	}

	[Token(Token = "0x600757E")]
	[Address(RVA = "0xBBDC10", Offset = "0xBBCE10", VA = "0x180BBDC10")]
	private void OnInputKeyLeft(bool isReverseX = false, bool isReverseY = false)
	{
	}

	[Token(Token = "0x600757F")]
	[Address(RVA = "0xBBDCC0", Offset = "0xBBCEC0", VA = "0x180BBDCC0")]
	private void OnInputKeyRight(bool isReverseX = false, bool isReverseY = false)
	{
	}

	[Token(Token = "0x6007580")]
	[Address(RVA = "0xBBDB10", Offset = "0xBBCD10", VA = "0x180BBDB10")]
	private void OnInputAnalogKey(Vector2 input, bool isReverseX = false, bool isReverseY = false)
	{
	}

	[Token(Token = "0x6007581")]
	[Address(RVA = "0xBC10F0", Offset = "0xBC02F0", VA = "0x180BC10F0")]
	public ItemPreviewViewController()
	{
	}
}
