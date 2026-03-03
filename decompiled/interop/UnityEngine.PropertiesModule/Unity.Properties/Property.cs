using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Properties.Internal;

namespace Unity.Properties;

[Token(Token = "0x2000018")]
public abstract class Property<TContainer, TValue> : IProperty<TContainer>, IProperty, IPropertyAccept<TContainer>, IAttributes
{
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x0")]
	private List<Attribute> m_Attributes;

	[Token(Token = "0x17000009")]
	private List<Attribute> Unity_002EProperties_002EInternal_002EIAttributes_002EAttributes
	{
		[Token(Token = "0x6000031")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000032")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public abstract string Name
	{
		[Token(Token = "0x6000033")]
		get;
	}

	[Token(Token = "0x1700000B")]
	public abstract bool IsReadOnly
	{
		[Token(Token = "0x6000034")]
		get;
	}

	[Token(Token = "0x6000035")]
	public Type DeclaredValueType()
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	public void Accept(IPropertyVisitor visitor, ref TContainer container)
	{
	}

	[Token(Token = "0x6000037")]
	public abstract TValue GetValue(ref TContainer container);

	[Token(Token = "0x6000038")]
	public abstract void SetValue(ref TContainer container, TValue value);

	[Token(Token = "0x6000039")]
	protected void AddAttribute(Attribute attribute)
	{
	}

	[Token(Token = "0x600003A")]
	protected void AddAttributes(IEnumerable<Attribute> attributes)
	{
	}

	[Token(Token = "0x600003B")]
	private void Unity_002EProperties_002EInternal_002EIAttributes_002EAddAttribute(Attribute attribute)
	{
	}

	[Token(Token = "0x600003C")]
	private void Unity_002EProperties_002EInternal_002EIAttributes_002EAddAttributes(IEnumerable<Attribute> attributes)
	{
	}

	[Token(Token = "0x600003D")]
	public bool HasAttribute<TAttribute>() where TAttribute : Attribute
	{
		return default(bool);
	}

	[Token(Token = "0x600003E")]
	public TAttribute GetAttribute<TAttribute>() where TAttribute : Attribute
	{
		return null;
	}

	[Token(Token = "0x600003F")]
	private AttributesScope Unity_002EProperties_002EInternal_002EIAttributes_002ECreateAttributesScope(IAttributes attributes)
	{
		return default(AttributesScope);
	}

	[Token(Token = "0x6000040")]
	protected Property()
	{
	}
}
