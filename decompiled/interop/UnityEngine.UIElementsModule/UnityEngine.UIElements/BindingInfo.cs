using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x200003C")]
public readonly struct BindingInfo
{
	[Token(Token = "0x1700003C")]
	public Binding binding
	{
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x29766D0", Offset = "0x29758D0", VA = "0x1829766D0")]
	private BindingInfo(VisualElement targetElement, in BindingId bindingId, Binding binding)
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x2976470", Offset = "0x2975670", VA = "0x182976470")]
	internal static BindingInfo FromRequest(VisualElement target, in PropertyPath targetPath, Binding binding)
	{
		return default(BindingInfo);
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x2976360", Offset = "0x2975560", VA = "0x182976360")]
	internal static BindingInfo FromBindingData(in DataBindingManager.BindingData bindingData)
	{
		return default(BindingInfo);
	}
}
