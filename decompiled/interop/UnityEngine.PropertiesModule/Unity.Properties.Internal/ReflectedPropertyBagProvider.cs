using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace Unity.Properties.Internal;

[Token(Token = "0x20000A2")]
internal class ReflectedPropertyBagProvider
{
	[Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class _003CGetPropertyMembers_003Ed__22 : IEnumerable<MemberInfo>, IEnumerable, IEnumerator<MemberInfo>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x18")]
		private MemberInfo _003C_003E2__current;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x20")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x28")]
		private Type type;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x30")]
		public Type _003C_003E3__type;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x38")]
		private IOrderedEnumerable<MemberInfo> _003Cmembers_003E5__1;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x40")]
		private IEnumerator<MemberInfo> _003C_003Es__2;

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x48")]
		private MemberInfo _003Cmember_003E5__3;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x50")]
		private bool _003ChasDontCreatePropertyAttribute_003E5__4;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x51")]
		private bool _003ChasCreatePropertyAttribute_003E5__5;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x52")]
		private bool _003ChasNonSerializedAttribute_003E5__6;

		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x53")]
		private bool _003ChasSerializedFieldAttribute_003E5__7;

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x54")]
		private bool _003ChasSerializeReferenceAttribute_003E5__8;

		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x58")]
		private FieldInfo _003Cfield_003E5__9;

		[Token(Token = "0x17000096")]
		private MemberInfo System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EReflection_002EMemberInfo_003E_002ECurrent
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x59ED60", Offset = "0x59DF60", VA = "0x18059ED60")]
		[DebuggerHidden]
		public _003CGetPropertyMembers_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x28F9610", Offset = "0x28F8810", VA = "0x1828F9610", Slot = "7")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x28F8C10", Offset = "0x28F7E10", VA = "0x1828F8C10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x28F96A0", Offset = "0x28F88A0", VA = "0x1828F96A0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x28F95D0", Offset = "0x28F87D0", VA = "0x1828F95D0", Slot = "10")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x28F9530", Offset = "0x28F8730", VA = "0x1828F9530", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MemberInfo> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EReflection_002EMemberInfo_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x28F9530", Offset = "0x28F8730", VA = "0x1828F9530", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x4000161")]
	[FieldOffset(Offset = "0x10")]
	private readonly MethodInfo m_CreatePropertyMethod;

	[Token(Token = "0x4000162")]
	[FieldOffset(Offset = "0x18")]
	private readonly MethodInfo m_CreatePropertyBagMethod;

	[Token(Token = "0x4000163")]
	[FieldOffset(Offset = "0x20")]
	private readonly MethodInfo m_CreateIndexedCollectionPropertyBagMethod;

	[Token(Token = "0x4000164")]
	[FieldOffset(Offset = "0x28")]
	private readonly MethodInfo m_CreateSetPropertyBagMethod;

	[Token(Token = "0x4000165")]
	[FieldOffset(Offset = "0x30")]
	private readonly MethodInfo m_CreateKeyValueCollectionPropertyBagMethod;

	[Token(Token = "0x4000166")]
	[FieldOffset(Offset = "0x38")]
	private readonly MethodInfo m_CreateKeyValuePairPropertyBagMethod;

	[Token(Token = "0x4000167")]
	[FieldOffset(Offset = "0x40")]
	private readonly MethodInfo m_CreateArrayPropertyBagMethod;

	[Token(Token = "0x4000168")]
	[FieldOffset(Offset = "0x48")]
	private readonly MethodInfo m_CreateListPropertyBagMethod;

	[Token(Token = "0x4000169")]
	[FieldOffset(Offset = "0x50")]
	private readonly MethodInfo m_CreateHashSetPropertyBagMethod;

	[Token(Token = "0x400016A")]
	[FieldOffset(Offset = "0x58")]
	private readonly MethodInfo m_CreateDictionaryPropertyBagMethod;

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x28F6910", Offset = "0x28F5B10", VA = "0x1828F6910")]
	public ReflectedPropertyBagProvider()
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x28F6510", Offset = "0x28F5710", VA = "0x1828F6510")]
	public IPropertyBag CreatePropertyBag(Type type)
	{
		return null;
	}

	[Token(Token = "0x600032D")]
	public IPropertyBag<TContainer> CreatePropertyBag<TContainer>()
	{
		return null;
	}

	[Token(Token = "0x600032E")]
	[Preserve]
	private void CreateProperty<TContainer, TValue>(IMemberInfo member, ReflectedPropertyBag<TContainer> propertyBag)
	{
	}

	[Token(Token = "0x600032F")]
	[Preserve]
	private IPropertyBag<TList> CreateIndexedCollectionPropertyBag<TList, TElement>() where TList : IList<TElement>
	{
		return null;
	}

	[Token(Token = "0x6000330")]
	[Preserve]
	private IPropertyBag<TSet> CreateSetPropertyBag<TSet, TValue>() where TSet : ISet<TValue>
	{
		return null;
	}

	[Token(Token = "0x6000331")]
	[Preserve]
	private IPropertyBag<TDictionary> CreateKeyValueCollectionPropertyBag<TDictionary, TKey, TValue>() where TDictionary : IDictionary<TKey, TValue>
	{
		return null;
	}

	[Token(Token = "0x6000332")]
	[Preserve]
	private IPropertyBag<KeyValuePair<TKey, TValue>> CreateKeyValuePairPropertyBag<TKey, TValue>()
	{
		return null;
	}

	[Token(Token = "0x6000333")]
	[Preserve]
	private IPropertyBag<TElement[]> CreateArrayPropertyBag<TElement>()
	{
		return null;
	}

	[Token(Token = "0x6000334")]
	[Preserve]
	private IPropertyBag<List<TElement>> CreateListPropertyBag<TElement>()
	{
		return null;
	}

	[Token(Token = "0x6000335")]
	[Preserve]
	private IPropertyBag<HashSet<TElement>> CreateHashSetPropertyBag<TElement>()
	{
		return null;
	}

	[Token(Token = "0x6000336")]
	[Preserve]
	private IPropertyBag<Dictionary<TKey, TValue>> CreateDictionaryPropertyBag<TKey, TValue>()
	{
		return null;
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x28F6660", Offset = "0x28F5860", VA = "0x1828F6660")]
	[IteratorStateMachine(typeof(_003CGetPropertyMembers_003Ed__22))]
	private static IEnumerable<MemberInfo> GetPropertyMembers(Type type)
	{
		return null;
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x28F66E0", Offset = "0x28F58E0", VA = "0x1828F66E0")]
	private static bool IsValidMember(MemberInfo memberInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x28F6820", Offset = "0x28F5A20", VA = "0x1828F6820")]
	private static bool IsValidPropertyType(Type type)
	{
		return default(bool);
	}
}
