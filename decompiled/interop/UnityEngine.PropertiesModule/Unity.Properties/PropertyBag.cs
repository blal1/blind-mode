using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties.Internal;

namespace Unity.Properties;

[Token(Token = "0x2000040")]
public static class PropertyBag
{
	[Token(Token = "0x60000EF")]
	public static void AcceptWithSpecializedVisitor<TContainer>(IPropertyBag<TContainer> properties, IPropertyBagVisitor visitor, ref TContainer container)
	{
	}

	[Token(Token = "0x60000F0")]
	public static void Register<TContainer>(PropertyBag<TContainer> propertyBag)
	{
	}

	[Token(Token = "0x60000F1")]
	public static void RegisterList<TElement>()
	{
	}

	[Token(Token = "0x60000F2")]
	public static void RegisterList<TContainer, TElement>()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x28F1940", Offset = "0x28F0B40", VA = "0x1828F1940")]
	public static IPropertyBag GetPropertyBag(Type type)
	{
		return null;
	}

	[Token(Token = "0x60000F4")]
	public static IPropertyBag<TContainer> GetPropertyBag<TContainer>()
	{
		return null;
	}

	[Token(Token = "0x60000F5")]
	public static bool TryGetPropertyBagForValue<TValue>(ref TValue value, out IPropertyBag propertyBag)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000041")]
public abstract class PropertyBag<TContainer> : IPropertyBag<TContainer>, IPropertyBag, IPropertyBagRegister, IConstructor<TContainer>, IConstructor
{
	[Token(Token = "0x17000031")]
	private InstantiationKind Unity_002EProperties_002EIConstructor_002EInstantiationKind
	{
		[Token(Token = "0x60000FD")]
		get
		{
			return default(InstantiationKind);
		}
	}

	[Token(Token = "0x17000032")]
	protected virtual InstantiationKind InstantiationKind
	{
		[Token(Token = "0x6000101")]
		[CompilerGenerated]
		get
		{
			return default(InstantiationKind);
		}
	}

	[Token(Token = "0x60000F6")]
	static PropertyBag()
	{
	}

	[Token(Token = "0x60000F7")]
	private void Unity_002EProperties_002EInternal_002EIPropertyBagRegister_002ERegister()
	{
	}

	[Token(Token = "0x60000F8")]
	public void Accept(ITypeVisitor visitor)
	{
	}

	[Token(Token = "0x60000F9")]
	private void Unity_002EProperties_002EIPropertyBag_002EAccept(IPropertyBagVisitor visitor, ref object container)
	{
	}

	[Token(Token = "0x60000FA")]
	private void Unity_002EProperties_002EIPropertyBag_003CTContainer_003E_002EAccept(IPropertyBagVisitor visitor, ref TContainer container)
	{
	}

	[Token(Token = "0x60000FB")]
	private PropertyCollection<TContainer> Unity_002EProperties_002EIPropertyBag_003CTContainer_003E_002EGetProperties()
	{
		return default(PropertyCollection<TContainer>);
	}

	[Token(Token = "0x60000FC")]
	private PropertyCollection<TContainer> Unity_002EProperties_002EIPropertyBag_003CTContainer_003E_002EGetProperties(ref TContainer container)
	{
		return default(PropertyCollection<TContainer>);
	}

	[Token(Token = "0x60000FE")]
	private TContainer Unity_002EProperties_002EIConstructor_003CTContainer_003E_002EInstantiate()
	{
		return (TContainer)null;
	}

	[Token(Token = "0x60000FF")]
	public abstract PropertyCollection<TContainer> GetProperties();

	[Token(Token = "0x6000100")]
	public abstract PropertyCollection<TContainer> GetProperties(ref TContainer container);

	[Token(Token = "0x6000102")]
	protected virtual TContainer Instantiate()
	{
		return (TContainer)null;
	}

	[Token(Token = "0x6000103")]
	protected PropertyBag()
	{
	}
}
