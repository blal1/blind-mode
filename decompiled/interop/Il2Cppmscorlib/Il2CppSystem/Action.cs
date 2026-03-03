using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem;

public sealed class Action : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

	static Action()
	{
		Il2CppClassPointerStore<Action>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Action");
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action>.NativeClassPtr, 100664218);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action>.NativeClassPtr, 100664219);
	}

	[CallerCount(4109)]
	[CachedScanResults(RefRangeStart = 27728, RefRangeEnd = 31837, XrefRangeStart = 27728, XrefRangeEnd = 31837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Action(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Action>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void Invoke()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Action(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator Action(System.Action P_0)
	{
		return DelegateSupport.ConvertDelegate<Action>((System.Delegate)P_0);
	}

	public static Action operator +(Action P_0, Action P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<Action>();
	}

	public static Action operator -(Action P_0, Action P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<Action>();
		}
		return (Action)obj;
	}
}
public sealed class Action<T> : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0;

	static Action()
	{
		Il2CppClassPointerStore<Action<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Action`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action<T>>.NativeClassPtr, 100664220);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action<T>>.NativeClassPtr, 100664221);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 718108, RefRangeEnd = 718111, XrefRangeStart = 718105, XrefRangeEnd = 718108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Action(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Action<T>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void Invoke(T obj)
	{
		//IL_004c->IL004f: Incompatible stack types: I vs Ref
		//IL_003f->IL004f: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj2 = obj;
			reference = ref *(_003F*)((!(obj2 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj2 is Il2CppObjectBase) ? obj2 : null)) : IL2CPP.ManagedStringToIl2Cpp(obj2 as string));
		}
		else
		{
			reference = ref obj;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Action(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator Action<T>(System.Action<T> P_0)
	{
		return DelegateSupport.ConvertDelegate<Action<T>>((System.Delegate)P_0);
	}

	public static Action<T> operator +(Action<T> P_0, Action<T> P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<Action<T>>();
	}

	public static Action<T> operator -(Action<T> P_0, Action<T> P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<Action<T>>();
		}
		return (Action<T>)obj;
	}
}
public sealed class Action<T1, T2> : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_0;

	static Action()
	{
		Il2CppClassPointerStore<Action<T1, T2>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Action`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[2]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
		})).TypeHandle.value);
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action<T1, T2>>.NativeClassPtr, 100664222);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action<T1, T2>>.NativeClassPtr, 100664223);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718111, XrefRangeEnd = 718114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Action(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Action<T1, T2>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void Invoke(T1 arg1, T2 arg2)
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
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Action(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator Action<T1, T2>(System.Action<T1, T2> P_0)
	{
		return DelegateSupport.ConvertDelegate<Action<T1, T2>>((System.Delegate)P_0);
	}

	public static Action<T1, T2> operator +(Action<T1, T2> P_0, Action<T1, T2> P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<Action<T1, T2>>();
	}

	public static Action<T1, T2> operator -(Action<T1, T2> P_0, Action<T1, T2> P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<Action<T1, T2>>();
		}
		return (Action<T1, T2>)obj;
	}
}
public sealed class Action<T1, T2, T3> : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_T3_0;

	static Action()
	{
		Il2CppClassPointerStore<Action<T1, T2, T3>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Action`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[3]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr))
		})).TypeHandle.value);
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action<T1, T2, T3>>.NativeClassPtr, 100664224);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action<T1, T2, T3>>.NativeClassPtr, 100664225);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718114, XrefRangeEnd = 718117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Action(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Action<T1, T2, T3>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void Invoke(T1 arg1, T2 arg2, T3 arg3)
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
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_T3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Action(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator Action<T1, T2, T3>(System.Action<T1, T2, T3> P_0)
	{
		return DelegateSupport.ConvertDelegate<Action<T1, T2, T3>>((System.Delegate)P_0);
	}

	public static Action<T1, T2, T3> operator +(Action<T1, T2, T3> P_0, Action<T1, T2, T3> P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<Action<T1, T2, T3>>();
	}

	public static Action<T1, T2, T3> operator -(Action<T1, T2, T3> P_0, Action<T1, T2, T3> P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<Action<T1, T2, T3>>();
		}
		return (Action<T1, T2, T3>)obj;
	}
}
public sealed class Action<T1, T2, T3, T4> : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_T3_T4_0;

	static Action()
	{
		Il2CppClassPointerStore<Action<T1, T2, T3, T4>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Action`4"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[4]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr))
		})).TypeHandle.value);
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action<T1, T2, T3, T4>>.NativeClassPtr, 100664226);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_T3_T4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action<T1, T2, T3, T4>>.NativeClassPtr, 100664227);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 718120, RefRangeEnd = 718128, XrefRangeStart = 718117, XrefRangeEnd = 718120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Action(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Action<T1, T2, T3, T4>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
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
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_T3_T4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Action(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator Action<T1, T2, T3, T4>(System.Action<T1, T2, T3, T4> P_0)
	{
		return DelegateSupport.ConvertDelegate<Action<T1, T2, T3, T4>>((System.Delegate)P_0);
	}

	public static Action<T1, T2, T3, T4> operator +(Action<T1, T2, T3, T4> P_0, Action<T1, T2, T3, T4> P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<Action<T1, T2, T3, T4>>();
	}

	public static Action<T1, T2, T3, T4> operator -(Action<T1, T2, T3, T4> P_0, Action<T1, T2, T3, T4> P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<Action<T1, T2, T3, T4>>();
		}
		return (Action<T1, T2, T3, T4>)obj;
	}
}
public sealed class Action<T1, T2, T3, T4, T5, T6> : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_T3_T4_T5_T6_0;

	static Action()
	{
		Il2CppClassPointerStore<Action<T1, T2, T3, T4, T5, T6>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Action`6"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[6]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr))
		})).TypeHandle.value);
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action<T1, T2, T3, T4, T5, T6>>.NativeClassPtr, 100664228);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_T3_T4_T5_T6_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action<T1, T2, T3, T4, T5, T6>>.NativeClassPtr, 100664229);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 718131, RefRangeEnd = 718132, XrefRangeStart = 718128, XrefRangeEnd = 718131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Action(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Action<T1, T2, T3, T4, T5, T6>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718132, XrefRangeEnd = 718141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
	{
		//IL_004c->IL004f: Incompatible stack types: I vs Ref
		//IL_003f->IL004f: Incompatible stack types: I vs Ref
		//IL_0094->IL0097: Incompatible stack types: I vs Ref
		//IL_0087->IL0097: Incompatible stack types: I vs Ref
		//IL_00dc->IL00df: Incompatible stack types: I vs Ref
		//IL_00cf->IL00df: Incompatible stack types: I vs Ref
		//IL_0125->IL0128: Incompatible stack types: I vs Ref
		//IL_0118->IL0128: Incompatible stack types: I vs Ref
		//IL_016e->IL0171: Incompatible stack types: I vs Ref
		//IL_0161->IL0171: Incompatible stack types: I vs Ref
		//IL_01b7->IL01ba: Incompatible stack types: I vs Ref
		//IL_01aa->IL01ba: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
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
		byte* num4 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T5 reference5;
		if (!typeof(T5).IsValueType)
		{
			object obj5 = arg5;
			reference5 = ref *(_003F*)((!(obj5 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj5 is Il2CppObjectBase) ? obj5 : null)) : IL2CPP.ManagedStringToIl2Cpp(obj5 as string));
		}
		else
		{
			reference5 = ref arg5;
		}
		*(void**)num4 = Unsafe.AsPointer(ref reference5);
		byte* num5 = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T6 reference6;
		if (!typeof(T6).IsValueType)
		{
			object obj6 = arg6;
			reference6 = ref *(_003F*)((!(obj6 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj6 is Il2CppObjectBase) ? obj6 : null)) : IL2CPP.ManagedStringToIl2Cpp(obj6 as string));
		}
		else
		{
			reference6 = ref arg6;
		}
		*(void**)num5 = Unsafe.AsPointer(ref reference6);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_T3_T4_T5_T6_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Action(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator Action<T1, T2, T3, T4, T5, T6>(System.Action<T1, T2, T3, T4, T5, T6> P_0)
	{
		return DelegateSupport.ConvertDelegate<Action<T1, T2, T3, T4, T5, T6>>((System.Delegate)P_0);
	}

	public static Action<T1, T2, T3, T4, T5, T6> operator +(Action<T1, T2, T3, T4, T5, T6> P_0, Action<T1, T2, T3, T4, T5, T6> P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<Action<T1, T2, T3, T4, T5, T6>>();
	}

	public static Action<T1, T2, T3, T4, T5, T6> operator -(Action<T1, T2, T3, T4, T5, T6> P_0, Action<T1, T2, T3, T4, T5, T6> P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<Action<T1, T2, T3, T4, T5, T6>>();
		}
		return (Action<T1, T2, T3, T4, T5, T6>)obj;
	}
}
public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8> : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_T3_T4_T5_T6_T7_T8_0;

	static Action()
	{
		Il2CppClassPointerStore<Action<T1, T2, T3, T4, T5, T6, T7, T8>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Action`8"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[8]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr))
		})).TypeHandle.value);
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action<T1, T2, T3, T4, T5, T6, T7, T8>>.NativeClassPtr, 100664230);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_T3_T4_T5_T6_T7_T8_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action<T1, T2, T3, T4, T5, T6, T7, T8>>.NativeClassPtr, 100664231);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718141, XrefRangeEnd = 718144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Action(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Action<T1, T2, T3, T4, T5, T6, T7, T8>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718144, XrefRangeEnd = 718153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
	{
		//IL_004c->IL004f: Incompatible stack types: I vs Ref
		//IL_003f->IL004f: Incompatible stack types: I vs Ref
		//IL_0094->IL0097: Incompatible stack types: I vs Ref
		//IL_0087->IL0097: Incompatible stack types: I vs Ref
		//IL_00dc->IL00df: Incompatible stack types: I vs Ref
		//IL_00cf->IL00df: Incompatible stack types: I vs Ref
		//IL_0125->IL0128: Incompatible stack types: I vs Ref
		//IL_0118->IL0128: Incompatible stack types: I vs Ref
		//IL_016e->IL0171: Incompatible stack types: I vs Ref
		//IL_0161->IL0171: Incompatible stack types: I vs Ref
		//IL_01b7->IL01ba: Incompatible stack types: I vs Ref
		//IL_01aa->IL01ba: Incompatible stack types: I vs Ref
		//IL_0200->IL0203: Incompatible stack types: I vs Ref
		//IL_01f3->IL0203: Incompatible stack types: I vs Ref
		//IL_0249->IL024c: Incompatible stack types: I vs Ref
		//IL_023c->IL024c: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
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
		byte* num4 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T5 reference5;
		if (!typeof(T5).IsValueType)
		{
			object obj5 = arg5;
			reference5 = ref *(_003F*)((!(obj5 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj5 is Il2CppObjectBase) ? obj5 : null)) : IL2CPP.ManagedStringToIl2Cpp(obj5 as string));
		}
		else
		{
			reference5 = ref arg5;
		}
		*(void**)num4 = Unsafe.AsPointer(ref reference5);
		byte* num5 = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T6 reference6;
		if (!typeof(T6).IsValueType)
		{
			object obj6 = arg6;
			reference6 = ref *(_003F*)((!(obj6 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj6 is Il2CppObjectBase) ? obj6 : null)) : IL2CPP.ManagedStringToIl2Cpp(obj6 as string));
		}
		else
		{
			reference6 = ref arg6;
		}
		*(void**)num5 = Unsafe.AsPointer(ref reference6);
		byte* num6 = (byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T7 reference7;
		if (!typeof(T7).IsValueType)
		{
			object obj7 = arg7;
			reference7 = ref *(_003F*)((!(obj7 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj7 is Il2CppObjectBase) ? obj7 : null)) : IL2CPP.ManagedStringToIl2Cpp(obj7 as string));
		}
		else
		{
			reference7 = ref arg7;
		}
		*(void**)num6 = Unsafe.AsPointer(ref reference7);
		byte* num7 = (byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T8 reference8;
		if (!typeof(T8).IsValueType)
		{
			object obj8 = arg8;
			reference8 = ref *(_003F*)((!(obj8 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj8 is Il2CppObjectBase) ? obj8 : null)) : IL2CPP.ManagedStringToIl2Cpp(obj8 as string));
		}
		else
		{
			reference8 = ref arg8;
		}
		*(void**)num7 = Unsafe.AsPointer(ref reference8);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_T3_T4_T5_T6_T7_T8_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Action(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator Action<T1, T2, T3, T4, T5, T6, T7, T8>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8> P_0)
	{
		return DelegateSupport.ConvertDelegate<Action<T1, T2, T3, T4, T5, T6, T7, T8>>((System.Delegate)P_0);
	}

	public static Action<T1, T2, T3, T4, T5, T6, T7, T8> operator +(Action<T1, T2, T3, T4, T5, T6, T7, T8> P_0, Action<T1, T2, T3, T4, T5, T6, T7, T8> P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<Action<T1, T2, T3, T4, T5, T6, T7, T8>>();
	}

	public static Action<T1, T2, T3, T4, T5, T6, T7, T8> operator -(Action<T1, T2, T3, T4, T5, T6, T7, T8> P_0, Action<T1, T2, T3, T4, T5, T6, T7, T8> P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<Action<T1, T2, T3, T4, T5, T6, T7, T8>>();
		}
		return (Action<T1, T2, T3, T4, T5, T6, T7, T8>)obj;
	}
}
