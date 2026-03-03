using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.UI;

[Token(Token = "0x200054A")]
public abstract class PlatformVisibleIconBase : MonoBehaviour
{
	[Token(Token = "0x200054B")]
	public enum DispType
	{
		[Token(Token = "0x40019AF")]
		Graphic,
		[Token(Token = "0x40019B0")]
		GameObject
	}

	[Token(Token = "0x40019AA")]
	[FieldOffset(Offset = "0x20")]
	public DispType dispTarget;

	[Token(Token = "0x40019AB")]
	[FieldOffset(Offset = "0x28")]
	private UnityAction<SelectorManager.InputDevice> changeDeviceAction;

	[Token(Token = "0x40019AC")]
	[FieldOffset(Offset = "0x30")]
	protected bool isDisp;

	[Token(Token = "0x40019AD")]
	[FieldOffset(Offset = "0x31")]
	protected bool setup;

	[Token(Token = "0x6002251")]
	[Address(RVA = "0x64CF30", Offset = "0x64C130", VA = "0x18064CF30")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002252")]
	[Address(RVA = "0x64CF50", Offset = "0x64C150", VA = "0x18064CF50")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002253")]
	[Address(RVA = "0x64D0E0", Offset = "0x64C2E0", VA = "0x18064D0E0")]
	private void Setup()
	{
	}

	[Token(Token = "0x6002254")]
	protected abstract bool IsDispPlatform();

	[Token(Token = "0x6002255")]
	[Address(RVA = "0x64D210", Offset = "0x64C410", VA = "0x18064D210")]
	[ContextMenu("UpdateDisplay")]
	private void UpdateDisplay()
	{
	}

	[Token(Token = "0x6002256")]
	[Address(RVA = "0x64D000", Offset = "0x64C200", VA = "0x18064D000")]
	private void SetDisp(bool disp)
	{
	}

	[Token(Token = "0x6002257")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	protected PlatformVisibleIconBase()
	{
	}
}
