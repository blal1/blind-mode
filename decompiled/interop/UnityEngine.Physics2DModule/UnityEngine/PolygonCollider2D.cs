using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class PolygonCollider2D : Collider2D
{
	private delegate bool get_useDelaunayMesh_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_useDelaunayMesh_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_autoTiling_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_autoTiling_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate int GetTotalPointCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void get_points_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_points_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate int get_pathCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_pathCount_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate void GetPath_Internal_InjectedDelegate(System.IntPtr _unity_self, int index, [Out] System.IntPtr ret);

	private delegate int GetPathList_Internal_InjectedDelegate(System.IntPtr _unity_self, int index, System.IntPtr points);

	private delegate void SetPathList_Internal_InjectedDelegate(System.IntPtr _unity_self, int index, System.IntPtr points);

	private delegate void CreatePrimitive_Internal_InjectedDelegate(System.IntPtr _unity_self, int sides, [In] System.IntPtr scale, [In] System.IntPtr offset, bool autoRefresh);

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPath_Public_Void_Int32_Il2CppStructArray_1_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPath_Internal_Private_Void_Int32_Il2CppStructArray_1_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPath_Internal_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_0;

	private static readonly get_useDelaunayMesh_InjectedDelegate get_useDelaunayMesh_InjectedDelegateField;

	private static readonly set_useDelaunayMesh_InjectedDelegate set_useDelaunayMesh_InjectedDelegateField;

	private static readonly get_autoTiling_InjectedDelegate get_autoTiling_InjectedDelegateField;

	private static readonly set_autoTiling_InjectedDelegate set_autoTiling_InjectedDelegateField;

	private static readonly GetTotalPointCount_InjectedDelegate GetTotalPointCount_InjectedDelegateField;

	private static readonly get_points_InjectedDelegate get_points_InjectedDelegateField;

	private static readonly set_points_InjectedDelegate set_points_InjectedDelegateField;

	private static readonly get_pathCount_InjectedDelegate get_pathCount_InjectedDelegateField;

	private static readonly set_pathCount_InjectedDelegate set_pathCount_InjectedDelegateField;

	private static readonly GetPath_Internal_InjectedDelegate GetPath_Internal_InjectedDelegateField;

	private static readonly GetPathList_Internal_InjectedDelegate GetPathList_Internal_InjectedDelegateField;

	private static readonly SetPathList_Internal_InjectedDelegate SetPathList_Internal_InjectedDelegateField;

	private static readonly CreatePrimitive_Internal_InjectedDelegate CreatePrimitive_Internal_InjectedDelegateField;

	public bool useDelaunayMesh
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useDelaunayMesh_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useDelaunayMesh_Injected(intPtr, value);
		}
	}

	public bool autoTiling
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_autoTiling_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_autoTiling_Injected(intPtr, value);
		}
	}

	public unsafe Il2CppStructArray<Vector2> points
	{
		get
		{
			Unsafe.SkipInit(out BlittableArrayWrapper ret);
			Il2CppStructArray<Vector2> result;
			try
			{
				System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (System.IntPtr)0)
				{
					UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
				}
				get_points_Injected(intPtr, out ret);
			}
			finally
			{
				Unsafe.SkipInit(out Il2CppStructArray<Vector2> array);
				ret.Unmarshal(ref *(Il2CppArrayBase<Vector2>*)(&array));
				result = array;
			}
			return result;
		}
		set
		{
			//IL_0018: Expected O, but got Ref
			//IL_001f: Expected O, but got Ref
			//IL_002b: Expected O, but got Ref
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out Il2CppSystem.Span<Vector2> span);
			((Il2CppSystem.Span<Vector2>)(&span))._002Ector((Il2CppArrayBase<Vector2>)(object)value);
			fixed (Vector2* begin = &((Il2CppSystem.Span<Vector2>)(&span)).GetPinnableReference())
			{
				ManagedSpanWrapper value2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Vector2>)(&span)).Length);
				set_points_Injected(intPtr, ref value2);
			}
		}
	}

	public int pathCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_pathCount_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_pathCount_Injected(intPtr, value);
		}
	}

	static PolygonCollider2D()
	{
		Il2CppClassPointerStore<PolygonCollider2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "PolygonCollider2D");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PolygonCollider2D>.NativeClassPtr);
		NativeMethodInfoPtr_SetPath_Public_Void_Int32_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonCollider2D>.NativeClassPtr, 100663382);
		NativeMethodInfoPtr_SetPath_Internal_Private_Void_Int32_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonCollider2D>.NativeClassPtr, 100663383);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonCollider2D>.NativeClassPtr, 100663384);
		NativeMethodInfoPtr_SetPath_Internal_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonCollider2D>.NativeClassPtr, 100663385);
		get_useDelaunayMesh_InjectedDelegateField = IL2CPP.ResolveICall<get_useDelaunayMesh_InjectedDelegate>("UnityEngine.PolygonCollider2D::get_useDelaunayMesh_Injected");
		set_useDelaunayMesh_InjectedDelegateField = IL2CPP.ResolveICall<set_useDelaunayMesh_InjectedDelegate>("UnityEngine.PolygonCollider2D::set_useDelaunayMesh_Injected");
		get_autoTiling_InjectedDelegateField = IL2CPP.ResolveICall<get_autoTiling_InjectedDelegate>("UnityEngine.PolygonCollider2D::get_autoTiling_Injected");
		set_autoTiling_InjectedDelegateField = IL2CPP.ResolveICall<set_autoTiling_InjectedDelegate>("UnityEngine.PolygonCollider2D::set_autoTiling_Injected");
		GetTotalPointCount_InjectedDelegateField = IL2CPP.ResolveICall<GetTotalPointCount_InjectedDelegate>("UnityEngine.PolygonCollider2D::GetTotalPointCount_Injected");
		get_points_InjectedDelegateField = IL2CPP.ResolveICall<get_points_InjectedDelegate>("UnityEngine.PolygonCollider2D::get_points_Injected");
		set_points_InjectedDelegateField = IL2CPP.ResolveICall<set_points_InjectedDelegate>("UnityEngine.PolygonCollider2D::set_points_Injected");
		get_pathCount_InjectedDelegateField = IL2CPP.ResolveICall<get_pathCount_InjectedDelegate>("UnityEngine.PolygonCollider2D::get_pathCount_Injected");
		set_pathCount_InjectedDelegateField = IL2CPP.ResolveICall<set_pathCount_InjectedDelegate>("UnityEngine.PolygonCollider2D::set_pathCount_Injected");
		GetPath_Internal_InjectedDelegateField = IL2CPP.ResolveICall<GetPath_Internal_InjectedDelegate>("UnityEngine.PolygonCollider2D::GetPath_Internal_Injected");
		GetPathList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<GetPathList_Internal_InjectedDelegate>("UnityEngine.PolygonCollider2D::GetPathList_Internal_Injected");
		SetPathList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<SetPathList_Internal_InjectedDelegate>("UnityEngine.PolygonCollider2D::SetPathList_Internal_Injected");
		CreatePrimitive_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CreatePrimitive_Internal_InjectedDelegate>("UnityEngine.PolygonCollider2D::CreatePrimitive_Internal_Injected");
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1259099, RefRangeEnd = 1259102, XrefRangeStart = 1259085, XrefRangeEnd = 1259099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPath(int index, Il2CppStructArray<Vector2> points)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)points);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPath_Public_Void_Int32_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259102, XrefRangeEnd = 1259116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPath_Internal(int index, Il2CppStructArray<Vector2> points)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)points);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPath_Internal_Private_Void_Int32_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PolygonCollider2D()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PolygonCollider2D>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259116, XrefRangeEnd = 1259118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPath_Internal_Injected(System.IntPtr _unity_self, int index, ref ManagedSpanWrapper points)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref points);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPath_Internal_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public PolygonCollider2D(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public int GetTotalPointCount()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetTotalPointCount_Injected(intPtr);
	}

	public Il2CppStructArray<Vector2> GetPath(int index)
	{
		if (index >= pathCount)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Path {0} does not exist.", (Il2CppSystem.Object)(object)index));
		}
		if (index < 0)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Path {0} does not exist; negative path index is invalid.", (Il2CppSystem.Object)(object)index));
		}
		return GetPath_Internal(index);
	}

	public unsafe Il2CppStructArray<Vector2> GetPath_Internal(int index)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<Vector2> result;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetPath_Internal_Injected(intPtr, index, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<Vector2> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<Vector2>*)(&array));
			result = array;
		}
		return result;
	}

	public int GetPath(int index, List<Vector2> points)
	{
		if (index < 0 || index >= pathCount)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("index", Il2CppSystem.String.Format("Path index {0} must be in the range of 0 to {1}.", (Il2CppSystem.Object)(object)index, (Il2CppSystem.Object)(object)(pathCount - 1)));
		}
		if (points == null)
		{
			throw new Il2CppSystem.ArgumentNullException("points");
		}
		return GetPathList_Internal(index, points);
	}

	public int GetPathList_Internal(int index, List<Vector2> points)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void SetPath(int index, List<Vector2> points)
	{
		if (index < 0)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Negative path index {0} is invalid.", (Il2CppSystem.Object)(object)index));
		}
		SetPathList_Internal(index, points);
	}

	public void SetPathList_Internal(int index, List<Vector2> points)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void CreatePrimitive(int sides)
	{
		CreatePrimitive(sides, Vector2.one, Vector2.zero);
	}

	public void CreatePrimitive(int sides, Vector2 scale)
	{
		CreatePrimitive(sides, scale, Vector2.zero);
	}

	public void CreatePrimitive(int sides, Vector2 scale, Vector2 offset)
	{
		if (sides < 3)
		{
			Debug.LogWarning("Cannot create a 2D polygon primitive collider with less than two sides.", this);
		}
		else if (!(scale.x > 0f) || !(scale.y > 0f))
		{
			Debug.LogWarning("Cannot create a 2D polygon primitive collider with an axis scale less than or equal to zero.", this);
		}
		else
		{
			CreatePrimitive_Internal(sides, scale, offset, autoRefresh: true);
		}
	}

	public void CreatePrimitive_Internal(int sides, Vector2 scale, Vector2 offset, bool autoRefresh)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		CreatePrimitive_Internal_Injected(intPtr, sides, ref scale, ref offset, autoRefresh);
	}

	public static bool get_useDelaunayMesh_Injected(System.IntPtr _unity_self)
	{
		return get_useDelaunayMesh_InjectedDelegateField(_unity_self);
	}

	public static void set_useDelaunayMesh_Injected(System.IntPtr _unity_self, bool value)
	{
		set_useDelaunayMesh_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_autoTiling_Injected(System.IntPtr _unity_self)
	{
		return get_autoTiling_InjectedDelegateField(_unity_self);
	}

	public static void set_autoTiling_Injected(System.IntPtr _unity_self, bool value)
	{
		set_autoTiling_InjectedDelegateField(_unity_self, value);
	}

	public static int GetTotalPointCount_Injected(System.IntPtr _unity_self)
	{
		return GetTotalPointCount_InjectedDelegateField(_unity_self);
	}

	public unsafe static void get_points_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		get_points_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_points_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper value)
	{
		set_points_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static int get_pathCount_Injected(System.IntPtr _unity_self)
	{
		return get_pathCount_InjectedDelegateField(_unity_self);
	}

	public static void set_pathCount_Injected(System.IntPtr _unity_self, int value)
	{
		set_pathCount_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void GetPath_Internal_Injected(System.IntPtr _unity_self, int index, out BlittableArrayWrapper ret)
	{
		GetPath_Internal_InjectedDelegateField(_unity_self, index, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static int GetPathList_Internal_Injected(System.IntPtr _unity_self, int index, ref BlittableListWrapper points)
	{
		return GetPathList_Internal_InjectedDelegateField(_unity_self, index, (nint)Unsafe.AsPointer(ref points));
	}

	public unsafe static void SetPathList_Internal_Injected(System.IntPtr _unity_self, int index, ref BlittableListWrapper points)
	{
		SetPathList_Internal_InjectedDelegateField(_unity_self, index, (nint)Unsafe.AsPointer(ref points));
	}

	public unsafe static void CreatePrimitive_Internal_Injected(System.IntPtr _unity_self, int sides, [In] ref Vector2 scale, [In] ref Vector2 offset, bool autoRefresh)
	{
		CreatePrimitive_Internal_InjectedDelegateField(_unity_self, sides, (nint)Unsafe.AsPointer(ref scale), (nint)Unsafe.AsPointer(ref offset), autoRefresh);
	}
}
