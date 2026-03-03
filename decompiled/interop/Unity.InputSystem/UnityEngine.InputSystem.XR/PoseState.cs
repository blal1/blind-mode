using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.XR;

namespace UnityEngine.InputSystem.XR;

[StructLayout(LayoutKind.Explicit)]
public struct PoseState
{
	private static readonly System.IntPtr NativeFieldInfoPtr_kSizeInBytes;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Format;

	private static readonly System.IntPtr NativeFieldInfoPtr_isTracked;

	private static readonly System.IntPtr NativeFieldInfoPtr_trackingState;

	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_velocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_angularVelocity;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_InputTrackingState_Vector3_Quaternion_Vector3_Vector3_0;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.U1)]
	public bool isTracked;

	[FieldOffset(4)]
	public InputTrackingState trackingState;

	[FieldOffset(8)]
	public Vector3 position;

	[FieldOffset(20)]
	public Quaternion rotation;

	[FieldOffset(36)]
	public Vector3 velocity;

	[FieldOffset(48)]
	public Vector3 angularVelocity;

	public unsafe static int kSizeInBytes
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kSizeInBytes, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kSizeInBytes, (void*)(&value));
		}
	}

	public unsafe static FourCC s_Format
	{
		get
		{
			Unsafe.SkipInit(out FourCC result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Format, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Format, (void*)(&value));
		}
	}

	public unsafe virtual FourCC format
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999189, XrefRangeEnd = 999193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static PoseState()
	{
		Il2CppClassPointerStore<PoseState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.XR", "PoseState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoseState>.NativeClassPtr);
		NativeFieldInfoPtr_kSizeInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoseState>.NativeClassPtr, "kSizeInBytes");
		NativeFieldInfoPtr_s_Format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoseState>.NativeClassPtr, "s_Format");
		NativeFieldInfoPtr_isTracked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoseState>.NativeClassPtr, "isTracked");
		NativeFieldInfoPtr_trackingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoseState>.NativeClassPtr, "trackingState");
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoseState>.NativeClassPtr, "position");
		NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoseState>.NativeClassPtr, "rotation");
		NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoseState>.NativeClassPtr, "velocity");
		NativeFieldInfoPtr_angularVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoseState>.NativeClassPtr, "angularVelocity");
		NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoseState>.NativeClassPtr, 100666368);
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_InputTrackingState_Vector3_Quaternion_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoseState>.NativeClassPtr, 100666369);
	}

	[CallerCount(0)]
	public unsafe PoseState(bool isTracked, InputTrackingState trackingState, Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&isTracked);
		*(InputTrackingState**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &trackingState;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(Vector3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &velocity;
		*(Vector3**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &angularVelocity;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_InputTrackingState_Vector3_Quaternion_Vector3_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PoseState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
