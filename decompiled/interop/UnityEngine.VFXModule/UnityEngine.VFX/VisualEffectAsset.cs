using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.VFX;

public class VisualEffectAsset : VisualEffectObject
{
	private static readonly IntPtr NativeFieldInfoPtr_PlayEventName;

	private static readonly IntPtr NativeFieldInfoPtr_StopEventName;

	private static readonly IntPtr NativeFieldInfoPtr_PlayEventID;

	private static readonly IntPtr NativeFieldInfoPtr_StopEventID;

	private static readonly IntPtr NativeMethodInfoPtr_GetTextureDimension_Public_TextureDimension_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetExposedSpace_Public_VFXSpace_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetExposedProperties_Public_Void_List_1_VFXExposedProperty_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetEvents_Public_Void_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_HasSystem_Internal_Boolean_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSystemNames_Internal_Void_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetParticleSystemNames_Internal_Void_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetOutputEventNames_Internal_Void_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSpawnSystemNames_Internal_Void_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetTextureDimension_Public_TextureDimension_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetExposedSpace_Public_VFXSpace_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetTextureDimension_Injected_Private_Static_TextureDimension_IntPtr_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetExposedSpace_Injected_Private_Static_VFXSpace_IntPtr_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetExposedProperties_Injected_Private_Static_Void_IntPtr_List_1_VFXExposedProperty_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetEvents_Injected_Private_Static_Void_IntPtr_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_HasSystem_Injected_Private_Static_Boolean_IntPtr_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSystemNames_Injected_Private_Static_Void_IntPtr_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetParticleSystemNames_Injected_Private_Static_Void_IntPtr_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetOutputEventNames_Injected_Private_Static_Void_IntPtr_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSpawnSystemNames_Injected_Private_Static_Void_IntPtr_List_1_String_0;

	public unsafe static string PlayEventName
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayEventName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayEventName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string StopEventName
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_StopEventName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_StopEventName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static int PlayEventID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayEventID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayEventID, (void*)(&value));
		}
	}

	public unsafe static int StopEventID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_StopEventID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_StopEventID, (void*)(&value));
		}
	}

	static VisualEffectAsset()
	{
		Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VisualEffectAsset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr);
		NativeFieldInfoPtr_PlayEventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, "PlayEventName");
		NativeFieldInfoPtr_StopEventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, "StopEventName");
		NativeFieldInfoPtr_PlayEventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, "PlayEventID");
		NativeFieldInfoPtr_StopEventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, "StopEventID");
		NativeMethodInfoPtr_GetTextureDimension_Public_TextureDimension_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, 100663406);
		NativeMethodInfoPtr_GetExposedSpace_Public_VFXSpace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, 100663407);
		NativeMethodInfoPtr_GetExposedProperties_Public_Void_List_1_VFXExposedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, 100663408);
		NativeMethodInfoPtr_GetEvents_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, 100663409);
		NativeMethodInfoPtr_HasSystem_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, 100663410);
		NativeMethodInfoPtr_GetSystemNames_Internal_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, 100663411);
		NativeMethodInfoPtr_GetParticleSystemNames_Internal_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, 100663412);
		NativeMethodInfoPtr_GetOutputEventNames_Internal_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, 100663413);
		NativeMethodInfoPtr_GetSpawnSystemNames_Internal_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, 100663414);
		NativeMethodInfoPtr_GetTextureDimension_Public_TextureDimension_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, 100663415);
		NativeMethodInfoPtr_GetExposedSpace_Public_VFXSpace_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, 100663416);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, 100663417);
		NativeMethodInfoPtr_GetTextureDimension_Injected_Private_Static_TextureDimension_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, 100663419);
		NativeMethodInfoPtr_GetExposedSpace_Injected_Private_Static_VFXSpace_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, 100663420);
		NativeMethodInfoPtr_GetExposedProperties_Injected_Private_Static_Void_IntPtr_List_1_VFXExposedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, 100663421);
		NativeMethodInfoPtr_GetEvents_Injected_Private_Static_Void_IntPtr_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, 100663422);
		NativeMethodInfoPtr_HasSystem_Injected_Private_Static_Boolean_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, 100663423);
		NativeMethodInfoPtr_GetSystemNames_Injected_Private_Static_Void_IntPtr_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, 100663424);
		NativeMethodInfoPtr_GetParticleSystemNames_Injected_Private_Static_Void_IntPtr_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, 100663425);
		NativeMethodInfoPtr_GetOutputEventNames_Injected_Private_Static_Void_IntPtr_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, 100663426);
		NativeMethodInfoPtr_GetSpawnSystemNames_Injected_Private_Static_Void_IntPtr_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, 100663427);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409262, XrefRangeEnd = 1409270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureDimension GetTextureDimension(int nameID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&nameID);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureDimension_Public_TextureDimension_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureDimension*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1409278, RefRangeEnd = 1409282, XrefRangeStart = 1409270, XrefRangeEnd = 1409278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VFXSpace GetExposedSpace(int nameID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&nameID);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExposedSpace_Public_VFXSpace_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(VFXSpace*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409282, XrefRangeEnd = 1409293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetExposedProperties(List<VFXExposedProperty> exposedProperties)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exposedProperties);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExposedProperties_Public_Void_List_1_VFXExposedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409293, XrefRangeEnd = 1409304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetEvents(List<string> names)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)names);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEvents_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409304, XrefRangeEnd = 1409321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasSystem(int nameID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&nameID);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasSystem_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409321, XrefRangeEnd = 1409332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetSystemNames(List<string> names)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)names);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSystemNames_Internal_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409332, XrefRangeEnd = 1409343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetParticleSystemNames(List<string> names)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)names);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParticleSystemNames_Internal_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409343, XrefRangeEnd = 1409354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetOutputEventNames(List<string> names)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)names);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOutputEventNames_Internal_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409354, XrefRangeEnd = 1409365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetSpawnSystemNames(List<string> names)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)names);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpawnSystemNames_Internal_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409365, XrefRangeEnd = 1409374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureDimension GetTextureDimension(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureDimension_Public_TextureDimension_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureDimension*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409374, XrefRangeEnd = 1409383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VFXSpace GetExposedSpace(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExposedSpace_Public_VFXSpace_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(VFXSpace*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VisualEffectAsset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409383, XrefRangeEnd = 1409385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TextureDimension GetTextureDimension_Injected(IntPtr _unity_self, int nameID)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &nameID;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureDimension_Injected_Private_Static_TextureDimension_IntPtr_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureDimension*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409385, XrefRangeEnd = 1409387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static VFXSpace GetExposedSpace_Injected(IntPtr _unity_self, int nameID)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &nameID;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExposedSpace_Injected_Private_Static_VFXSpace_IntPtr_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(VFXSpace*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409387, XrefRangeEnd = 1409389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetExposedProperties_Injected(IntPtr _unity_self, List<VFXExposedProperty> exposedProperties)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exposedProperties);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExposedProperties_Injected_Private_Static_Void_IntPtr_List_1_VFXExposedProperty_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409389, XrefRangeEnd = 1409391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetEvents_Injected(IntPtr _unity_self, List<string> names)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)names);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEvents_Injected_Private_Static_Void_IntPtr_List_1_String_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409391, XrefRangeEnd = 1409393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasSystem_Injected(IntPtr _unity_self, int nameID)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &nameID;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasSystem_Injected_Private_Static_Boolean_IntPtr_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409393, XrefRangeEnd = 1409395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetSystemNames_Injected(IntPtr _unity_self, List<string> names)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)names);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSystemNames_Injected_Private_Static_Void_IntPtr_List_1_String_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409395, XrefRangeEnd = 1409397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetParticleSystemNames_Injected(IntPtr _unity_self, List<string> names)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)names);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParticleSystemNames_Injected_Private_Static_Void_IntPtr_List_1_String_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409397, XrefRangeEnd = 1409399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetOutputEventNames_Injected(IntPtr _unity_self, List<string> names)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)names);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOutputEventNames_Injected_Private_Static_Void_IntPtr_List_1_String_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409399, XrefRangeEnd = 1409401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetSpawnSystemNames_Injected(IntPtr _unity_self, List<string> names)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)names);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpawnSystemNames_Injected_Private_Static_Void_IntPtr_List_1_String_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public VisualEffectAsset(IntPtr pointer)
		: base(pointer)
	{
	}
}
