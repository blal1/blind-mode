using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003D6")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal struct StyleDataRef<T> : IEquatable<StyleDataRef<T>> where T : struct, IEquatable<T>, IStyleDataGroup<T>
{
	[Token(Token = "0x20003D7")]
	private class RefCounted
	{
		[Token(Token = "0x4000CBE")]
		[FieldOffset(Offset = "0x0")]
		private static uint m_NextId;

		[Token(Token = "0x4000CBF")]
		[FieldOffset(Offset = "0x0")]
		private int m_RefCount;

		[Token(Token = "0x4000CC0")]
		[FieldOffset(Offset = "0x0")]
		private readonly uint m_Id;

		[Token(Token = "0x4000CC1")]
		[FieldOffset(Offset = "0x0")]
		public T value;

		[Token(Token = "0x1700082B")]
		public int refCount
		{
			[Token(Token = "0x6001D4B")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6001D4C")]
		public RefCounted()
		{
		}

		[Token(Token = "0x6001D4D")]
		public void Acquire()
		{
		}

		[Token(Token = "0x6001D4E")]
		public void Release()
		{
		}

		[Token(Token = "0x6001D4F")]
		public RefCounted Copy()
		{
			return null;
		}
	}

	[Token(Token = "0x4000CBD")]
	[FieldOffset(Offset = "0x0")]
	private RefCounted m_Ref;

	[Token(Token = "0x6001D40")]
	public StyleDataRef<T> Acquire()
	{
		return default(StyleDataRef<T>);
	}

	[Token(Token = "0x6001D41")]
	public void Release()
	{
	}

	[Token(Token = "0x6001D42")]
	public void CopyFrom(StyleDataRef<T> other)
	{
	}

	[Token(Token = "0x6001D43")]
	public unsafe ref T Read()
	{
		return ref *(T*)null;
	}

	[Token(Token = "0x6001D44")]
	public unsafe ref T Write()
	{
		return ref *(T*)null;
	}

	[Token(Token = "0x6001D45")]
	public static StyleDataRef<T> Create()
	{
		return default(StyleDataRef<T>);
	}

	[Token(Token = "0x6001D46")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001D47")]
	public static bool operator ==(StyleDataRef<T> lhs, StyleDataRef<T> rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D48")]
	public bool Equals(StyleDataRef<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D49")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D4A")]
	public bool ReferenceEquals(StyleDataRef<T> other)
	{
		return default(bool);
	}
}
