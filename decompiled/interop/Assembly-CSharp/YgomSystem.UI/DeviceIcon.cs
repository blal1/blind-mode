using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.UI;

[Token(Token = "0x200052D")]
public class DeviceIcon : MonoBehaviour
{
	[Token(Token = "0x200052E")]
	public enum DispType
	{
		[Token(Token = "0x4001948")]
		Graphic,
		[Token(Token = "0x4001949")]
		GameObject
	}

	[Token(Token = "0x400193F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private UnityAction<SelectorManager.InputDevice> changeDeviceAction;

	[Token(Token = "0x4001940")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SelectorManager.InputDevice displayInputDevice;

	[Token(Token = "0x4001942")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool alwaysShowOnConsole;

	[Token(Token = "0x4001943")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public DispType dispTarget;

	[Token(Token = "0x4001944")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected bool isDisp;

	[Token(Token = "0x4001945")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	protected bool setup;

	[Token(Token = "0x4001946")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	protected bool _isActivate;

	[Token(Token = "0x1700036D")]
	public UnityEvent onChanged
	{
		[Token(Token = "0x6002193")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002194")]
		[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700036E")]
	public bool isActivate
	{
		[Token(Token = "0x6002195")]
		[Address(RVA = "0x648660", Offset = "0x647860", VA = "0x180648660")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002196")]
		[Address(RVA = "0x648670", Offset = "0x647870", VA = "0x180648670")]
		set
		{
		}
	}

	[Token(Token = "0x6002197")]
	[Address(RVA = "0x648190", Offset = "0x647390", VA = "0x180648190", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6002198")]
	[Address(RVA = "0x6481B0", Offset = "0x6473B0", VA = "0x1806481B0", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6002199")]
	[Address(RVA = "0x648350", Offset = "0x647550", VA = "0x180648350", Slot = "6")]
	protected virtual void Setup()
	{
	}

	[Token(Token = "0x600219A")]
	[Address(RVA = "0x648470", Offset = "0x647670", VA = "0x180648470", Slot = "7")]
	protected virtual void UpdateDisplay([Optional] Action onCompleted)
	{
	}

	[Token(Token = "0x600219B")]
	[Address(RVA = "0x648270", Offset = "0x647470", VA = "0x180648270")]
	public void SetDisp(bool disp)
	{
	}

	[Token(Token = "0x600219C")]
	[Address(RVA = "0x6485E0", Offset = "0x6477E0", VA = "0x1806485E0")]
	public DeviceIcon()
	{
	}
}
