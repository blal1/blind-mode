using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Il2CppDummyDll;
using UnityEngine.Pool;
using UnityEngine.Scripting;

namespace Unity.Properties;

[Token(Token = "0x2000066")]
public static class TypeUtility
{
	[Token(Token = "0x2000067")]
	private interface ITypeConstructor
	{
		[Token(Token = "0x1700004D")]
		bool CanBeInstantiated
		{
			[Token(Token = "0x600024E")]
			get;
		}

		[Token(Token = "0x600024F")]
		object Instantiate();
	}

	[Token(Token = "0x2000068")]
	private interface ITypeConstructor<T> : ITypeConstructor
	{
		[Token(Token = "0x6000250")]
		new T Instantiate();

		[Token(Token = "0x6000251")]
		void SetExplicitConstructor(Func<T> constructor);
	}

	[Token(Token = "0x2000069")]
	private class TypeConstructor<T> : ITypeConstructor<T>, ITypeConstructor
	{
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x0")]
		private Func<T> m_ExplicitConstructor;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x0")]
		private Func<T> m_ImplicitConstructor;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x0")]
		private IConstructor<T> m_OverrideConstructor;

		[Token(Token = "0x1700004E")]
		private bool Unity_002EProperties_002ETypeUtility_002EITypeConstructor_002ECanBeInstantiated
		{
			[Token(Token = "0x6000252")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000253")]
		public TypeConstructor()
		{
		}

		[Token(Token = "0x6000254")]
		private void SetImplicitConstructor()
		{
		}

		[Token(Token = "0x6000255")]
		private static T CreateValueTypeInstance()
		{
			return (T)null;
		}

		[Token(Token = "0x6000256")]
		private static T CreateScriptableObjectInstance()
		{
			return (T)null;
		}

		[Token(Token = "0x6000257")]
		private static T CreateClassInstance()
		{
			return (T)null;
		}

		[Token(Token = "0x6000258")]
		public void SetExplicitConstructor(Func<T> constructor)
		{
		}

		[Token(Token = "0x6000259")]
		private T Unity_002EProperties_002ETypeUtility_002EITypeConstructor_003CT_003E_002EInstantiate()
		{
			return (T)null;
		}

		[Token(Token = "0x600025A")]
		private object Unity_002EProperties_002ETypeUtility_002EITypeConstructor_002EInstantiate()
		{
			return null;
		}
	}

	[Token(Token = "0x200006A")]
	private class NonConstructable : ITypeConstructor
	{
		[Token(Token = "0x1700004F")]
		private bool Unity_002EProperties_002ETypeUtility_002EITypeConstructor_002ECanBeInstantiated
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x28D9070", Offset = "0x28D8270", VA = "0x1828D9070", Slot = "5")]
		public object Instantiate()
		{
			return null;
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public NonConstructable()
		{
		}
	}

	[Token(Token = "0x200006B")]
	private struct Cache<T>
	{
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x0")]
		public static ITypeConstructor<T> TypeConstructor;
	}

	[Token(Token = "0x200006C")]
	private class TypeConstructorVisitor : ITypeVisitor
	{
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x10")]
		public ITypeConstructor TypeConstructor;

		[Token(Token = "0x600025E")]
		public void Visit<TContainer>()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public TypeConstructorVisitor()
		{
		}
	}

	[Token(Token = "0x4000152")]
	[FieldOffset(Offset = "0x0")]
	private static readonly ConcurrentDictionary<Type, ITypeConstructor> s_TypeConstructors;

	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x8")]
	private static readonly MethodInfo s_CreateTypeConstructor;

	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x10")]
	private static readonly ConcurrentDictionary<Type, string> s_CachedResolvedName;

	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x18")]
	private static readonly ObjectPool<StringBuilder> s_Builders;

	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x20")]
	private static readonly object syncedPoolObject;

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x28F8780", Offset = "0x28F7980", VA = "0x1828F8780")]
	static TypeUtility()
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x28F7D20", Offset = "0x28F6F20", VA = "0x1828F7D20")]
	public static string GetTypeDisplayName(Type type)
	{
		return null;
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x28F7E40", Offset = "0x28F7040", VA = "0x1828F7E40")]
	private static string GetTypeDisplayName(Type type, IReadOnlyList<Type> args, ref int argIndex)
	{
		return null;
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x28F7B70", Offset = "0x28F6D70", VA = "0x1828F7B70")]
	public static Type GetRootType(this Type type)
	{
		return null;
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x28F7890", Offset = "0x28F6A90", VA = "0x1828F7890")]
	[Preserve]
	private static ITypeConstructor CreateTypeConstructor(Type type)
	{
		return null;
	}

	[Token(Token = "0x600023E")]
	private static ITypeConstructor<T> CreateTypeConstructor<T>()
	{
		return null;
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x28F7C60", Offset = "0x28F6E60", VA = "0x1828F7C60")]
	private static ITypeConstructor GetTypeConstructor(Type type)
	{
		return null;
	}

	[Token(Token = "0x6000240")]
	private static ITypeConstructor<T> GetTypeConstructor<T>()
	{
		return null;
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x28F7520", Offset = "0x28F6720", VA = "0x1828F7520")]
	public static bool CanBeInstantiated(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x6000242")]
	public static bool CanBeInstantiated<T>()
	{
		return default(bool);
	}

	[Token(Token = "0x6000243")]
	public static void SetExplicitInstantiationMethod<T>(Func<T> constructor)
	{
	}

	[Token(Token = "0x6000244")]
	public static T Instantiate<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x6000245")]
	public static bool TryInstantiate<T>(out T instance)
	{
		return default(bool);
	}

	[Token(Token = "0x6000246")]
	public static T Instantiate<T>(Type derivedType)
	{
		return (T)null;
	}

	[Token(Token = "0x6000247")]
	public static bool TryInstantiate<T>(Type derivedType, out T value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000248")]
	public static TArray InstantiateArray<TArray>(int count = 0)
	{
		return (TArray)null;
	}

	[Token(Token = "0x6000249")]
	public static bool TryInstantiateArray<TArray>(int count, out TArray instance)
	{
		return default(bool);
	}

	[Token(Token = "0x600024A")]
	public static TArray InstantiateArray<TArray>(Type derivedType, int count = 0)
	{
		return (TArray)null;
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x28F7710", Offset = "0x28F6910", VA = "0x1828F7710")]
	private static void CheckIsAssignableFrom(Type type, Type derivedType)
	{
	}

	[Token(Token = "0x600024C")]
	private static void CheckCanBeInstantiated<T>(ITypeConstructor<T> constructor)
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x28F7630", Offset = "0x28F6830", VA = "0x1828F7630")]
	private static void CheckCanBeInstantiated(ITypeConstructor constructor, Type type)
	{
	}
}
