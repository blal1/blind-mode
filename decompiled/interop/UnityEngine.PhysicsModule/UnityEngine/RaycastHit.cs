using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct RaycastHit
{
	private delegate void CalculateRaycastTexCoord_InjectedDelegate(int colliderInstanceID, [In] System.IntPtr uv, [In] System.IntPtr pos, uint face, int textcoord, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Point;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Normal;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FaceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Distance;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UV;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Collider;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_collider_Public_get_Collider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_point_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_normal_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_distance_Public_get_Single_0;

	[FieldOffset(0)]
	public Vector3 m_Point;

	[FieldOffset(12)]
	public Vector3 m_Normal;

	[FieldOffset(24)]
	public uint m_FaceID;

	[FieldOffset(28)]
	public float m_Distance;

	[FieldOffset(32)]
	public Vector2 m_UV;

	[FieldOffset(40)]
	public int m_Collider;

	private static readonly CalculateRaycastTexCoord_InjectedDelegate CalculateRaycastTexCoord_InjectedDelegateField;

	public unsafe Collider collider
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1259814, RefRangeEnd = 1259820, XrefRangeStart = 1259808, XrefRangeEnd = 1259814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_collider_Public_get_Collider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
		}
	}

	public unsafe Vector3 point
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1154376, RefRangeEnd = 1154380, XrefRangeStart = 1154376, XrefRangeEnd = 1154380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_point_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Point = value;
		}
	}

	public unsafe Vector3 normal
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1157010, RefRangeEnd = 1157013, XrefRangeStart = 1157010, XrefRangeEnd = 1157013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_normal_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Normal = value;
		}
	}

	public unsafe float distance
	{
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1156476, RefRangeEnd = 1156529, XrefRangeStart = 1156476, XrefRangeEnd = 1156529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public int colliderInstanceID => m_Collider;

	public Vector3 barycentricCoordinate
	{
		get
		{
			return new Vector3(1f - (m_UV.y + m_UV.x), m_UV.x, m_UV.y);
		}
		set
		{
			m_UV = value;
		}
	}

	public int triangleIndex => (int)m_FaceID;

	public Vector2 textureCoord => CalculateRaycastTexCoord(m_Collider, m_UV, m_Point, m_FaceID, 0);

	public Vector2 textureCoord2 => CalculateRaycastTexCoord(m_Collider, m_UV, m_Point, m_FaceID, 1);

	public Transform transform
	{
		get
		{
			Rigidbody rigidbody = this.rigidbody;
			if (rigidbody != null)
			{
				return rigidbody.transform;
			}
			if (collider != null)
			{
				return collider.transform;
			}
			return null;
		}
	}

	public Rigidbody rigidbody => (collider != null) ? collider.attachedRigidbody : null;

	public ArticulationBody articulationBody => (collider != null) ? collider.attachedArticulationBody : null;

	public Vector2 lightmapCoord
	{
		get
		{
			Vector2 result = CalculateRaycastTexCoord(m_Collider, m_UV, m_Point, m_FaceID, 1);
			if (collider.GetComponent<Renderer>() != null)
			{
				Vector4 lightmapScaleOffset = collider.GetComponent<Renderer>().lightmapScaleOffset;
				result.x = result.x * lightmapScaleOffset.x + lightmapScaleOffset.z;
				result.y = result.y * lightmapScaleOffset.y + lightmapScaleOffset.w;
			}
			return result;
		}
	}

	public Vector2 textureCoord1 => textureCoord2;

	static RaycastHit()
	{
		Il2CppClassPointerStore<RaycastHit>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "RaycastHit");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr);
		NativeFieldInfoPtr_m_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_Point");
		NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_Normal");
		NativeFieldInfoPtr_m_FaceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_FaceID");
		NativeFieldInfoPtr_m_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_Distance");
		NativeFieldInfoPtr_m_UV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_UV");
		NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_Collider");
		NativeMethodInfoPtr_get_collider_Public_get_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, 100663429);
		NativeMethodInfoPtr_get_point_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, 100663430);
		NativeMethodInfoPtr_get_normal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, 100663431);
		NativeMethodInfoPtr_get_distance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, 100663432);
		CalculateRaycastTexCoord_InjectedDelegateField = IL2CPP.ResolveICall<CalculateRaycastTexCoord_InjectedDelegate>("UnityEngine.RaycastHit::CalculateRaycastTexCoord_Injected");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static Vector2 CalculateRaycastTexCoord(int colliderInstanceID, Vector2 uv, Vector3 pos, uint face, int textcoord)
	{
		CalculateRaycastTexCoord_Injected(colliderInstanceID, ref uv, ref pos, face, textcoord, out var ret);
		return ret;
	}

	public unsafe static void CalculateRaycastTexCoord_Injected(int colliderInstanceID, [In] ref Vector2 uv, [In] ref Vector3 pos, uint face, int textcoord, out Vector2 ret)
	{
		CalculateRaycastTexCoord_InjectedDelegateField(colliderInstanceID, (nint)Unsafe.AsPointer(ref uv), (nint)Unsafe.AsPointer(ref pos), face, textcoord, (nint)Unsafe.AsPointer(ref ret));
	}
}
