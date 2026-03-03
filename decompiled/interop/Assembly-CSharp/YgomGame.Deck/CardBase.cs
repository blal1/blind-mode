using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Deck;

[Token(Token = "0x2001068")]
[RequireComponent(typeof(ElementObjectManager))]
public class CardBase : MonoBehaviour
{
	[Token(Token = "0x400AEFE")]
	[FieldOffset(Offset = "0x20")]
	protected ElementObjectManager m_eom;

	[Token(Token = "0x400AEFF")]
	protected const string LABEL_IMG_CARDIMAGE = "ImageCard";

	[Token(Token = "0x400AF00")]
	protected const string LABEL_IMG_NOCARD = "NoCard";

	[Token(Token = "0x400AF01")]
	protected const string LABEL_IMG_RENTALCARD = "RentalCard";

	[Token(Token = "0x400AF02")]
	protected const string LABEL_IMG_AUTOBUILDCARD = "AutoBuildCard";

	[Token(Token = "0x400AF03")]
	[FieldOffset(Offset = "0x28")]
	public SelectionButton m_ImageCardButton;

	[Token(Token = "0x400AF04")]
	[FieldOffset(Offset = "0x30")]
	public Image m_ImageNoCard;

	[Token(Token = "0x400AF05")]
	[FieldOffset(Offset = "0x38")]
	public Image m_ImageRentalCard;

	[Token(Token = "0x400AF06")]
	[FieldOffset(Offset = "0x40")]
	public Image m_ImageAutoBuildCard;

	[Token(Token = "0x400AF07")]
	[FieldOffset(Offset = "0x48")]
	protected RawImage m_CardImage;

	[Token(Token = "0x400AF09")]
	[FieldOffset(Offset = "0x70")]
	protected UnityAction m_OnClickAction;

	[Token(Token = "0x400AF0A")]
	[FieldOffset(Offset = "0x78")]
	protected UnityAction m_OnSelectedAction;

	[Token(Token = "0x400AF0B")]
	[FieldOffset(Offset = "0x80")]
	protected UnityAction m_OnDeselectedAction;

	[Token(Token = "0x400AF0C")]
	[FieldOffset(Offset = "0x88")]
	protected UnityAction<bool> m_OnRightClickAction;

	[Token(Token = "0x400AF0D")]
	[FieldOffset(Offset = "0x90")]
	protected UnityAction m_SelectedKeyL2Action;

	[Token(Token = "0x400AF0E")]
	[FieldOffset(Offset = "0x98")]
	protected UnityAction<Vector2> m_DragBeginAction;

	[Token(Token = "0x400AF0F")]
	[FieldOffset(Offset = "0xA0")]
	protected UnityAction<Vector2> m_DragAction;

	[Token(Token = "0x400AF10")]
	[FieldOffset(Offset = "0xA8")]
	protected UnityAction<Vector2> m_DragEndAction;

	[Token(Token = "0x400AF11")]
	[FieldOffset(Offset = "0xB0")]
	private bool isIni;

	[Token(Token = "0x17000FC5")]
	public CardBaseData m_BaseData
	{
		[Token(Token = "0x60063FA")]
		[Address(RVA = "0xAA15D0", Offset = "0xAA07D0", VA = "0x180AA15D0")]
		[CompilerGenerated]
		get
		{
			return default(CardBaseData);
		}
		[Token(Token = "0x60063FB")]
		[Address(RVA = "0xAA15F0", Offset = "0xAA07F0", VA = "0x180AA15F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60063FC")]
	[Address(RVA = "0xAA0C50", Offset = "0xA9FE50", VA = "0x180AA0C50")]
	protected void InitializeElemnts()
	{
	}

	[Token(Token = "0x60063FD")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void Awake()
	{
	}

	[Token(Token = "0x60063FE")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void Start()
	{
	}

	[Token(Token = "0x60063FF")]
	[Address(RVA = "0xAA1080", Offset = "0xAA0280", VA = "0x180AA1080", Slot = "4")]
	public virtual void SetData(CardBaseData data, int regulationID = -1)
	{
	}

	[Token(Token = "0x6006400")]
	[Address(RVA = "0xAA0FF0", Offset = "0xAA01F0", VA = "0x180AA0FF0")]
	public void SetCardImage(Texture image)
	{
	}

	[Token(Token = "0x6006401")]
	[Address(RVA = "0xAA0F40", Offset = "0xAA0140", VA = "0x180AA0F40")]
	public void SetCardImageMaterial(Material mat)
	{
	}

	[Token(Token = "0x6006402")]
	[Address(RVA = "0xAA1450", Offset = "0xAA0650", VA = "0x180AA1450")]
	public void SetMonochrome(bool b)
	{
	}

	[Token(Token = "0x6006403")]
	[Address(RVA = "0xAA0ED0", Offset = "0xAA00D0", VA = "0x180AA0ED0")]
	public void SetAutoBuildImage(bool b)
	{
	}

	[Token(Token = "0x6006404")]
	[Address(RVA = "0xAA1510", Offset = "0xAA0710", VA = "0x180AA1510")]
	public void SetRentalImage(bool b)
	{
	}

	[Token(Token = "0x6006405")]
	[Address(RVA = "0xAA1550", Offset = "0xAA0750", VA = "0x180AA1550")]
	public void UnsetCardImagTexture()
	{
	}

	[Token(Token = "0x6006406")]
	[Address(RVA = "0xAA13B0", Offset = "0xAA05B0", VA = "0x180AA13B0")]
	public void SetDisp(bool disp)
	{
	}

	[Token(Token = "0x6006407")]
	[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
	public void SetOnSelectedCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6006408")]
	[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
	public void SetOnDeselectedCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6006409")]
	[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
	public void SetOnClickCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x600640A")]
	[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
	public void SetOnRightClickCallback(UnityAction<bool> callback)
	{
	}

	[Token(Token = "0x600640B")]
	[Address(RVA = "0x4989A0", Offset = "0x497BA0", VA = "0x1804989A0")]
	public void SetOnSelectedKeyL2Callback(UnityAction callback)
	{
	}

	[Token(Token = "0x600640C")]
	[Address(RVA = "0x42FFD0", Offset = "0x42F1D0", VA = "0x18042FFD0")]
	public void SetDragBeginCallback(UnityAction<Vector2> callback)
	{
	}

	[Token(Token = "0x600640D")]
	[Address(RVA = "0x42FF10", Offset = "0x42F110", VA = "0x18042FF10")]
	public void SetDragCallback(UnityAction<Vector2> callback)
	{
	}

	[Token(Token = "0x600640E")]
	[Address(RVA = "0x42FF30", Offset = "0x42F130", VA = "0x18042FF30")]
	public void SetDragEndCallback(UnityAction<Vector2> callback)
	{
	}

	[Token(Token = "0x600640F")]
	[Address(RVA = "0xAA0E40", Offset = "0xAA0040", VA = "0x180AA0E40")]
	public void InvokeDragBeginCallback(Vector2 screenPoint)
	{
	}

	[Token(Token = "0x6006410")]
	[Address(RVA = "0xAA0E70", Offset = "0xAA0070", VA = "0x180AA0E70")]
	public void InvokeDragCallback(Vector2 screenPoint)
	{
	}

	[Token(Token = "0x6006411")]
	[Address(RVA = "0xAA0EA0", Offset = "0xAA00A0", VA = "0x180AA0EA0")]
	public void InvokeDragEndCallback(Vector2 screenPoint)
	{
	}

	[Token(Token = "0x6006412")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public CardBase()
	{
	}
}
