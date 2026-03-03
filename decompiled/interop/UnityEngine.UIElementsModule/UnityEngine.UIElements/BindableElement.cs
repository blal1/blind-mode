using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000018")]
public class BindableElement : VisualElement, IBindable
{
	[Token(Token = "0x2000019")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<BindableElement, UxmlTraits>
	{
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2999460", Offset = "0x2998660", VA = "0x182999460")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x200001A")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : VisualElement.UxmlTraits
	{
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x88")]
		private UxmlStringAttributeDescription m_PropertyPath;

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2999640", Offset = "0x2998840", VA = "0x182999640")]
		public UxmlTraits()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x29994A0", Offset = "0x29986A0", VA = "0x1829994A0", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	[Token(Token = "0x400002D")]
	internal const string k_BindingPathTooltip = "Default method to define a path to a serialized property. Most often used for Editor extensions and inspectors.";

	[Token(Token = "0x17000019")]
	public IBinding binding
	{
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x154C3B0", Offset = "0x154B5B0", VA = "0x18154C3B0", Slot = "137")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001A")]
	public string bindingPath
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x29755F0", Offset = "0x29747F0", VA = "0x1829755F0", Slot = "138")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x29755A0", Offset = "0x29747A0", VA = "0x1829755A0")]
	public BindableElement()
	{
	}
}
