using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct Keyframe
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Time;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Value;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InTangent;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OutTangent;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_WeightedMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OutWeight;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_time_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_time_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_value_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_value_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_inTangent_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_inTangent_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_outTangent_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_outTangent_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_inWeight_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_inWeight_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_outWeight_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_outWeight_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_weightedMode_Public_get_WeightedMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_weightedMode_Public_set_Void_WeightedMode_0;

	[FieldOffset(0)]
	public float m_Time;

	[FieldOffset(4)]
	public float m_Value;

	[FieldOffset(8)]
	public float m_InTangent;

	[FieldOffset(12)]
	public float m_OutTangent;

	[FieldOffset(16)]
	public int m_WeightedMode;

	[FieldOffset(20)]
	public float m_InWeight;

	[FieldOffset(24)]
	public float m_OutWeight;

	public unsafe float time
	{
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 1167165, RefRangeEnd = 1167244, XrefRangeStart = 1167165, XrefRangeEnd = 1167165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_time_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 1007806, RefRangeEnd = 1007828, XrefRangeStart = 1007806, XrefRangeEnd = 1007828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_time_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float value
	{
		[CallerCount(90)]
		[CachedScanResults(RefRangeStart = 1153785, RefRangeEnd = 1153875, XrefRangeStart = 1153785, XrefRangeEnd = 1153875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_value_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 968557, RefRangeEnd = 968572, XrefRangeStart = 968557, XrefRangeEnd = 968572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_value_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float inTangent
	{
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 1161205, RefRangeEnd = 1161251, XrefRangeStart = 1161205, XrefRangeEnd = 1161251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inTangent_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1003681, RefRangeEnd = 1003686, XrefRangeStart = 1003681, XrefRangeEnd = 1003686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_inTangent_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float outTangent
	{
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 1154246, RefRangeEnd = 1154286, XrefRangeStart = 1154246, XrefRangeEnd = 1154286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_outTangent_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1007802, RefRangeEnd = 1007805, XrefRangeStart = 1007802, XrefRangeEnd = 1007805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_outTangent_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float inWeight
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1154286, RefRangeEnd = 1154293, XrefRangeStart = 1154286, XrefRangeEnd = 1154293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inWeight_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355317, RefRangeEnd = 355318, XrefRangeStart = 355317, XrefRangeEnd = 355318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_inWeight_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float outWeight
	{
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 1154293, RefRangeEnd = 1154355, XrefRangeStart = 1154293, XrefRangeEnd = 1154355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_outWeight_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110624, RefRangeEnd = 110625, XrefRangeStart = 110624, XrefRangeEnd = 110625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_outWeight_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe WeightedMode weightedMode
	{
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 1167244, RefRangeEnd = 1167304, XrefRangeStart = 1167244, XrefRangeEnd = 1167244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_weightedMode_Public_get_WeightedMode_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(WeightedMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 86468, RefRangeEnd = 86476, XrefRangeStart = 86468, XrefRangeEnd = 86476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_weightedMode_Public_set_Void_WeightedMode_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public int tangentMode
	{
		get
		{
			return tangentModeInternal;
		}
		set
		{
			tangentModeInternal = value;
		}
	}

	public int tangentModeInternal
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	static Keyframe()
	{
		Il2CppClassPointerStore<Keyframe>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Keyframe");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Keyframe>.NativeClassPtr);
		NativeFieldInfoPtr_m_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_Time");
		NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_Value");
		NativeFieldInfoPtr_m_InTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_InTangent");
		NativeFieldInfoPtr_m_OutTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_OutTangent");
		NativeFieldInfoPtr_m_WeightedMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_WeightedMode");
		NativeFieldInfoPtr_m_InWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_InWeight");
		NativeFieldInfoPtr_m_OutWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_OutWeight");
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663749);
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663750);
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663751);
		NativeMethodInfoPtr_get_time_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663752);
		NativeMethodInfoPtr_set_time_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663753);
		NativeMethodInfoPtr_get_value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663754);
		NativeMethodInfoPtr_set_value_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663755);
		NativeMethodInfoPtr_get_inTangent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663756);
		NativeMethodInfoPtr_set_inTangent_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663757);
		NativeMethodInfoPtr_get_outTangent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663758);
		NativeMethodInfoPtr_set_outTangent_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663759);
		NativeMethodInfoPtr_get_inWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663760);
		NativeMethodInfoPtr_set_inWeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663761);
		NativeMethodInfoPtr_get_outWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663762);
		NativeMethodInfoPtr_set_outWeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663763);
		NativeMethodInfoPtr_get_weightedMode_Public_get_WeightedMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663764);
		NativeMethodInfoPtr_set_weightedMode_Public_set_Void_WeightedMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663765);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 1167126, RefRangeEnd = 1167142, XrefRangeStart = 1167126, XrefRangeEnd = 1167126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Keyframe(float time, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&time);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 1167142, RefRangeEnd = 1167164, XrefRangeStart = 1167142, XrefRangeEnd = 1167142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Keyframe(float time, float value, float inTangent, float outTangent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&time);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inTangent;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &outTangent;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1167164, RefRangeEnd = 1167165, XrefRangeStart = 1167164, XrefRangeEnd = 1167164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Keyframe(float time, float value, float inTangent, float outTangent, float inWeight, float outWeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&time);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inTangent;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &outTangent;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &inWeight;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &outWeight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
