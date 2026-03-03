using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Prize.TurnOverPrize;

[Token(Token = "0x2000BB1")]
public class PackGroupActor : ElementWidgetBase
{
	[Token(Token = "0x40097BC")]
	private const string k_ELabelPackFormat = "Pack{0:D2}";

	[Token(Token = "0x40097BD")]
	private const string k_OLabelPackFormat = "Pack_{0:D2}";

	[Token(Token = "0x40097BE")]
	[FieldOffset(Offset = "0x20")]
	private readonly TransitionGridGroup m_TransitionGridGroup;

	[Token(Token = "0x40097BF")]
	[FieldOffset(Offset = "0x28")]
	private PackActor[] m_Packs;

	[Token(Token = "0x170009A1")]
	public PackActor[] packs
	{
		[Token(Token = "0x600473A")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600473B")]
	[Address(RVA = "0x903650", Offset = "0x902850", VA = "0x180903650")]
	public PackGroupActor(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x600473C")]
	[Address(RVA = "0x903140", Offset = "0x902340", VA = "0x180903140")]
	public void CollectPacks(int packTotal)
	{
	}

	[Token(Token = "0x600473D")]
	[Address(RVA = "0x903590", Offset = "0x902790", VA = "0x180903590")]
	public void SwitchPackGroupOverrideGroup(int packTotal)
	{
	}

	[Token(Token = "0x600473E")]
	[Address(RVA = "0x9034A0", Offset = "0x9026A0", VA = "0x1809034A0")]
	public void SetButtonsEnabled(bool enabled)
	{
	}

	[Token(Token = "0x600473F")]
	[Address(RVA = "0x9033C0", Offset = "0x9025C0", VA = "0x1809033C0")]
	public void SetArrowsVisible(bool enabled)
	{
	}
}
