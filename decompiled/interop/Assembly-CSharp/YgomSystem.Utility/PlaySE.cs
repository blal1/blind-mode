using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x20003F4")]
public class PlaySE : MonoBehaviour
{
	[Token(Token = "0x40013BA")]
	[FieldOffset(Offset = "0x20")]
	private string seLabel;

	[Token(Token = "0x40013BB")]
	[FieldOffset(Offset = "0x28")]
	private float playDelay;

	[Token(Token = "0x40013BC")]
	[FieldOffset(Offset = "0x2C")]
	private float playTime;

	[Token(Token = "0x600194A")]
	[Address(RVA = "0x5D1A80", Offset = "0x5D0C80", VA = "0x1805D1A80")]
	public void Play(string se, float time = 0f, float delay = 0f)
	{
	}

	[Token(Token = "0x600194B")]
	[Address(RVA = "0x5D1B80", Offset = "0x5D0D80", VA = "0x1805D1B80")]
	private void Update()
	{
	}

	[Token(Token = "0x600194C")]
	[Address(RVA = "0x5D19A0", Offset = "0x5D0BA0", VA = "0x1805D19A0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600194D")]
	[Address(RVA = "0x5D1C40", Offset = "0x5D0E40", VA = "0x1805D1C40")]
	public PlaySE()
	{
	}
}
