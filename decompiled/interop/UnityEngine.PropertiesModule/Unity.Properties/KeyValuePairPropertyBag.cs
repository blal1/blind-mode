using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x200003C")]
public class KeyValuePairPropertyBag<TKey, TValue> : PropertyBag<KeyValuePair<TKey, TValue>>, INamedProperties<KeyValuePair<TKey, TValue>>
{
	[Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class _003CGetPropertiesEnumerable_003Ed__4 : IEnumerable<IProperty<KeyValuePair<TKey, TValue>>>, IEnumerable, IEnumerator<IProperty<KeyValuePair<TKey, TValue>>>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003E1__state;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x0")]
		private IProperty<KeyValuePair<TKey, TValue>> _003C_003E2__current;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x1700002E")]
		private IProperty<KeyValuePair<TKey, TValue>> System_002ECollections_002EGeneric_002EIEnumerator_003CUnity_002EProperties_002EIProperty_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_003E_002ECurrent
		{
			[Token(Token = "0x60000E6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60000E8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E3")]
		[DebuggerHidden]
		public _003CGetPropertiesEnumerable_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60000E4")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60000E5")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E7")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60000E9")]
		[DebuggerHidden]
		private IEnumerator<IProperty<KeyValuePair<TKey, TValue>>> System_002ECollections_002EGeneric_002EIEnumerable_003CUnity_002EProperties_002EIProperty_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000EA")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x0")]
	private static readonly DelegateProperty<KeyValuePair<TKey, TValue>, TKey> s_KeyProperty;

	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly DelegateProperty<KeyValuePair<TKey, TValue>, TValue> s_ValueProperty;

	[Token(Token = "0x60000D9")]
	public override PropertyCollection<KeyValuePair<TKey, TValue>> GetProperties()
	{
		return default(PropertyCollection<KeyValuePair<TKey, TValue>>);
	}

	[Token(Token = "0x60000DA")]
	public override PropertyCollection<KeyValuePair<TKey, TValue>> GetProperties(ref KeyValuePair<TKey, TValue> container)
	{
		return default(PropertyCollection<KeyValuePair<TKey, TValue>>);
	}

	[Token(Token = "0x60000DB")]
	[IteratorStateMachine(typeof(KeyValuePairPropertyBag<, >._003CGetPropertiesEnumerable_003Ed__4))]
	private static IEnumerable<IProperty<KeyValuePair<TKey, TValue>>> GetPropertiesEnumerable()
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	public bool TryGetProperty(ref KeyValuePair<TKey, TValue> container, string name, out IProperty<KeyValuePair<TKey, TValue>> property)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DD")]
	public KeyValuePairPropertyBag()
	{
	}
}
