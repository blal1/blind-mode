using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x200187E")]
public class DamageFrame : MonoBehaviour
{
	[Token(Token = "0x400E5F2")]
	[FieldOffset(Offset = "0x20")]
	private TweenAlpha tween;

	[Token(Token = "0x6009CC9")]
	[Address(RVA = "0xEA0C20", Offset = "0xE9FE20", VA = "0x180EA0C20")]
	private void Awake()
	{
	}

	[Token(Token = "0x6009CCA")]
	[Address(RVA = "0xEA0C70", Offset = "0xE9FE70", VA = "0x180EA0C70")]
	public void Show()
	{
	}

	[Token(Token = "0x6009CCB")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public DamageFrame()
	{
	}
}
