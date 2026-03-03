using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000504")]
public abstract class TweenInvokerBase : MonoBehaviour
{
	[Token(Token = "0x40018B9")]
	[FieldOffset(Offset = "0x20")]
	public string label;

	[Token(Token = "0x40018BA")]
	[FieldOffset(Offset = "0x28")]
	public bool includeChildren;

	[Token(Token = "0x40018BB")]
	[FieldOffset(Offset = "0x29")]
	public bool wakeup;

	[Token(Token = "0x40018BC")]
	[FieldOffset(Offset = "0x2A")]
	public bool resetOnPlay;

	[Token(Token = "0x40018BD")]
	[FieldOffset(Offset = "0x2B")]
	public bool immediate;

	[Token(Token = "0x60020D9")]
	protected abstract bool IsInvokable();

	[Token(Token = "0x60020DA")]
	[Address(RVA = "0x63BBA0", Offset = "0x63ADA0", VA = "0x18063BBA0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60020DB")]
	[Address(RVA = "0x63BCD0", Offset = "0x63AED0", VA = "0x18063BCD0")]
	public void PlayTween()
	{
	}

	[Token(Token = "0x60020DC")]
	[Address(RVA = "0x633000", Offset = "0x632200", VA = "0x180633000")]
	protected TweenInvokerBase()
	{
	}
}
