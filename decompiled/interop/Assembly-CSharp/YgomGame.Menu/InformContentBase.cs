using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu;

[Token(Token = "0x20011A3")]
public abstract class InformContentBase : MonoBehaviour
{
	[Token(Token = "0x400B853")]
	[FieldOffset(Offset = "0x20")]
	public Dictionary<string, object> Args;

	[Token(Token = "0x400B854")]
	[FieldOffset(Offset = "0x28")]
	public int selectorPriority;

	[Token(Token = "0x6006EBC")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
	public virtual void OnPush()
	{
	}

	[Token(Token = "0x6006EBD")]
	[Address(RVA = "0xB5FCE0", Offset = "0xB5EEE0", VA = "0x180B5FCE0")]
	protected InformContentBase()
	{
	}
}
