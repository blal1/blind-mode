using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace UnityEngine.UIElements;

[Token(Token = "0x200023A")]
internal class PropagationPaths : IDisposable
{
	[Token(Token = "0x40008E7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly ObjectPool<PropagationPaths> s_Pool;

	[Token(Token = "0x40008E8")]
	[FieldOffset(Offset = "0x10")]
	public readonly List<VisualElement> trickleDownPath;

	[Token(Token = "0x40008E9")]
	[FieldOffset(Offset = "0x18")]
	public readonly List<VisualElement> bubbleUpPath;

	[Token(Token = "0x6000FA6")]
	[Address(RVA = "0x2B3A4B0", Offset = "0x2B396B0", VA = "0x182B3A4B0")]
	public PropagationPaths()
	{
	}

	[Token(Token = "0x6000FA7")]
	[Address(RVA = "0x2B3A0D0", Offset = "0x2B392D0", VA = "0x182B3A0D0")]
	[NotNull]
	public static PropagationPaths Build(VisualElement elem, EventBase evt, int eventCategories)
	{
		return null;
	}

	[Token(Token = "0x6000FA8")]
	[Address(RVA = "0x2B3A2C0", Offset = "0x2B394C0", VA = "0x182B3A2C0", Slot = "4")]
	public void Dispose()
	{
	}
}
