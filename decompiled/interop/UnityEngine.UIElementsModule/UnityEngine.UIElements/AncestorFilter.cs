using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000179")]
internal class AncestorFilter
{
	[Token(Token = "0x4000743")]
	[FieldOffset(Offset = "0x10")]
	private CountingBloomFilter m_CountingBloomFilter;

	[Token(Token = "0x4000744")]
	[FieldOffset(Offset = "0x4010")]
	private Stack<int> m_HashStack;

	[Token(Token = "0x6000B39")]
	[Address(RVA = "0x2AF3A60", Offset = "0x2AF2C60", VA = "0x182AF3A60")]
	public AncestorFilter()
	{
	}

	[Token(Token = "0x6000B3A")]
	[Address(RVA = "0x2AF3680", Offset = "0x2AF2880", VA = "0x182AF3680")]
	private void AddHash(int hash)
	{
	}

	[Token(Token = "0x6000B3B")]
	[Address(RVA = "0x2AF3700", Offset = "0x2AF2900", VA = "0x182AF3700")]
	public bool IsCandidate(StyleComplexSelector complexSel)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B3C")]
	[Address(RVA = "0x2AF3850", Offset = "0x2AF2A50", VA = "0x182AF3850")]
	public void PushElement(VisualElement element)
	{
	}

	[Token(Token = "0x6000B3D")]
	[Address(RVA = "0x2AF3770", Offset = "0x2AF2970", VA = "0x182AF3770")]
	public void PopElement()
	{
	}
}
