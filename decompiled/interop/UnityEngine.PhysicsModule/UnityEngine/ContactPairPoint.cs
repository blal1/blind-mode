using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct ContactPairPoint
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Position;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Separation;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Normal;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InternalFaceIndex0;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Impulse;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InternalFaceIndex1;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_separation_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_normal_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_impulse_Public_get_Vector3_0;

	[FieldOffset(0)]
	public readonly Vector3 m_Position;

	[FieldOffset(12)]
	public readonly float m_Separation;

	[FieldOffset(16)]
	public readonly Vector3 m_Normal;

	[FieldOffset(28)]
	public readonly uint m_InternalFaceIndex0;

	[FieldOffset(32)]
	public readonly Vector3 m_Impulse;

	[FieldOffset(44)]
	public readonly uint m_InternalFaceIndex1;

	public unsafe Vector3 position
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_position_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float separation
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_separation_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Vector3 normal
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_normal_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Vector3 impulse
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_impulse_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public Vector3 Position => position;

	public float Separation => separation;

	public Vector3 Normal => normal;

	public Vector3 Impulse => impulse;

	static ContactPairPoint()
	{
		Il2CppClassPointerStore<ContactPairPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "ContactPairPoint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactPairPoint>.NativeClassPtr);
		NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPairPoint>.NativeClassPtr, "m_Position");
		NativeFieldInfoPtr_m_Separation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPairPoint>.NativeClassPtr, "m_Separation");
		NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPairPoint>.NativeClassPtr, "m_Normal");
		NativeFieldInfoPtr_m_InternalFaceIndex0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPairPoint>.NativeClassPtr, "m_InternalFaceIndex0");
		NativeFieldInfoPtr_m_Impulse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPairPoint>.NativeClassPtr, "m_Impulse");
		NativeFieldInfoPtr_m_InternalFaceIndex1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPairPoint>.NativeClassPtr, "m_InternalFaceIndex1");
		NativeMethodInfoPtr_get_position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPairPoint>.NativeClassPtr, 100663410);
		NativeMethodInfoPtr_get_separation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPairPoint>.NativeClassPtr, 100663411);
		NativeMethodInfoPtr_get_normal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPairPoint>.NativeClassPtr, 100663412);
		NativeMethodInfoPtr_get_impulse_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPairPoint>.NativeClassPtr, 100663413);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContactPairPoint>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
