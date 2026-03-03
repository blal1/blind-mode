using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements.Internal;

[Token(Token = "0x20005FB")]
internal class TypePathVisitor : ITypeVisitor, IPropertyBagVisitor, IPropertyVisitor
{
	[Token(Token = "0x40015FC")]
	[FieldOffset(Offset = "0xB0")]
	private Type m_LastType;

	[Token(Token = "0x40015FD")]
	[FieldOffset(Offset = "0xB8")]
	private int m_PathIndex;

	[Token(Token = "0x17000AC0")]
	public PropertyPath Path
	{
		[Token(Token = "0x60029A1")]
		[Address(RVA = "0x199E8A0", Offset = "0x199DAA0", VA = "0x18199E8A0")]
		[CompilerGenerated]
		get
		{
			return default(PropertyPath);
		}
		[Token(Token = "0x60029A2")]
		[Address(RVA = "0x2A90FB0", Offset = "0x2A901B0", VA = "0x182A90FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000AC1")]
	private Type resolvedType
	{
		[Token(Token = "0x60029A3")]
		[Address(RVA = "0x42FF10", Offset = "0x42F110", VA = "0x18042FF10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000AC2")]
	public VisitReturnCode ReturnCode
	{
		[Token(Token = "0x60029A4")]
		[Address(RVA = "0x42D5E0", Offset = "0x42C7E0", VA = "0x18042D5E0")]
		[CompilerGenerated]
		get
		{
			return default(VisitReturnCode);
		}
		[Token(Token = "0x60029A5")]
		[Address(RVA = "0x42D690", Offset = "0x42C890", VA = "0x18042D690")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x60029A6")]
	[Address(RVA = "0x2A90F20", Offset = "0x2A90120", VA = "0x182A90F20")]
	public void Reset()
	{
	}

	[Token(Token = "0x60029A7")]
	private void Unity_002EProperties_002EIPropertyBagVisitor_002EVisit<TContainer>(IPropertyBag<TContainer> properties, ref TContainer container)
	{
	}

	[Token(Token = "0x60029A8")]
	private void Unity_002EProperties_002EIPropertyVisitor_002EVisit<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container)
	{
	}

	[Token(Token = "0x60029A9")]
	private void Unity_002EProperties_002EITypeVisitor_002EVisit<TContainer>()
	{
	}

	[Token(Token = "0x60029AA")]
	[Address(RVA = "0x2A90E80", Offset = "0x2A90080", VA = "0x182A90E80")]
	private bool IsLastPartReached()
	{
		return default(bool);
	}

	[Token(Token = "0x60029AB")]
	[Address(RVA = "0x2A90CC0", Offset = "0x2A8FEC0", VA = "0x182A90CC0")]
	private static Type GetElementType(Type type)
	{
		return null;
	}

	[Token(Token = "0x60029AC")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public TypePathVisitor()
	{
	}
}
