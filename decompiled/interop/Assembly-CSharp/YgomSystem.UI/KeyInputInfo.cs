using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x200047A")]
public class KeyInputInfo
{
	[Token(Token = "0x40015E5")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<SelectorManager.KeyType, SelectorManager.KeyStatus> keyStatus;

	[Token(Token = "0x40015E6")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<SelectorManager.AnalogType, Vector2> analogInput;

	[Token(Token = "0x40015E7")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<SelectorManager.MouseType, SelectorManager.KeyStatus> mouseStatus;

	[Token(Token = "0x40015E8")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 screenPoint;

	[Token(Token = "0x40015E9")]
	[FieldOffset(Offset = "0x30")]
	private Vector2 screenPointDelta;

	[Token(Token = "0x40015EA")]
	[FieldOffset(Offset = "0x38")]
	private bool onScreen;

	[Token(Token = "0x40015ED")]
	[FieldOffset(Offset = "0x44")]
	private float padInputContinueTime;

	[Token(Token = "0x40015EE")]
	[FieldOffset(Offset = "0x48")]
	private SelectorManager.KeyType currentDirection;

	[Token(Token = "0x40015EF")]
	[FieldOffset(Offset = "0x50")]
	private SelectorManager.KeyType[] keyPrioriority;

	[Token(Token = "0x40015F0")]
	[FieldOffset(Offset = "0x58")]
	private SelectorManager.MouseType[] mousePriority;

	[Token(Token = "0x40015F1")]
	[FieldOffset(Offset = "0x60")]
	private SelectorManager.AnalogType[] analogPriority;

	[Token(Token = "0x170002D2")]
	public int onKeyCount
	{
		[Token(Token = "0x6001CDE")]
		[Address(RVA = "0x5EA1B0", Offset = "0x5E93B0", VA = "0x1805EA1B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001CDF")]
		[Address(RVA = "0x600F80", Offset = "0x600180", VA = "0x180600F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170002D3")]
	public int directionBlockerCount
	{
		[Token(Token = "0x6001CE0")]
		[Address(RVA = "0x5FA7B0", Offset = "0x5F99B0", VA = "0x1805FA7B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001CE1")]
		[Address(RVA = "0x409CD0", Offset = "0x408ED0", VA = "0x180409CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170002D4")]
	public static float padInputRepeatStartTime
	{
		[Token(Token = "0x6001CE2")]
		[Address(RVA = "0x600F40", Offset = "0x600140", VA = "0x180600F40")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002D5")]
	public static float padInputRepeatIntervalTime
	{
		[Token(Token = "0x6001CE3")]
		[Address(RVA = "0x600F00", Offset = "0x600100", VA = "0x180600F00")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6001CE4")]
	[Address(RVA = "0x5FF940", Offset = "0x5FEB40", VA = "0x1805FF940")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6001CE5")]
	[Address(RVA = "0x5FFDB0", Offset = "0x5FEFB0", VA = "0x1805FFDB0")]
	public void ResetInputInfo()
	{
	}

	[Token(Token = "0x6001CE6")]
	[Address(RVA = "0x600840", Offset = "0x5FFA40", VA = "0x180600840")]
	public bool UpdatePadKeyInputInfo(GamePad pad)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CE7")]
	[Address(RVA = "0x600B60", Offset = "0x5FFD60", VA = "0x180600B60")]
	private int UpdatePadKeyInputInfo(GamePad pad, SelectorManager.KeyType keyType, ref bool isReleased, ref bool isOnPush, ref bool isPushed, ref bool isOnRelease)
	{
		return default(int);
	}

	[Token(Token = "0x6001CE8")]
	[Address(RVA = "0x5FFDC0", Offset = "0x5FEFC0", VA = "0x1805FFDC0")]
	public bool UpdateAnalogInput(GamePad pad)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CE9")]
	[Address(RVA = "0x600420", Offset = "0x5FF620", VA = "0x180600420")]
	public bool UpdatePadDirectionalInputInfo(GamePad pad)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CEA")]
	[Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420")]
	private int GetGamePadKeyConfig(SelectorManager.KeyType keyType)
	{
		return default(int);
	}

	[Token(Token = "0x6001CEB")]
	[Address(RVA = "0x5FF470", Offset = "0x5FE670", VA = "0x1805FF470")]
	public static (int, int) GetGamePadKeyConfig(SelectorManager.AnalogType analogType)
	{
		return default((int, int));
	}

	[Token(Token = "0x6001CEC")]
	[Address(RVA = "0x5FF730", Offset = "0x5FE930", VA = "0x1805FF730")]
	private KeyCode[] GetKeyboardKeyConfig(SelectorManager.KeyType keyType)
	{
		return null;
	}

	[Token(Token = "0x6001CED")]
	[Address(RVA = "0x5FF5F0", Offset = "0x5FE7F0", VA = "0x1805FF5F0")]
	private static bool GetKey(GamePad pad, int gamepad_key_id, KeyCode[] key_code)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CEE")]
	[Address(RVA = "0x600040", Offset = "0x5FF240", VA = "0x180600040")]
	public bool UpdateBackkeyInputInfo(bool on_back_key)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CEF")]
	[Address(RVA = "0x600080", Offset = "0x5FF280", VA = "0x180600080")]
	private SelectorManager.KeyStatus UpdateKeyStatus(SelectorManager.KeyType key_type, bool on_key)
	{
		return default(SelectorManager.KeyStatus);
	}

	[Token(Token = "0x6001CF0")]
	[Address(RVA = "0x5FFF70", Offset = "0x5FF170", VA = "0x1805FFF70")]
	private bool UpdateAnalogInput(SelectorManager.AnalogType type, Vector2 input)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CF1")]
	[Address(RVA = "0x600180", Offset = "0x5FF380", VA = "0x180600180")]
	public bool UpdateMouseInputInfo(bool on_left, bool on_right, bool on_center, float wheel, Vector2 screenPoint, bool onScreen)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CF2")]
	[Address(RVA = "0x600310", Offset = "0x5FF510", VA = "0x180600310")]
	private bool UpdateMouseStatus(SelectorManager.MouseType mouse_type, bool on_key)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CF3")]
	[Address(RVA = "0x5FF4C0", Offset = "0x5FE6C0", VA = "0x1805FF4C0")]
	public SelectorManager.KeyStatus GetKeyStatus(SelectorManager.KeyType key_type)
	{
		return default(SelectorManager.KeyStatus);
	}

	[Token(Token = "0x6001CF4")]
	[Address(RVA = "0x5FF2D0", Offset = "0x5FE4D0", VA = "0x1805FF2D0")]
	public Vector2 GetAnalogInput(SelectorManager.AnalogType analog_type)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001CF5")]
	[Address(RVA = "0x5FF780", Offset = "0x5FE980", VA = "0x1805FF780")]
	public SelectorManager.KeyStatus GetMouseStatus(SelectorManager.MouseType mouse_type)
	{
		return default(SelectorManager.KeyStatus);
	}

	[Token(Token = "0x6001CF6")]
	[Address(RVA = "0x5FF8B0", Offset = "0x5FEAB0", VA = "0x1805FF8B0")]
	public (bool, Vector2, Vector2) GetScreenPoint()
	{
		return default((bool, Vector2, Vector2));
	}

	[Token(Token = "0x6001CF7")]
	[Address(RVA = "0x5FF520", Offset = "0x5FE720", VA = "0x1805FF520")]
	public SelectorManager.KeyType GetKeyType(SelectorManager.KeyStatus status)
	{
		return default(SelectorManager.KeyType);
	}

	[Token(Token = "0x6001CF8")]
	[Address(RVA = "0x5FF7E0", Offset = "0x5FE9E0", VA = "0x1805FF7E0")]
	public SelectorManager.MouseType GetMouseType(SelectorManager.KeyStatus status)
	{
		return default(SelectorManager.MouseType);
	}

	[Token(Token = "0x6001CF9")]
	[Address(RVA = "0x5FF330", Offset = "0x5FE530", VA = "0x1805FF330")]
	public SelectorManager.AnalogType GetAnalogType()
	{
		return default(SelectorManager.AnalogType);
	}

	[Token(Token = "0x6001CFA")]
	[Address(RVA = "0x600DF0", Offset = "0x5FFFF0", VA = "0x180600DF0")]
	public KeyInputInfo()
	{
	}
}
