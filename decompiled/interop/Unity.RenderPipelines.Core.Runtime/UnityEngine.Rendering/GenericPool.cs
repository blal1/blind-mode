using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public static class GenericPool<T> : Il2CppSystem.Object where T : new()
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_Pool;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_PooledObject_T_byref_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_T_0;

	public unsafe static ObjectPool<T> s_Pool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Pool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectPool<T>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Pool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static GenericPool()
	{
		Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "GenericPool`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr);
		NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr, "s_Pool");
		NativeMethodInfoPtr_Get_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr, 100664479);
		NativeMethodInfoPtr_Get_Public_Static_PooledObject_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr, 100664480);
		NativeMethodInfoPtr_Release_Public_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr, 100664481);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1029671, RefRangeEnd = 1029673, XrefRangeStart = 1029663, XrefRangeEnd = 1029671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T Get()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_T_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1029680, RefRangeEnd = 1029688, XrefRangeStart = 1029673, XrefRangeEnd = 1029680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ObjectPool<T>.PooledObject Get(out T value)
	{
		//IL_0026->IL0028: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		Unsafe.SkipInit(out nint num);
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			num = 0;
			reference = ref *(_003F*)(&num);
		}
		else
		{
			reference = ref value;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_PooledObject_T_byref_T_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		if (!typeof(T).IsValueType)
		{
			nint num2 = num;
			Unsafe.As<T, object>(ref value) = ((num2 == 0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>((System.IntPtr)num2, false, false));
		}
		return new ObjectPool<T>.PooledObject(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1029696, RefRangeEnd = 1029698, XrefRangeStart = 1029688, XrefRangeEnd = 1029696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Release(T toRelease)
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = toRelease;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref toRelease;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Release_Public_Static_Void_T_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GenericPool(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
