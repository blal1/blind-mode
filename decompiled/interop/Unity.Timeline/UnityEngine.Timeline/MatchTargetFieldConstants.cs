using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline;

public static class MatchTargetFieldConstants : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_All;

	private static readonly System.IntPtr NativeFieldInfoPtr_None;

	private static readonly System.IntPtr NativeFieldInfoPtr_Position;

	private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasAny_Public_Static_Boolean_MatchTargetFields_MatchTargetFields_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Toggle_Public_Static_MatchTargetFields_MatchTargetFields_MatchTargetFields_0;

	public unsafe static MatchTargetFields All
	{
		get
		{
			Unsafe.SkipInit(out MatchTargetFields result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_All, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_All, (void*)(&value));
		}
	}

	public unsafe static MatchTargetFields None
	{
		get
		{
			Unsafe.SkipInit(out MatchTargetFields result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_None, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_None, (void*)(&value));
		}
	}

	public unsafe static MatchTargetFields Position
	{
		get
		{
			Unsafe.SkipInit(out MatchTargetFields result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Position, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Position, (void*)(&value));
		}
	}

	public unsafe static MatchTargetFields Rotation
	{
		get
		{
			Unsafe.SkipInit(out MatchTargetFields result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Rotation, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Rotation, (void*)(&value));
		}
	}

	static MatchTargetFieldConstants()
	{
		Il2CppClassPointerStore<MatchTargetFieldConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "MatchTargetFieldConstants");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchTargetFieldConstants>.NativeClassPtr);
		NativeFieldInfoPtr_All = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchTargetFieldConstants>.NativeClassPtr, "All");
		NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchTargetFieldConstants>.NativeClassPtr, "None");
		NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchTargetFieldConstants>.NativeClassPtr, "Position");
		NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchTargetFieldConstants>.NativeClassPtr, "Rotation");
		NativeMethodInfoPtr_HasAny_Public_Static_Boolean_MatchTargetFields_MatchTargetFields_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchTargetFieldConstants>.NativeClassPtr, 100663368);
		NativeMethodInfoPtr_Toggle_Public_Static_MatchTargetFields_MatchTargetFields_MatchTargetFields_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchTargetFieldConstants>.NativeClassPtr, 100663369);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135543, XrefRangeEnd = 1135547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasAny(this MatchTargetFields me, MatchTargetFields fields)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&me);
		*(MatchTargetFields**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fields;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasAny_Public_Static_Boolean_MatchTargetFields_MatchTargetFields_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static MatchTargetFields Toggle(this MatchTargetFields me, MatchTargetFields flag)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&me);
		*(MatchTargetFields**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flag;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Toggle_Public_Static_MatchTargetFields_MatchTargetFields_MatchTargetFields_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(MatchTargetFields*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public MatchTargetFieldConstants(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
