using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem;

[Token(Token = "0x2000170")]
public abstract class GamePad
{
	[Token(Token = "0x2000171")]
	public enum VIBRATION
	{
		[Token(Token = "0x40008DB")]
		NONE,
		[Token(Token = "0x40008DC")]
		SYS_RESPONSE,
		[Token(Token = "0x40008DD")]
		DUEL_MONSTER_CUTIN,
		[Token(Token = "0x40008DE")]
		DUEL_MONSTER_LAND_MID,
		[Token(Token = "0x40008DF")]
		DUEL_MONSTER_LAND_HIGH,
		[Token(Token = "0x40008E0")]
		DUEL_CARD_BREAK,
		[Token(Token = "0x40008E1")]
		DUEL_ATTACK_LOW,
		[Token(Token = "0x40008E2")]
		DUEL_ATTACK_HIGH,
		[Token(Token = "0x40008E3")]
		DUEL_EFFECT_DAMAGE,
		[Token(Token = "0x40008E4")]
		DUEL_BG_BREAK,
		[Token(Token = "0x40008E5")]
		DUEL_FINISHBLOW
	}

	[Token(Token = "0x40008B7")]
	public const int GAMEPAD_01 = 1;

	[Token(Token = "0x40008B8")]
	public const int GAMEPAD_02 = 2;

	[Token(Token = "0x40008B9")]
	public const int GAMEPAD_03 = 3;

	[Token(Token = "0x40008BA")]
	public const int GAMEPAD_04 = 4;

	[Token(Token = "0x40008BB")]
	[FieldOffset(Offset = "0x0")]
	public static readonly int PAD_MAX_NUM;

	[Token(Token = "0x40008BC")]
	public const int BUTTON_INVALID = -1;

	[Token(Token = "0x40008BD")]
	public const int BUTTON_RLEFT = 0;

	[Token(Token = "0x40008BE")]
	public const int BUTTON_RDOWN = 1;

	[Token(Token = "0x40008BF")]
	public const int BUTTON_RRIGHT = 2;

	[Token(Token = "0x40008C0")]
	public const int BUTTON_RUP = 3;

	[Token(Token = "0x40008C1")]
	public const int BUTTON_L1 = 4;

	[Token(Token = "0x40008C2")]
	public const int BUTTON_R1 = 5;

	[Token(Token = "0x40008C3")]
	public const int BUTTON_L2 = 6;

	[Token(Token = "0x40008C4")]
	public const int BUTTON_R2 = 7;

	[Token(Token = "0x40008C5")]
	public const int BUTTON_OPTION1 = 9;

	[Token(Token = "0x40008C6")]
	public const int BUTTON_L3 = 10;

	[Token(Token = "0x40008C7")]
	public const int BUTTON_R3 = 11;

	[Token(Token = "0x40008C8")]
	public const int BUTTON_OPTION2 = 13;

	[Token(Token = "0x40008C9")]
	public const int BUTTON_UP = 100;

	[Token(Token = "0x40008CA")]
	public const int BUTTON_RIGHT = 101;

	[Token(Token = "0x40008CB")]
	public const int BUTTON_DOWN = 102;

	[Token(Token = "0x40008CC")]
	public const int BUTTON_LEFT = 103;

	[Token(Token = "0x40008CD")]
	public const int ANALOG_L_X = 200;

	[Token(Token = "0x40008CE")]
	public const int ANALOG_L_Y = 201;

	[Token(Token = "0x40008CF")]
	public const int ANALOG_R_X = 202;

	[Token(Token = "0x40008D0")]
	public const int ANALOG_R_Y = 203;

	[Token(Token = "0x40008D1")]
	public const int ANALOG_L2 = 204;

	[Token(Token = "0x40008D2")]
	public const int ANALOG_R2 = 205;

	[Token(Token = "0x40008D3")]
	public const int BUTTON_FUNC_base = 1000;

	[Token(Token = "0x40008D4")]
	public const int BUTTON_FUNC_DECISION = 1001;

	[Token(Token = "0x40008D5")]
	public const int BUTTON_FUNC_CANCEL = 1002;

	[Token(Token = "0x40008D6")]
	public const int BUTTON_FUNC_end = 1003;

	[Token(Token = "0x40008D7")]
	[FieldOffset(Offset = "0x8")]
	private static GamePad[] g_GamePadArray;

	[Token(Token = "0x40008D8")]
	[FieldOffset(Offset = "0x10")]
	private static GamePadUpdater g_GamePadUpdater;

	[Token(Token = "0x40008D9")]
	[FieldOffset(Offset = "0x10")]
	protected int m_iPadID;

	[Token(Token = "0x170000FC")]
	public static GamePadUpdater GamePadUpdater
	{
		[Token(Token = "0x600094C")]
		[Address(RVA = "0xAF79D0", Offset = "0xAF6BD0", VA = "0x180AF79D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000FD")]
	public static GamePad[] GamePadArray
	{
		[Token(Token = "0x600094D")]
		[Address(RVA = "0xAF7980", Offset = "0xAF6B80", VA = "0x180AF7980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000FE")]
	public static int gamePadMaxNum
	{
		[Token(Token = "0x600094E")]
		[Address(RVA = "0xAF7A80", Offset = "0xAF6C80", VA = "0x180AF7A80")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000FF")]
	public static int UsingPadId
	{
		[Token(Token = "0x600094F")]
		[Address(RVA = "0xAF7A20", Offset = "0xAF6C20", VA = "0x180AF7A20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000100")]
	public int PadID
	{
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000948")]
	[Address(RVA = "0xAF4CE0", Offset = "0xAF3EE0", VA = "0x180AF4CE0")]
	public static bool IsFuncButton(int Type)
	{
		return default(bool);
	}

	[Token(Token = "0x6000949")]
	[Address(RVA = "0xAF4800", Offset = "0xAF3A00", VA = "0x180AF4800")]
	public static GamePad GetGamePad(int iPadID = 1)
	{
		return null;
	}

	[Token(Token = "0x600094A")]
	[Address(RVA = "0xAF46D0", Offset = "0xAF38D0", VA = "0x180AF46D0")]
	public static GamePad FindGamePad(int padId)
	{
		return null;
	}

	[Token(Token = "0x600094B")]
	[Address(RVA = "0xAF4A30", Offset = "0xAF3C30", VA = "0x180AF4A30")]
	public static void InitializeGamePadSystem(GameObject residentObject)
	{
	}

	[Token(Token = "0x6000950")]
	protected abstract int resolveFuncButton(int Type);

	[Token(Token = "0x6000951")]
	[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
	public GamePad(int iPadID)
	{
	}

	[Token(Token = "0x6000952")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	public virtual void UpdateFrame()
	{
	}

	[Token(Token = "0x6000954")]
	public abstract bool GetKey(int Type);

	[Token(Token = "0x6000955")]
	public abstract bool GetKeyDown(int Type);

	[Token(Token = "0x6000956")]
	public abstract float GetAnalog(int Type);

	[Token(Token = "0x6000957")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "9")]
	public virtual void Vibrate(VIBRATION Id)
	{
	}

	[Token(Token = "0x6000958")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "10")]
	public virtual void StopVibration()
	{
	}

	[Token(Token = "0x6000959")]
	[Address(RVA = "0xAF49B0", Offset = "0xAF3BB0", VA = "0x180AF49B0")]
	public int GetPhysicalKey(int Type)
	{
		return default(int);
	}

	[Token(Token = "0x600095A")]
	[Address(RVA = "0xAF4790", Offset = "0xAF3990", VA = "0x180AF4790")]
	public int GetFunctionalKey(int Type)
	{
		return default(int);
	}
}
