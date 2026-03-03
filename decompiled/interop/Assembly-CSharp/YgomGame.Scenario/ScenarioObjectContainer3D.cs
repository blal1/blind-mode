using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A7E")]
public class ScenarioObjectContainer3D : ScenarioContainerBase
{
	[Token(Token = "0x4009269")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelBGRoot;

	[Token(Token = "0x400926A")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelActorRoot;

	[Token(Token = "0x400926B")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelPrefabBackUIRoot;

	[Token(Token = "0x400926C")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelBlurLayer;

	[Token(Token = "0x400926D")]
	[FieldOffset(Offset = "0x48")]
	public readonly ScenarioBGContainer bgContainer;

	[Token(Token = "0x400926E")]
	[FieldOffset(Offset = "0x50")]
	public readonly ScenarioActorContainer actorContainer;

	[Token(Token = "0x400926F")]
	[FieldOffset(Offset = "0x58")]
	public readonly ScenarioPrefabContainer prefabContainer;

	[Token(Token = "0x4009270")]
	[FieldOffset(Offset = "0x60")]
	public readonly ScenarioBlurLayerActor blurScreenActor;

	[Token(Token = "0x60040A5")]
	[Address(RVA = "0x88CF70", Offset = "0x88C170", VA = "0x18088CF70")]
	public ScenarioObjectContainer3D(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x60040A6")]
	[Address(RVA = "0x88CEB0", Offset = "0x88C0B0", VA = "0x18088CEB0")]
	public void Initialize(ScenarioWork work)
	{
	}

	[Token(Token = "0x60040A7")]
	[Address(RVA = "0x88CD90", Offset = "0x88BF90", VA = "0x18088CD90")]
	public void ApplyCameraScale(Camera camera3d)
	{
	}

	[Token(Token = "0x60040A8")]
	[Address(RVA = "0x88CED0", Offset = "0x88C0D0", VA = "0x18088CED0")]
	private void OnCreateCardActor(ScenarioCardActor cardActor)
	{
	}

	[Token(Token = "0x60040A9")]
	[Address(RVA = "0x88CEF0", Offset = "0x88C0F0", VA = "0x18088CEF0")]
	private void OnCreatePref(string label, GameObject gom)
	{
	}
}
