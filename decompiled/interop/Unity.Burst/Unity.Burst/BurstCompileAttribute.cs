using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Burst;

public class BurstCompileAttribute : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__FloatMode_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__FloatPrecision_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__compileSynchronously;

	private static readonly System.IntPtr NativeFieldInfoPtr__disableSafetyChecks;

	private static readonly System.IntPtr NativeFieldInfoPtr__OptimizeFor_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Options_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_FloatMode_Public_set_Void_FloatMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_FloatPrecision_Public_set_Void_FloatPrecision_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_CompileSynchronously_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_DisableSafetyChecks_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_OptimizeFor_Public_set_Void_OptimizeFor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Options_Internal_set_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FloatPrecision_FloatMode_0;

	public unsafe FloatMode _FloatMode_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FloatMode_k__BackingField);
			return *(FloatMode*)num;
		}
		set
		{
			*(FloatMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FloatMode_k__BackingField)) = value;
		}
	}

	public unsafe FloatPrecision _FloatPrecision_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FloatPrecision_k__BackingField);
			return *(FloatPrecision*)num;
		}
		set
		{
			*(FloatPrecision*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FloatPrecision_k__BackingField)) = value;
		}
	}

	public unsafe Il2CppSystem.Nullable<bool> _compileSynchronously
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__compileSynchronously);
			return new Il2CppSystem.Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<bool>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__compileSynchronously), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<bool>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Il2CppSystem.Nullable<bool> _disableSafetyChecks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__disableSafetyChecks);
			return new Il2CppSystem.Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<bool>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__disableSafetyChecks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<bool>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe OptimizeFor _OptimizeFor_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OptimizeFor_k__BackingField);
			return *(OptimizeFor*)num;
		}
		set
		{
			*(OptimizeFor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OptimizeFor_k__BackingField)) = value;
		}
	}

	public unsafe Il2CppStringArray _Options_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Options_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Options_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe FloatMode FloatMode
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 86468, RefRangeEnd = 86476, XrefRangeStart = 86468, XrefRangeEnd = 86476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_FloatMode_Public_set_Void_FloatMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe FloatPrecision FloatPrecision
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 164133, RefRangeEnd = 164138, XrefRangeStart = 164133, XrefRangeEnd = 164138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_FloatPrecision_Public_set_Void_FloatPrecision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool CompileSynchronously
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 958576, RefRangeEnd = 958577, XrefRangeStart = 958573, XrefRangeEnd = 958576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CompileSynchronously_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool DisableSafetyChecks
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958577, XrefRangeEnd = 958580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DisableSafetyChecks_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe OptimizeFor OptimizeFor
	{
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_OptimizeFor_Public_set_Void_OptimizeFor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppStringArray Options
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 32149, RefRangeEnd = 32159, XrefRangeStart = 32149, XrefRangeEnd = 32159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Options_Internal_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static BurstCompileAttribute()
	{
		Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst", "BurstCompileAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__FloatMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, "<FloatMode>k__BackingField");
		NativeFieldInfoPtr__FloatPrecision_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, "<FloatPrecision>k__BackingField");
		NativeFieldInfoPtr__compileSynchronously = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, "_compileSynchronously");
		NativeFieldInfoPtr__disableSafetyChecks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, "_disableSafetyChecks");
		NativeFieldInfoPtr__OptimizeFor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, "<OptimizeFor>k__BackingField");
		NativeFieldInfoPtr__Options_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, "<Options>k__BackingField");
		NativeMethodInfoPtr_set_FloatMode_Public_set_Void_FloatMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_set_FloatPrecision_Public_set_Void_FloatPrecision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr_set_CompileSynchronously_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_set_DisableSafetyChecks_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_set_OptimizeFor_Public_set_Void_OptimizeFor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_set_Options_Internal_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr__ctor_Public_Void_FloatPrecision_FloatMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663304);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BurstCompileAttribute()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958580, XrefRangeEnd = 958581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BurstCompileAttribute(FloatPrecision floatPrecision, FloatMode floatMode)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&floatPrecision);
		*(FloatMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &floatMode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_FloatPrecision_FloatMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public BurstCompileAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
