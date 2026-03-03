using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct RaycastHit2D
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Centroid;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Point;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Normal;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Distance;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Fraction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Collider;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_point_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_normal_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_distance_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_collider_Public_get_Collider2D_0;

	[FieldOffset(0)]
	public Vector2 m_Centroid;

	[FieldOffset(8)]
	public Vector2 m_Point;

	[FieldOffset(16)]
	public Vector2 m_Normal;

	[FieldOffset(24)]
	public float m_Distance;

	[FieldOffset(28)]
	public float m_Fraction;

	[FieldOffset(32)]
	public int m_Collider;

	public unsafe Vector2 point
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1171371, RefRangeEnd = 1171372, XrefRangeStart = 1171371, XrefRangeEnd = 1171372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_point_Public_get_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Point = value;
		}
	}

	public unsafe Vector2 normal
	{
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1258926, RefRangeEnd = 1258945, XrefRangeStart = 1258926, XrefRangeEnd = 1258926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_normal_Public_get_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Normal = value;
		}
	}

	public unsafe float distance
	{
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 1154293, RefRangeEnd = 1154355, XrefRangeStart = 1154293, XrefRangeEnd = 1154355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_distance_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Distance = value;
		}
	}

	public unsafe Collider2D collider
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1258951, RefRangeEnd = 1258954, XrefRangeStart = 1258945, XrefRangeEnd = 1258951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_collider_Public_get_Collider2D_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Collider2D>(intPtr2) : null;
		}
	}

	public Vector2 centroid
	{
		get
		{
			return m_Centroid;
		}
		set
		{
			m_Centroid = value;
		}
	}

	public float fraction
	{
		get
		{
			return m_Fraction;
		}
		set
		{
			m_Fraction = value;
		}
	}

	public Rigidbody2D rigidbody => (collider != null) ? collider.attachedRigidbody : null;

	public Transform transform
	{
		get
		{
			Rigidbody2D rigidbody2D = rigidbody;
			if (rigidbody2D != null)
			{
				return rigidbody2D.transform;
			}
			if (collider != null)
			{
				return collider.transform;
			}
			return null;
		}
	}

	static RaycastHit2D()
	{
		Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "RaycastHit2D");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr);
		NativeFieldInfoPtr_m_Centroid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Centroid");
		NativeFieldInfoPtr_m_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Point");
		NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Normal");
		NativeFieldInfoPtr_m_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Distance");
		NativeFieldInfoPtr_m_Fraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Fraction");
		NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Collider");
		NativeMethodInfoPtr_get_point_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, 100663343);
		NativeMethodInfoPtr_get_normal_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_get_distance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr_get_collider_Public_get_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, 100663346);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static implicit operator bool(RaycastHit2D hit)
	{
		return hit.collider != null;
	}

	public int CompareTo(RaycastHit2D other)
	{
		if (collider == null)
		{
			return 1;
		}
		if (other.collider == null)
		{
			return -1;
		}
		return fraction.CompareTo(other.fraction);
	}
}
