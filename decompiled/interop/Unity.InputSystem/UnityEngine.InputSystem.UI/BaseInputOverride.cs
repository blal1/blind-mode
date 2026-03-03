using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.EventSystems;

namespace UnityEngine.InputSystem.UI;

public class BaseInputOverride : BaseInput
{
	private static readonly IntPtr NativeFieldInfoPtr__compositionString_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_compositionString_Public_Virtual_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string _compositionString_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__compositionString_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__compositionString_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe override string compositionString
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_compositionString_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	static BaseInputOverride()
	{
		Il2CppClassPointerStore<BaseInputOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.UI", "BaseInputOverride");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseInputOverride>.NativeClassPtr);
		NativeFieldInfoPtr__compositionString_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseInputOverride>.NativeClassPtr, "<compositionString>k__BackingField");
		NativeMethodInfoPtr_get_compositionString_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputOverride>.NativeClassPtr, 100666680);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputOverride>.NativeClassPtr, 100666681);
	}

	[CallerCount(39)]
	[CachedScanResults(RefRangeStart = 38937, RefRangeEnd = 38976, XrefRangeStart = 38937, XrefRangeEnd = 38976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BaseInputOverride()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseInputOverride>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public BaseInputOverride(IntPtr pointer)
		: base(pointer)
	{
	}
}
