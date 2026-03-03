using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001A62")]
public class MeshAlphaFader : MonoBehaviour
{
	[Token(Token = "0x2001A63")]
	public enum FadeType
	{
		[Token(Token = "0x400F300")]
		FadeIn,
		[Token(Token = "0x400F301")]
		FadeOut
	}

	[Token(Token = "0x400F2FA")]
	[FieldOffset(Offset = "0x20")]
	private FadeType fadeType;

	[Token(Token = "0x400F2FB")]
	[FieldOffset(Offset = "0x24")]
	private float alphaTime;

	[Token(Token = "0x400F2FC")]
	[FieldOffset(Offset = "0x28")]
	private Action onFinishedAlpha;

	[Token(Token = "0x400F2FD")]
	[FieldOffset(Offset = "0x30")]
	private float dulation;

	[Token(Token = "0x400F2FE")]
	[FieldOffset(Offset = "0x34")]
	private bool recursively;

	[Token(Token = "0x17001A77")]
	public bool isShowing
	{
		[Token(Token = "0x600AB46")]
		[Address(RVA = "0x4234B0", Offset = "0x4226B0", VA = "0x1804234B0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001A78")]
	public bool isHiding
	{
		[Token(Token = "0x600AB47")]
		[Address(RVA = "0x423480", Offset = "0x422680", VA = "0x180423480")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600AB42")]
	[Address(RVA = "0x423060", Offset = "0x422260", VA = "0x180423060")]
	private void Awake()
	{
	}

	[Token(Token = "0x600AB43")]
	[Address(RVA = "0x423390", Offset = "0x422590", VA = "0x180423390")]
	private void Update()
	{
	}

	[Token(Token = "0x600AB44")]
	[Address(RVA = "0x4230A0", Offset = "0x4222A0", VA = "0x1804230A0")]
	private void Finish()
	{
	}

	[Token(Token = "0x600AB45")]
	[Address(RVA = "0x423280", Offset = "0x422480", VA = "0x180423280")]
	public void StartFade(FadeType fadeType, float dulation, bool recursively, Action onFinished)
	{
	}

	[Token(Token = "0x600AB48")]
	[Address(RVA = "0x423000", Offset = "0x422200", VA = "0x180423000")]
	public void Abort()
	{
	}

	[Token(Token = "0x600AB49")]
	[Address(RVA = "0x4230F0", Offset = "0x4222F0", VA = "0x1804230F0")]
	private void SetMeshAlpha(float alpha)
	{
	}

	[Token(Token = "0x600AB4A")]
	[Address(RVA = "0x423060", Offset = "0x422260", VA = "0x180423060")]
	private void ResetAlphaFade()
	{
	}

	[Token(Token = "0x600AB4B")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public MeshAlphaFader()
	{
	}
}
