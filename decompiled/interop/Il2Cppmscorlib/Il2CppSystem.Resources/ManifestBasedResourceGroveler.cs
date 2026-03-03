using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Resources;

public class ManifestBasedResourceGroveler : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__mediator;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ResourceManagerMediator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNeutralResourcesLanguage_Internal_Static_CultureInfo_Assembly_byref_UltimateResourceFallbackLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNeutralResourcesLanguageAttribute_Private_Static_Boolean_Assembly_byref_String_byref_Int16_0;

	public unsafe ResourceManager.ResourceManagerMediator _mediator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mediator);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResourceManager.ResourceManagerMediator>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mediator)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ManifestBasedResourceGroveler()
	{
		Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "ManifestBasedResourceGroveler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr);
		NativeFieldInfoPtr__mediator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, "_mediator");
		NativeMethodInfoPtr__ctor_Public_Void_ResourceManagerMediator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100671591);
		NativeMethodInfoPtr_GetNeutralResourcesLanguage_Internal_Static_CultureInfo_Assembly_byref_UltimateResourceFallbackLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100671592);
		NativeMethodInfoPtr_GetNeutralResourcesLanguageAttribute_Private_Static_Boolean_Assembly_byref_String_byref_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100671593);
	}

	[CallerCount(215)]
	[CachedScanResults(RefRangeStart = 79185, RefRangeEnd = 79400, XrefRangeStart = 79185, XrefRangeEnd = 79400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ManifestBasedResourceGroveler(ResourceManager.ResourceManagerMediator mediator)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mediator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ResourceManagerMediator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 807712, RefRangeEnd = 807713, XrefRangeStart = 807694, XrefRangeEnd = 807712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CultureInfo GetNeutralResourcesLanguage(Assembly a, ref UltimateResourceFallbackLocation fallbackLocation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref fallbackLocation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNeutralResourcesLanguage_Internal_Static_CultureInfo_Assembly_byref_UltimateResourceFallbackLocation_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 807713, XrefRangeEnd = 807717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetNeutralResourcesLanguageAttribute(Assembly assembly, ref string cultureName, ref short fallbackLocation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)assembly);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(cultureName);
		*(System.IntPtr**)num = &intPtr;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref fallbackLocation);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNeutralResourcesLanguageAttribute_Private_Static_Boolean_Assembly_byref_String_byref_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		cultureName = IL2CPP.Il2CppStringToManaged(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	public ManifestBasedResourceGroveler(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
