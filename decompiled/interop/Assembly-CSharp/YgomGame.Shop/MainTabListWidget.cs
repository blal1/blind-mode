using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop;

[Token(Token = "0x2000955")]
public class MainTabListWidget : ElementWidgetBase
{
	[Token(Token = "0x4008B04")]
	internal const string k_ELabel_TabTemplate_Default = "TabTemplate_Default";

	[Token(Token = "0x4008B05")]
	internal const string k_ELabel_TabTemplate_Icon = "TabTemplate_Icon";

	[Token(Token = "0x4008B06")]
	internal const string k_ELabel_TabTemplate_Pickup = "TabTemplate_Pickup";

	[Token(Token = "0x4008B07")]
	[FieldOffset(Offset = "0x20")]
	public readonly Selector selector;

	[Token(Token = "0x4008B08")]
	[FieldOffset(Offset = "0x28")]
	private readonly ElementObjectReusableList m_EomTemplatePool;

	[Token(Token = "0x4008B09")]
	[FieldOffset(Offset = "0x30")]
	private readonly List<string> m_TabTemplateLabels;

	[Token(Token = "0x4008B0A")]
	[FieldOffset(Offset = "0x38")]
	private readonly Dictionary<GameObject, ShopTabWidget> m_TabWidgetMap;

	[Token(Token = "0x4008B0B")]
	[FieldOffset(Offset = "0x40")]
	private IMainTabListWidgetHandler m_Handler;

	[Token(Token = "0x4008B0C")]
	[FieldOffset(Offset = "0x48")]
	private IMainTabListWidgetListener m_Listener;

	[Token(Token = "0x60038E4")]
	[Address(RVA = "0x7EBED0", Offset = "0x7EB0D0", VA = "0x1807EBED0")]
	public MainTabListWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x60038E5")]
	[Address(RVA = "0x7EB480", Offset = "0x7EA680", VA = "0x1807EB480")]
	public void Init(IMainTabListWidgetHandler handler, IMainTabListWidgetListener listener)
	{
	}

	[Token(Token = "0x60038E6")]
	[Address(RVA = "0x7EBDC0", Offset = "0x7EAFC0", VA = "0x1807EBDC0")]
	public void UpdateDataCount()
	{
	}

	[Token(Token = "0x60038E7")]
	[Address(RVA = "0x7EBEB0", Offset = "0x7EB0B0", VA = "0x1807EBEB0")]
	public void UpdateData()
	{
	}

	[Token(Token = "0x60038E8")]
	[Address(RVA = "0x7EB970", Offset = "0x7EAB70", VA = "0x1807EB970")]
	private void OnCreateTabEntity(GameObject tabEntity, string label)
	{
	}

	[Token(Token = "0x60038E9")]
	[Address(RVA = "0x7EBAC0", Offset = "0x7EACC0", VA = "0x1807EBAC0")]
	private void OnUpdateTabEntity(GameObject tabEntity, int dataIndex, string label)
	{
	}

	[Token(Token = "0x60038EA")]
	[Address(RVA = "0x7EBCB0", Offset = "0x7EAEB0", VA = "0x1807EBCB0")]
	public bool SelectCurrentIdx(bool isInitializeSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60038EB")]
	[Address(RVA = "0x7EB1A0", Offset = "0x7EA3A0", VA = "0x1807EB1A0")]
	public bool CheckRecoverSelectItem()
	{
		return default(bool);
	}
}
