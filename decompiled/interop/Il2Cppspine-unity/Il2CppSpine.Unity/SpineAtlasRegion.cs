using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2CppSpine.Unity;

public class SpineAtlasRegion : PropertyAttribute
{
	private static readonly IntPtr NativeFieldInfoPtr_atlasAssetField;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	public unsafe string atlasAssetField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atlasAssetField);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atlasAssetField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static SpineAtlasRegion()
	{
		Il2CppClassPointerStore<SpineAtlasRegion>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-unity.dll", "Spine.Unity", "SpineAtlasRegion");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpineAtlasRegion>.NativeClassPtr);
		NativeFieldInfoPtr_atlasAssetField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineAtlasRegion>.NativeClassPtr, "atlasAssetField");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpineAtlasRegion>.NativeClassPtr, 100664133);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 110022, RefRangeEnd = 110023, XrefRangeStart = 110022, XrefRangeEnd = 110023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpineAtlasRegion(string atlasAssetField = "")
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpineAtlasRegion>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(atlasAssetField);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SpineAtlasRegion(IntPtr pointer)
		: base(pointer)
	{
	}
}
