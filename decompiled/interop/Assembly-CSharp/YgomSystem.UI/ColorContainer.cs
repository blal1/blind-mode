using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000470")]
public abstract class ColorContainer : MonoBehaviour
{
	[Token(Token = "0x2000471")]
	public enum SelectMode
	{
		[Token(Token = "0x40015CA")]
		Unselected,
		[Token(Token = "0x40015CB")]
		Selected
	}

	[Token(Token = "0x2000472")]
	public enum StatusMode
	{
		[Token(Token = "0x40015CD")]
		Normal,
		[Token(Token = "0x40015CE")]
		Down,
		[Token(Token = "0x40015CF")]
		Enter
	}

	[Token(Token = "0x2000473")]
	public enum ColorMode
	{
		[Token(Token = "0x40015D1")]
		Multiple,
		[Token(Token = "0x40015D2")]
		Override
	}

	[Token(Token = "0x40015AF")]
	[FieldOffset(Offset = "0x20")]
	public Color baseColor;

	[Token(Token = "0x40015B0")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Tooltip("親オブジェクトのColorContainerの設定を受け継ぐか")]
	protected bool inheritParentColorSetting;

	[Token(Token = "0x40015B1")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Tooltip("非選択状態で乗算する色")]
	private Color colorUnselected;

	[Token(Token = "0x40015B2")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Tooltip("選択状態で乗算する色")]
	private Color colorSelected;

	[Token(Token = "0x40015B3")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Tooltip("押下時に乗算する色")]
	private Color colorButtonDown;

	[Token(Token = "0x40015B4")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Tooltip("ハイライト時に乗算する色")]
	private Color colorButtonEnter;

	[Token(Token = "0x40015B5")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Tooltip("無効時に乗算する色")]
	private Color colorButtonInactive;

	[Token(Token = "0x40015B6")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[ColorLabelString]
	private string colorLabelUnselected;

	[Token(Token = "0x40015B7")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[ColorLabelString]
	private string colorLabelSelected;

	[Token(Token = "0x40015B8")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[ColorLabelString]
	private string colorLabelButtonDown;

	[Token(Token = "0x40015B9")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[ColorLabelString]
	private string colorLabelButtonEnter;

	[Token(Token = "0x40015BA")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[ColorLabelString]
	private string colorLabelButtonInactive;

	[Token(Token = "0x40015BB")]
	[FieldOffset(Offset = "0xB0")]
	public int index;

	[Token(Token = "0x40015BC")]
	[FieldOffset(Offset = "0xB4")]
	[SerializeField]
	protected ColorMode colorModeUnselected;

	[Token(Token = "0x40015BD")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	protected ColorMode colorModeSelected;

	[Token(Token = "0x40015BE")]
	[FieldOffset(Offset = "0xBC")]
	[SerializeField]
	protected ColorMode colorModeButtonDown;

	[Token(Token = "0x40015BF")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	protected ColorMode colorModeButtonEnter;

	[Token(Token = "0x40015C0")]
	[FieldOffset(Offset = "0xC4")]
	[SerializeField]
	protected ColorMode colorModeButtonInactive;

	[Token(Token = "0x40015C1")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	protected float intensityUnselected;

	[Token(Token = "0x40015C2")]
	[FieldOffset(Offset = "0xCC")]
	[SerializeField]
	protected float intensitySelected;

	[Token(Token = "0x40015C3")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	protected float intensityButtonDown;

	[Token(Token = "0x40015C4")]
	[FieldOffset(Offset = "0xD4")]
	[SerializeField]
	protected float intensityButtonEnter;

	[Token(Token = "0x40015C5")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	protected float intensityButtonInactive;

	[Token(Token = "0x40015C6")]
	[FieldOffset(Offset = "0xDC")]
	private SelectMode currentSelectMode;

	[Token(Token = "0x40015C7")]
	[FieldOffset(Offset = "0xE0")]
	private StatusMode currentStatusMode;

	[Token(Token = "0x40015C8")]
	[FieldOffset(Offset = "0xE4")]
	private bool currentIsActive;

	[Token(Token = "0x6001CAB")]
	[Address(RVA = "0x5FD710", Offset = "0x5FC910", VA = "0x1805FD710")]
	protected Color GetColorUnselected()
	{
		return default(Color);
	}

	[Token(Token = "0x6001CAC")]
	[Address(RVA = "0x5FD690", Offset = "0x5FC890", VA = "0x1805FD690")]
	protected Color GetColorSelected()
	{
		return default(Color);
	}

	[Token(Token = "0x6001CAD")]
	[Address(RVA = "0x5FD510", Offset = "0x5FC710", VA = "0x1805FD510")]
	protected Color GetColorButtonDown()
	{
		return default(Color);
	}

	[Token(Token = "0x6001CAE")]
	[Address(RVA = "0x5FD590", Offset = "0x5FC790", VA = "0x1805FD590")]
	protected Color GetColorButtonEnter()
	{
		return default(Color);
	}

	[Token(Token = "0x6001CAF")]
	[Address(RVA = "0x5FD610", Offset = "0x5FC810", VA = "0x1805FD610")]
	protected Color GetColorButtonInactive()
	{
		return default(Color);
	}

	[Token(Token = "0x6001CB0")]
	[Address(RVA = "0x5FD3B0", Offset = "0x5FC5B0", VA = "0x1805FD3B0")]
	public void CopyToSettings(ColorContainer dst)
	{
	}

	[Token(Token = "0x6001CB1")]
	[Address(RVA = "0x5FD7D0", Offset = "0x5FC9D0", VA = "0x1805FD7D0", Slot = "4")]
	public virtual void SetColor(SelectMode select_mode, StatusMode status_mode, bool is_active = true)
	{
	}

	[Token(Token = "0x6001CB2")]
	[Address(RVA = "0x5FD790", Offset = "0x5FC990", VA = "0x1805FD790")]
	public void Reapply()
	{
	}

	[Token(Token = "0x6001CB3")]
	[Address(RVA = "0x5FD7F0", Offset = "0x5FC9F0", VA = "0x1805FD7F0")]
	protected ColorContainer()
	{
	}
}
