using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x200183B")]
public class AudienceInfo : MonoBehaviour
{
	[Token(Token = "0x400E31C")]
	[FieldOffset(Offset = "0x20")]
	private ElementObjectManager ui;

	[Token(Token = "0x400E31D")]
	[FieldOffset(Offset = "0x28")]
	private ExtendedTextMeshProUGUI numText;

	[Token(Token = "0x400E31E")]
	[FieldOffset(Offset = "0x30")]
	private int watcherNum;

	[Token(Token = "0x6009A08")]
	[Address(RVA = "0xE4E2B0", Offset = "0xE4D4B0", VA = "0x180E4E2B0")]
	public void Initialize(ElementObjectManager ui)
	{
	}

	[Token(Token = "0x6009A09")]
	[Address(RVA = "0xE4E400", Offset = "0xE4D600", VA = "0x180E4E400")]
	public void SetWatcherNum(int num, bool show)
	{
	}

	[Token(Token = "0x6009A0A")]
	[Address(RVA = "0xE4E380", Offset = "0xE4D580", VA = "0x180E4E380")]
	public void SetDisp(bool disp)
	{
	}

	[Token(Token = "0x6009A0B")]
	[Address(RVA = "0xE4E470", Offset = "0xE4D670", VA = "0x180E4E470")]
	public void ShowIfExistWatcher()
	{
	}

	[Token(Token = "0x6009A0C")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public AudienceInfo()
	{
	}
}
