using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x2000544")]
public class PlatformPlayerNameGroup : MonoBehaviour
{
	[Token(Token = "0x4001996")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_CurrentPlatformIconPath;

	[Token(Token = "0x4001997")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TMP_Text m_YmdPlayerNameText;

	[Token(Token = "0x4001998")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject m_PlatformNameRoot;

	[Token(Token = "0x4001999")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private TMP_Text m_PlatformPlayerNameText;

	[Token(Token = "0x400199A")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Image m_PlatformPlayerIcon;

	[Token(Token = "0x400199B")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool m_IsDispPcode;

	[Token(Token = "0x170003A0")]
	public GameObject PlatformNameRoot
	{
		[Token(Token = "0x6002243")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002244")]
	[Address(RVA = "0x64C750", Offset = "0x64B950", VA = "0x18064C750")]
	public void Set(string ymdPlayerName, string platformPlayerName, long pcode, bool isRegistedPlatform)
	{
	}

	[Token(Token = "0x6002245")]
	[Address(RVA = "0x64C5F0", Offset = "0x64B7F0", VA = "0x18064C5F0")]
	public string GetYmdPlayerName()
	{
		return null;
	}

	[Token(Token = "0x6002246")]
	[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
	public TMP_Text GetNameTMP()
	{
		return null;
	}

	[Token(Token = "0x6002247")]
	[Address(RVA = "0x64C690", Offset = "0x64B890", VA = "0x18064C690")]
	public void SetPcodeWCSFinal(long pcode)
	{
	}

	[Token(Token = "0x6002248")]
	[Address(RVA = "0x64CB60", Offset = "0x64BD60", VA = "0x18064CB60")]
	public PlatformPlayerNameGroup()
	{
	}
}
