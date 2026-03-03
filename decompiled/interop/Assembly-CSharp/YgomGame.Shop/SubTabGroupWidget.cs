using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop;

[Token(Token = "0x2000969")]
public class SubTabGroupWidget : ElementWidgetBase, ISubTabWidget
{
	[Token(Token = "0x4008B8E")]
	private const string k_ELabelHandleToggle = "HandleToggle";

	[Token(Token = "0x4008B8F")]
	private const string k_TLabelToOpen = "ToOpen";

	[Token(Token = "0x4008B90")]
	private const string k_TLabelToClose = "ToClose";

	[Token(Token = "0x4008B91")]
	[FieldOffset(Offset = "0x20")]
	private readonly ShopTabWidget m_TabWidget;

	[Token(Token = "0x4008B92")]
	[FieldOffset(Offset = "0x28")]
	private readonly ElementEntityFactory m_EntityFactory;

	[Token(Token = "0x4008B93")]
	[FieldOffset(Offset = "0x30")]
	private List<Tween> m_ToOpenTweens;

	[Token(Token = "0x4008B94")]
	[FieldOffset(Offset = "0x38")]
	private List<Tween> m_ToCloseTweens;

	[Token(Token = "0x17000784")]
	public ShopTabWidget tabWidget
	{
		[Token(Token = "0x600395E")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000785")]
	public ElementEntityFactory entityFactory
	{
		[Token(Token = "0x600395F")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000786")]
	public SubTabGroupWidget parentGroup
	{
		[Token(Token = "0x6003960")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000787")]
	public int dataCount
	{
		[Token(Token = "0x6003961")]
		[Address(RVA = "0x6785E0", Offset = "0x6777E0", VA = "0x1806785E0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6003962")]
	[Address(RVA = "0x803FF0", Offset = "0x8031F0", VA = "0x180803FF0")]
	private List<Tween> GetTweenByLabel(string label)
	{
		return null;
	}

	[Token(Token = "0x6003963")]
	[Address(RVA = "0x804560", Offset = "0x803760", VA = "0x180804560")]
	public SubTabGroupWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6003964")]
	[Address(RVA = "0x803CE0", Offset = "0x802EE0", VA = "0x180803CE0")]
	public void CaptureTweenFrom()
	{
	}

	[Token(Token = "0x6003965")]
	[Address(RVA = "0x804080", Offset = "0x803280", VA = "0x180804080")]
	public void PlayTween(bool isOn, bool immediate = false)
	{
	}

	[Token(Token = "0x6003966")]
	[Address(RVA = "0x803D60", Offset = "0x802F60", VA = "0x180803D60")]
	private void CheckCollectTween()
	{
	}

	[Token(Token = "0x6003967")]
	[Address(RVA = "0x804190", Offset = "0x803390", VA = "0x180804190")]
	private void StopAllTween()
	{
	}

	[Token(Token = "0x6003968")]
	[Address(RVA = "0x804360", Offset = "0x803560", VA = "0x180804360")]
	private void TargetGotoAndPlayLabel(string label, bool wakeup, bool immediate)
	{
	}
}
