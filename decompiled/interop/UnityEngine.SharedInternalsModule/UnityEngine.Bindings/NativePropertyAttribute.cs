using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Bindings;

public class NativePropertyAttribute : NativeMethodAttribute
{
	private static readonly IntPtr NativeFieldInfoPtr__TargetType_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_set_TargetType_Public_set_Void_TargetType_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_TargetType_0;

	public unsafe TargetType _TargetType_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetType_k__BackingField);
			return *(TargetType*)num;
		}
		set
		{
			*(TargetType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetType_k__BackingField)) = value;
		}
	}

	public unsafe TargetType TargetType
	{
		get
		{
			return _TargetType_k__BackingField;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102244, RefRangeEnd = 102245, XrefRangeStart = 102244, XrefRangeEnd = 102245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TargetType_Public_set_Void_TargetType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static NativePropertyAttribute()
	{
		Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "NativePropertyAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__TargetType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr, "<TargetType>k__BackingField");
		NativeMethodInfoPtr_set_TargetType_Public_set_Void_TargetType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr, 100663327);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr, 100663328);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_TargetType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr, 100663330);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativePropertyAttribute()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271576, XrefRangeEnd = 1271577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativePropertyAttribute(string name)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271577, XrefRangeEnd = 1271578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativePropertyAttribute(string name, bool isFree, TargetType targetType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &isFree;
		*(TargetType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &targetType;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_TargetType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public NativePropertyAttribute(IntPtr pointer)
		: base(pointer)
	{
	}
}
