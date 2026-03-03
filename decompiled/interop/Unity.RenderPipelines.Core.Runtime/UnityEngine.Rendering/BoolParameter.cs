using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering;

[Serializable]
public class BoolParameter : VolumeParameter<bool>
{
	[OriginalName("Unity.RenderPipelines.Core.Runtime.dll", "", "DisplayType")]
	public enum DisplayType
	{
		Checkbox,
		EnumPopup
	}

	private static readonly IntPtr NativeFieldInfoPtr_displayType;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_DisplayType_Boolean_0;

	public unsafe DisplayType displayType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayType);
			return *(DisplayType*)num;
		}
		set
		{
			*(DisplayType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayType)) = value;
		}
	}

	static BoolParameter()
	{
		Il2CppClassPointerStore<BoolParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "BoolParameter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolParameter>.NativeClassPtr);
		NativeFieldInfoPtr_displayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolParameter>.NativeClassPtr, "displayType");
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolParameter>.NativeClassPtr, 100666924);
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_DisplayType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolParameter>.NativeClassPtr, 100666925);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1054563, RefRangeEnd = 1054571, XrefRangeStart = 1054560, XrefRangeEnd = 1054563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BoolParameter(bool value, bool overrideState = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolParameter>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&value);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &overrideState;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1054571, XrefRangeEnd = 1054574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BoolParameter(bool value, DisplayType displayType, bool overrideState = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolParameter>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&value);
		*(DisplayType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &displayType;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &overrideState;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_DisplayType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public BoolParameter(IntPtr pointer)
		: base(pointer)
	{
	}
}
