using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine;

[System.Serializable]
public sealed class LazyLoadReference<T> : Il2CppSystem.ValueType where T : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_kInstanceID_None;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InstanceID;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isSet_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_asset_Public_get_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_asset_Public_set_Void_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LazyLoadReference_1_T_T_0;

	public unsafe static int kInstanceID_None
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kInstanceID_None, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kInstanceID_None, (void*)(&value));
		}
	}

	public unsafe int m_InstanceID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceID)) = value;
		}
	}

	public unsafe bool isSet
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1202940, RefRangeEnd = 1202941, XrefRangeStart = 1202940, XrefRangeEnd = 1202940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isSet_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe T asset
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202941, XrefRangeEnd = 1202949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_asset_Public_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202949, XrefRangeEnd = 1202957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			//IL_004c->IL004f: Incompatible stack types: I vs Ref
			//IL_003f->IL004f: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			ref T reference;
			if (!typeof(T).IsValueType)
			{
				T val = value;
				reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
			}
			else
			{
				reference = ref value;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_asset_Public_set_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public bool isBroken => ((LazyLoadReference<>)(object)this).m_InstanceID != 0 && !Object.DoesObjectWithInstanceIDExist(((LazyLoadReference<>)(object)this).m_InstanceID);

	public int instanceID
	{
		get
		{
			return ((LazyLoadReference<>)(object)this).m_InstanceID;
		}
		set
		{
			((LazyLoadReference<>)(object)this).m_InstanceID = value;
		}
	}

	static LazyLoadReference()
	{
		Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LazyLoadReference`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr);
		NativeFieldInfoPtr_kInstanceID_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr, "kInstanceID_None");
		NativeFieldInfoPtr_m_InstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr, "m_InstanceID");
		NativeMethodInfoPtr_get_isSet_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr, 100666390);
		NativeMethodInfoPtr_get_asset_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr, 100666391);
		NativeMethodInfoPtr_set_asset_Public_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr, 100666392);
		NativeMethodInfoPtr_op_Implicit_Public_Static_LazyLoadReference_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr, 100666393);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1202959, RefRangeEnd = 1202960, XrefRangeStart = 1202957, XrefRangeEnd = 1202959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator LazyLoadReference<T>(T asset)
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = asset;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref asset;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_LazyLoadReference_1_T_T_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new LazyLoadReference<T>(pointer);
	}

	public LazyLoadReference(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public LazyLoadReference()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr))
	{
	}

	public unsafe static implicit operator LazyLoadReference<T>(int instanceID)
	{
		//IL_0011: Expected O, but got Ref
		LazyLoadReference<T> result = null;
		((LazyLoadReference<T>)(&result)).instanceID = instanceID;
		return result;
	}
}
