using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x2000057")]
public abstract class PathVisitor : IPropertyBagVisitor, IPropertyVisitor
{
	[Token(Token = "0x2000058")]
	private readonly struct PropertyScope : IDisposable
	{
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x0")]
		private readonly PathVisitor m_Visitor;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x8")]
		private readonly IProperty m_Property;

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x28F6070", Offset = "0x28F5270", VA = "0x1828F6070")]
		public PropertyScope(PathVisitor visitor, IProperty property)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x28F6040", Offset = "0x28F5240", VA = "0x1828F6040", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x10")]
	private int m_PathIndex;

	[Token(Token = "0x1700003B")]
	public PropertyPath Path
	{
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x28D9120", Offset = "0x28D8320", VA = "0x1828D9120")]
		[CompilerGenerated]
		get
		{
			return default(PropertyPath);
		}
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x28D9180", Offset = "0x28D8380", VA = "0x1828D9180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700003C")]
	private IProperty Property
	{
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x49BDF0", Offset = "0x49AFF0", VA = "0x18049BDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x42FF30", Offset = "0x42F130", VA = "0x18042FF30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700003D")]
	public bool ReadonlyVisit
	{
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x150BFE0", Offset = "0x150B1E0", VA = "0x18150BFE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2583430", Offset = "0x2582630", VA = "0x182583430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700003E")]
	public VisitReturnCode ReturnCode
	{
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x42D600", Offset = "0x42C800", VA = "0x18042D600")]
		[CompilerGenerated]
		get
		{
			return default(VisitReturnCode);
		}
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x42D6B0", Offset = "0x42C8B0", VA = "0x18042D6B0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x28D90C0", Offset = "0x28D82C0", VA = "0x1828D90C0", Slot = "6")]
	public virtual void Reset()
	{
	}

	[Token(Token = "0x6000145")]
	private void Unity_002EProperties_002EIPropertyBagVisitor_002EVisit<TContainer>(IPropertyBag<TContainer> properties, ref TContainer container)
	{
	}

	[Token(Token = "0x6000146")]
	private void Unity_002EProperties_002EIPropertyVisitor_002EVisit<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container)
	{
	}

	[Token(Token = "0x6000147")]
	protected virtual void VisitPath<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container, ref TValue value)
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected PathVisitor()
	{
	}
}
