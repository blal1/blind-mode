using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem;

[Token(Token = "0x200015C")]
public class EventSystemCreator : MonoBehaviour
{
	[Token(Token = "0x4000830")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected GameObject m_InputSystemUIInputModule;

	[Token(Token = "0x4000831")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected GameObject m_InputSystemUIInputModule_iOS;

	[Token(Token = "0x4000832")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected GameObject m_StandaloneInputModule;

	[Token(Token = "0x60008A3")]
	[Address(RVA = "0xAF4310", Offset = "0xAF3510", VA = "0x180AF4310")]
	private void Awake()
	{
	}

	[Token(Token = "0x60008A4")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public EventSystemCreator()
	{
	}
}
