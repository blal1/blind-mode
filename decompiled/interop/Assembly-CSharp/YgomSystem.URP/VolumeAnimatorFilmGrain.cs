using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace YgomSystem.URP;

[Token(Token = "0x2000307")]
public class VolumeAnimatorFilmGrain : VolumeAnimatorComponentBase<FilmGrain>
{
	[Token(Token = "0x4001090")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool type_Ov;

	[Token(Token = "0x4001091")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private FilmGrainLookup type_Val;

	[Token(Token = "0x4001092")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool intensity_Ov;

	[Token(Token = "0x4001093")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Range(0f, 1f)]
	private float intensity_Val;

	[Token(Token = "0x4001094")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool response_Ov;

	[Token(Token = "0x4001095")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Range(0f, 1f)]
	private float response_Val;

	[Token(Token = "0x4001096")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool texture_Ov;

	[Token(Token = "0x4001097")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Texture texture_Val;

	[Token(Token = "0x6001300")]
	[Address(RVA = "0x41BC10", Offset = "0x41AE10", VA = "0x18041BC10", Slot = "10")]
	protected override void ExecuteImport(FilmGrain component)
	{
	}

	[Token(Token = "0x6001301")]
	[Address(RVA = "0x41BAD0", Offset = "0x41ACD0", VA = "0x18041BAD0", Slot = "11")]
	protected override void ExecuteExport(FilmGrain component)
	{
	}

	[Token(Token = "0x6001302")]
	[Address(RVA = "0x41BD60", Offset = "0x41AF60", VA = "0x18041BD60")]
	public VolumeAnimatorFilmGrain()
	{
	}
}
