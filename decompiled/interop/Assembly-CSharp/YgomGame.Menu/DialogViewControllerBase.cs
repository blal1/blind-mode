using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Menu;

[Token(Token = "0x2001252")]
public abstract class DialogViewControllerBase : BaseMenuViewController
{
	[Token(Token = "0x400BB23")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private ElementObjectManager m_UIPrefab;

	[Token(Token = "0x400BB24")]
	[FieldOffset(Offset = "0xD8")]
	protected ElementObjectManager m_UI;

	[Token(Token = "0x17001205")]
	protected virtual int selectorPriority
	{
		[Token(Token = "0x600723C")]
		[Address(RVA = "0xB89A70", Offset = "0xB88C70", VA = "0x180B89A70", Slot = "28")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600723D")]
	[Address(RVA = "0xB89920", Offset = "0xB88B20", VA = "0x180B89920", Slot = "29")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x600723E")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	protected DialogViewControllerBase()
	{
	}
}
