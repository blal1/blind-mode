using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x200195C")]
public class CameraShaker : MonoBehaviour
{
	[Token(Token = "0x200195D")]
	public enum Type
	{
		[Token(Token = "0x400EC08")]
		LIFEDAMAGE,
		[Token(Token = "0x400EC09")]
		ATTACKGUARD,
		[Token(Token = "0x400EC0A")]
		ATTACKBREAK,
		[Token(Token = "0x400EC0B")]
		ATTACKDIRECT,
		[Token(Token = "0x400EC0C")]
		ACEMONST1,
		[Token(Token = "0x400EC0D")]
		ACEMONST2,
		[Token(Token = "0x400EC0E")]
		ACEMONST3,
		[Token(Token = "0x400EC0F")]
		EFFECT4354,
		[Token(Token = "0x400EC10")]
		EFFECT4342
	}

	[Token(Token = "0x400EBFE")]
	[FieldOffset(Offset = "0x20")]
	public bool isShaking;

	[Token(Token = "0x400EBFF")]
	[FieldOffset(Offset = "0x24")]
	private float shakeTimer;

	[Token(Token = "0x400EC00")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 big;

	[Token(Token = "0x400EC01")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 lit;

	[Token(Token = "0x400EC02")]
	[FieldOffset(Offset = "0x40")]
	private int loopCount;

	[Token(Token = "0x400EC03")]
	[FieldOffset(Offset = "0x48")]
	private string settingPath;

	[Token(Token = "0x400EC04")]
	[FieldOffset(Offset = "0x50")]
	private CameraShakerSetting setting;

	[Token(Token = "0x400EC05")]
	[FieldOffset(Offset = "0x58")]
	private CameraShakerSetting.Info shaker;

	[Token(Token = "0x170018F1")]
	public Vector3 shakeOffset
	{
		[Token(Token = "0x600A2FF")]
		[Address(RVA = "0xF01390", Offset = "0xF00590", VA = "0x180F01390")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600A300")]
		[Address(RVA = "0xF013B0", Offset = "0xF005B0", VA = "0x180F013B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600A2FC")]
	[Address(RVA = "0xF00C10", Offset = "0xEFFE10", VA = "0x180F00C10")]
	public bool LoadSetting(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x600A2FD")]
	[Address(RVA = "0xF00FE0", Offset = "0xF001E0", VA = "0x180F00FE0")]
	public void Shake(Type type)
	{
	}

	[Token(Token = "0x600A2FE")]
	[Address(RVA = "0xF00DB0", Offset = "0xEFFFB0", VA = "0x180F00DB0")]
	public void Shake(string label)
	{
	}

	[Token(Token = "0x600A301")]
	[Address(RVA = "0xF01330", Offset = "0xF00530", VA = "0x180F01330")]
	private void Update()
	{
	}

	[Token(Token = "0x600A302")]
	[Address(RVA = "0xF01200", Offset = "0xF00400", VA = "0x180F01200")]
	private void UpdateShake(bool countup_time = true)
	{
	}

	[Token(Token = "0x600A303")]
	[Address(RVA = "0xF00BC0", Offset = "0xEFFDC0", VA = "0x180F00BC0")]
	public void FinishShake()
	{
	}

	[Token(Token = "0x600A304")]
	[Address(RVA = "0xF01340", Offset = "0xF00540", VA = "0x180F01340")]
	public CameraShaker()
	{
	}
}
