using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000223")]
public interface IPointerEvent
{
	[Token(Token = "0x170002A0")]
	int pointerId
	{
		[Token(Token = "0x6000EF1")]
		get;
	}

	[Token(Token = "0x170002A1")]
	string pointerType
	{
		[Token(Token = "0x6000EF2")]
		get;
	}

	[Token(Token = "0x170002A2")]
	bool isPrimary
	{
		[Token(Token = "0x6000EF3")]
		get;
	}

	[Token(Token = "0x170002A3")]
	int button
	{
		[Token(Token = "0x6000EF4")]
		get;
	}

	[Token(Token = "0x170002A4")]
	int pressedButtons
	{
		[Token(Token = "0x6000EF5")]
		get;
	}

	[Token(Token = "0x170002A5")]
	Vector3 position
	{
		[Token(Token = "0x6000EF6")]
		get;
	}

	[Token(Token = "0x170002A6")]
	Vector3 localPosition
	{
		[Token(Token = "0x6000EF7")]
		get;
	}

	[Token(Token = "0x170002A7")]
	Vector3 deltaPosition
	{
		[Token(Token = "0x6000EF8")]
		get;
	}

	[Token(Token = "0x170002A8")]
	float deltaTime
	{
		[Token(Token = "0x6000EF9")]
		get;
	}

	[Token(Token = "0x170002A9")]
	int clickCount
	{
		[Token(Token = "0x6000EFA")]
		get;
	}

	[Token(Token = "0x170002AA")]
	float pressure
	{
		[Token(Token = "0x6000EFB")]
		get;
	}

	[Token(Token = "0x170002AB")]
	float tangentialPressure
	{
		[Token(Token = "0x6000EFC")]
		get;
	}

	[Token(Token = "0x170002AC")]
	float altitudeAngle
	{
		[Token(Token = "0x6000EFD")]
		get;
	}

	[Token(Token = "0x170002AD")]
	float azimuthAngle
	{
		[Token(Token = "0x6000EFE")]
		get;
	}

	[Token(Token = "0x170002AE")]
	float twist
	{
		[Token(Token = "0x6000EFF")]
		get;
	}

	[Token(Token = "0x170002AF")]
	Vector2 tilt
	{
		[Token(Token = "0x6000F00")]
		get;
	}

	[Token(Token = "0x170002B0")]
	PenStatus penStatus
	{
		[Token(Token = "0x6000F01")]
		get;
	}

	[Token(Token = "0x170002B1")]
	Vector2 radius
	{
		[Token(Token = "0x6000F02")]
		get;
	}

	[Token(Token = "0x170002B2")]
	Vector2 radiusVariance
	{
		[Token(Token = "0x6000F03")]
		get;
	}

	[Token(Token = "0x170002B3")]
	EventModifiers modifiers
	{
		[Token(Token = "0x6000F04")]
		get;
	}

	[Token(Token = "0x170002B4")]
	bool shiftKey
	{
		[Token(Token = "0x6000F05")]
		get;
	}

	[Token(Token = "0x170002B5")]
	bool ctrlKey
	{
		[Token(Token = "0x6000F06")]
		get;
	}

	[Token(Token = "0x170002B6")]
	bool commandKey
	{
		[Token(Token = "0x6000F07")]
		get;
	}

	[Token(Token = "0x170002B7")]
	bool altKey
	{
		[Token(Token = "0x6000F08")]
		get;
	}

	[Token(Token = "0x170002B8")]
	bool actionKey
	{
		[Token(Token = "0x6000F09")]
		get;
	}
}
