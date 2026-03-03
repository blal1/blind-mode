using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000482")]
public static class UQueryExtensions
{
	[Token(Token = "0x4000F19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static UQueryState<VisualElement> SingleElementEmptyQuery;

	[Token(Token = "0x4000F1A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static UQueryState<VisualElement> SingleElementNameQuery;

	[Token(Token = "0x4000F1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static UQueryState<VisualElement> SingleElementClassQuery;

	[Token(Token = "0x4000F1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static UQueryState<VisualElement> SingleElementNameAndClassQuery;

	[Token(Token = "0x4000F1D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static UQueryState<VisualElement> SingleElementTypeQuery;

	[Token(Token = "0x4000F1E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static UQueryState<VisualElement> SingleElementTypeAndNameQuery;

	[Token(Token = "0x4000F1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static UQueryState<VisualElement> SingleElementTypeAndClassQuery;

	[Token(Token = "0x4000F20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static UQueryState<VisualElement> SingleElementTypeAndNameAndClassQuery;

	[Token(Token = "0x600221A")]
	[Address(RVA = "0x2A1AB20", Offset = "0x2A19D20", VA = "0x182A1AB20")]
	public static VisualElement Q(this VisualElement e, [Optional] string name, params string[] classes)
	{
		return null;
	}

	[Token(Token = "0x600221B")]
	public static T Q<T>(this VisualElement e, [Optional] string name, [Optional] string className) where T : VisualElement
	{
		return null;
	}

	[Token(Token = "0x600221C")]
	[Address(RVA = "0x2A1A650", Offset = "0x2A19850", VA = "0x182A1A650")]
	public static VisualElement Q(this VisualElement e, [Optional] string name, [Optional] string className)
	{
		return null;
	}

	[Token(Token = "0x600221D")]
	public static UQueryBuilder<T> Query<T>(this VisualElement e, [Optional] string name, params string[] classes) where T : VisualElement
	{
		return default(UQueryBuilder<T>);
	}

	[Token(Token = "0x600221E")]
	public static UQueryBuilder<T> Query<T>(this VisualElement e, [Optional] string name, [Optional] string className) where T : VisualElement
	{
		return default(UQueryBuilder<T>);
	}
}
