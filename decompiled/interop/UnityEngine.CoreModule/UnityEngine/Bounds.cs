using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct Bounds
{
	private delegate bool Contains_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr point);

	private delegate float SqrDistance_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr point);

	private delegate bool IntersectRayAABB_InjectedDelegate([In] System.IntPtr ray, [In] System.IntPtr bounds, [Out] System.IntPtr dist);

	private delegate void ClosestPoint_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr point, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Center;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Extents;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_center_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_center_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_extents_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_extents_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_min_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_min_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_max_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_max_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Bounds_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Bounds_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMinMax_Public_Void_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Encapsulate_Public_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Encapsulate_Public_Void_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

	[FieldOffset(0)]
	public Vector3 m_Center;

	[FieldOffset(12)]
	public Vector3 m_Extents;

	private static readonly Contains_InjectedDelegate Contains_InjectedDelegateField;

	private static readonly SqrDistance_InjectedDelegate SqrDistance_InjectedDelegateField;

	private static readonly IntersectRayAABB_InjectedDelegate IntersectRayAABB_InjectedDelegateField;

	private static readonly ClosestPoint_InjectedDelegate ClosestPoint_InjectedDelegateField;

	public unsafe Vector3 center
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1154376, RefRangeEnd = 1154380, XrefRangeStart = 1154376, XrefRangeEnd = 1154380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_center_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1000096, RefRangeEnd = 1000102, XrefRangeStart = 1000096, XrefRangeEnd = 1000102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_center_Public_set_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 size
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_size_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_size_Public_set_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 extents
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1157010, RefRangeEnd = 1157013, XrefRangeStart = 1157010, XrefRangeEnd = 1157013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_extents_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_extents_Public_set_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 min
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_min_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_min_Public_set_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 max
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_max_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_max_Public_set_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static Bounds()
	{
		Il2CppClassPointerStore<Bounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Bounds");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bounds>.NativeClassPtr);
		NativeFieldInfoPtr_m_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bounds>.NativeClassPtr, "m_Center");
		NativeFieldInfoPtr_m_Extents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bounds>.NativeClassPtr, "m_Extents");
		NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664125);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664126);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664127);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664128);
		NativeMethodInfoPtr_get_center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664129);
		NativeMethodInfoPtr_set_center_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664130);
		NativeMethodInfoPtr_get_size_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664131);
		NativeMethodInfoPtr_set_size_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664132);
		NativeMethodInfoPtr_get_extents_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664133);
		NativeMethodInfoPtr_set_extents_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664134);
		NativeMethodInfoPtr_get_min_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664135);
		NativeMethodInfoPtr_set_min_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664136);
		NativeMethodInfoPtr_get_max_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664137);
		NativeMethodInfoPtr_set_max_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664138);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Bounds_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664139);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Bounds_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664140);
		NativeMethodInfoPtr_SetMinMax_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664141);
		NativeMethodInfoPtr_Encapsulate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664142);
		NativeMethodInfoPtr_Encapsulate_Public_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664143);
		NativeMethodInfoPtr_Intersects_Public_Boolean_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664144);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664145);
		NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664146);
		Contains_InjectedDelegateField = IL2CPP.ResolveICall<Contains_InjectedDelegate>("UnityEngine.Bounds::Contains_Injected");
		SqrDistance_InjectedDelegateField = IL2CPP.ResolveICall<SqrDistance_InjectedDelegate>("UnityEngine.Bounds::SqrDistance_Injected");
		IntersectRayAABB_InjectedDelegateField = IL2CPP.ResolveICall<IntersectRayAABB_InjectedDelegate>("UnityEngine.Bounds::IntersectRayAABB_Injected");
		ClosestPoint_InjectedDelegateField = IL2CPP.ResolveICall<ClosestPoint_InjectedDelegate>("UnityEngine.Bounds::ClosestPoint_Injected");
	}

	[CallerCount(0)]
	public unsafe Bounds(Vector3 center, Vector3 size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&center);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171201, XrefRangeEnd = 1171207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171207, XrefRangeEnd = 1171210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool Equals(Bounds other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Bounds_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool operator ==(Bounds lhs, Bounds rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(Bounds**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Bounds_Bounds_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool operator !=(Bounds lhs, Bounds rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(Bounds**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Bounds_Bounds_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetMinMax(Vector3 min, Vector3 max)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&min);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMinMax_Public_Void_Vector3_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1171210, RefRangeEnd = 1171212, XrefRangeStart = 1171210, XrefRangeEnd = 1171210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Encapsulate(Vector3 point)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&point);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Encapsulate_Public_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1171214, RefRangeEnd = 1171216, XrefRangeStart = 1171212, XrefRangeEnd = 1171214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Encapsulate(Bounds bounds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bounds);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Encapsulate_Public_Void_Bounds_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1171216, RefRangeEnd = 1171218, XrefRangeStart = 1171216, XrefRangeEnd = 1171216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Intersects(Bounds bounds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bounds);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Intersects_Public_Boolean_Bounds_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171218, XrefRangeEnd = 1171219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171219, XrefRangeEnd = 1171244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)formatProvider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Bounds>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public void Expand(float amount)
	{
		amount *= 0.5f;
		extents += new Vector3(amount, amount, amount);
	}

	public void Expand(Vector3 amount)
	{
		extents += amount * 0.5f;
	}

	public bool IntersectRay(Ray ray)
	{
		float dist;
		return IntersectRayAABB(ray, this, out dist);
	}

	public bool IntersectRay(Ray ray, out float distance)
	{
		return IntersectRayAABB(ray, this, out distance);
	}

	public string ToString(string format)
	{
		return ToString(format, null);
	}

	public bool Contains(Vector3 point)
	{
		return Contains_Injected(ref this, ref point);
	}

	public float SqrDistance(Vector3 point)
	{
		return SqrDistance_Injected(ref this, ref point);
	}

	public static bool IntersectRayAABB(Ray ray, Bounds bounds, out float dist)
	{
		return IntersectRayAABB_Injected(ref ray, ref bounds, out dist);
	}

	public Vector3 ClosestPoint(Vector3 point)
	{
		ClosestPoint_Injected(ref this, ref point, out var ret);
		return ret;
	}

	public unsafe static bool Contains_Injected(ref Bounds _unity_self, [In] ref Vector3 point)
	{
		return Contains_InjectedDelegateField((nint)Unsafe.AsPointer(ref _unity_self), (nint)Unsafe.AsPointer(ref point));
	}

	public unsafe static float SqrDistance_Injected(ref Bounds _unity_self, [In] ref Vector3 point)
	{
		return SqrDistance_InjectedDelegateField((nint)Unsafe.AsPointer(ref _unity_self), (nint)Unsafe.AsPointer(ref point));
	}

	public unsafe static bool IntersectRayAABB_Injected([In] ref Ray ray, [In] ref Bounds bounds, out float dist)
	{
		return IntersectRayAABB_InjectedDelegateField((nint)Unsafe.AsPointer(ref ray), (nint)Unsafe.AsPointer(ref bounds), (nint)Unsafe.AsPointer(ref dist));
	}

	public unsafe static void ClosestPoint_Injected(ref Bounds _unity_self, [In] ref Vector3 point, out Vector3 ret)
	{
		ClosestPoint_InjectedDelegateField((nint)Unsafe.AsPointer(ref _unity_self), (nint)Unsafe.AsPointer(ref point), (nint)Unsafe.AsPointer(ref ret));
	}
}
