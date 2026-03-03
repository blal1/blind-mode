using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.CardPack.Open.Actor;

[Token(Token = "0x2001575")]
public class CardPackInfoActorContainer : ActorContainerBase<CardPackInfoActorContainer>
{
	[Token(Token = "0x400CD0B")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelLabelRoot;

	[Token(Token = "0x400CD0C")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelLabelRoot_LabelBand;

	[Token(Token = "0x400CD0D")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelLabelRoot_LabelText;

	[Token(Token = "0x400CD0E")]
	internal const string k_TLabelShow = "Show";

	[Token(Token = "0x400CD0F")]
	internal const string k_TLabelHide = "Hide";

	[Token(Token = "0x400CD10")]
	[FieldOffset(Offset = "0x40")]
	private ActorBindingRefs m_BindingRefs;

	[Token(Token = "0x400CD11")]
	[FieldOffset(Offset = "0x48")]
	private ElementObjectManager m_LabelRootEom;

	[Token(Token = "0x60084CA")]
	[Address(RVA = "0xCD8A40", Offset = "0xCD7C40", VA = "0x180CD8A40")]
	public static CardPackInfoActorContainer Create(ElementObjectManager eom, ActorBindingRefs bindingRefs)
	{
		return null;
	}

	[Token(Token = "0x60084CB")]
	[Address(RVA = "0xCD89C0", Offset = "0xCD7BC0", VA = "0x180CD89C0", Slot = "4")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x60084CC")]
	[Address(RVA = "0xCD8BB0", Offset = "0xCD7DB0", VA = "0x180CD8BB0")]
	public void SetLabel(int bandStyle, string labelText)
	{
	}

	[Token(Token = "0x60084CD")]
	[Address(RVA = "0xCD8AB0", Offset = "0xCD7CB0", VA = "0x180CD8AB0")]
	public void PlayLabelTween(string tweenKey)
	{
	}

	[Token(Token = "0x60084CE")]
	[Address(RVA = "0xCD8950", Offset = "0xCD7B50", VA = "0x180CD8950", Slot = "5")]
	public override void Cleanup(bool keepInfo)
	{
	}

	[Token(Token = "0x60084CF")]
	[Address(RVA = "0xCD8D60", Offset = "0xCD7F60", VA = "0x180CD8D60")]
	public CardPackInfoActorContainer()
	{
	}
}
