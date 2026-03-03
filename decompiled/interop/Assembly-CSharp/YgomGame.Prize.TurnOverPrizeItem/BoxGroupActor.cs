using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Prize.TurnOverPrizeItem;

[Token(Token = "0x2000B99")]
public class BoxGroupActor : ElementWidgetBase
{
	[Token(Token = "0x400975A")]
	private const string k_ELabelPackFormat = "Box{0:D2}";

	[Token(Token = "0x400975B")]
	[FieldOffset(Offset = "0x20")]
	private readonly TransitionGridGroup m_TransitionGridGroup;

	[Token(Token = "0x400975C")]
	[FieldOffset(Offset = "0x28")]
	private BoxActor[] m_Packs;

	[Token(Token = "0x17000988")]
	public BoxActor[] packs
	{
		[Token(Token = "0x60046B6")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60046B7")]
	[Address(RVA = "0x8E1EA0", Offset = "0x8E10A0", VA = "0x1808E1EA0")]
	public BoxGroupActor(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x60046B8")]
	[Address(RVA = "0x8E1A50", Offset = "0x8E0C50", VA = "0x1808E1A50")]
	public void CollectPacks(int packTotal)
	{
	}

	[Token(Token = "0x60046B9")]
	[Address(RVA = "0x8E1DB0", Offset = "0x8E0FB0", VA = "0x1808E1DB0")]
	public void SetButtonsEnabled(bool enabled)
	{
	}

	[Token(Token = "0x60046BA")]
	[Address(RVA = "0x8E1CD0", Offset = "0x8E0ED0", VA = "0x1808E1CD0")]
	public void SetArrowsVisible(bool enabled)
	{
	}
}
