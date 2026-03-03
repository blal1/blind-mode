using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x2000543")]
public class PlatformPlayerIcon : MonoBehaviour
{
	[Token(Token = "0x4001992")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_CurrentPlatformIconPath;

	[Token(Token = "0x4001993")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_OtherPlatformIconPath;

	[Token(Token = "0x4001994")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject m_TargetRoot;

	[Token(Token = "0x4001995")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image m_TargetIconImage;

	[Token(Token = "0x1700039F")]
	public GameObject TargetRoot
	{
		[Token(Token = "0x600223D")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600223E")]
	[Address(RVA = "0x64C2A0", Offset = "0x64B4A0", VA = "0x18064C2A0")]
	public void Set(bool isSamePlatfrom)
	{
	}

	[Token(Token = "0x600223F")]
	[Address(RVA = "0x64C100", Offset = "0x64B300", VA = "0x18064C100")]
	private void SetDisp(bool disp)
	{
	}

	[Token(Token = "0x6002240")]
	[Address(RVA = "0x64C1B0", Offset = "0x64B3B0", VA = "0x18064C1B0")]
	private void SetIcon(bool isSamePlatform)
	{
	}

	[Token(Token = "0x6002241")]
	[Address(RVA = "0x64C570", Offset = "0x64B770", VA = "0x18064C570")]
	public PlatformPlayerIcon()
	{
	}
}
