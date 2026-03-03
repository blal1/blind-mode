using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x2000434")]
public class InputBlocker : MonoBehaviour
{
	[Token(Token = "0x4001496")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Graphic m_GameMaxRaycastBlocker;

	[Token(Token = "0x4001497")]
	[FieldOffset(Offset = "0x28")]
	private int m_BlockCounter;

	[Token(Token = "0x17000278")]
	public bool isBlocked
	{
		[Token(Token = "0x6001AF5")]
		[Address(RVA = "0x5EB0F0", Offset = "0x5EA2F0", VA = "0x1805EB0F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001AF6")]
	[Address(RVA = "0x5EAF70", Offset = "0x5EA170", VA = "0x1805EAF70")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001AF7")]
	[Address(RVA = "0x5EAF80", Offset = "0x5EA180", VA = "0x1805EAF80")]
	private void Clear()
	{
	}

	[Token(Token = "0x6001AF8")]
	[Address(RVA = "0x5EAF70", Offset = "0x5EA170", VA = "0x1805EAF70")]
	public void Reboot()
	{
	}

	[Token(Token = "0x6001AF9")]
	[Address(RVA = "0x5EB000", Offset = "0x5EA200", VA = "0x1805EB000")]
	public void SetBlockEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6001AFA")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public InputBlocker()
	{
	}
}
