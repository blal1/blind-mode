using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem;

public sealed class Func<TResult> : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_0;

	static Func()
	{
		Il2CppClassPointerStore<Func<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Func`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<TResult>>.NativeClassPtr, 100664232);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<TResult>>.NativeClassPtr, 100664233);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718153, XrefRangeEnd = 718156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Func(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Func<TResult>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual TResult Invoke()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
	}

	public Func(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator Func<TResult>(System.Func<TResult> P_0)
	{
		return DelegateSupport.ConvertDelegate<Func<TResult>>((System.Delegate)P_0);
	}

	public static Func<TResult> operator +(Func<TResult> P_0, Func<TResult> P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<Func<TResult>>();
	}

	public static Func<TResult> operator -(Func<TResult> P_0, Func<TResult> P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<Func<TResult>>();
		}
		return (Func<TResult>)obj;
	}
}
public sealed class Func<T, TResult> : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T_0;

	static Func()
	{
		Il2CppClassPointerStore<Func<T, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Func`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[2]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
		})).TypeHandle.value);
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T, TResult>>.NativeClassPtr, 100664234);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T, TResult>>.NativeClassPtr, 100664235);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 718159, RefRangeEnd = 718173, XrefRangeStart = 718156, XrefRangeEnd = 718159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Func(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Func<T, TResult>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual TResult Invoke(T arg)
	{
		//IL_004c->IL004f: Incompatible stack types: I vs Ref
		//IL_003f->IL004f: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = arg;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref arg;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
	}

	public Func(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator Func<T, TResult>(System.Func<T, TResult> P_0)
	{
		return DelegateSupport.ConvertDelegate<Func<T, TResult>>((System.Delegate)P_0);
	}

	public static Func<T, TResult> operator +(Func<T, TResult> P_0, Func<T, TResult> P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<Func<T, TResult>>();
	}

	public static Func<T, TResult> operator -(Func<T, TResult> P_0, Func<T, TResult> P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<Func<T, TResult>>();
		}
		return (Func<T, TResult>)obj;
	}
}
public sealed class Func<T1, T2, TResult> : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_T2_0;

	static Func()
	{
		Il2CppClassPointerStore<Func<T1, T2, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Func`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[3]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
		})).TypeHandle.value);
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T1, T2, TResult>>.NativeClassPtr, 100664236);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T1, T2, TResult>>.NativeClassPtr, 100664237);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 718176, RefRangeEnd = 718177, XrefRangeStart = 718173, XrefRangeEnd = 718176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Func(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Func<T1, T2, TResult>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual TResult Invoke(T1 arg1, T2 arg2)
	{
		//IL_004c->IL004f: Incompatible stack types: I vs Ref
		//IL_003f->IL004f: Incompatible stack types: I vs Ref
		//IL_0094->IL0097: Incompatible stack types: I vs Ref
		//IL_0087->IL0097: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		ref T1 reference;
		if (!typeof(T1).IsValueType)
		{
			object obj = arg1;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref arg1;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T2 reference2;
		if (!typeof(T2).IsValueType)
		{
			object obj2 = arg2;
			reference2 = ref *(_003F*)((!(obj2 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj2 is Il2CppObjectBase) ? obj2 : null)) : IL2CPP.ManagedStringToIl2Cpp(obj2 as string));
		}
		else
		{
			reference2 = ref arg2;
		}
		*(void**)num = Unsafe.AsPointer(ref reference2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
	}

	public Func(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator Func<T1, T2, TResult>(System.Func<T1, T2, TResult> P_0)
	{
		return DelegateSupport.ConvertDelegate<Func<T1, T2, TResult>>((System.Delegate)P_0);
	}

	public static Func<T1, T2, TResult> operator +(Func<T1, T2, TResult> P_0, Func<T1, T2, TResult> P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<Func<T1, T2, TResult>>();
	}

	public static Func<T1, T2, TResult> operator -(Func<T1, T2, TResult> P_0, Func<T1, T2, TResult> P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<Func<T1, T2, TResult>>();
		}
		return (Func<T1, T2, TResult>)obj;
	}
}
public sealed class Func<T1, T2, T3, TResult> : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_T2_T3_0;

	static Func()
	{
		Il2CppClassPointerStore<Func<T1, T2, T3, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Func`4"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[4]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
		})).TypeHandle.value);
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T1, T2, T3, TResult>>.NativeClassPtr, 100664238);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_T2_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T1, T2, T3, TResult>>.NativeClassPtr, 100664239);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718177, XrefRangeEnd = 718180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Func(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Func<T1, T2, T3, TResult>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3)
	{
		//IL_004c->IL004f: Incompatible stack types: I vs Ref
		//IL_003f->IL004f: Incompatible stack types: I vs Ref
		//IL_0094->IL0097: Incompatible stack types: I vs Ref
		//IL_0087->IL0097: Incompatible stack types: I vs Ref
		//IL_00dc->IL00df: Incompatible stack types: I vs Ref
		//IL_00cf->IL00df: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		ref T1 reference;
		if (!typeof(T1).IsValueType)
		{
			object obj = arg1;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref arg1;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T2 reference2;
		if (!typeof(T2).IsValueType)
		{
			object obj2 = arg2;
			reference2 = ref *(_003F*)((!(obj2 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj2 is Il2CppObjectBase) ? obj2 : null)) : IL2CPP.ManagedStringToIl2Cpp(obj2 as string));
		}
		else
		{
			reference2 = ref arg2;
		}
		*(void**)num = Unsafe.AsPointer(ref reference2);
		byte* num2 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T3 reference3;
		if (!typeof(T3).IsValueType)
		{
			object obj3 = arg3;
			reference3 = ref *(_003F*)((!(obj3 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj3 is Il2CppObjectBase) ? obj3 : null)) : IL2CPP.ManagedStringToIl2Cpp(obj3 as string));
		}
		else
		{
			reference3 = ref arg3;
		}
		*(void**)num2 = Unsafe.AsPointer(ref reference3);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_T2_T3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
	}

	public Func(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator Func<T1, T2, T3, TResult>(System.Func<T1, T2, T3, TResult> P_0)
	{
		return DelegateSupport.ConvertDelegate<Func<T1, T2, T3, TResult>>((System.Delegate)P_0);
	}

	public static Func<T1, T2, T3, TResult> operator +(Func<T1, T2, T3, TResult> P_0, Func<T1, T2, T3, TResult> P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<Func<T1, T2, T3, TResult>>();
	}

	public static Func<T1, T2, T3, TResult> operator -(Func<T1, T2, T3, TResult> P_0, Func<T1, T2, T3, TResult> P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<Func<T1, T2, T3, TResult>>();
		}
		return (Func<T1, T2, T3, TResult>)obj;
	}
}
public sealed class Func<T1, T2, T3, T4, TResult> : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_T2_T3_T4_0;

	static Func()
	{
		Il2CppClassPointerStore<Func<T1, T2, T3, T4, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Func`5"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[5]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
		})).TypeHandle.value);
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T1, T2, T3, T4, TResult>>.NativeClassPtr, 100664240);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_T2_T3_T4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T1, T2, T3, T4, TResult>>.NativeClassPtr, 100664241);
	}

	[CallerCount(72)]
	[CachedScanResults(RefRangeStart = 630126, RefRangeEnd = 630198, XrefRangeStart = 630126, XrefRangeEnd = 630198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Func(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Func<T1, T2, T3, T4, TResult>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
	{
		//IL_004c->IL004f: Incompatible stack types: I vs Ref
		//IL_003f->IL004f: Incompatible stack types: I vs Ref
		//IL_0094->IL0097: Incompatible stack types: I vs Ref
		//IL_0087->IL0097: Incompatible stack types: I vs Ref
		//IL_00dc->IL00df: Incompatible stack types: I vs Ref
		//IL_00cf->IL00df: Incompatible stack types: I vs Ref
		//IL_0125->IL0128: Incompatible stack types: I vs Ref
		//IL_0118->IL0128: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		ref T1 reference;
		if (!typeof(T1).IsValueType)
		{
			object obj = arg1;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref arg1;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T2 reference2;
		if (!typeof(T2).IsValueType)
		{
			object obj2 = arg2;
			reference2 = ref *(_003F*)((!(obj2 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj2 is Il2CppObjectBase) ? obj2 : null)) : IL2CPP.ManagedStringToIl2Cpp(obj2 as string));
		}
		else
		{
			reference2 = ref arg2;
		}
		*(void**)num = Unsafe.AsPointer(ref reference2);
		byte* num2 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T3 reference3;
		if (!typeof(T3).IsValueType)
		{
			object obj3 = arg3;
			reference3 = ref *(_003F*)((!(obj3 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj3 is Il2CppObjectBase) ? obj3 : null)) : IL2CPP.ManagedStringToIl2Cpp(obj3 as string));
		}
		else
		{
			reference3 = ref arg3;
		}
		*(void**)num2 = Unsafe.AsPointer(ref reference3);
		byte* num3 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T4 reference4;
		if (!typeof(T4).IsValueType)
		{
			object obj4 = arg4;
			reference4 = ref *(_003F*)((!(obj4 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj4 is Il2CppObjectBase) ? obj4 : null)) : IL2CPP.ManagedStringToIl2Cpp(obj4 as string));
		}
		else
		{
			reference4 = ref arg4;
		}
		*(void**)num3 = Unsafe.AsPointer(ref reference4);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_T2_T3_T4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
	}

	public Func(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator Func<T1, T2, T3, T4, TResult>(System.Func<T1, T2, T3, T4, TResult> P_0)
	{
		return DelegateSupport.ConvertDelegate<Func<T1, T2, T3, T4, TResult>>((System.Delegate)P_0);
	}

	public static Func<T1, T2, T3, T4, TResult> operator +(Func<T1, T2, T3, T4, TResult> P_0, Func<T1, T2, T3, T4, TResult> P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<Func<T1, T2, T3, T4, TResult>>();
	}

	public static Func<T1, T2, T3, T4, TResult> operator -(Func<T1, T2, T3, T4, TResult> P_0, Func<T1, T2, T3, T4, TResult> P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<Func<T1, T2, T3, T4, TResult>>();
		}
		return (Func<T1, T2, T3, T4, TResult>)obj;
	}
}
