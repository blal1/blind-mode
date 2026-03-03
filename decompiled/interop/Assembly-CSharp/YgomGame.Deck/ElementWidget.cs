using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Deck;

[Token(Token = "0x2001066")]
public abstract class ElementWidget : MonoBehaviour
{
	[Token(Token = "0x400AEF4")]
	[FieldOffset(Offset = "0x20")]
	protected ElementObjectManager m_Eom;

	[Token(Token = "0x400AEF5")]
	[FieldOffset(Offset = "0x28")]
	protected bool isInitialized;

	[Token(Token = "0x17000FBC")]
	public bool isIni
	{
		[Token(Token = "0x60063DF")]
		[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60063E0")]
	[Address(RVA = "0xAAE950", Offset = "0xAADB50", VA = "0x180AAE950")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60063E1")]
	[Address(RVA = "0xAAE940", Offset = "0xAADB40", VA = "0x180AAE940")]
	private void Awake()
	{
	}

	[Token(Token = "0x60063E2")]
	protected abstract void InitializeElements();

	[Token(Token = "0x60063E3")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	protected ElementWidget()
	{
	}
}
