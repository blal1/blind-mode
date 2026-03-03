using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Bindings;

namespace UnityEngine;

public class GridLayout : Behaviour
{
	public enum CellLayout
	{
		Rectangle,
		Hexagon,
		Isometric,
		IsometricZAsY
	}

	public enum CellSwizzle
	{
		XYZ,
		XZY,
		YXZ,
		YZX,
		ZXY,
		ZYX
	}

	private delegate void get_cellSize_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void get_cellGap_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate CellLayout get_cellLayout_InjectedDelegate(IntPtr _unity_self);

	private delegate CellSwizzle get_cellSwizzle_InjectedDelegate(IntPtr _unity_self);

	private delegate void GetBoundsLocal_InjectedDelegate(IntPtr _unity_self, [In] IntPtr cellPosition, [Out] IntPtr ret);

	private delegate void GetBoundsLocalOriginSize_InjectedDelegate(IntPtr _unity_self, [In] IntPtr origin, [In] IntPtr size, [Out] IntPtr ret);

	private delegate void CellToLocal_InjectedDelegate(IntPtr _unity_self, [In] IntPtr cellPosition, [Out] IntPtr ret);

	private delegate void LocalToCell_InjectedDelegate(IntPtr _unity_self, [In] IntPtr localPosition, [Out] IntPtr ret);

	private delegate void CellToLocalInterpolated_InjectedDelegate(IntPtr _unity_self, [In] IntPtr cellPosition, [Out] IntPtr ret);

	private delegate void LocalToCellInterpolated_InjectedDelegate(IntPtr _unity_self, [In] IntPtr localPosition, [Out] IntPtr ret);

	private delegate void CellToWorld_InjectedDelegate(IntPtr _unity_self, [In] IntPtr cellPosition, [Out] IntPtr ret);

	private delegate void WorldToCell_InjectedDelegate(IntPtr _unity_self, [In] IntPtr worldPosition, [Out] IntPtr ret);

	private delegate void LocalToWorld_InjectedDelegate(IntPtr _unity_self, [In] IntPtr localPosition, [Out] IntPtr ret);

	private delegate void WorldToLocal_InjectedDelegate(IntPtr _unity_self, [In] IntPtr worldPosition, [Out] IntPtr ret);

	private delegate void GetLayoutCellCenter_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private static readonly IntPtr NativeMethodInfoPtr_DoNothing_Private_Void_0;

	private static readonly get_cellSize_InjectedDelegate get_cellSize_InjectedDelegateField;

	private static readonly get_cellGap_InjectedDelegate get_cellGap_InjectedDelegateField;

	private static readonly get_cellLayout_InjectedDelegate get_cellLayout_InjectedDelegateField;

	private static readonly get_cellSwizzle_InjectedDelegate get_cellSwizzle_InjectedDelegateField;

	private static readonly GetBoundsLocal_InjectedDelegate GetBoundsLocal_InjectedDelegateField;

	private static readonly GetBoundsLocalOriginSize_InjectedDelegate GetBoundsLocalOriginSize_InjectedDelegateField;

	private static readonly CellToLocal_InjectedDelegate CellToLocal_InjectedDelegateField;

	private static readonly LocalToCell_InjectedDelegate LocalToCell_InjectedDelegateField;

	private static readonly CellToLocalInterpolated_InjectedDelegate CellToLocalInterpolated_InjectedDelegateField;

	private static readonly LocalToCellInterpolated_InjectedDelegate LocalToCellInterpolated_InjectedDelegateField;

	private static readonly CellToWorld_InjectedDelegate CellToWorld_InjectedDelegateField;

	private static readonly WorldToCell_InjectedDelegate WorldToCell_InjectedDelegateField;

	private static readonly LocalToWorld_InjectedDelegate LocalToWorld_InjectedDelegateField;

	private static readonly WorldToLocal_InjectedDelegate WorldToLocal_InjectedDelegateField;

	private static readonly GetLayoutCellCenter_InjectedDelegate GetLayoutCellCenter_InjectedDelegateField;

	public Vector3 cellSize
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_cellSize_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public Vector3 cellGap
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_cellGap_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public CellLayout cellLayout
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_cellLayout_Injected(intPtr);
		}
	}

	public CellSwizzle cellSwizzle
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_cellSwizzle_Injected(intPtr);
		}
	}

	static GridLayout()
	{
		Il2CppClassPointerStore<GridLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.GridModule.dll", "UnityEngine", "GridLayout");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridLayout>.NativeClassPtr);
		NativeMethodInfoPtr_DoNothing_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayout>.NativeClassPtr, 100663297);
		get_cellSize_InjectedDelegateField = IL2CPP.ResolveICall<get_cellSize_InjectedDelegate>("UnityEngine.GridLayout::get_cellSize_Injected");
		get_cellGap_InjectedDelegateField = IL2CPP.ResolveICall<get_cellGap_InjectedDelegate>("UnityEngine.GridLayout::get_cellGap_Injected");
		get_cellLayout_InjectedDelegateField = IL2CPP.ResolveICall<get_cellLayout_InjectedDelegate>("UnityEngine.GridLayout::get_cellLayout_Injected");
		get_cellSwizzle_InjectedDelegateField = IL2CPP.ResolveICall<get_cellSwizzle_InjectedDelegate>("UnityEngine.GridLayout::get_cellSwizzle_Injected");
		GetBoundsLocal_InjectedDelegateField = IL2CPP.ResolveICall<GetBoundsLocal_InjectedDelegate>("UnityEngine.GridLayout::GetBoundsLocal_Injected");
		GetBoundsLocalOriginSize_InjectedDelegateField = IL2CPP.ResolveICall<GetBoundsLocalOriginSize_InjectedDelegate>("UnityEngine.GridLayout::GetBoundsLocalOriginSize_Injected");
		CellToLocal_InjectedDelegateField = IL2CPP.ResolveICall<CellToLocal_InjectedDelegate>("UnityEngine.GridLayout::CellToLocal_Injected");
		LocalToCell_InjectedDelegateField = IL2CPP.ResolveICall<LocalToCell_InjectedDelegate>("UnityEngine.GridLayout::LocalToCell_Injected");
		CellToLocalInterpolated_InjectedDelegateField = IL2CPP.ResolveICall<CellToLocalInterpolated_InjectedDelegate>("UnityEngine.GridLayout::CellToLocalInterpolated_Injected");
		LocalToCellInterpolated_InjectedDelegateField = IL2CPP.ResolveICall<LocalToCellInterpolated_InjectedDelegate>("UnityEngine.GridLayout::LocalToCellInterpolated_Injected");
		CellToWorld_InjectedDelegateField = IL2CPP.ResolveICall<CellToWorld_InjectedDelegate>("UnityEngine.GridLayout::CellToWorld_Injected");
		WorldToCell_InjectedDelegateField = IL2CPP.ResolveICall<WorldToCell_InjectedDelegate>("UnityEngine.GridLayout::WorldToCell_Injected");
		LocalToWorld_InjectedDelegateField = IL2CPP.ResolveICall<LocalToWorld_InjectedDelegate>("UnityEngine.GridLayout::LocalToWorld_Injected");
		WorldToLocal_InjectedDelegateField = IL2CPP.ResolveICall<WorldToLocal_InjectedDelegate>("UnityEngine.GridLayout::WorldToLocal_Injected");
		GetLayoutCellCenter_InjectedDelegateField = IL2CPP.ResolveICall<GetLayoutCellCenter_InjectedDelegate>("UnityEngine.GridLayout::GetLayoutCellCenter_Injected");
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoNothing()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoNothing_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GridLayout(IntPtr pointer)
		: base(pointer)
	{
	}

	public Bounds GetBoundsLocal(Vector3Int cellPosition)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		GetBoundsLocal_Injected(intPtr, ref cellPosition, out var ret);
		return ret;
	}

	public Bounds GetBoundsLocal(Vector3 origin, Vector3 size)
	{
		return GetBoundsLocalOriginSize(origin, size);
	}

	public Bounds GetBoundsLocalOriginSize(Vector3 origin, Vector3 size)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		GetBoundsLocalOriginSize_Injected(intPtr, ref origin, ref size, out var ret);
		return ret;
	}

	public Vector3 CellToLocal(Vector3Int cellPosition)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		CellToLocal_Injected(intPtr, ref cellPosition, out var ret);
		return ret;
	}

	public Vector3Int LocalToCell(Vector3 localPosition)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		LocalToCell_Injected(intPtr, ref localPosition, out var ret);
		return ret;
	}

	public Vector3 CellToLocalInterpolated(Vector3 cellPosition)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		CellToLocalInterpolated_Injected(intPtr, ref cellPosition, out var ret);
		return ret;
	}

	public Vector3 LocalToCellInterpolated(Vector3 localPosition)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		LocalToCellInterpolated_Injected(intPtr, ref localPosition, out var ret);
		return ret;
	}

	public Vector3 CellToWorld(Vector3Int cellPosition)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		CellToWorld_Injected(intPtr, ref cellPosition, out var ret);
		return ret;
	}

	public Vector3Int WorldToCell(Vector3 worldPosition)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		WorldToCell_Injected(intPtr, ref worldPosition, out var ret);
		return ret;
	}

	public Vector3 LocalToWorld(Vector3 localPosition)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		LocalToWorld_Injected(intPtr, ref localPosition, out var ret);
		return ret;
	}

	public Vector3 WorldToLocal(Vector3 worldPosition)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		WorldToLocal_Injected(intPtr, ref worldPosition, out var ret);
		return ret;
	}

	public Vector3 GetLayoutCellCenter()
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		GetLayoutCellCenter_Injected(intPtr, out var ret);
		return ret;
	}

	public unsafe static void get_cellSize_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_cellSize_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_cellGap_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_cellGap_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static CellLayout get_cellLayout_Injected(IntPtr _unity_self)
	{
		return get_cellLayout_InjectedDelegateField(_unity_self);
	}

	public static CellSwizzle get_cellSwizzle_Injected(IntPtr _unity_self)
	{
		return get_cellSwizzle_InjectedDelegateField(_unity_self);
	}

	public unsafe static void GetBoundsLocal_Injected(IntPtr _unity_self, [In] ref Vector3Int cellPosition, out Bounds ret)
	{
		GetBoundsLocal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref cellPosition), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetBoundsLocalOriginSize_Injected(IntPtr _unity_self, [In] ref Vector3 origin, [In] ref Vector3 size, out Bounds ret)
	{
		GetBoundsLocalOriginSize_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref origin), (nint)Unsafe.AsPointer(ref size), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void CellToLocal_Injected(IntPtr _unity_self, [In] ref Vector3Int cellPosition, out Vector3 ret)
	{
		CellToLocal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref cellPosition), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void LocalToCell_Injected(IntPtr _unity_self, [In] ref Vector3 localPosition, out Vector3Int ret)
	{
		LocalToCell_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref localPosition), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void CellToLocalInterpolated_Injected(IntPtr _unity_self, [In] ref Vector3 cellPosition, out Vector3 ret)
	{
		CellToLocalInterpolated_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref cellPosition), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void LocalToCellInterpolated_Injected(IntPtr _unity_self, [In] ref Vector3 localPosition, out Vector3 ret)
	{
		LocalToCellInterpolated_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref localPosition), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void CellToWorld_Injected(IntPtr _unity_self, [In] ref Vector3Int cellPosition, out Vector3 ret)
	{
		CellToWorld_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref cellPosition), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void WorldToCell_Injected(IntPtr _unity_self, [In] ref Vector3 worldPosition, out Vector3Int ret)
	{
		WorldToCell_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref worldPosition), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void LocalToWorld_Injected(IntPtr _unity_self, [In] ref Vector3 localPosition, out Vector3 ret)
	{
		LocalToWorld_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref localPosition), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void WorldToLocal_Injected(IntPtr _unity_self, [In] ref Vector3 worldPosition, out Vector3 ret)
	{
		WorldToLocal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref worldPosition), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetLayoutCellCenter_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		GetLayoutCellCenter_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}
}
