using System;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;
using YgomSystem.YGomTMPro;

namespace YgomGame.DeckBrowser;

[Token(Token = "0x2001036")]
public class PickupCursorWidget : ElementWidgetBehaviourBase<PickupCursorWidget>
{
	[Token(Token = "0x400AD6D")]
	private const string k_PrefPath = "Prefabs/UI/DeckBrowser/Optionals/PickupCursor";

	[Token(Token = "0x400AD6E")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelText;

	[Token(Token = "0x400AD6F")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsActive;

	[Token(Token = "0x400AD70")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_GameObject;

	[Token(Token = "0x400AD71")]
	[FieldOffset(Offset = "0x40")]
	private int m_PickupId;

	[Token(Token = "0x400AD72")]
	[FieldOffset(Offset = "0x48")]
	private ExtendedTextMeshProUGUI m_Text;

	[Token(Token = "0x400AD73")]
	[FieldOffset(Offset = "0x50")]
	public Action onClickedCallback;

	[Token(Token = "0x400AD74")]
	[FieldOffset(Offset = "0x58")]
	public Action onCreated;

	[Token(Token = "0x17000F5E")]
	public bool isActive
	{
		[Token(Token = "0x600623F")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000F5F")]
	public int pickupId
	{
		[Token(Token = "0x6006240")]
		[Address(RVA = "0x5FA7B0", Offset = "0x5F99B0", VA = "0x1805FA7B0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006241")]
		[Address(RVA = "0xA95E00", Offset = "0xA95000", VA = "0x180A95E00")]
		set
		{
		}
	}

	[Token(Token = "0x6006242")]
	[Address(RVA = "0xA95BD0", Offset = "0xA94DD0", VA = "0x180A95BD0")]
	public void Initialize(ElementObjectManager eom, int pickupId = -1)
	{
	}

	[Token(Token = "0x6006243")]
	[Address(RVA = "0xA95AD0", Offset = "0xA94CD0", VA = "0x180A95AD0")]
	public static void Create(Transform parent, Action<PickupCursorWidget> onCreated, int pickupId = -1)
	{
	}

	[Token(Token = "0x6006244")]
	[Address(RVA = "0xA95CD0", Offset = "0xA94ED0", VA = "0x180A95CD0")]
	private void SetPickupId(int pickupId)
	{
	}

	[Token(Token = "0x6006245")]
	[Address(RVA = "0xA95DA0", Offset = "0xA94FA0", VA = "0x180A95DA0")]
	public PickupCursorWidget()
	{
	}
}
