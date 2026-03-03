using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A57")]
public class ScenarioBGContainer : ScenarioContainerBase
{
	[Token(Token = "0x4009187")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelBGCanvas;

	[Token(Token = "0x4009188")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelBGOutlineCanvas;

	[Token(Token = "0x4009189")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelBGRawImage;

	[Token(Token = "0x400918A")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelBGSubRawImage;

	[Token(Token = "0x400918B")]
	[FieldOffset(Offset = "0x48")]
	private readonly Canvas bgCanvas;

	[Token(Token = "0x400918C")]
	[FieldOffset(Offset = "0x50")]
	private readonly Canvas bgOutlineCanvas;

	[Token(Token = "0x400918D")]
	[FieldOffset(Offset = "0x58")]
	public readonly ScenarioBGActor bgActor;

	[Token(Token = "0x400918E")]
	[FieldOffset(Offset = "0x60")]
	public readonly ScenarioBGActor bgSubActor;

	[Token(Token = "0x1700086F")]
	protected override GameObject shakeTarget
	{
		[Token(Token = "0x6003F8B")]
		[Address(RVA = "0x867C40", Offset = "0x866E40", VA = "0x180867C40", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F8C")]
	[Address(RVA = "0x867A30", Offset = "0x866C30", VA = "0x180867A30")]
	public ScenarioBGContainer(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6003F8D")]
	[Address(RVA = "0x867280", Offset = "0x866480", VA = "0x180867280")]
	public void Initialize(ScenarioWork work)
	{
	}

	[Token(Token = "0x6003F8E")]
	[Address(RVA = "0x867240", Offset = "0x866440", VA = "0x180867240")]
	private static float CalcFullBGSizeRate(float outerSafeAreaSize, float innerSafeAreaSize, float screenSize)
	{
		return default(float);
	}

	[Token(Token = "0x6003F8F")]
	[Address(RVA = "0x867980", Offset = "0x866B80", VA = "0x180867980")]
	public void ToBlurOn()
	{
	}

	[Token(Token = "0x6003F90")]
	[Address(RVA = "0x867890", Offset = "0x866A90", VA = "0x180867890")]
	public void ToBlurOff()
	{
	}
}
