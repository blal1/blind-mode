using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements.Internal;

[Token(Token = "0x20005F7")]
internal class AutoCompletePathVisitor : ITypeVisitor, IPropertyVisitor, IPropertyBagVisitor, IListPropertyVisitor
{
	[Token(Token = "0x20005F8")]
	private class VisitContext
	{
		[Token(Token = "0x17000ABC")]
		public List<PropertyPathInfo> propertyPathInfos
		{
			[Token(Token = "0x6002994")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002995")]
			[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000ABD")]
		public HashSet<Type> types
		{
			[Token(Token = "0x6002996")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ABE")]
		public PropertyPath current
		{
			[Token(Token = "0x6002997")]
			[Address(RVA = "0x2A914F0", Offset = "0x2A906F0", VA = "0x182A914F0")]
			[CompilerGenerated]
			get
			{
				return default(PropertyPath);
			}
			[Token(Token = "0x6002998")]
			[Address(RVA = "0x2A91550", Offset = "0x2A90750", VA = "0x182A91550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000ABF")]
		public int currentDepth
		{
			[Token(Token = "0x6002999")]
			[Address(RVA = "0x42D5D0", Offset = "0x42C7D0", VA = "0x18042D5D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600299A")]
			[Address(RVA = "0x42D680", Offset = "0x42C880", VA = "0x18042D680")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600299B")]
		[Address(RVA = "0x2A91470", Offset = "0x2A90670", VA = "0x182A91470")]
		public VisitContext()
		{
		}
	}

	[Token(Token = "0x20005F9")]
	private struct InspectedTypeScope<TContainer> : IDisposable
	{
		[Token(Token = "0x40015F7")]
		[FieldOffset(Offset = "0x0")]
		private VisitContext m_VisitContext;

		[Token(Token = "0x600299C")]
		public InspectedTypeScope(VisitContext context)
		{
		}

		[Token(Token = "0x600299D")]
		public void Dispose()
		{
		}
	}

	[Token(Token = "0x20005FA")]
	private struct VisitedPropertyScope : IDisposable
	{
		[Token(Token = "0x40015F8")]
		[FieldOffset(Offset = "0x0")]
		private VisitContext m_VisitContext;

		[Token(Token = "0x600299E")]
		[Address(RVA = "0x2A91A80", Offset = "0x2A90C80", VA = "0x182A91A80")]
		public VisitedPropertyScope(VisitContext context, IProperty property)
		{
		}

		[Token(Token = "0x600299F")]
		[Address(RVA = "0x2A91740", Offset = "0x2A90940", VA = "0x182A91740")]
		public VisitedPropertyScope(VisitContext context, int index, Type type)
		{
		}

		[Token(Token = "0x60029A0")]
		[Address(RVA = "0x2A915B0", Offset = "0x2A907B0", VA = "0x182A915B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Token(Token = "0x40015F1")]
	[FieldOffset(Offset = "0x10")]
	private VisitContext m_VisitContext;

	[Token(Token = "0x17000ABB")]
	public int maxDepth
	{
		[Token(Token = "0x600298B")]
		[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600298C")]
	[Address(RVA = "0x2A80660", Offset = "0x2A7F860", VA = "0x182A80660")]
	private bool HasReachedEnd(Type containerType)
	{
		return default(bool);
	}

	[Token(Token = "0x600298D")]
	[Address(RVA = "0x2A806E0", Offset = "0x2A7F8E0", VA = "0x182A806E0")]
	public void Reset()
	{
	}

	[Token(Token = "0x600298E")]
	private void Unity_002EProperties_002EITypeVisitor_002EVisit<TContainer>()
	{
	}

	[Token(Token = "0x600298F")]
	private void Unity_002EProperties_002EIPropertyBagVisitor_002EVisit<TContainer>(IPropertyBag<TContainer> properties, ref TContainer container)
	{
	}

	[Token(Token = "0x6002990")]
	private void Unity_002EProperties_002EIPropertyVisitor_002EVisit<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container)
	{
	}

	[Token(Token = "0x6002991")]
	private void Unity_002EProperties_002EIListPropertyVisitor_002EVisit<TContainer, TList, TElement>(Property<TContainer, TList> property, ref TContainer container, ref TList list) where TList : IList<TElement>
	{
	}

	[Token(Token = "0x6002992")]
	[Address(RVA = "0x2A807B0", Offset = "0x2A7F9B0", VA = "0x182A807B0")]
	private void VisitPropertyType(Type type)
	{
	}

	[Token(Token = "0x6002993")]
	[Address(RVA = "0x2A80B10", Offset = "0x2A7FD10", VA = "0x182A80B10")]
	public AutoCompletePathVisitor()
	{
	}
}
