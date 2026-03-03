using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct ContactFilter2D
{
	private delegate bool IsFilteringNormalAngleUsingAngleDelegate(System.IntPtr @this, float angle);

	private delegate bool IsFilteringNormalAngle_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr normal);

	private static readonly System.IntPtr NativeFieldInfoPtr_useTriggers;

	private static readonly System.IntPtr NativeFieldInfoPtr_useLayerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_useDepth;

	private static readonly System.IntPtr NativeFieldInfoPtr_useOutsideDepth;

	private static readonly System.IntPtr NativeFieldInfoPtr_useNormalAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_useOutsideNormalAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_layerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_minDepth;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxDepth;

	private static readonly System.IntPtr NativeFieldInfoPtr_minNormalAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxNormalAngle;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckConsistency_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLayerMask_Public_Void_LayerMask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDepth_Public_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateLegacyFilter_Internal_Static_ContactFilter2D_Int32_Single_Single_0;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.U1)]
	public bool useTriggers;

	[FieldOffset(1)]
	[MarshalAs(UnmanagedType.U1)]
	public bool useLayerMask;

	[FieldOffset(2)]
	[MarshalAs(UnmanagedType.U1)]
	public bool useDepth;

	[FieldOffset(3)]
	[MarshalAs(UnmanagedType.U1)]
	public bool useOutsideDepth;

	[FieldOffset(4)]
	[MarshalAs(UnmanagedType.U1)]
	public bool useNormalAngle;

	[FieldOffset(5)]
	[MarshalAs(UnmanagedType.U1)]
	public bool useOutsideNormalAngle;

	[FieldOffset(8)]
	public LayerMask layerMask;

	[FieldOffset(12)]
	public float minDepth;

	[FieldOffset(16)]
	public float maxDepth;

	[FieldOffset(20)]
	public float minNormalAngle;

	[FieldOffset(24)]
	public float maxNormalAngle;

	public const float NormalAngleUpperLimit = 359.9999f;

	private static readonly IsFilteringNormalAngleUsingAngleDelegate IsFilteringNormalAngleUsingAngleDelegateField;

	private static readonly IsFilteringNormalAngle_InjectedDelegate IsFilteringNormalAngle_InjectedDelegateField;

	public bool isFiltering => !useTriggers || useLayerMask || useDepth || useNormalAngle;

	static ContactFilter2D()
	{
		Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "ContactFilter2D");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr);
		NativeFieldInfoPtr_useTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "useTriggers");
		NativeFieldInfoPtr_useLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "useLayerMask");
		NativeFieldInfoPtr_useDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "useDepth");
		NativeFieldInfoPtr_useOutsideDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "useOutsideDepth");
		NativeFieldInfoPtr_useNormalAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "useNormalAngle");
		NativeFieldInfoPtr_useOutsideNormalAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "useOutsideNormalAngle");
		NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "layerMask");
		NativeFieldInfoPtr_minDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "minDepth");
		NativeFieldInfoPtr_maxDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "maxDepth");
		NativeFieldInfoPtr_minNormalAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "minNormalAngle");
		NativeFieldInfoPtr_maxNormalAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "maxNormalAngle");
		NativeMethodInfoPtr_CheckConsistency_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, 100663339);
		NativeMethodInfoPtr_SetLayerMask_Public_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, 100663340);
		NativeMethodInfoPtr_SetDepth_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_CreateLegacyFilter_Internal_Static_ContactFilter2D_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, 100663342);
		IsFilteringNormalAngleUsingAngleDelegateField = IL2CPP.ResolveICall<IsFilteringNormalAngleUsingAngleDelegate>("UnityEngine.ContactFilter2D::IsFilteringNormalAngleUsingAngle");
		IsFilteringNormalAngle_InjectedDelegateField = IL2CPP.ResolveICall<IsFilteringNormalAngle_InjectedDelegate>("UnityEngine.ContactFilter2D::IsFilteringNormalAngle_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258909, XrefRangeEnd = 1258911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckConsistency()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckConsistency_Private_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetLayerMask(LayerMask layerMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&layerMask);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLayerMask_Public_Void_LayerMask_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258911, XrefRangeEnd = 1258913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDepth(float minDepth, float maxDepth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&minDepth);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDepth;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDepth_Public_Void_Single_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1258921, RefRangeEnd = 1258926, XrefRangeStart = 1258913, XrefRangeEnd = 1258921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&layerMask);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minDepth;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDepth;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateLegacyFilter_Internal_Static_ContactFilter2D_Int32_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ContactFilter2D*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public ContactFilter2D NoFilter()
	{
		useTriggers = true;
		useLayerMask = false;
		layerMask = -1;
		useDepth = false;
		useOutsideDepth = false;
		minDepth = float.NegativeInfinity;
		maxDepth = float.PositiveInfinity;
		useNormalAngle = false;
		useOutsideNormalAngle = false;
		minNormalAngle = 0f;
		maxNormalAngle = 359.9999f;
		return this;
	}

	public void ClearLayerMask()
	{
		useLayerMask = false;
	}

	public void ClearDepth()
	{
		useDepth = false;
	}

	public void ClearNormalAngle()
	{
		useNormalAngle = false;
	}

	public void SetNormalAngle(float minNormalAngle, float maxNormalAngle)
	{
		this.minNormalAngle = minNormalAngle;
		this.maxNormalAngle = maxNormalAngle;
		useNormalAngle = true;
		CheckConsistency();
	}

	public bool IsFilteringTrigger(Collider2D collider)
	{
		return !useTriggers && collider.isTrigger;
	}

	public bool IsFilteringLayerMask(GameObject obj)
	{
		return useLayerMask && ((int)layerMask & (1 << obj.layer)) == 0;
	}

	public bool IsFilteringDepth(GameObject obj)
	{
		if (!useDepth)
		{
			return false;
		}
		if (minDepth > maxDepth)
		{
			float num = minDepth;
			minDepth = maxDepth;
			maxDepth = num;
		}
		float z = obj.transform.position.z;
		bool flag = z < minDepth || z > maxDepth;
		if (useOutsideDepth)
		{
			return !flag;
		}
		return flag;
	}

	public bool IsFilteringNormalAngle(Vector2 normal)
	{
		return IsFilteringNormalAngle_Injected(ref this, ref normal);
	}

	public bool IsFilteringNormalAngle(float angle)
	{
		return IsFilteringNormalAngleUsingAngle(angle);
	}

	public unsafe bool IsFilteringNormalAngleUsingAngle(float angle)
	{
		//IL_000b: Expected O, but got Ref
		return IsFilteringNormalAngleUsingAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)), angle);
	}

	public unsafe static bool IsFilteringNormalAngle_Injected(ref ContactFilter2D _unity_self, [In] ref Vector2 normal)
	{
		return IsFilteringNormalAngle_InjectedDelegateField((nint)Unsafe.AsPointer(ref _unity_self), (nint)Unsafe.AsPointer(ref normal));
	}
}
