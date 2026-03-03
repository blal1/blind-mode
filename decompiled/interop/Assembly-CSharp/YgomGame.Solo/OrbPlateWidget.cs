using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Solo;

[Token(Token = "0x2000881")]
public class OrbPlateWidget : ElementWidgetBase
{
	[Token(Token = "0x4008685")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_EOrb;

	[Token(Token = "0x4008686")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_EImage;

	[Token(Token = "0x4008687")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_EText;

	[Token(Token = "0x4008688")]
	[FieldOffset(Offset = "0x38")]
	private readonly int k_DarkOrbId;

	[Token(Token = "0x6003384")]
	[Address(RVA = "0x7694E0", Offset = "0x7686E0", VA = "0x1807694E0")]
	public OrbPlateWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6003385")]
	[Address(RVA = "0x7693C0", Offset = "0x7685C0", VA = "0x1807693C0")]
	public void UpdateOrbNum()
	{
	}
}
