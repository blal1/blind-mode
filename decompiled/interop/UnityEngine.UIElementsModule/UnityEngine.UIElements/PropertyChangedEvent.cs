using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004E3")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class PropertyChangedEvent : EventBase<PropertyChangedEvent>
{
	[Token(Token = "0x17000958")]
	public BindingId property
	{
		[Token(Token = "0x6002386")]
		[Address(RVA = "0x2A320D0", Offset = "0x2A312D0", VA = "0x182A320D0")]
		[CompilerGenerated]
		get
		{
			return default(BindingId);
		}
		[Token(Token = "0x6002387")]
		[Address(RVA = "0x2A32150", Offset = "0x2A31350", VA = "0x182A32150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6002385")]
	[Address(RVA = "0x2A31F70", Offset = "0x2A31170", VA = "0x182A31F70")]
	static PropertyChangedEvent()
	{
	}

	[Token(Token = "0x6002388")]
	[Address(RVA = "0x2A32050", Offset = "0x2A31250", VA = "0x182A32050")]
	public PropertyChangedEvent()
	{
	}

	[Token(Token = "0x6002389")]
	[Address(RVA = "0x2A31E50", Offset = "0x2A31050", VA = "0x182A31E50")]
	public static PropertyChangedEvent GetPooled(in BindingId property)
	{
		return null;
	}
}
