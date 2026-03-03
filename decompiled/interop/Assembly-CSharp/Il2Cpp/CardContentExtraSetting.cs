using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp;

public class CardContentExtraSetting : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_m_Instance;

	private static readonly IntPtr NativeFieldInfoPtr_noStarCardIds;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_CardContentExtraSetting_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsNoStarCard_Public_Boolean_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe static CardContentExtraSetting m_Instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_Instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<CardContentExtraSetting>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> noStarCardIds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noStarCardIds);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noStarCardIds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CardContentExtraSetting Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31999, XrefRangeEnd = 32001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_CardContentExtraSetting_0, (IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<CardContentExtraSetting>(intPtr2) : null;
		}
	}

	static CardContentExtraSetting()
	{
		Il2CppClassPointerStore<CardContentExtraSetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CardContentExtraSetting");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardContentExtraSetting>.NativeClassPtr);
		NativeFieldInfoPtr_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardContentExtraSetting>.NativeClassPtr, "PATH");
		NativeFieldInfoPtr_m_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardContentExtraSetting>.NativeClassPtr, "m_Instance");
		NativeFieldInfoPtr_noStarCardIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardContentExtraSetting>.NativeClassPtr, "noStarCardIds");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_CardContentExtraSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardContentExtraSetting>.NativeClassPtr, 100663526);
		NativeMethodInfoPtr_CreateInstance_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardContentExtraSetting>.NativeClassPtr, 100663527);
		NativeMethodInfoPtr_IsNoStarCard_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardContentExtraSetting>.NativeClassPtr, 100663528);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardContentExtraSetting>.NativeClassPtr, 100663529);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32015, RefRangeEnd = 32016, XrefRangeStart = 32001, XrefRangeEnd = 32015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateInstance()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInstance_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 32017, RefRangeEnd = 32019, XrefRangeStart = 32016, XrefRangeEnd = 32017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsNoStarCard(int cardId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&cardId);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNoStarCard_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(36)]
	[CachedScanResults(RefRangeStart = 26528, RefRangeEnd = 26564, XrefRangeStart = 26528, XrefRangeEnd = 26564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardContentExtraSetting()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardContentExtraSetting>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CardContentExtraSetting(IntPtr pointer)
		: base(pointer)
	{
	}
}
