using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x200044D")]
[UxmlElement("Instance")]
[HideInInspector]
public class TemplateContainer : BindableElement
{
	[Token(Token = "0x200044E")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<TemplateContainer, UxmlTraits>
	{
		[Token(Token = "0x17000892")]
		public override string uxmlName
		{
			[Token(Token = "0x6001FE4")]
			[Address(RVA = "0x2A07320", Offset = "0x2A06520", VA = "0x182A07320", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000893")]
		public override string uxmlQualifiedName
		{
			[Token(Token = "0x6001FE5")]
			[Address(RVA = "0x2A07350", Offset = "0x2A06550", VA = "0x182A07350", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001FE6")]
		[Address(RVA = "0x2A072E0", Offset = "0x2A064E0", VA = "0x182A072E0")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x200044F")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BindableElement.UxmlTraits
	{
		[Token(Token = "0x4000E2A")]
		[FieldOffset(Offset = "0x90")]
		private UxmlStringAttributeDescription m_Template;

		[Token(Token = "0x6001FE7")]
		[Address(RVA = "0x2A073D0", Offset = "0x2A065D0", VA = "0x182A073D0", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x6001FE8")]
		[Address(RVA = "0x2A07900", Offset = "0x2A06B00", VA = "0x182A07900")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x4000E25")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId templateIdProperty;

	[Token(Token = "0x4000E26")]
	[FieldOffset(Offset = "0x98")]
	internal static readonly BindingId templateSourceProperty;

	[Token(Token = "0x4000E28")]
	[FieldOffset(Offset = "0x4C0")]
	private VisualElement m_ContentContainer;

	[Token(Token = "0x4000E29")]
	[FieldOffset(Offset = "0x4C8")]
	private VisualTreeAsset m_TemplateSource;

	[Token(Token = "0x1700088F")]
	[CreateProperty(ReadOnly = true)]
	public string templateId
	{
		[Token(Token = "0x6001FDA")]
		[Address(RVA = "0x29FCCC0", Offset = "0x29FBEC0", VA = "0x1829FCCC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001FDB")]
		[Address(RVA = "0x29FCCE0", Offset = "0x29FBEE0", VA = "0x1829FCCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000890")]
	[CreateProperty(ReadOnly = true)]
	public VisualTreeAsset templateSource
	{
		[Token(Token = "0x6001FDC")]
		[Address(RVA = "0x29FCCD0", Offset = "0x29FBED0", VA = "0x1829FCCD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001FDD")]
		[Address(RVA = "0x29FCD00", Offset = "0x29FBF00", VA = "0x1829FCD00")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000891")]
	public override VisualElement contentContainer
	{
		[Token(Token = "0x6001FE1")]
		[Address(RVA = "0x29FCCB0", Offset = "0x29FBEB0", VA = "0x1829FCCB0", Slot = "136")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001FDE")]
	[Address(RVA = "0x29FCBE0", Offset = "0x29FBDE0", VA = "0x1829FCBE0")]
	public TemplateContainer()
	{
	}

	[Token(Token = "0x6001FDF")]
	[Address(RVA = "0x29FCB70", Offset = "0x29FBD70", VA = "0x1829FCB70")]
	public TemplateContainer(string templateId)
	{
	}

	[Token(Token = "0x6001FE0")]
	[Address(RVA = "0x29FCC40", Offset = "0x29FBE40", VA = "0x1829FCC40")]
	internal TemplateContainer(string templateId, VisualTreeAsset templateSource)
	{
	}

	[Token(Token = "0x6001FE2")]
	[Address(RVA = "0x29FC960", Offset = "0x29FBB60", VA = "0x1829FC960")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal void SetContentContainer(VisualElement content)
	{
	}
}
