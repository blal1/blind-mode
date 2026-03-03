using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.UI;

[Token(Token = "0x20004B4")]
public class SelectorManager : MonoBehaviour
{
	[Token(Token = "0x20004B5")]
	public enum KeyType
	{
		[Token(Token = "0x4001747")]
		None,
		[Token(Token = "0x4001748")]
		Accept,
		[Token(Token = "0x4001749")]
		Cancel,
		[Token(Token = "0x400174A")]
		Sub1,
		[Token(Token = "0x400174B")]
		Sub2,
		[Token(Token = "0x400174C")]
		Left1,
		[Token(Token = "0x400174D")]
		Left2,
		[Token(Token = "0x400174E")]
		Left3,
		[Token(Token = "0x400174F")]
		Right1,
		[Token(Token = "0x4001750")]
		Right2,
		[Token(Token = "0x4001751")]
		Right3,
		[Token(Token = "0x4001752")]
		Option1,
		[Token(Token = "0x4001753")]
		Option2,
		[Token(Token = "0x4001754")]
		DirectionUp,
		[Token(Token = "0x4001755")]
		DirectionDown,
		[Token(Token = "0x4001756")]
		DirectionLeft,
		[Token(Token = "0x4001757")]
		DirectionRight,
		[Token(Token = "0x4001758")]
		BackKey,
		[Token(Token = "0x4001759")]
		Any
	}

	[Token(Token = "0x20004B6")]
	public enum AnalogType
	{
		[Token(Token = "0x400175B")]
		None,
		[Token(Token = "0x400175C")]
		Main,
		[Token(Token = "0x400175D")]
		Sub,
		[Token(Token = "0x400175E")]
		Wheel
	}

	[Token(Token = "0x20004B7")]
	public enum MouseType
	{
		[Token(Token = "0x4001760")]
		None,
		[Token(Token = "0x4001761")]
		Main,
		[Token(Token = "0x4001762")]
		Sub1,
		[Token(Token = "0x4001763")]
		Sub2
	}

	[Token(Token = "0x20004B8")]
	public enum KeyStatus
	{
		[Token(Token = "0x4001765")]
		Released,
		[Token(Token = "0x4001766")]
		OnPush,
		[Token(Token = "0x4001767")]
		Pushed,
		[Token(Token = "0x4001768")]
		OnRelease
	}

	[Token(Token = "0x20004B9")]
	public enum CombiKeyStatus
	{
		[Token(Token = "0x400176A")]
		SubOffMainReleased = 0,
		[Token(Token = "0x400176B")]
		SubOffMainOnPush = 1,
		[Token(Token = "0x400176C")]
		SubOffMainPushed = 2,
		[Token(Token = "0x400176D")]
		SubOffMainOnRelease = 3,
		[Token(Token = "0x400176E")]
		SubOnMainReleased = 4,
		[Token(Token = "0x400176F")]
		SubOnMainOnPush = 8,
		[Token(Token = "0x4001770")]
		SubOnMainPushed = 16,
		[Token(Token = "0x4001771")]
		SubOnMainOnRelease = 32
	}

	[Token(Token = "0x20004BA")]
	public enum KeyTypeMask
	{
		[Token(Token = "0x4001773")]
		None = 0,
		[Token(Token = "0x4001774")]
		Accept = 2,
		[Token(Token = "0x4001775")]
		Cancel = 4,
		[Token(Token = "0x4001776")]
		Sub1 = 8,
		[Token(Token = "0x4001777")]
		Sub2 = 0x10,
		[Token(Token = "0x4001778")]
		Left1 = 0x20,
		[Token(Token = "0x4001779")]
		Left2 = 0x40,
		[Token(Token = "0x400177A")]
		Left3 = 0x80,
		[Token(Token = "0x400177B")]
		Right1 = 0x100,
		[Token(Token = "0x400177C")]
		Right2 = 0x200,
		[Token(Token = "0x400177D")]
		Right3 = 0x400,
		[Token(Token = "0x400177E")]
		Option1 = 0x800,
		[Token(Token = "0x400177F")]
		Option2 = 0x1000,
		[Token(Token = "0x4001780")]
		DirectionUp = 0x2000,
		[Token(Token = "0x4001781")]
		DirectionDown = 0x4000,
		[Token(Token = "0x4001782")]
		DirectionLeft = 0x8000,
		[Token(Token = "0x4001783")]
		DirectionRight = 0x10000,
		[Token(Token = "0x4001784")]
		BackKey = 0x20000
	}

	[Token(Token = "0x20004BB")]
	public enum AnalogTypeFlag
	{
		[Token(Token = "0x4001786")]
		None = 0,
		[Token(Token = "0x4001787")]
		Main = 2,
		[Token(Token = "0x4001788")]
		Sub = 4,
		[Token(Token = "0x4001789")]
		Wheel = 8
	}

	[Token(Token = "0x20004BC")]
	public struct ScreenInputInfo
	{
		[Token(Token = "0x400178A")]
		[FieldOffset(Offset = "0x0")]
		public bool onScreen;

		[Token(Token = "0x400178B")]
		[FieldOffset(Offset = "0x4")]
		public Vector2 screenPoint;

		[Token(Token = "0x400178C")]
		[FieldOffset(Offset = "0xC")]
		public bool pressMain;

		[Token(Token = "0x400178D")]
		[FieldOffset(Offset = "0xD")]
		public bool pressSub1;

		[Token(Token = "0x400178E")]
		[FieldOffset(Offset = "0xE")]
		public bool pressSub2;

		[Token(Token = "0x6001FA2")]
		[Address(RVA = "0x615AC0", Offset = "0x614CC0", VA = "0x180615AC0")]
		public bool IsChanged(ScreenInputInfo info)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20004BD")]
	public enum InputDevice
	{
		[Token(Token = "0x4001790")]
		PointingDevice,
		[Token(Token = "0x4001791")]
		GamePad
	}

	[Token(Token = "0x20004BE")]
	public class ChangeDeviceEvent : UnityEvent<InputDevice>
	{
		[Token(Token = "0x6001FA3")]
		[Address(RVA = "0x6158F0", Offset = "0x614AF0", VA = "0x1806158F0")]
		public ChangeDeviceEvent()
		{
		}
	}

	[Token(Token = "0x20004BF")]
	private delegate bool ClusterFunc(SelectorCluster cluster);

	[Token(Token = "0x4001700")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, SelectorCluster> clusters;

	[Token(Token = "0x4001702")]
	[FieldOffset(Offset = "0x10")]
	private static ClusterFunc selectCurrentItemCallback;

	[Token(Token = "0x4001703")]
	[FieldOffset(Offset = "0x18")]
	private static ClusterFunc selectHighestPriorityItemCallback;

	[Token(Token = "0x4001704")]
	[FieldOffset(Offset = "0x20")]
	private static ClusterFunc getCurrentItemCallback;

	[Token(Token = "0x4001705")]
	[FieldOffset(Offset = "0x28")]
	private static ClusterFunc protectActivationClusterCallback;

	[Token(Token = "0x4001706")]
	[FieldOffset(Offset = "0x30")]
	private static ClusterFunc activateClusterCallback;

	[Token(Token = "0x4001707")]
	[FieldOffset(Offset = "0x38")]
	private static ClusterFunc resetCallbackManagerPriorityCallback;

	[Token(Token = "0x4001708")]
	[FieldOffset(Offset = "0x40")]
	private static ClusterFunc setCallbackManagerPriorityCallback;

	[Token(Token = "0x4001709")]
	[FieldOffset(Offset = "0x20")]
	private GamePad _pad;

	[Token(Token = "0x400170A")]
	[FieldOffset(Offset = "0x28")]
	private KeyInputInfo _keyInputInfo;

	[Token(Token = "0x400170B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _padInputRepeatStartTime;

	[Token(Token = "0x400170C")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float _padInputRepeatIntervalTime;

	[Token(Token = "0x400170D")]
	[FieldOffset(Offset = "0x38")]
	private ScreenInputInfo currentInputInfo;

	[Token(Token = "0x400170E")]
	[FieldOffset(Offset = "0x48")]
	private ScreenInputInfo screenInputInfo;

	[Token(Token = "0x400170F")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float _dragStartThreshold;

	[Token(Token = "0x4001710")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private float _flickThreshold;

	[Token(Token = "0x4001711")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 preMousePosition;

	[Token(Token = "0x4001717")]
	[FieldOffset(Offset = "0x98")]
	private bool dragging;

	[Token(Token = "0x4001718")]
	[FieldOffset(Offset = "0x99")]
	private bool dragSuccess;

	[Token(Token = "0x4001719")]
	[FieldOffset(Offset = "0x9C")]
	private float holdTime;

	[Token(Token = "0x400171A")]
	[FieldOffset(Offset = "0xA0")]
	private bool holding;

	[Token(Token = "0x400171B")]
	[FieldOffset(Offset = "0xA1")]
	private bool holdCheck;

	[Token(Token = "0x400171C")]
	[FieldOffset(Offset = "0xA4")]
	private Vector2 pressedPoint;

	[Token(Token = "0x400171D")]
	private const float clickInterval = 0.2f;

	[Token(Token = "0x400171E")]
	[FieldOffset(Offset = "0xAC")]
	private float preClickedTime;

	[Token(Token = "0x400171F")]
	[FieldOffset(Offset = "0x48")]
	private static bool screenInputUpdateRequest;

	[Token(Token = "0x4001725")]
	[FieldOffset(Offset = "0x68")]
	private static Dictionary<int, int> inputBlockCounter;

	[Token(Token = "0x4001726")]
	[FieldOffset(Offset = "0x70")]
	private static int highestInputBlockPriority;

	[Token(Token = "0x4001728")]
	[FieldOffset(Offset = "0x78")]
	private static List<SelectionItem> provisionalRegistedItem;

	[Token(Token = "0x4001729")]
	[FieldOffset(Offset = "0x80")]
	private static List<SelectionItem> provisionalSelectedItem;

	[Token(Token = "0x400172A")]
	[FieldOffset(Offset = "0x88")]
	private static List<Selector> provisionalRegistedSelector;

	[Token(Token = "0x400172F")]
	[FieldOffset(Offset = "0xB8")]
	private SelectorCallbackManager callbackManager;

	[Token(Token = "0x4001730")]
	[FieldOffset(Offset = "0x98")]
	public static SelectorManager instance;

	[Token(Token = "0x4001732")]
	[FieldOffset(Offset = "0xA4")]
	public static InputDevice defaultInputDevice;

	[Token(Token = "0x4001735")]
	[FieldOffset(Offset = "0xB4")]
	private static bool deviceLock;

	[Token(Token = "0x4001737")]
	[FieldOffset(Offset = "0xC0")]
	private static bool usePointingDeviceInput;

	[Token(Token = "0x4001738")]
	[FieldOffset(Offset = "0xC1")]
	private static bool useGamePadInput;

	[Token(Token = "0x4001739")]
	[FieldOffset(Offset = "0xC4")]
	private static int useKeyboardPadKeyBlockCounter;

	[Token(Token = "0x400173A")]
	[FieldOffset(Offset = "0xC8")]
	private static Dictionary<KeyType, int> gamePadButtonKeyConfig;

	[Token(Token = "0x400173B")]
	[FieldOffset(Offset = "0xD0")]
	private static Dictionary<AnalogType, int[]> gamePadAnalogKeyConfig;

	[Token(Token = "0x400173C")]
	[FieldOffset(Offset = "0xD8")]
	private static Dictionary<KeyType, KeyCode[]> keyboardButtonKeyConfig;

	[Token(Token = "0x400173D")]
	[FieldOffset(Offset = "0xE0")]
	private static Dictionary<MouseType, int> mouseKeyConfig;

	[Token(Token = "0x400173E")]
	[FieldOffset(Offset = "0xC0")]
	private KeyType currentOnPushKeyType;

	[Token(Token = "0x400173F")]
	[FieldOffset(Offset = "0xC4")]
	private KeyType currentPushedKeyType;

	[Token(Token = "0x4001740")]
	[FieldOffset(Offset = "0xC8")]
	private KeyType currentOnReleaseKeyType;

	[Token(Token = "0x4001741")]
	[FieldOffset(Offset = "0xCC")]
	private KeyType currentSubKeyType;

	[Token(Token = "0x4001742")]
	[FieldOffset(Offset = "0xD0")]
	private MouseType currentOnPushMouseType;

	[Token(Token = "0x4001743")]
	[FieldOffset(Offset = "0xD4")]
	private MouseType currentPushedMouseType;

	[Token(Token = "0x4001744")]
	[FieldOffset(Offset = "0xD8")]
	private MouseType currentOnReleaseMouseType;

	[Token(Token = "0x4001745")]
	[FieldOffset(Offset = "0xDC")]
	private AnalogType currentAnalogType;

	[Token(Token = "0x1700030A")]
	public static SelectorCluster currentCluster
	{
		[Token(Token = "0x6001F10")]
		[Address(RVA = "0x6279E0", Offset = "0x626BE0", VA = "0x1806279E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F11")]
		[Address(RVA = "0x628CF0", Offset = "0x627EF0", VA = "0x180628CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700030B")]
	public static SelectionItem currentItem
	{
		[Token(Token = "0x6001F12")]
		[Address(RVA = "0x627A90", Offset = "0x626C90", VA = "0x180627A90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700030C")]
	private GamePad pad
	{
		[Token(Token = "0x6001F17")]
		[Address(RVA = "0x6288F0", Offset = "0x627AF0", VA = "0x1806288F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700030D")]
	private KeyInputInfo keyInputInfo
	{
		[Token(Token = "0x6001F18")]
		[Address(RVA = "0x628160", Offset = "0x627360", VA = "0x180628160")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700030E")]
	public static float padInputRepeatStartTime
	{
		[Token(Token = "0x6001F19")]
		[Address(RVA = "0x628820", Offset = "0x627A20", VA = "0x180628820")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700030F")]
	public static float padInputRepeatIntervalTime
	{
		[Token(Token = "0x6001F1A")]
		[Address(RVA = "0x628750", Offset = "0x627950", VA = "0x180628750")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000310")]
	public static float dragStartThreshold
	{
		[Token(Token = "0x6001F1B")]
		[Address(RVA = "0x627E40", Offset = "0x627040", VA = "0x180627E40")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000311")]
	public static float flickThreshold
	{
		[Token(Token = "0x6001F1C")]
		[Address(RVA = "0x627F70", Offset = "0x627170", VA = "0x180627F70")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000312")]
	public static float dragDistance
	{
		[Token(Token = "0x6001F1D")]
		[Address(RVA = "0x627D20", Offset = "0x626F20", VA = "0x180627D20")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000313")]
	public SelectionItem pressedItem
	{
		[Token(Token = "0x6001F1E")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F1F")]
		[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000314")]
	public SelectionItem draggingItem
	{
		[Token(Token = "0x6001F20")]
		[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F21")]
		[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000315")]
	public SelectionItem holdingItem
	{
		[Token(Token = "0x6001F22")]
		[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F23")]
		[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000316")]
	public SelectionItem currentPointedItem
	{
		[Token(Token = "0x6001F24")]
		[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F25")]
		[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000317")]
	public SelectionItem preClickedItem
	{
		[Token(Token = "0x6001F26")]
		[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F27")]
		[Address(RVA = "0x4989A0", Offset = "0x497BA0", VA = "0x1804989A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000318")]
	public static Vector2 flickSpeed
	{
		[Token(Token = "0x6001F28")]
		[Address(RVA = "0x627F10", Offset = "0x627110", VA = "0x180627F10")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6001F29")]
		[Address(RVA = "0x628E90", Offset = "0x628090", VA = "0x180628E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000319")]
	public int padInputBlocker
	{
		[Token(Token = "0x6001F2A")]
		[Address(RVA = "0x42D5D0", Offset = "0x42C7D0", VA = "0x18042D5D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001F2B")]
		[Address(RVA = "0x42D680", Offset = "0x42C880", VA = "0x18042D680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700031A")]
	public int mouseButtonInputBlocker
	{
		[Token(Token = "0x6001F2C")]
		[Address(RVA = "0x42D600", Offset = "0x42C800", VA = "0x18042D600")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001F2D")]
		[Address(RVA = "0x42D6B0", Offset = "0x42C8B0", VA = "0x18042D6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700031B")]
	public static Dictionary<KeyType, int> noCountKeyInput
	{
		[Token(Token = "0x6001F2E")]
		[Address(RVA = "0x6281E0", Offset = "0x6273E0", VA = "0x1806281E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F2F")]
		[Address(RVA = "0x628F00", Offset = "0x628100", VA = "0x180628F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700031C")]
	public static Dictionary<KeyType, int> directionBlockKeyInput
	{
		[Token(Token = "0x6001F30")]
		[Address(RVA = "0x627CD0", Offset = "0x626ED0", VA = "0x180627CD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F31")]
		[Address(RVA = "0x628E20", Offset = "0x628020", VA = "0x180628E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700031D")]
	public static bool acceptKeyboadInput
	{
		[Token(Token = "0x6001F32")]
		[Address(RVA = "0x627750", Offset = "0x626950", VA = "0x180627750")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001F33")]
		[Address(RVA = "0x628C90", Offset = "0x627E90", VA = "0x180628C90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700031E")]
	public static bool anyInput
	{
		[Token(Token = "0x6001F34")]
		[Address(RVA = "0x627870", Offset = "0x626A70", VA = "0x180627870")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700031F")]
	public static bool pointingInput
	{
		[Token(Token = "0x6001F35")]
		[Address(RVA = "0x628960", Offset = "0x627B60", VA = "0x180628960")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001F36")]
		[Address(RVA = "0x629190", Offset = "0x628390", VA = "0x180629190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000320")]
	public static bool padInputDirection
	{
		[Token(Token = "0x6001F37")]
		[Address(RVA = "0x628690", Offset = "0x627890", VA = "0x180628690")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001F38")]
		[Address(RVA = "0x6290D0", Offset = "0x6282D0", VA = "0x1806290D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000321")]
	public static bool padInputKey
	{
		[Token(Token = "0x6001F39")]
		[Address(RVA = "0x6286F0", Offset = "0x6278F0", VA = "0x1806286F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001F3A")]
		[Address(RVA = "0x629130", Offset = "0x628330", VA = "0x180629130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000322")]
	public static bool padInputAnalog
	{
		[Token(Token = "0x6001F3B")]
		[Address(RVA = "0x628630", Offset = "0x627830", VA = "0x180628630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001F3C")]
		[Address(RVA = "0x629070", Offset = "0x628270", VA = "0x180629070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000323")]
	public static InputDevice currentInputDevice
	{
		[Token(Token = "0x6001F3D")]
		[Address(RVA = "0x627A30", Offset = "0x626C30", VA = "0x180627A30")]
		[CompilerGenerated]
		get
		{
			return default(InputDevice);
		}
		[Token(Token = "0x6001F3E")]
		[Address(RVA = "0x628D60", Offset = "0x627F60", VA = "0x180628D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000324")]
	public static ChangeDeviceEvent onDeviceChangeEvent
	{
		[Token(Token = "0x6001F3F")]
		[Address(RVA = "0x628290", Offset = "0x627490", VA = "0x180628290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F40")]
		[Address(RVA = "0x628FF0", Offset = "0x6281F0", VA = "0x180628FF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000325")]
	public static int deviceLockCounter
	{
		[Token(Token = "0x6001F41")]
		[Address(RVA = "0x627C70", Offset = "0x626E70", VA = "0x180627C70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001F42")]
		[Address(RVA = "0x628DC0", Offset = "0x627FC0", VA = "0x180628DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000326")]
	public static Action onBackKeyNoActionCallback
	{
		[Token(Token = "0x6001F43")]
		[Address(RVA = "0x628230", Offset = "0x627430", VA = "0x180628230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F44")]
		[Address(RVA = "0x628F70", Offset = "0x628170", VA = "0x180628F70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000327")]
	private static bool useKeyboardPadKey
	{
		[Token(Token = "0x6001F45")]
		[Address(RVA = "0x628C30", Offset = "0x627E30", VA = "0x180628C30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000328")]
	public static KeyType onPushKeyType
	{
		[Token(Token = "0x6001F55")]
		[Address(RVA = "0x6282F0", Offset = "0x6274F0", VA = "0x1806282F0")]
		get
		{
			return default(KeyType);
		}
	}

	[Token(Token = "0x17000329")]
	public static KeyType pushedKeyType
	{
		[Token(Token = "0x6001F56")]
		[Address(RVA = "0x6289C0", Offset = "0x627BC0", VA = "0x1806289C0")]
		get
		{
			return default(KeyType);
		}
	}

	[Token(Token = "0x1700032A")]
	public static KeyType onReleaseKeyType
	{
		[Token(Token = "0x6001F57")]
		[Address(RVA = "0x628490", Offset = "0x627690", VA = "0x180628490")]
		get
		{
			return default(KeyType);
		}
	}

	[Token(Token = "0x1700032B")]
	public static KeyType subKeyType
	{
		[Token(Token = "0x6001F58")]
		[Address(RVA = "0x628B60", Offset = "0x627D60", VA = "0x180628B60")]
		get
		{
			return default(KeyType);
		}
	}

	[Token(Token = "0x1700032C")]
	public static MouseType onPushMouseType
	{
		[Token(Token = "0x6001F59")]
		[Address(RVA = "0x6283C0", Offset = "0x6275C0", VA = "0x1806283C0")]
		get
		{
			return default(MouseType);
		}
	}

	[Token(Token = "0x1700032D")]
	public static MouseType pushedMouseType
	{
		[Token(Token = "0x6001F5A")]
		[Address(RVA = "0x628A90", Offset = "0x627C90", VA = "0x180628A90")]
		get
		{
			return default(MouseType);
		}
	}

	[Token(Token = "0x1700032E")]
	public static MouseType onReleaseMouseType
	{
		[Token(Token = "0x6001F5B")]
		[Address(RVA = "0x628560", Offset = "0x627760", VA = "0x180628560")]
		get
		{
			return default(MouseType);
		}
	}

	[Token(Token = "0x1700032F")]
	public static AnalogType analogType
	{
		[Token(Token = "0x6001F5C")]
		[Address(RVA = "0x6277A0", Offset = "0x6269A0", VA = "0x1806277A0")]
		get
		{
			return default(AnalogType);
		}
	}

	[Token(Token = "0x17000330")]
	public static bool isGamePadInput
	{
		[Token(Token = "0x6001F5F")]
		[Address(RVA = "0x628040", Offset = "0x627240", VA = "0x180628040")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000331")]
	public static bool isPointingInput
	{
		[Token(Token = "0x6001F60")]
		[Address(RVA = "0x6280D0", Offset = "0x6272D0", VA = "0x1806280D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001F13")]
	[Address(RVA = "0x6200D0", Offset = "0x61F2D0", VA = "0x1806200D0")]
	private static SelectionItem GetCurrentItem()
	{
		return null;
	}

	[Token(Token = "0x6001F14")]
	[Address(RVA = "0x61FD50", Offset = "0x61EF50", VA = "0x18061FD50")]
	private static SelectorCluster GetCluster(int priority)
	{
		return null;
	}

	[Token(Token = "0x6001F15")]
	[Address(RVA = "0x61FF10", Offset = "0x61F110", VA = "0x18061FF10")]
	public static SelectorCluster GetCluster(SelectorGroup group)
	{
		return null;
	}

	[Token(Token = "0x6001F16")]
	[Address(RVA = "0x6206A0", Offset = "0x61F8A0", VA = "0x1806206A0")]
	public static int GetGroupPriority(SelectorGroup group)
	{
		return default(int);
	}

	[Token(Token = "0x6001F46")]
	[Address(RVA = "0x61E5F0", Offset = "0x61D7F0", VA = "0x18061E5F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001F47")]
	[Address(RVA = "0x61F830", Offset = "0x61EA30", VA = "0x18061F830")]
	public static SelectorManager Create(string name, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6001F48")]
	[Address(RVA = "0x61F6D0", Offset = "0x61E8D0", VA = "0x18061F6D0")]
	private static void CreateInstance()
	{
	}

	[Token(Token = "0x6001F49")]
	[Address(RVA = "0x61DC80", Offset = "0x61CE80", VA = "0x18061DC80")]
	public static SelectorGroup AddSelector(string group_label, Selector selector, int new_group_priority, out bool is_new_group)
	{
		return null;
	}

	[Token(Token = "0x6001F4A")]
	[Address(RVA = "0x622E80", Offset = "0x622080", VA = "0x180622E80")]
	public static void RemoveSelector(string group_label, Selector selector)
	{
	}

	[Token(Token = "0x6001F4B")]
	[Address(RVA = "0x61CF40", Offset = "0x61C140", VA = "0x18061CF40")]
	public static void ActivateClusterHighestPriority()
	{
	}

	[Token(Token = "0x6001F4C")]
	[Address(RVA = "0x6237B0", Offset = "0x6229B0", VA = "0x1806237B0")]
	private void SetCallbackManagerClusterPriority()
	{
	}

	[Token(Token = "0x6001F4D")]
	[Address(RVA = "0x620AC0", Offset = "0x61FCC0", VA = "0x180620AC0")]
	public static (int, SelectorCluster) GetHighestPriorityCluster(int maxPriority = -1, bool ignoreInputBlocker = false)
	{
		return default((int, SelectorCluster));
	}

	[Token(Token = "0x6001F4E")]
	[Address(RVA = "0x61ECC0", Offset = "0x61DEC0", VA = "0x18061ECC0")]
	public static void ChangeGroupPriority(SelectorGroup group, int priority)
	{
	}

	[Token(Token = "0x6001F4F")]
	[Address(RVA = "0x61FB90", Offset = "0x61ED90", VA = "0x18061FB90")]
	public static void DeselectItemActiveCluster()
	{
	}

	[Token(Token = "0x6001F50")]
	[Address(RVA = "0x61FA90", Offset = "0x61EC90", VA = "0x18061FA90")]
	public static void DeselectItemActiveCluster(SelectorCluster targetCluster)
	{
	}

	[Token(Token = "0x6001F51")]
	[Address(RVA = "0x620870", Offset = "0x61FA70", VA = "0x180620870")]
	public static SelectorCluster GetHigherActiveCluster(SelectorCluster targetCluster)
	{
		return null;
	}

	[Token(Token = "0x6001F52")]
	[Address(RVA = "0x6208E0", Offset = "0x61FAE0", VA = "0x1806208E0")]
	public static SelectorCluster GetHigherCluster(SelectorCluster targetCluster)
	{
		return null;
	}

	[Token(Token = "0x6001F53")]
	[Address(RVA = "0x625C80", Offset = "0x624E80", VA = "0x180625C80")]
	private void Update()
	{
	}

	[Token(Token = "0x6001F54")]
	[Address(RVA = "0x624890", Offset = "0x623A90", VA = "0x180624890")]
	private void UpdateInputInfo()
	{
	}

	[Token(Token = "0x6001F5D")]
	[Address(RVA = "0x623F20", Offset = "0x623120", VA = "0x180623F20")]
	private void UpdateCurrentKeyInfo()
	{
	}

	[Token(Token = "0x6001F5E")]
	[Address(RVA = "0x61EEE0", Offset = "0x61E0E0", VA = "0x18061EEE0")]
	private void ChangeInputDevice(InputDevice inputDevice)
	{
	}

	[Token(Token = "0x6001F61")]
	[Address(RVA = "0x6222E0", Offset = "0x6214E0", VA = "0x1806222E0")]
	public static void LockDeviceChange()
	{
	}

	[Token(Token = "0x6001F62")]
	[Address(RVA = "0x623E30", Offset = "0x623030", VA = "0x180623E30")]
	public static void UnlockDeviceChange()
	{
	}

	[Token(Token = "0x6001F63")]
	[Address(RVA = "0x6240E0", Offset = "0x6232E0", VA = "0x1806240E0")]
	private void UpdateDirectionInput(SelectorCluster target_cluster)
	{
	}

	[Token(Token = "0x6001F64")]
	[Address(RVA = "0x61F0D0", Offset = "0x61E2D0", VA = "0x18061F0D0")]
	public static bool ChangeSelectionItem(Vector2 position, Vector2 normalized_direction, SelectionItem baseItem)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F65")]
	[Address(RVA = "0x625BB0", Offset = "0x624DB0", VA = "0x180625BB0")]
	private void UpdateScreenInput(ScreenInputInfo current, SelectorCluster rootCluster, bool blockClick)
	{
	}

	[Token(Token = "0x6001F66")]
	[Address(RVA = "0x625040", Offset = "0x624240", VA = "0x180625040")]
	private void UpdateScreenInput(SelectorCluster target_cluster, bool blockClick, bool reset)
	{
	}

	[Token(Token = "0x6001F67")]
	[Address(RVA = "0x623420", Offset = "0x622620", VA = "0x180623420")]
	public static void ResetHold()
	{
	}

	[Token(Token = "0x6001F68")]
	[Address(RVA = "0x6233D0", Offset = "0x6225D0", VA = "0x1806233D0")]
	public static void RequestScreenInputUpdate()
	{
	}

	[Token(Token = "0x6001F69")]
	[Address(RVA = "0x621BF0", Offset = "0x620DF0", VA = "0x180621BF0")]
	private bool GetScreenInputInfo(ref ScreenInputInfo res)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F6A")]
	[Address(RVA = "0x621AE0", Offset = "0x620CE0", VA = "0x180621AE0")]
	private bool GetScreenInputInfoTouch(ref ScreenInputInfo res)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F6B")]
	[Address(RVA = "0x621890", Offset = "0x620A90", VA = "0x180621890")]
	private bool GetScreenInputInfoMouse(ref ScreenInputInfo res)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F6C")]
	[Address(RVA = "0x6220C0", Offset = "0x6212C0", VA = "0x1806220C0")]
	private bool IsOnScreen(Vector2 point)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F6D")]
	[Address(RVA = "0x621300", Offset = "0x620500", VA = "0x180621300")]
	public static KeyStatus GetKeyStatus(KeyType key_type)
	{
		return default(KeyStatus);
	}

	[Token(Token = "0x6001F6E")]
	[Address(RVA = "0x6213F0", Offset = "0x6205F0", VA = "0x1806213F0")]
	public static CombiKeyStatus GetKeyStatus(KeyType key_type_main, KeyType key_type_sub)
	{
		return default(CombiKeyStatus);
	}

	[Token(Token = "0x6001F6F")]
	[Address(RVA = "0x6212C0", Offset = "0x6204C0", VA = "0x1806212C0")]
	public static bool GetKeyStatusFlag(KeyStatus keyStatus, ref bool isReleased, ref bool isOnPush, ref bool isPushed, ref bool isOnRelease)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F70")]
	[Address(RVA = "0x61FC20", Offset = "0x61EE20", VA = "0x18061FC20")]
	public static Vector2 GetAnalogInput(AnalogType analog_type)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001F71")]
	[Address(RVA = "0x6217A0", Offset = "0x6209A0", VA = "0x1806217A0")]
	public static KeyStatus GetMouseStatus(MouseType mouse_type)
	{
		return default(KeyStatus);
	}

	[Token(Token = "0x6001F72")]
	[Address(RVA = "0x61E820", Offset = "0x61DA20", VA = "0x18061E820")]
	public static void BlockInput(int block_priority)
	{
	}

	[Token(Token = "0x6001F73")]
	[Address(RVA = "0x61F910", Offset = "0x61EB10", VA = "0x18061F910")]
	public static void DeblockInput(int block_priority)
	{
	}

	[Token(Token = "0x6001F74")]
	[Address(RVA = "0x61F410", Offset = "0x61E610", VA = "0x18061F410")]
	public static void ClearInputBlockCounter()
	{
	}

	[Token(Token = "0x6001F75")]
	[Address(RVA = "0x622420", Offset = "0x621620", VA = "0x180622420")]
	public static void Reboot()
	{
	}

	[Token(Token = "0x6001F76")]
	[Address(RVA = "0x6246F0", Offset = "0x6238F0", VA = "0x1806246F0")]
	private static void UpdateHighestInputBlockPriority()
	{
	}

	[Token(Token = "0x6001F77")]
	[Address(RVA = "0x61EA20", Offset = "0x61DC20", VA = "0x18061EA20")]
	public void BlockPadInput()
	{
	}

	[Token(Token = "0x6001F78")]
	[Address(RVA = "0x61FA80", Offset = "0x61EC80", VA = "0x18061FA80")]
	public void DeblockPadInput()
	{
	}

	[Token(Token = "0x6001F79")]
	[Address(RVA = "0x622140", Offset = "0x621340", VA = "0x180622140")]
	public static bool IsPadInputBlocked()
	{
		return default(bool);
	}

	[Token(Token = "0x6001F7A")]
	[Address(RVA = "0x61EA10", Offset = "0x61DC10", VA = "0x18061EA10")]
	public void BlockMouseButtonInput()
	{
	}

	[Token(Token = "0x6001F7B")]
	[Address(RVA = "0x61FA70", Offset = "0x61EC70", VA = "0x18061FA70")]
	public void DeblockMouseButtonInput()
	{
	}

	[Token(Token = "0x6001F7C")]
	[Address(RVA = "0x621EB0", Offset = "0x6210B0", VA = "0x180621EB0")]
	public static bool IsMouseButtonInputBlocked()
	{
		return default(bool);
	}

	[Token(Token = "0x6001F7D")]
	[Address(RVA = "0x623BE0", Offset = "0x622DE0", VA = "0x180623BE0")]
	public static void SetNoCountKeyInput(KeyType keyType, bool regist)
	{
	}

	[Token(Token = "0x6001F7E")]
	[Address(RVA = "0x621F80", Offset = "0x621180", VA = "0x180621F80")]
	public static bool IsNoCountKeyInput(KeyType keyType)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F7F")]
	[Address(RVA = "0x623990", Offset = "0x622B90", VA = "0x180623990")]
	public static void SetDirectionBlockKeyInput(KeyType keyType, bool regist)
	{
	}

	[Token(Token = "0x6001F80")]
	[Address(RVA = "0x621D70", Offset = "0x620F70", VA = "0x180621D70")]
	public static bool IsDirectionBlockKeyInput(KeyType keyType)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F81")]
	[Address(RVA = "0x621090", Offset = "0x620290", VA = "0x180621090")]
	public static SelectionItem GetItem(Vector2 view_position)
	{
		return null;
	}

	[Token(Token = "0x6001F82")]
	[Address(RVA = "0x621240", Offset = "0x620440", VA = "0x180621240")]
	public static SelectionItem GetItem(Vector2 view_position, int cluster_priority)
	{
		return null;
	}

	[Token(Token = "0x6001F83")]
	[Address(RVA = "0x620D50", Offset = "0x61FF50", VA = "0x180620D50")]
	public static void GetItemAll(Vector2 view_position, List<SelectionItem> hitItems, bool containNoneInteractable = false, bool withOrder = false)
	{
	}

	[Token(Token = "0x6001F84")]
	[Address(RVA = "0x61D7D0", Offset = "0x61C9D0", VA = "0x18061D7D0")]
	public static void AddProvisionalRegistedItem(SelectionItem item)
	{
	}

	[Token(Token = "0x6001F85")]
	[Address(RVA = "0x622710", Offset = "0x621910", VA = "0x180622710")]
	public static void RegistAllProvisionalRegistedItem()
	{
	}

	[Token(Token = "0x6001F86")]
	[Address(RVA = "0x61D970", Offset = "0x61CB70", VA = "0x18061D970")]
	public static void AddProvisionalSelectedItem(SelectionItem item)
	{
	}

	[Token(Token = "0x6001F87")]
	[Address(RVA = "0x623630", Offset = "0x622830", VA = "0x180623630")]
	public static void SelectAllProvisionalSelectedItem()
	{
	}

	[Token(Token = "0x6001F88")]
	[Address(RVA = "0x61D8A0", Offset = "0x61CAA0", VA = "0x18061D8A0")]
	public static void AddProvisionalRegistedSelector(Selector selector)
	{
	}

	[Token(Token = "0x6001F89")]
	[Address(RVA = "0x622890", Offset = "0x621A90", VA = "0x180622890")]
	public static void RegistAllProvisionalRegistedSelector()
	{
	}

	[Token(Token = "0x6001F8A")]
	[Address(RVA = "0x6205C0", Offset = "0x61F7C0", VA = "0x1806205C0")]
	public static int GetGamePadKeyConfig(KeyType key_type)
	{
		return default(int);
	}

	[Token(Token = "0x6001F8B")]
	[Address(RVA = "0x620470", Offset = "0x61F670", VA = "0x180620470")]
	public static (int, int) GetGamePadKeyConfig(AnalogType analog_type)
	{
		return default((int, int));
	}

	[Token(Token = "0x6001F8C")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020")]
	public static KeyCode[] GetKeyboardKeyConfig(KeyType key_type)
	{
		return null;
	}

	[Token(Token = "0x6001F8D")]
	[Address(RVA = "0x61E980", Offset = "0x61DB80", VA = "0x18061E980")]
	public static void BlockKeyboardPadKey(bool block)
	{
	}

	[Token(Token = "0x6001F8E")]
	[Address(RVA = "0x620390", Offset = "0x61F590", VA = "0x180620390")]
	public static int[] GetGamePadAnalogKeyConfig(AnalogType analog_type)
	{
		return null;
	}

	[Token(Token = "0x6001F8F")]
	[Address(RVA = "0x6216C0", Offset = "0x6208C0", VA = "0x1806216C0")]
	public static int GetMouseKeyConfig(MouseType mouse_type)
	{
		return default(int);
	}

	[Token(Token = "0x6001F90")]
	[Address(RVA = "0x620280", Offset = "0x61F480", VA = "0x180620280")]
	public static Vector2 GetCurrentScreenPoint()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001F91")]
	[Address(RVA = "0x622210", Offset = "0x621410", VA = "0x180622210")]
	public static bool IsScreenInputActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6001F92")]
	[Address(RVA = "0x61D770", Offset = "0x61C970", VA = "0x18061D770")]
	public static void AddClusterGoThroughCounter(int clusterPriority)
	{
	}

	[Token(Token = "0x6001F93")]
	[Address(RVA = "0x622B30", Offset = "0x621D30", VA = "0x180622B30")]
	public static void RemoveClusterGoThroughCounter(int clusterPriority)
	{
	}

	[Token(Token = "0x6001F94")]
	[Address(RVA = "0x61CE30", Offset = "0x61C030", VA = "0x18061CE30")]
	private static SelectorCluster ActionForHighestPriorityCluster(ClusterFunc callback)
	{
		return null;
	}

	[Token(Token = "0x6001F95")]
	[Address(RVA = "0x61EA30", Offset = "0x61DC30", VA = "0x18061EA30")]
	public static KeyType ButtonTypeToKeyType(int buttonType)
	{
		return default(KeyType);
	}

	[Token(Token = "0x6001F96")]
	[Address(RVA = "0x61DA40", Offset = "0x61CC40", VA = "0x18061DA40")]
	public static uint AddSelectedCallback(SelectionItem item, KeyStatus status, KeyType main, KeyType sub, MouseType mouse, AnalogType analog, Func<bool> callback)
	{
		return default(uint);
	}

	[Token(Token = "0x6001F97")]
	[Address(RVA = "0x622D00", Offset = "0x621F00", VA = "0x180622D00")]
	public static List<uint> RemoveSelectedCallback(SelectionItem item, KeyStatus status, KeyType main, KeyType sub, MouseType mouse, AnalogType analog, Func<bool> callback)
	{
		return null;
	}

	[Token(Token = "0x6001F98")]
	[Address(RVA = "0x622B90", Offset = "0x621D90", VA = "0x180622B90")]
	public static List<uint> RemoveSelectedCallback(SelectionItem item, KeyStatus status, KeyType main, KeyType sub, MouseType mouse, AnalogType analog)
	{
		return null;
	}

	[Token(Token = "0x6001F99")]
	[Address(RVA = "0x61F490", Offset = "0x61E690", VA = "0x18061F490")]
	public static List<uint> ClearSelectedCallback(SelectionItem item)
	{
		return null;
	}

	[Token(Token = "0x6001F9A")]
	[Address(RVA = "0x622A10", Offset = "0x621C10", VA = "0x180622A10")]
	public static List<uint> RemoveCallback(uint id)
	{
		return null;
	}

	[Token(Token = "0x6001F9B")]
	[Address(RVA = "0x61E380", Offset = "0x61D580", VA = "0x18061E380")]
	public static uint AddShortcutCallback(SelectionItem item, KeyStatus status, KeyType main, KeyType sub, MouseType mouse, AnalogType analog, Func<bool> callback, bool highPriority = false)
	{
		return default(uint);
	}

	[Token(Token = "0x6001F9C")]
	[Address(RVA = "0x623250", Offset = "0x622450", VA = "0x180623250")]
	public static List<uint> RemoveShortcutCallback(SelectionItem item, KeyStatus status, KeyType main, KeyType sub, MouseType mouse, AnalogType analog, Func<bool> callback)
	{
		return null;
	}

	[Token(Token = "0x6001F9D")]
	[Address(RVA = "0x6230E0", Offset = "0x6222E0", VA = "0x1806230E0")]
	public static List<uint> RemoveShortcutCallback(SelectionItem item, KeyStatus status, KeyType main, KeyType sub, MouseType mouse, AnalogType analog)
	{
		return null;
	}

	[Token(Token = "0x6001F9E")]
	[Address(RVA = "0x61F5B0", Offset = "0x61E7B0", VA = "0x18061F5B0")]
	public static List<uint> ClearShortcutCallback(SelectionItem item)
	{
		return null;
	}

	[Token(Token = "0x6001F9F")]
	[Address(RVA = "0x61E1F0", Offset = "0x61D3F0", VA = "0x18061E1F0")]
	public static uint AddShortcutCallback(int priority, KeyStatus status, KeyType main, KeyType sub, MouseType mouse, AnalogType analog, Func<bool> callback, bool highPriority = false)
	{
		return default(uint);
	}

	[Token(Token = "0x6001FA0")]
	[Address(RVA = "0x6275E0", Offset = "0x6267E0", VA = "0x1806275E0")]
	public SelectorManager()
	{
	}
}
