using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004B5")]
[Obsolete("BaseUxmlFactory<TCreatedType, TTraits> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
public abstract class BaseUxmlFactory<TCreatedType, TTraits> where TCreatedType : new() where TTraits : BaseUxmlTraits, new()
{
	[Token(Token = "0x4000F61")]
	[FieldOffset(Offset = "0x0")]
	internal TTraits m_Traits;

	[Token(Token = "0x17000925")]
	public virtual string uxmlName
	{
		[Token(Token = "0x60022AB")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000926")]
	public virtual string uxmlNamespace
	{
		[Token(Token = "0x60022AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000927")]
	public virtual string uxmlQualifiedName
	{
		[Token(Token = "0x60022AD")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000928")]
	public virtual Type uxmlType
	{
		[Token(Token = "0x60022AE")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60022AA")]
	protected BaseUxmlFactory()
	{
	}

	[Token(Token = "0x60022AF")]
	public virtual bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc)
	{
		return default(bool);
	}
}
