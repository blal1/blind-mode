using System;
using System.Reflection;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001D5")]
[DefaultMember("Item")]
internal class EventCallbackList
{
	[Token(Token = "0x400084E")]
	[FieldOffset(Offset = "0x0")]
	public static readonly EventCallbackList EmptyList;

	[Token(Token = "0x400084F")]
	[FieldOffset(Offset = "0x8")]
	private static readonly EventCallbackFunctorBase[] EmptyArray;

	[Token(Token = "0x4000850")]
	[FieldOffset(Offset = "0x10")]
	private EventCallbackFunctorBase[] m_Array;

	[Token(Token = "0x4000851")]
	[FieldOffset(Offset = "0x18")]
	private int m_Count;

	[Token(Token = "0x17000264")]
	public Span<EventCallbackFunctorBase> Span
	{
		[Token(Token = "0x6000D55")]
		[Address(RVA = "0x2B12A00", Offset = "0x2B11C00", VA = "0x182B12A00")]
		get
		{
			return default(Span<EventCallbackFunctorBase>);
		}
	}

	[Token(Token = "0x6000D4F")]
	[Address(RVA = "0x2B12900", Offset = "0x2B11B00", VA = "0x182B12900")]
	public EventCallbackList()
	{
	}

	[Token(Token = "0x6000D50")]
	[Address(RVA = "0x2B12970", Offset = "0x2B11B70", VA = "0x182B12970")]
	public EventCallbackList(EventCallbackList source)
	{
	}

	[Token(Token = "0x6000D51")]
	[Address(RVA = "0x2B12620", Offset = "0x2B11820", VA = "0x182B12620")]
	public EventCallbackFunctorBase Find(long eventTypeId, [NotNull] Delegate callback)
	{
		return null;
	}

	[Token(Token = "0x6000D52")]
	[Address(RVA = "0x2B126D0", Offset = "0x2B118D0", VA = "0x182B126D0")]
	public bool Remove(long eventTypeId, [NotNull] Delegate callback, out EventCallbackFunctorBase removedFunctor)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D53")]
	[Address(RVA = "0x2B12520", Offset = "0x2B11720", VA = "0x182B12520")]
	public void Add(EventCallbackFunctorBase item)
	{
	}

	[Token(Token = "0x6000D54")]
	[Address(RVA = "0x2B12450", Offset = "0x2B11650", VA = "0x182B12450")]
	public void AddRange(EventCallbackList list)
	{
	}

	[Token(Token = "0x6000D56")]
	[Address(RVA = "0x1F89530", Offset = "0x1F88730", VA = "0x181F89530")]
	public void Clear()
	{
	}
}
