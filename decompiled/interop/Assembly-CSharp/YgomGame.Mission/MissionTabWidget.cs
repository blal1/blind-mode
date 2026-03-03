using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Mission;

[Token(Token = "0x2000C16")]
public class MissionTabWidget : ElementWidgetBase
{
	[Token(Token = "0x170009F6")]
	private GameObject onRoot
	{
		[Token(Token = "0x60049B5")]
		[Address(RVA = "0x941400", Offset = "0x940600", VA = "0x180941400")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009F7")]
	private GameObject offRoot
	{
		[Token(Token = "0x60049B6")]
		[Address(RVA = "0x9413B0", Offset = "0x9405B0", VA = "0x1809413B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009F8")]
	public string label
	{
		[Token(Token = "0x60049B7")]
		[Address(RVA = "0x941630", Offset = "0x940830", VA = "0x180941630")]
		set
		{
		}
	}

	[Token(Token = "0x170009F9")]
	public bool isOn
	{
		[Token(Token = "0x60049B8")]
		[Address(RVA = "0x941350", Offset = "0x940550", VA = "0x180941350")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60049B9")]
		[Address(RVA = "0x941570", Offset = "0x940770", VA = "0x180941570")]
		set
		{
		}
	}

	[Token(Token = "0x170009FA")]
	public bool badgeVisible
	{
		[Token(Token = "0x60049BA")]
		[Address(RVA = "0x941450", Offset = "0x940650", VA = "0x180941450")]
		set
		{
		}
	}

	[Token(Token = "0x170009FB")]
	public bool numBadgeVisible
	{
		[Token(Token = "0x60049BB")]
		[Address(RVA = "0x9417F0", Offset = "0x9409F0", VA = "0x1809417F0")]
		set
		{
		}
	}

	[Token(Token = "0x170009FC")]
	public int numBadgeCnt
	{
		[Token(Token = "0x60049BC")]
		[Address(RVA = "0x941760", Offset = "0x940960", VA = "0x180941760")]
		set
		{
		}
	}

	[Token(Token = "0x170009FD")]
	public bool completeVisible
	{
		[Token(Token = "0x60049BD")]
		[Address(RVA = "0x9414E0", Offset = "0x9406E0", VA = "0x1809414E0")]
		set
		{
		}
	}

	[Token(Token = "0x170009FE")]
	public SelectionButton button
	{
		[Token(Token = "0x60049BE")]
		[Address(RVA = "0x9412F0", Offset = "0x9404F0", VA = "0x1809412F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60049BF")]
	[Address(RVA = "0x8847B0", Offset = "0x8839B0", VA = "0x1808847B0")]
	public MissionTabWidget(ElementObjectManager eom)
	{
	}
}
