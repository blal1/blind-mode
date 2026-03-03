using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x2000476")]
public class ColorContainerImage : ColorContainerGraphic
{
	[Token(Token = "0x40015DB")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private Sprite _spriteUnselected;

	[Token(Token = "0x40015DC")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private Sprite _spriteSelected;

	[Token(Token = "0x40015DD")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private Sprite _spriteButtonDown;

	[Token(Token = "0x40015DE")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	private Sprite _spriteButtonEnter;

	[Token(Token = "0x40015DF")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private Sprite _spriteInactive;

	[Token(Token = "0x40015E0")]
	[FieldOffset(Offset = "0x118")]
	private Image _targetImage;

	[Token(Token = "0x170002C9")]
	public Sprite spriteUnselected
	{
		[Token(Token = "0x6001CC4")]
		[Address(RVA = "0x5961D0", Offset = "0x5953D0", VA = "0x1805961D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001CC5")]
		[Address(RVA = "0x5FC6E0", Offset = "0x5FB8E0", VA = "0x1805FC6E0")]
		set
		{
		}
	}

	[Token(Token = "0x170002CA")]
	public Sprite spriteSelected
	{
		[Token(Token = "0x6001CC6")]
		[Address(RVA = "0x596200", Offset = "0x595400", VA = "0x180596200")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001CC7")]
		[Address(RVA = "0x5FC6C0", Offset = "0x5FB8C0", VA = "0x1805FC6C0")]
		set
		{
		}
	}

	[Token(Token = "0x170002CB")]
	public Sprite spriteButtonDown
	{
		[Token(Token = "0x6001CC8")]
		[Address(RVA = "0x5FC5E0", Offset = "0x5FB7E0", VA = "0x1805FC5E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001CC9")]
		[Address(RVA = "0x5968C0", Offset = "0x595AC0", VA = "0x1805968C0")]
		set
		{
		}
	}

	[Token(Token = "0x170002CC")]
	public Sprite spriteButtonEnter
	{
		[Token(Token = "0x6001CCA")]
		[Address(RVA = "0x5FC5F0", Offset = "0x5FB7F0", VA = "0x1805FC5F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001CCB")]
		[Address(RVA = "0x5FC6A0", Offset = "0x5FB8A0", VA = "0x1805FC6A0")]
		set
		{
		}
	}

	[Token(Token = "0x170002CD")]
	public Sprite spriteInactive
	{
		[Token(Token = "0x6001CCC")]
		[Address(RVA = "0x3DA790", Offset = "0x3D9990", VA = "0x1803DA790")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001CCD")]
		[Address(RVA = "0x3DA7A0", Offset = "0x3D99A0", VA = "0x1803DA7A0")]
		set
		{
		}
	}

	[Token(Token = "0x170002CE")]
	public Image targetImage
	{
		[Token(Token = "0x6001CCE")]
		[Address(RVA = "0x5FC600", Offset = "0x5FB800", VA = "0x1805FC600")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001CCF")]
	[Address(RVA = "0x5FC4C0", Offset = "0x5FB6C0", VA = "0x1805FC4C0", Slot = "4")]
	public override void SetColor(SelectMode select_mode, StatusMode status_mode, bool is_active = true)
	{
	}

	[Token(Token = "0x6001CD0")]
	[Address(RVA = "0x5FB770", Offset = "0x5FA970", VA = "0x1805FB770")]
	public ColorContainerImage()
	{
	}
}
