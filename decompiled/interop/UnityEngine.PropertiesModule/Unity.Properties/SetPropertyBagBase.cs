using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x2000045")]
public class SetPropertyBagBase<TSet, TElement> : PropertyBag<TSet>, ISetPropertyBag<TSet, TElement>, ICollectionPropertyBag<TSet, TElement>, IPropertyBag<TSet>, IPropertyBag, ICollectionPropertyBagAccept<TSet>, ISetPropertyBagAccept<TSet>, IKeyedProperties<TSet, object> where TSet : ISet<TElement>
{
	[Token(Token = "0x2000046")]
	private class SetElementProperty : Property<TSet, TElement>, ISetElementProperty
	{
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x0")]
		internal TElement m_Value;

		[Token(Token = "0x17000036")]
		public override string Name
		{
			[Token(Token = "0x600011C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600011D")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000038")]
		public object ObjectKey
		{
			[Token(Token = "0x6000120")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600011E")]
		public override TElement GetValue(ref TSet container)
		{
			return (TElement)null;
		}

		[Token(Token = "0x600011F")]
		public override void SetValue(ref TSet container, TElement value)
		{
		}

		[Token(Token = "0x6000121")]
		public SetElementProperty()
		{
		}
	}

	[Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class _003CGetPropertiesEnumerable_003Ed__4 : IEnumerable<IProperty<TSet>>, IEnumerable, IEnumerator<IProperty<TSet>>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x0")]
		private IProperty<TSet> _003C_003E2__current;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x0")]
		private TSet container;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x0")]
		public TSet _003C_003E3__container;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x0")]
		public SetPropertyBagBase<TSet, TElement> _003C_003E4__this;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerator<TElement> _003C_003Es__1;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x0")]
		private TElement _003Celement_003E5__2;

		[Token(Token = "0x17000039")]
		private IProperty<TSet> System_002ECollections_002EGeneric_002EIEnumerator_003CUnity_002EProperties_002EIProperty_003CTSet_003E_003E_002ECurrent
		{
			[Token(Token = "0x6000126")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000128")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000122")]
		[DebuggerHidden]
		public _003CGetPropertiesEnumerable_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000123")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000124")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000125")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6000127")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000129")]
		[DebuggerHidden]
		private IEnumerator<IProperty<TSet>> System_002ECollections_002EGeneric_002EIEnumerable_003CUnity_002EProperties_002EIProperty_003CTSet_003E_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600012A")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x0")]
	private readonly SetElementProperty m_Property;

	[Token(Token = "0x6000115")]
	public override PropertyCollection<TSet> GetProperties()
	{
		return default(PropertyCollection<TSet>);
	}

	[Token(Token = "0x6000116")]
	public override PropertyCollection<TSet> GetProperties(ref TSet container)
	{
		return default(PropertyCollection<TSet>);
	}

	[Token(Token = "0x6000117")]
	[IteratorStateMachine(typeof(SetPropertyBagBase<, >._003CGetPropertiesEnumerable_003Ed__4))]
	private IEnumerable<IProperty<TSet>> GetPropertiesEnumerable(TSet container)
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	private void Unity_002EProperties_002EICollectionPropertyBagAccept_003CTSet_003E_002EAccept(ICollectionPropertyBagVisitor visitor, ref TSet container)
	{
	}

	[Token(Token = "0x6000119")]
	private void Unity_002EProperties_002EISetPropertyBagAccept_003CTSet_003E_002EAccept(ISetPropertyBagVisitor visitor, ref TSet container)
	{
	}

	[Token(Token = "0x600011A")]
	public bool TryGetProperty(ref TSet container, object key, out IProperty<TSet> property)
	{
		return default(bool);
	}

	[Token(Token = "0x600011B")]
	public SetPropertyBagBase()
	{
	}
}
