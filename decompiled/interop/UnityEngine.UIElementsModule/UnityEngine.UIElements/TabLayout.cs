using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000151")]
internal class TabLayout
{
	[Token(Token = "0x40006AE")]
	[FieldOffset(Offset = "0x10")]
	private TabView m_TabView;

	[Token(Token = "0x40006AF")]
	[FieldOffset(Offset = "0x18")]
	private List<VisualElement> m_TabHeaders;

	[Token(Token = "0x40006B0")]
	[FieldOffset(Offset = "0x20")]
	private bool m_IsVertical;

	[Token(Token = "0x6000A37")]
	[Address(RVA = "0x2AFF480", Offset = "0x2AFE680", VA = "0x182AFF480")]
	public TabLayout(TabView tabView, bool isVertical)
	{
	}

	[Token(Token = "0x6000A38")]
	[Address(RVA = "0x2AFF1C0", Offset = "0x2AFE3C0", VA = "0x182AFF1C0")]
	public static float GetHeight(VisualElement t)
	{
		return default(float);
	}

	[Token(Token = "0x6000A39")]
	[Address(RVA = "0x2AFF320", Offset = "0x2AFE520", VA = "0x182AFF320")]
	public static float GetWidth(VisualElement t)
	{
		return default(float);
	}

	[Token(Token = "0x6000A3A")]
	[Address(RVA = "0x2AFF1F0", Offset = "0x2AFE3F0", VA = "0x182AFF1F0")]
	public float GetTabOffset(VisualElement tab)
	{
		return default(float);
	}

	[Token(Token = "0x6000A3B")]
	[Address(RVA = "0x2AFF350", Offset = "0x2AFE550", VA = "0x182AFF350")]
	private void InitOrderTabs()
	{
	}

	[Token(Token = "0x6000A3C")]
	[Address(RVA = "0x2AFF3D0", Offset = "0x2AFE5D0", VA = "0x182AFF3D0")]
	public void ReorderDisplay(int from, int to)
	{
	}
}
