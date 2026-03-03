using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.UI;

[Token(Token = "0x2000530")]
public class GamepadCursor : MonoBehaviour
{
	[Token(Token = "0x400194A")]
	[FieldOffset(Offset = "0x20")]
	private UnityAction<SelectorManager.InputDevice> changeDeviceAction;

	[Token(Token = "0x60021A0")]
	[Address(RVA = "0x649100", Offset = "0x648300", VA = "0x180649100")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60021A1")]
	[Address(RVA = "0x649050", Offset = "0x648250", VA = "0x180649050")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60021A2")]
	[Address(RVA = "0x6492C0", Offset = "0x6484C0", VA = "0x1806492C0")]
	private void UpdateDisplay()
	{
	}

	[Token(Token = "0x60021A3")]
	[Address(RVA = "0x649210", Offset = "0x648410", VA = "0x180649210")]
	private void SetDisp(bool disp)
	{
	}

	[Token(Token = "0x60021A4")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public GamepadCursor()
	{
	}
}
