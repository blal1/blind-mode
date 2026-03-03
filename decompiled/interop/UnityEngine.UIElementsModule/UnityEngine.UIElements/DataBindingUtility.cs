using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Pool;
using UnityEngine.UIElements.Internal;

namespace UnityEngine.UIElements;

[Token(Token = "0x200003E")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal static class DataBindingUtility
{
	[Token(Token = "0x400013C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly UnityEngine.Pool.ObjectPool<TypePathVisitor> k_TypeVisitors;

	[Token(Token = "0x400013D")]
	[FieldOffset(Offset = "0x8")]
	private static readonly UnityEngine.Pool.ObjectPool<AutoCompletePathVisitor> k_AutoCompleteVisitors;

	[Token(Token = "0x400013E")]
	[FieldOffset(Offset = "0x10")]
	private static readonly Regex s_ReplaceIndices;

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x2991050", Offset = "0x2990250", VA = "0x182991050")]
	public static bool TryGetBinding(VisualElement element, in BindingId bindingId, out BindingInfo bindingInfo)
	{
		return default(bool);
	}
}
