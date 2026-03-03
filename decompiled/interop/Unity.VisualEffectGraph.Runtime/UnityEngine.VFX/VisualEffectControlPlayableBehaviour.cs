using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Playables;
using UnityEngine.VFX.Utility;

namespace UnityEngine.VFX;

public class VisualEffectControlPlayableBehaviour : PlayableBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__clipStart_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__clipEnd_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__scrubbing_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__reinitEnter_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__reinitExit_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__startSeed_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__events_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__clipEventsCount_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__prewarmStepCount_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__prewarmDeltaTime_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__prewarmEvent_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_clipStart_Public_get_Double_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_clipStart_Public_set_Void_Double_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_clipEnd_Public_get_Double_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_clipEnd_Public_set_Void_Double_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_scrubbing_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_scrubbing_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_reinitEnter_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_reinitEnter_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_reinitExit_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_reinitExit_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_startSeed_Public_get_UInt32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_startSeed_Public_set_Void_UInt32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_events_Public_get_Il2CppReferenceArray_1_VisualEffectPlayableSerializedEvent_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_events_Public_set_Void_Il2CppReferenceArray_1_VisualEffectPlayableSerializedEvent_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_clipEventsCount_Public_get_UInt32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_clipEventsCount_Public_set_Void_UInt32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_prewarmStepCount_Public_get_UInt32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_prewarmStepCount_Public_set_Void_UInt32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_prewarmDeltaTime_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_prewarmDeltaTime_Public_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_prewarmEvent_Public_get_ExposedProperty_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_prewarmEvent_Public_set_Void_ExposedProperty_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe double _clipStart_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__clipStart_k__BackingField);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__clipStart_k__BackingField)) = value;
		}
	}

	public unsafe double _clipEnd_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__clipEnd_k__BackingField);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__clipEnd_k__BackingField)) = value;
		}
	}

	public unsafe bool _scrubbing_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scrubbing_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scrubbing_k__BackingField)) = value;
		}
	}

	public unsafe bool _reinitEnter_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reinitEnter_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reinitEnter_k__BackingField)) = value;
		}
	}

	public unsafe bool _reinitExit_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reinitExit_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reinitExit_k__BackingField)) = value;
		}
	}

	public unsafe uint _startSeed_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__startSeed_k__BackingField);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__startSeed_k__BackingField)) = value;
		}
	}

	public unsafe Il2CppReferenceArray<VisualEffectPlayableSerializedEvent> _events_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__events_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VisualEffectPlayableSerializedEvent>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__events_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe uint _clipEventsCount_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__clipEventsCount_k__BackingField);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__clipEventsCount_k__BackingField)) = value;
		}
	}

	public unsafe uint _prewarmStepCount_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__prewarmStepCount_k__BackingField);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__prewarmStepCount_k__BackingField)) = value;
		}
	}

	public unsafe float _prewarmDeltaTime_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__prewarmDeltaTime_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__prewarmDeltaTime_k__BackingField)) = value;
		}
	}

	public unsafe ExposedProperty _prewarmEvent_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__prewarmEvent_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ExposedProperty>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__prewarmEvent_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe double clipStart
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clipStart_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_clipStart_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe double clipEnd
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clipEnd_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_clipEnd_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool scrubbing
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scrubbing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 59885, RefRangeEnd = 59887, XrefRangeStart = 59885, XrefRangeEnd = 59887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_scrubbing_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool reinitEnter
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_reinitEnter_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_reinitEnter_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool reinitExit
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_reinitExit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_reinitExit_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe uint startSeed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_startSeed_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_startSeed_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppReferenceArray<VisualEffectPlayableSerializedEvent> events
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 42604, RefRangeEnd = 42610, XrefRangeStart = 42604, XrefRangeEnd = 42610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_events_Public_get_Il2CppReferenceArray_1_VisualEffectPlayableSerializedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VisualEffectPlayableSerializedEvent>>(intPtr2) : null;
		}
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 41896, RefRangeEnd = 41911, XrefRangeStart = 41896, XrefRangeEnd = 41911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_events_Public_set_Void_Il2CppReferenceArray_1_VisualEffectPlayableSerializedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe uint clipEventsCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66330, RefRangeEnd = 66331, XrefRangeStart = 66330, XrefRangeEnd = 66331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clipEventsCount_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243941, RefRangeEnd = 243942, XrefRangeStart = 243941, XrefRangeEnd = 243942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_clipEventsCount_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe uint prewarmStepCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 65293, RefRangeEnd = 65294, XrefRangeStart = 65293, XrefRangeEnd = 65294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_prewarmStepCount_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_prewarmStepCount_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float prewarmDeltaTime
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_prewarmDeltaTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 842832, RefRangeEnd = 842835, XrefRangeStart = 842832, XrefRangeEnd = 842835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_prewarmDeltaTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ExposedProperty prewarmEvent
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_prewarmEvent_Public_get_ExposedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ExposedProperty>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_prewarmEvent_Public_set_Void_ExposedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static VisualEffectControlPlayableBehaviour()
	{
		Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.VisualEffectGraph.Runtime.dll", "UnityEngine.VFX", "VisualEffectControlPlayableBehaviour");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr);
		NativeFieldInfoPtr__clipStart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, "<clipStart>k__BackingField");
		NativeFieldInfoPtr__clipEnd_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, "<clipEnd>k__BackingField");
		NativeFieldInfoPtr__scrubbing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, "<scrubbing>k__BackingField");
		NativeFieldInfoPtr__reinitEnter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, "<reinitEnter>k__BackingField");
		NativeFieldInfoPtr__reinitExit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, "<reinitExit>k__BackingField");
		NativeFieldInfoPtr__startSeed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, "<startSeed>k__BackingField");
		NativeFieldInfoPtr__events_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, "<events>k__BackingField");
		NativeFieldInfoPtr__clipEventsCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, "<clipEventsCount>k__BackingField");
		NativeFieldInfoPtr__prewarmStepCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, "<prewarmStepCount>k__BackingField");
		NativeFieldInfoPtr__prewarmDeltaTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, "<prewarmDeltaTime>k__BackingField");
		NativeFieldInfoPtr__prewarmEvent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, "<prewarmEvent>k__BackingField");
		NativeMethodInfoPtr_get_clipStart_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, 100663403);
		NativeMethodInfoPtr_set_clipStart_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, 100663404);
		NativeMethodInfoPtr_get_clipEnd_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, 100663405);
		NativeMethodInfoPtr_set_clipEnd_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, 100663406);
		NativeMethodInfoPtr_get_scrubbing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, 100663407);
		NativeMethodInfoPtr_set_scrubbing_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, 100663408);
		NativeMethodInfoPtr_get_reinitEnter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, 100663409);
		NativeMethodInfoPtr_set_reinitEnter_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, 100663410);
		NativeMethodInfoPtr_get_reinitExit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, 100663411);
		NativeMethodInfoPtr_set_reinitExit_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, 100663412);
		NativeMethodInfoPtr_get_startSeed_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, 100663413);
		NativeMethodInfoPtr_set_startSeed_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, 100663414);
		NativeMethodInfoPtr_get_events_Public_get_Il2CppReferenceArray_1_VisualEffectPlayableSerializedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, 100663415);
		NativeMethodInfoPtr_set_events_Public_set_Void_Il2CppReferenceArray_1_VisualEffectPlayableSerializedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, 100663416);
		NativeMethodInfoPtr_get_clipEventsCount_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, 100663417);
		NativeMethodInfoPtr_set_clipEventsCount_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, 100663418);
		NativeMethodInfoPtr_get_prewarmStepCount_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, 100663419);
		NativeMethodInfoPtr_set_prewarmStepCount_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, 100663420);
		NativeMethodInfoPtr_get_prewarmDeltaTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, 100663421);
		NativeMethodInfoPtr_set_prewarmDeltaTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, 100663422);
		NativeMethodInfoPtr_get_prewarmEvent_Public_get_ExposedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, 100663423);
		NativeMethodInfoPtr_set_prewarmEvent_Public_set_Void_ExposedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, 100663424);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr, 100663425);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VisualEffectControlPlayableBehaviour()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualEffectControlPlayableBehaviour>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public VisualEffectControlPlayableBehaviour(IntPtr pointer)
		: base(pointer)
	{
	}
}
