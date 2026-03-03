using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Lottery;

[Token(Token = "0x20016DB")]
public abstract class ElementWidget : MonoBehaviour
{
	[Token(Token = "0x400D8E7")]
	[FieldOffset(Offset = "0x20")]
	protected ElementObjectManager m_Eom;

	[Token(Token = "0x400D8E8")]
	[FieldOffset(Offset = "0x28")]
	protected bool isInitialized;

	[Token(Token = "0x17001593")]
	public bool isIni
	{
		[Token(Token = "0x6008E31")]
		[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6008E32")]
	[Address(RVA = "0xD918B0", Offset = "0xD90AB0", VA = "0x180D918B0")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6008E33")]
	[Address(RVA = "0xD918B0", Offset = "0xD90AB0", VA = "0x180D918B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6008E34")]
	protected abstract void InitializeElements();

	[Token(Token = "0x6008E35")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	protected ElementWidget()
	{
	}
}
