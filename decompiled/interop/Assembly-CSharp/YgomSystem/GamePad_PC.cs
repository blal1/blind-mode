using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

namespace YgomSystem;

[Token(Token = "0x2000173")]
public class GamePad_PC : GamePad
{
	[Token(Token = "0x2000174")]
	public class VibrationSetting
	{
		[Token(Token = "0x40008F1")]
		[FieldOffset(Offset = "0x10")]
		public float lowFrequency;

		[Token(Token = "0x40008F2")]
		[FieldOffset(Offset = "0x14")]
		public float highFrequency;

		[Token(Token = "0x40008F3")]
		[FieldOffset(Offset = "0x18")]
		public float time;

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x718EA0", Offset = "0x7180A0", VA = "0x180718EA0")]
		public VibrationSetting(float l, float h, float t)
		{
		}
	}

	[Token(Token = "0x2000175")]
	protected class ButtonInputState
	{
		[Token(Token = "0x40008F4")]
		[FieldOffset(Offset = "0x10")]
		public int type;

		[Token(Token = "0x40008F5")]
		[FieldOffset(Offset = "0x18")]
		public ButtonControl buttonControl;

		[Token(Token = "0x40008F6")]
		[FieldOffset(Offset = "0x20")]
		public bool nowOn;

		[Token(Token = "0x40008F7")]
		[FieldOffset(Offset = "0x21")]
		public bool prevOn;

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ButtonInputState()
		{
		}
	}

	[Token(Token = "0x40008E8")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<VIBRATION, List<VibrationSetting>> vibrationSettings;

	[Token(Token = "0x40008E9")]
	[FieldOffset(Offset = "0x20")]
	private List<VibrationSetting> vibrationList;

	[Token(Token = "0x40008EA")]
	[FieldOffset(Offset = "0x28")]
	private float vibrationTime;

	[Token(Token = "0x40008EB")]
	[FieldOffset(Offset = "0x2C")]
	private int vibrationIdx;

	[Token(Token = "0x40008EC")]
	[FieldOffset(Offset = "0x0")]
	protected static readonly int[] buttonTypes;

	[Token(Token = "0x40008ED")]
	[FieldOffset(Offset = "0x30")]
	protected Dictionary<int, ButtonInputState> buttonInputStates;

	[Token(Token = "0x40008EE")]
	[FieldOffset(Offset = "0x38")]
	protected Gamepad currentPad;

	[Token(Token = "0x40008EF")]
	[FieldOffset(Offset = "0x40")]
	protected Dictionary<int, AxisControl> analogAxisControls;

	[Token(Token = "0x40008F0")]
	[FieldOffset(Offset = "0x48")]
	private bool _isAxisNotFoundErrorOccured;

	[Token(Token = "0x17000102")]
	protected string axisNotFoundError
	{
		[Token(Token = "0x6000965")]
		[Address(RVA = "0xAF78C0", Offset = "0xAF6AC0", VA = "0x180AF78C0")]
		set
		{
		}
	}

	[Token(Token = "0x6000964")]
	[Address(RVA = "0xAF4F60", Offset = "0xAF4160", VA = "0x180AF4F60")]
	public static void InitializePCGamePadSystem()
	{
	}

	[Token(Token = "0x6000966")]
	[Address(RVA = "0xAF7680", Offset = "0xAF6880", VA = "0x180AF7680")]
	private bool getKeyOn(int Type)
	{
		return default(bool);
	}

	[Token(Token = "0x6000967")]
	[Address(RVA = "0xAF7610", Offset = "0xAF6810", VA = "0x180AF7610")]
	public GamePad_PC(int iPadID)
	{
	}

	[Token(Token = "0x6000968")]
	[Address(RVA = "0xAF5080", Offset = "0xAF4280", VA = "0x180AF5080")]
	protected void SetupButtonsAndAxes()
	{
	}

	[Token(Token = "0x6000969")]
	[Address(RVA = "0xAF52E0", Offset = "0xAF44E0", VA = "0x180AF52E0")]
	protected void SetupVibrations()
	{
	}

	[Token(Token = "0x600096A")]
	[Address(RVA = "0xAF6A50", Offset = "0xAF5C50", VA = "0x180AF6A50", Slot = "5")]
	public override void UpdateFrame()
	{
	}

	[Token(Token = "0x600096B")]
	[Address(RVA = "0xAF4EC0", Offset = "0xAF40C0", VA = "0x180AF4EC0", Slot = "6")]
	public override bool GetKey(int Type)
	{
		return default(bool);
	}

	[Token(Token = "0x600096C")]
	[Address(RVA = "0xAF4E10", Offset = "0xAF4010", VA = "0x180AF4E10", Slot = "7")]
	public override bool GetKeyDown(int Type)
	{
		return default(bool);
	}

	[Token(Token = "0x600096D")]
	[Address(RVA = "0xAF4D00", Offset = "0xAF3F00", VA = "0x180AF4D00", Slot = "8")]
	public override float GetAnalog(int Type)
	{
		return default(float);
	}

	[Token(Token = "0x600096E")]
	[Address(RVA = "0xAF74D0", Offset = "0xAF66D0", VA = "0x180AF74D0", Slot = "9")]
	public override void Vibrate(VIBRATION Id)
	{
	}

	[Token(Token = "0x600096F")]
	[Address(RVA = "0xAF69E0", Offset = "0xAF5BE0", VA = "0x180AF69E0", Slot = "10")]
	public override void StopVibration()
	{
	}

	[Token(Token = "0x6000970")]
	[Address(RVA = "0xAF7290", Offset = "0xAF6490", VA = "0x180AF7290")]
	private void UpdateVibration()
	{
	}

	[Token(Token = "0x6000971")]
	[Address(RVA = "0xAF78A0", Offset = "0xAF6AA0", VA = "0x180AF78A0", Slot = "4")]
	protected override int resolveFuncButton(int Type)
	{
		return default(int);
	}

	[Token(Token = "0x6000972")]
	[Address(RVA = "0xAF7400", Offset = "0xAF6600", VA = "0x180AF7400")]
	[Conditional("YGO_DEBUG")]
	protected void VerifyBtnMapping()
	{
	}
}
