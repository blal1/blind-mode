using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Menu;

[Token(Token = "0x200115E")]
public class QRCodeCreator : MonoBehaviour
{
	[Token(Token = "0x400B686")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ElabelQRCodeImage;

	[Token(Token = "0x400B687")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ElabelTextURL;

	[Token(Token = "0x400B688")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ElabelURLButton;

	[Token(Token = "0x400B689")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private string clientWorkPath;

	[Token(Token = "0x400B68A")]
	[FieldOffset(Offset = "0x40")]
	private ElementObjectManager m_RootEom;

	[Token(Token = "0x400B68B")]
	[FieldOffset(Offset = "0x48")]
	private RawImage m_QRCodeImage;

	[Token(Token = "0x400B68C")]
	[FieldOffset(Offset = "0x50")]
	private TextMeshProUGUI m_TextURL;

	[Token(Token = "0x400B68D")]
	[FieldOffset(Offset = "0x58")]
	private Button m_URLButton;

	[Token(Token = "0x6006CE5")]
	[Address(RVA = "0xB50260", Offset = "0xB4F460", VA = "0x180B50260")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006CE6")]
	[Address(RVA = "0xB50640", Offset = "0xB4F840", VA = "0x180B50640")]
	public QRCodeCreator()
	{
	}
}
