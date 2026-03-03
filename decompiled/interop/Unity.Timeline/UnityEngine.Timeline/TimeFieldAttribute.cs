using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Timeline;

public class TimeFieldAttribute : PropertyAttribute
{
	[OriginalName("Unity.Timeline.dll", "", "UseEditMode")]
	public enum UseEditMode
	{
		None,
		ApplyEditMode
	}

	private static readonly IntPtr NativeFieldInfoPtr__useEditMode_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_useEditMode_Public_get_UseEditMode_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UseEditMode_0;

	public unsafe UseEditMode _useEditMode_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useEditMode_k__BackingField);
			return *(UseEditMode*)num;
		}
		set
		{
			*(UseEditMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useEditMode_k__BackingField)) = value;
		}
	}

	public unsafe UseEditMode useEditMode
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useEditMode_Public_get_UseEditMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(UseEditMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static TimeFieldAttribute()
	{
		Il2CppClassPointerStore<TimeFieldAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TimeFieldAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeFieldAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__useEditMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeFieldAttribute>.NativeClassPtr, "<useEditMode>k__BackingField");
		NativeMethodInfoPtr_get_useEditMode_Public_get_UseEditMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeFieldAttribute>.NativeClassPtr, 100664087);
		NativeMethodInfoPtr__ctor_Public_Void_UseEditMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeFieldAttribute>.NativeClassPtr, 100664088);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TimeFieldAttribute(UseEditMode useEditMode = UseEditMode.ApplyEditMode)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeFieldAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&useEditMode);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UseEditMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TimeFieldAttribute(IntPtr pointer)
		: base(pointer)
	{
	}
}
