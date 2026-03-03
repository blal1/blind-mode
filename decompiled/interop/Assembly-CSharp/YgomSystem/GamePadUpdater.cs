using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem;

[Token(Token = "0x2000172")]
public class GamePadUpdater : MonoBehaviour
{
	[Token(Token = "0x40008E6")]
	[FieldOffset(Offset = "0x20")]
	private UnityEvent m_updateEvent;

	[Token(Token = "0x40008E7")]
	[FieldOffset(Offset = "0x0")]
	private static bool s_applicationFocused;

	[Token(Token = "0x17000101")]
	public static bool ApplicationFocused
	{
		[Token(Token = "0x6000960")]
		[Address(RVA = "0xAF4680", Offset = "0xAF3880", VA = "0x180AF4680")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600095C")]
	[Address(RVA = "0xAF43E0", Offset = "0xAF35E0", VA = "0x180AF43E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600095D")]
	[Address(RVA = "0xAF44E0", Offset = "0xAF36E0", VA = "0x180AF44E0")]
	private void Update()
	{
	}

	[Token(Token = "0x600095E")]
	[Address(RVA = "0xAF44A0", Offset = "0xAF36A0", VA = "0x180AF44A0")]
	public void RegisterUpdateEvent(UnityAction onUpdate)
	{
	}

	[Token(Token = "0x600095F")]
	[Address(RVA = "0xAF44C0", Offset = "0xAF36C0", VA = "0x180AF44C0")]
	public void UnregisterUpdateEvent(UnityAction onUpdate)
	{
	}

	[Token(Token = "0x6000961")]
	[Address(RVA = "0xAF4440", Offset = "0xAF3640", VA = "0x180AF4440")]
	private void OnApplicationFocus(bool focusStatus)
	{
	}

	[Token(Token = "0x6000962")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public GamePadUpdater()
	{
	}
}
