using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Unity.Collections;

public static class CollectionExtensions : Il2CppSystem.Object
{
	[ObfuscatedName("Unity.Collections.CollectionExtensions+<>c__DisplayClass3_0`1")]
	public sealed class __c__DisplayClass3_0<T> : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_serializeElement;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SerializedView_b__0_Internal_String_T_0;

		public unsafe Il2CppSystem.Func<T, string> serializeElement
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_serializeElement);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<T, string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_serializeElement)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c__DisplayClass3_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass3_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr, "<>c__DisplayClass3_0`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass3_0<T>>.NativeClassPtr);
			NativeFieldInfoPtr_serializeElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass3_0<T>>.NativeClassPtr, "serializeElement");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass3_0<T>>.NativeClassPtr, 100663506);
			NativeMethodInfoPtr__SerializedView_b__0_Internal_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass3_0<T>>.NativeClassPtr, 100663507);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass3_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass3_0<T>>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165090, XrefRangeEnd = 1165092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _SerializedView_b__0(T t)
		{
			//IL_004c->IL004f: Incompatible stack types: I vs Ref
			//IL_003f->IL004f: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			ref T reference;
			if (!typeof(T).IsValueType)
			{
				object obj = t;
				reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
			}
			else
			{
				reference = ref t;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SerializedView_b__0_Internal_String_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		public __c__DisplayClass3_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_SerializedView_Internal_Static_String_IEnumerable_1_T_Func_2_T_String_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializedView_Internal_Static_String_IEnumerable_1_T_Func_2_T_String_0, Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializedView_Internal_Static_String_IEnumerable_1_T_Func_2_T_String_0;

	static CollectionExtensions()
	{
		Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "CollectionExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_SerializedView_Internal_Static_String_IEnumerable_1_T_Func_2_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr, 100663505);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1165120, RefRangeEnd = 1165121, XrefRangeStart = 1165092, XrefRangeEnd = 1165120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string SerializedView<T>(this IEnumerable<T> collection, Il2CppSystem.Func<T, string> serializeElement)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collection);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializeElement);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializedView_Internal_Static_String_IEnumerable_1_T_Func_2_T_String_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public CollectionExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void AddSorted<T>(List<T> list, T item, [Optional] IComparer<T> comparer)
	{
		if (list == null)
		{
			throw new Il2CppSystem.ArgumentNullException("list must not be null.");
		}
		if (comparer == null)
		{
			comparer = (IComparer<T>)(object)Comparer<T>.Default;
		}
		if (list.Count == 0)
		{
			list.Add(item);
			return;
		}
		if (comparer.Compare(list[list.Count - 1], item) <= 0)
		{
			list.Add(item);
			return;
		}
		if (comparer.Compare(list[0], item) >= 0)
		{
			list.Insert(0, item);
			return;
		}
		int num = list.BinarySearch(item, comparer);
		if (num < 0)
		{
			num = ~num;
		}
		list.Insert(num, item);
	}

	public static void Fill<T>(List<T> dest, T value, int count)
	{
		if (dest == null)
		{
			throw new Il2CppSystem.ArgumentNullException("dest");
		}
		dest.Capacity = Il2CppSystem.Math.Max(dest.Capacity, dest.Count + count);
		while (count-- > 0)
		{
			dest.Add(value);
		}
	}

	public static T FirstOrDefaultSorted<T>(IEnumerable<T> collection, [Optional] IComparer<T> comparer)
	{
		if (collection == null)
		{
			throw new Il2CppSystem.ArgumentNullException("collection must not be null.");
		}
		if (comparer == null)
		{
			comparer = (IComparer<T>)(object)Comparer<T>.Default;
		}
		bool flag = false;
		T val = default(T);
		IEnumerator<T> enumerator = collection.GetEnumerator();
		try
		{
			while (((IEnumerator)(object)enumerator).MoveNext())
			{
				T current = enumerator.Current;
				if (!flag)
				{
					val = current;
					flag = true;
				}
				if (comparer.Compare(current, val) < 0)
				{
					val = current;
				}
			}
		}
		finally
		{
			((Il2CppSystem.IDisposable)(object)enumerator)?.Dispose();
		}
		return val;
	}

	public static bool ContainsByEquals<T>(IEnumerable<T> collection, T element)
	{
		if (collection == null)
		{
			throw new Il2CppSystem.ArgumentNullException("collection must not be null.");
		}
		IEnumerator<T> enumerator = collection.GetEnumerator();
		try
		{
			while (((IEnumerator)(object)enumerator).MoveNext())
			{
				if (((Il2CppSystem.Object)enumerator.Current).Equals((Il2CppSystem.Object)(object)element))
				{
					return true;
				}
			}
		}
		finally
		{
			((Il2CppSystem.IDisposable)(object)enumerator)?.Dispose();
		}
		return false;
	}
}
