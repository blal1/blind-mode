using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200021E")]
internal static class PointerDeviceState
{
	[Token(Token = "0x200021F")]
	[Flags]
	internal enum LocationFlag
	{
		[Token(Token = "0x40008B1")]
		None = 0,
		[Token(Token = "0x40008B2")]
		OutsidePanel = 1
	}

	[Token(Token = "0x2000220")]
	private struct PointerLocation
	{
		[Token(Token = "0x1700029D")]
		internal Vector2 Position
		{
			[Token(Token = "0x6000EE6")]
			[Address(RVA = "0x243F220", Offset = "0x243E420", VA = "0x18243F220")]
			[CompilerGenerated]
			readonly get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000EE7")]
			[Address(RVA = "0xF789F0", Offset = "0xF77BF0", VA = "0x180F789F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700029E")]
		internal IPanel Panel
		{
			[Token(Token = "0x6000EE8")]
			[Address(RVA = "0x5BF750", Offset = "0x5BE950", VA = "0x1805BF750")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000EE9")]
			[Address(RVA = "0x5BF770", Offset = "0x5BE970", VA = "0x1805BF770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700029F")]
		internal LocationFlag Flags
		{
			[Token(Token = "0x6000EEA")]
			[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
			[CompilerGenerated]
			readonly get
			{
				return default(LocationFlag);
			}
			[Token(Token = "0x6000EEB")]
			[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000EEC")]
		[Address(RVA = "0x2B21E90", Offset = "0x2B21090", VA = "0x182B21E90")]
		internal void SetLocation(Vector2 position, IPanel panel)
		{
		}
	}

	[Token(Token = "0x40008AD")]
	[FieldOffset(Offset = "0x0")]
	private static PointerLocation[] s_PlayerPointerLocations;

	[Token(Token = "0x40008AE")]
	[FieldOffset(Offset = "0x8")]
	private static int[] s_PressedButtons;

	[Token(Token = "0x40008AF")]
	[FieldOffset(Offset = "0x10")]
	private static readonly IPanel[] s_PlayerPanelWithSoftPointerCapture;

	[Token(Token = "0x6000ED8")]
	[Address(RVA = "0x2B21050", Offset = "0x2B20250", VA = "0x182B21050")]
	internal static void RemovePanelData(IPanel panel)
	{
	}

	[Token(Token = "0x6000ED9")]
	[Address(RVA = "0x2B21270", Offset = "0x2B20470", VA = "0x182B21270")]
	public static void SavePointerPosition(int pointerId, Vector2 position, IPanel panel, ContextType contextType)
	{
	}

	[Token(Token = "0x6000EDA")]
	[Address(RVA = "0x2B20DF0", Offset = "0x2B1FFF0", VA = "0x182B20DF0")]
	public static void PressButton(int pointerId, int buttonId)
	{
	}

	[Token(Token = "0x6000EDB")]
	[Address(RVA = "0x2B20F60", Offset = "0x2B20160", VA = "0x182B20F60")]
	public static void ReleaseButton(int pointerId, int buttonId)
	{
	}

	[Token(Token = "0x6000EDC")]
	[Address(RVA = "0x2B20EE0", Offset = "0x2B200E0", VA = "0x182B20EE0")]
	public static void ReleaseAllButtons(int pointerId)
	{
	}

	[Token(Token = "0x6000EDD")]
	[Address(RVA = "0x2B20BC0", Offset = "0x2B1FDC0", VA = "0x182B20BC0")]
	public static Vector2 GetPointerPosition(int pointerId, ContextType contextType)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000EDE")]
	[Address(RVA = "0x2B20AD0", Offset = "0x2B1FCD0", VA = "0x182B20AD0")]
	public static IPanel GetPanel(int pointerId, ContextType contextType)
	{
		return null;
	}

	[Token(Token = "0x6000EDF")]
	[Address(RVA = "0x2B20D50", Offset = "0x2B1FF50", VA = "0x182B20D50")]
	private static bool HasFlagFast(LocationFlag flagSet, LocationFlag flag)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EE0")]
	[Address(RVA = "0x2B20D60", Offset = "0x2B1FF60", VA = "0x182B20D60")]
	public static bool HasLocationFlag(int pointerId, ContextType contextType, LocationFlag flag)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EE1")]
	[Address(RVA = "0x2B20C50", Offset = "0x2B1FE50", VA = "0x182B20C50")]
	public static int GetPressedButtons(int pointerId)
	{
		return default(int);
	}

	[Token(Token = "0x6000EE2")]
	[Address(RVA = "0x2B20CC0", Offset = "0x2B1FEC0", VA = "0x182B20CC0")]
	internal static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EE3")]
	[Address(RVA = "0x2B21320", Offset = "0x2B20520", VA = "0x182B21320")]
	internal static void SetPlayerPanelWithSoftPointerCapture(int pointerId, IPanel panel)
	{
	}

	[Token(Token = "0x6000EE4")]
	[Address(RVA = "0x2B20B50", Offset = "0x2B1FD50", VA = "0x182B20B50")]
	internal static IPanel GetPlayerPanelWithSoftPointerCapture(int pointerId)
	{
		return null;
	}
}
