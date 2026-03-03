using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

public class SPCardSetting : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_m_Instance;

	private static readonly IntPtr NativeFieldInfoPtr_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_m_SPMrksList;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Protected_Static_get_SPCardSetting_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsSPIllust_Public_Static_Boolean_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static SPCardSetting m_Instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_Instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<SPCardSetting>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static string PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe List<int> m_SPMrksList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SPMrksList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SPMrksList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static SPCardSetting Instance
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33155, RefRangeEnd = 33157, XrefRangeStart = 33135, XrefRangeEnd = 33155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Protected_Static_get_SPCardSetting_0, (IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<SPCardSetting>(intPtr2) : null;
		}
	}

	static SPCardSetting()
	{
		Il2CppClassPointerStore<SPCardSetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SPCardSetting");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SPCardSetting>.NativeClassPtr);
		NativeFieldInfoPtr_m_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPCardSetting>.NativeClassPtr, "m_Instance");
		NativeFieldInfoPtr_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPCardSetting>.NativeClassPtr, "PATH");
		NativeFieldInfoPtr_m_SPMrksList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPCardSetting>.NativeClassPtr, "m_SPMrksList");
		NativeMethodInfoPtr_get_Instance_Protected_Static_get_SPCardSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPCardSetting>.NativeClassPtr, 100663599);
		NativeMethodInfoPtr_IsSPIllust_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPCardSetting>.NativeClassPtr, 100663600);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPCardSetting>.NativeClassPtr, 100663601);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 33169, RefRangeEnd = 33177, XrefRangeStart = 33157, XrefRangeEnd = 33169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsSPIllust(int cardid)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&cardid);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSPIllust_Public_Static_Boolean_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(36)]
	[CachedScanResults(RefRangeStart = 26528, RefRangeEnd = 26564, XrefRangeStart = 26528, XrefRangeEnd = 26564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SPCardSetting()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SPCardSetting>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SPCardSetting(IntPtr pointer)
		: base(pointer)
	{
	}
}
