using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000212")]
public class NavigationMoveEvent : NavigationEventBase<NavigationMoveEvent>
{
	[Token(Token = "0x2000213")]
	public enum Direction
	{
		[Token(Token = "0x400089F")]
		None,
		[Token(Token = "0x40008A0")]
		Left,
		[Token(Token = "0x40008A1")]
		Up,
		[Token(Token = "0x40008A2")]
		Right,
		[Token(Token = "0x40008A3")]
		Down,
		[Token(Token = "0x40008A4")]
		Next,
		[Token(Token = "0x40008A5")]
		Previous
	}

	[Token(Token = "0x17000299")]
	public Direction direction
	{
		[Token(Token = "0x6000EAE")]
		[Address(RVA = "0x803CC0", Offset = "0x802EC0", VA = "0x180803CC0")]
		[CompilerGenerated]
		get
		{
			return default(Direction);
		}
		[Token(Token = "0x6000EAF")]
		[Address(RVA = "0x99DB50", Offset = "0x99CD50", VA = "0x18099DB50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700029A")]
	private Vector2 move
	{
		[Token(Token = "0x6000EB0")]
		[Address(RVA = "0x12C3F40", Offset = "0x12C3140", VA = "0x1812C3F40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000EAC")]
	[Address(RVA = "0x2B20550", Offset = "0x2B1F750", VA = "0x182B20550")]
	static NavigationMoveEvent()
	{
	}

	[Token(Token = "0x6000EAD")]
	[Address(RVA = "0x2B1FFF0", Offset = "0x2B1F1F0", VA = "0x182B1FFF0")]
	internal static Direction DetermineMoveDirection(float x, float y, float deadZone = 0.6f)
	{
		return default(Direction);
	}

	[Token(Token = "0x6000EB1")]
	[Address(RVA = "0x2B202C0", Offset = "0x2B1F4C0", VA = "0x182B202C0")]
	public static NavigationMoveEvent GetPooled(Vector2 moveVector, EventModifiers modifiers = EventModifiers.None)
	{
		return null;
	}

	[Token(Token = "0x6000EB2")]
	[Address(RVA = "0x2B201C0", Offset = "0x2B1F3C0", VA = "0x182B201C0")]
	internal static NavigationMoveEvent GetPooled(Vector2 moveVector, NavigationDeviceType deviceType, EventModifiers modifiers = EventModifiers.None)
	{
		return null;
	}

	[Token(Token = "0x6000EB3")]
	[Address(RVA = "0x2B20070", Offset = "0x2B1F270", VA = "0x182B20070")]
	public static NavigationMoveEvent GetPooled(Direction direction, EventModifiers modifiers = EventModifiers.None)
	{
		return null;
	}

	[Token(Token = "0x6000EB4")]
	[Address(RVA = "0x2B20110", Offset = "0x2B1F310", VA = "0x182B20110")]
	internal static NavigationMoveEvent GetPooled(Direction direction, NavigationDeviceType deviceType, EventModifiers modifiers = EventModifiers.None)
	{
		return null;
	}

	[Token(Token = "0x6000EB5")]
	[Address(RVA = "0x2B203B0", Offset = "0x2B1F5B0", VA = "0x182B203B0", Slot = "13")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000EB6")]
	[Address(RVA = "0x2B20630", Offset = "0x2B1F830", VA = "0x182B20630")]
	public NavigationMoveEvent()
	{
	}

	[Token(Token = "0x6000EB7")]
	[Address(RVA = "0x2B20430", Offset = "0x2B1F630", VA = "0x182B20430")]
	private void LocalInit()
	{
	}

	[Token(Token = "0x6000EB8")]
	[Address(RVA = "0x2B20490", Offset = "0x2B1F690", VA = "0x182B20490", Slot = "9")]
	protected internal override void PostDispatch(IPanel panel)
	{
	}
}
