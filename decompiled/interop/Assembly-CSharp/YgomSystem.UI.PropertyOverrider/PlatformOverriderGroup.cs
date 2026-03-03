using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005B8")]
[AddComponentMenu("Ygom/UI/Platform Overrider/Platform Overrider Group")]
public class PlatformOverriderGroup : MonoBehaviour
{
	[Token(Token = "0x4001BC6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string m_SwitchLabel;

	[Token(Token = "0x4001BC7")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject[] m_ActiveOverriders;

	[Token(Token = "0x17000464")]
	public GameObject[] activeOverriders
	{
		[Token(Token = "0x60025A9")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000465")]
	public string switchLabel
	{
		[Token(Token = "0x60025AA")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
		[Token(Token = "0x60025AB")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		set
		{
		}
	}

	[Token(Token = "0x60025AC")]
	[Address(RVA = "0x69BFC0", Offset = "0x69B1C0", VA = "0x18069BFC0")]
	public bool MatchLabel(IPlatformPropertyOverrider ov)
	{
		return default(bool);
	}

	[Token(Token = "0x60025AD")]
	[Address(RVA = "0x69C0B0", Offset = "0x69B2B0", VA = "0x18069C0B0")]
	public static bool MatchLabel(string switchLabel, IPlatformPropertyOverrider ov)
	{
		return default(bool);
	}

	[Token(Token = "0x60025AE")]
	[Address(RVA = "0x69C1A0", Offset = "0x69B3A0", VA = "0x18069C1A0")]
	private void Start()
	{
	}

	[Token(Token = "0x60025AF")]
	[Address(RVA = "0x69BE90", Offset = "0x69B090", VA = "0x18069BE90")]
	public void ImmediateApply(bool frag = false)
	{
	}

	[Token(Token = "0x60025B0")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public PlatformOverriderGroup()
	{
	}
}
