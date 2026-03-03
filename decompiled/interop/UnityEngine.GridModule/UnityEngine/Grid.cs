using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class Grid : GridLayout
{
	private delegate void get_cellSize_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_cellSize_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_cellGap_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_cellGap_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate CellLayout get_cellLayout_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_cellLayout_InjectedDelegate(IntPtr _unity_self, CellLayout value);

	private delegate CellSwizzle get_cellSwizzle_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_cellSwizzle_InjectedDelegate(IntPtr _unity_self, CellSwizzle value);

	private delegate void Swizzle_InjectedDelegate(CellSwizzle swizzle, [In] IntPtr position, [Out] IntPtr ret);

	private delegate void InverseSwizzle_InjectedDelegate(CellSwizzle swizzle, [In] IntPtr position, [Out] IntPtr ret);

	private static readonly get_cellSize_InjectedDelegate get_cellSize_InjectedDelegateField = IL2CPP.ResolveICall<get_cellSize_InjectedDelegate>("UnityEngine.Grid::get_cellSize_Injected");

	private static readonly set_cellSize_InjectedDelegate set_cellSize_InjectedDelegateField = IL2CPP.ResolveICall<set_cellSize_InjectedDelegate>("UnityEngine.Grid::set_cellSize_Injected");

	private static readonly get_cellGap_InjectedDelegate get_cellGap_InjectedDelegateField = IL2CPP.ResolveICall<get_cellGap_InjectedDelegate>("UnityEngine.Grid::get_cellGap_Injected");

	private static readonly set_cellGap_InjectedDelegate set_cellGap_InjectedDelegateField = IL2CPP.ResolveICall<set_cellGap_InjectedDelegate>("UnityEngine.Grid::set_cellGap_Injected");

	private static readonly get_cellLayout_InjectedDelegate get_cellLayout_InjectedDelegateField = IL2CPP.ResolveICall<get_cellLayout_InjectedDelegate>("UnityEngine.Grid::get_cellLayout_Injected");

	private static readonly set_cellLayout_InjectedDelegate set_cellLayout_InjectedDelegateField = IL2CPP.ResolveICall<set_cellLayout_InjectedDelegate>("UnityEngine.Grid::set_cellLayout_Injected");

	private static readonly get_cellSwizzle_InjectedDelegate get_cellSwizzle_InjectedDelegateField = IL2CPP.ResolveICall<get_cellSwizzle_InjectedDelegate>("UnityEngine.Grid::get_cellSwizzle_Injected");

	private static readonly set_cellSwizzle_InjectedDelegate set_cellSwizzle_InjectedDelegateField = IL2CPP.ResolveICall<set_cellSwizzle_InjectedDelegate>("UnityEngine.Grid::set_cellSwizzle_Injected");

	private static readonly Swizzle_InjectedDelegate Swizzle_InjectedDelegateField = IL2CPP.ResolveICall<Swizzle_InjectedDelegate>("UnityEngine.Grid::Swizzle_Injected");

	private static readonly InverseSwizzle_InjectedDelegate InverseSwizzle_InjectedDelegateField = IL2CPP.ResolveICall<InverseSwizzle_InjectedDelegate>("UnityEngine.Grid::InverseSwizzle_Injected");

	public new Vector3 cellSize
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
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_cellSize_Injected(intPtr, ref value);
		}
	}

	public new Vector3 cellGap
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
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_cellGap_Injected(intPtr, ref value);
		}
	}

	public new CellLayout cellLayout
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
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_cellLayout_Injected(intPtr, value);
		}
	}

	public new CellSwizzle cellSwizzle
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
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_cellSwizzle_Injected(intPtr, value);
		}
	}

	public Vector3 GetCellCenterLocal(Vector3Int position)
	{
		return CellToLocalInterpolated(position + GetLayoutCellCenter());
	}

	public Vector3 GetCellCenterWorld(Vector3Int position)
	{
		return LocalToWorld(CellToLocalInterpolated(position + GetLayoutCellCenter()));
	}

	public static Vector3 Swizzle(CellSwizzle swizzle, Vector3 position)
	{
		Swizzle_Injected(swizzle, ref position, out var ret);
		return ret;
	}

	public static Vector3 InverseSwizzle(CellSwizzle swizzle, Vector3 position)
	{
		InverseSwizzle_Injected(swizzle, ref position, out var ret);
		return ret;
	}

	public new unsafe static void get_cellSize_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_cellSize_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_cellSize_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_cellSize_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public new unsafe static void get_cellGap_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_cellGap_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_cellGap_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_cellGap_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public new static CellLayout get_cellLayout_Injected(IntPtr _unity_self)
	{
		return get_cellLayout_InjectedDelegateField(_unity_self);
	}

	public static void set_cellLayout_Injected(IntPtr _unity_self, CellLayout value)
	{
		set_cellLayout_InjectedDelegateField(_unity_self, value);
	}

	public new static CellSwizzle get_cellSwizzle_Injected(IntPtr _unity_self)
	{
		return get_cellSwizzle_InjectedDelegateField(_unity_self);
	}

	public static void set_cellSwizzle_Injected(IntPtr _unity_self, CellSwizzle value)
	{
		set_cellSwizzle_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void Swizzle_Injected(CellSwizzle swizzle, [In] ref Vector3 position, out Vector3 ret)
	{
		Swizzle_InjectedDelegateField(swizzle, (nint)Unsafe.AsPointer(ref position), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void InverseSwizzle_Injected(CellSwizzle swizzle, [In] ref Vector3 position, out Vector3 ret)
	{
		InverseSwizzle_InjectedDelegateField(swizzle, (nint)Unsafe.AsPointer(ref position), (nint)Unsafe.AsPointer(ref ret));
	}
}
