using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Jobs;

[StructLayout(LayoutKind.Explicit)]
public struct TransformAccess
{
	private delegate void SetPositionAndRotation_InternalDelegate(System.IntPtr access, System.IntPtr position, System.IntPtr rotation);

	private delegate void SetLocalPositionAndRotation_InternalDelegate(System.IntPtr access, System.IntPtr localPosition, System.IntPtr localRotation);

	private delegate void GetPositionAndRotation_InternalDelegate(System.IntPtr access, [Out] System.IntPtr position, [Out] System.IntPtr rotation);

	private delegate void GetLocalPositionAndRotation_InternalDelegate(System.IntPtr access, [Out] System.IntPtr localPosition, [Out] System.IntPtr localRotation);

	private delegate void SetPositionDelegate(System.IntPtr access, System.IntPtr p);

	private delegate void SetRotationDelegate(System.IntPtr access, System.IntPtr r);

	private delegate void GetLocalPositionDelegate(System.IntPtr access, [Out] System.IntPtr p);

	private delegate void SetLocalPositionDelegate(System.IntPtr access, System.IntPtr p);

	private delegate void GetLocalRotationDelegate(System.IntPtr access, [Out] System.IntPtr r);

	private delegate void SetLocalRotationDelegate(System.IntPtr access, System.IntPtr r);

	private delegate void SetLocalScaleDelegate(System.IntPtr access, System.IntPtr r);

	private static readonly System.IntPtr NativeFieldInfoPtr_hierarchy;

	private static readonly System.IntPtr NativeFieldInfoPtr_index;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_worldToLocalMatrix_Public_get_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPosition_Private_Static_Void_byref_TransformAccess_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRotation_Private_Static_Void_byref_TransformAccess_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalScale_Private_Static_Void_byref_TransformAccess_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalToWorldMatrix_Private_Static_Void_byref_TransformAccess_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldToLocalMatrix_Private_Static_Void_byref_TransformAccess_byref_Matrix4x4_0;

	[FieldOffset(0)]
	public System.IntPtr hierarchy;

	[FieldOffset(8)]
	public int index;

	private static readonly SetPositionAndRotation_InternalDelegate SetPositionAndRotation_InternalDelegateField;

	private static readonly SetLocalPositionAndRotation_InternalDelegate SetLocalPositionAndRotation_InternalDelegateField;

	private static readonly GetPositionAndRotation_InternalDelegate GetPositionAndRotation_InternalDelegateField;

	private static readonly GetLocalPositionAndRotation_InternalDelegate GetLocalPositionAndRotation_InternalDelegateField;

	private static readonly SetPositionDelegate SetPositionDelegateField;

	private static readonly SetRotationDelegate SetRotationDelegateField;

	private static readonly GetLocalPositionDelegate GetLocalPositionDelegateField;

	private static readonly SetLocalPositionDelegate SetLocalPositionDelegateField;

	private static readonly GetLocalRotationDelegate GetLocalRotationDelegateField;

	private static readonly SetLocalRotationDelegate SetLocalRotationDelegateField;

	private static readonly SetLocalScaleDelegate SetLocalScaleDelegateField;

	public unsafe Vector3 position
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1222111, RefRangeEnd = 1222113, XrefRangeStart = 1222109, XrefRangeEnd = 1222111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_position_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			SetPosition(ref this, ref value);
		}
	}

	public unsafe Quaternion rotation
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1222115, RefRangeEnd = 1222118, XrefRangeStart = 1222113, XrefRangeEnd = 1222115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			SetRotation(ref this, ref value);
		}
	}

	public unsafe Vector3 localScale
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1222120, RefRangeEnd = 1222122, XrefRangeStart = 1222118, XrefRangeEnd = 1222120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			SetLocalScale(ref this, ref value);
		}
	}

	public unsafe Matrix4x4 localToWorldMatrix
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1222124, RefRangeEnd = 1222126, XrefRangeStart = 1222122, XrefRangeEnd = 1222124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Matrix4x4 worldToLocalMatrix
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1222128, RefRangeEnd = 1222129, XrefRangeStart = 1222126, XrefRangeEnd = 1222128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_worldToLocalMatrix_Public_get_Matrix4x4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public Vector3 localPosition
	{
		get
		{
			GetLocalPosition(ref this, out var p);
			return p;
		}
		set
		{
			SetLocalPosition(ref this, ref value);
		}
	}

	public Quaternion localRotation
	{
		get
		{
			GetLocalRotation(ref this, out var r);
			return r;
		}
		set
		{
			SetLocalRotation(ref this, ref value);
		}
	}

	public bool isValid => hierarchy != Il2CppSystem.IntPtr.Zero;

	static TransformAccess()
	{
		Il2CppClassPointerStore<TransformAccess>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Jobs", "TransformAccess");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr);
		NativeFieldInfoPtr_hierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, "hierarchy");
		NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, "index");
		NativeMethodInfoPtr_get_position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100666982);
		NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100666983);
		NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100666984);
		NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100666985);
		NativeMethodInfoPtr_get_worldToLocalMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100666986);
		NativeMethodInfoPtr_GetPosition_Private_Static_Void_byref_TransformAccess_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100666987);
		NativeMethodInfoPtr_GetRotation_Private_Static_Void_byref_TransformAccess_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100666988);
		NativeMethodInfoPtr_GetLocalScale_Private_Static_Void_byref_TransformAccess_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100666989);
		NativeMethodInfoPtr_GetLocalToWorldMatrix_Private_Static_Void_byref_TransformAccess_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100666990);
		NativeMethodInfoPtr_GetWorldToLocalMatrix_Private_Static_Void_byref_TransformAccess_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100666991);
		SetPositionAndRotation_InternalDelegateField = IL2CPP.ResolveICall<SetPositionAndRotation_InternalDelegate>("UnityEngine.Jobs.TransformAccess::SetPositionAndRotation_Internal");
		SetLocalPositionAndRotation_InternalDelegateField = IL2CPP.ResolveICall<SetLocalPositionAndRotation_InternalDelegate>("UnityEngine.Jobs.TransformAccess::SetLocalPositionAndRotation_Internal");
		GetPositionAndRotation_InternalDelegateField = IL2CPP.ResolveICall<GetPositionAndRotation_InternalDelegate>("UnityEngine.Jobs.TransformAccess::GetPositionAndRotation_Internal");
		GetLocalPositionAndRotation_InternalDelegateField = IL2CPP.ResolveICall<GetLocalPositionAndRotation_InternalDelegate>("UnityEngine.Jobs.TransformAccess::GetLocalPositionAndRotation_Internal");
		SetPositionDelegateField = IL2CPP.ResolveICall<SetPositionDelegate>("UnityEngine.Jobs.TransformAccess::SetPosition");
		SetRotationDelegateField = IL2CPP.ResolveICall<SetRotationDelegate>("UnityEngine.Jobs.TransformAccess::SetRotation");
		GetLocalPositionDelegateField = IL2CPP.ResolveICall<GetLocalPositionDelegate>("UnityEngine.Jobs.TransformAccess::GetLocalPosition");
		SetLocalPositionDelegateField = IL2CPP.ResolveICall<SetLocalPositionDelegate>("UnityEngine.Jobs.TransformAccess::SetLocalPosition");
		GetLocalRotationDelegateField = IL2CPP.ResolveICall<GetLocalRotationDelegate>("UnityEngine.Jobs.TransformAccess::GetLocalRotation");
		SetLocalRotationDelegateField = IL2CPP.ResolveICall<SetLocalRotationDelegate>("UnityEngine.Jobs.TransformAccess::SetLocalRotation");
		SetLocalScaleDelegateField = IL2CPP.ResolveICall<SetLocalScaleDelegate>("UnityEngine.Jobs.TransformAccess::SetLocalScale");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222129, XrefRangeEnd = 1222131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetPosition(ref TransformAccess access, out Vector3 p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref access);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref p);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPosition_Private_Static_Void_byref_TransformAccess_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222131, XrefRangeEnd = 1222133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetRotation(ref TransformAccess access, out Quaternion r)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref access);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref r);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRotation_Private_Static_Void_byref_TransformAccess_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222133, XrefRangeEnd = 1222135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetLocalScale(ref TransformAccess access, out Vector3 r)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref access);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref r);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalScale_Private_Static_Void_byref_TransformAccess_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222135, XrefRangeEnd = 1222137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetLocalToWorldMatrix(ref TransformAccess access, out Matrix4x4 m)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref access);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref m);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalToWorldMatrix_Private_Static_Void_byref_TransformAccess_byref_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222137, XrefRangeEnd = 1222139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetWorldToLocalMatrix(ref TransformAccess access, out Matrix4x4 m)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref access);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref m);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldToLocalMatrix_Private_Static_Void_byref_TransformAccess_byref_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
	{
		SetPositionAndRotation_Internal(ref this, ref position, ref rotation);
	}

	public void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation)
	{
		SetLocalPositionAndRotation_Internal(ref this, ref localPosition, ref localRotation);
	}

	public void GetPositionAndRotation(out Vector3 position, out Quaternion rotation)
	{
		GetPositionAndRotation_Internal(ref this, out position, out rotation);
	}

	public void GetLocalPositionAndRotation(out Vector3 localPosition, out Quaternion localRotation)
	{
		GetLocalPositionAndRotation_Internal(ref this, out localPosition, out localRotation);
	}

	public unsafe static void SetPositionAndRotation_Internal(ref TransformAccess access, ref Vector3 position, ref Quaternion rotation)
	{
		SetPositionAndRotation_InternalDelegateField((nint)Unsafe.AsPointer(ref access), (nint)Unsafe.AsPointer(ref position), (nint)Unsafe.AsPointer(ref rotation));
	}

	public unsafe static void SetLocalPositionAndRotation_Internal(ref TransformAccess access, ref Vector3 localPosition, ref Quaternion localRotation)
	{
		SetLocalPositionAndRotation_InternalDelegateField((nint)Unsafe.AsPointer(ref access), (nint)Unsafe.AsPointer(ref localPosition), (nint)Unsafe.AsPointer(ref localRotation));
	}

	public unsafe static void GetPositionAndRotation_Internal(ref TransformAccess access, out Vector3 position, out Quaternion rotation)
	{
		GetPositionAndRotation_InternalDelegateField((nint)Unsafe.AsPointer(ref access), (nint)Unsafe.AsPointer(ref position), (nint)Unsafe.AsPointer(ref rotation));
	}

	public unsafe static void GetLocalPositionAndRotation_Internal(ref TransformAccess access, out Vector3 localPosition, out Quaternion localRotation)
	{
		GetLocalPositionAndRotation_InternalDelegateField((nint)Unsafe.AsPointer(ref access), (nint)Unsafe.AsPointer(ref localPosition), (nint)Unsafe.AsPointer(ref localRotation));
	}

	public unsafe static void SetPosition(ref TransformAccess access, ref Vector3 p)
	{
		SetPositionDelegateField((nint)Unsafe.AsPointer(ref access), (nint)Unsafe.AsPointer(ref p));
	}

	public unsafe static void SetRotation(ref TransformAccess access, ref Quaternion r)
	{
		SetRotationDelegateField((nint)Unsafe.AsPointer(ref access), (nint)Unsafe.AsPointer(ref r));
	}

	public unsafe static void GetLocalPosition(ref TransformAccess access, out Vector3 p)
	{
		GetLocalPositionDelegateField((nint)Unsafe.AsPointer(ref access), (nint)Unsafe.AsPointer(ref p));
	}

	public unsafe static void SetLocalPosition(ref TransformAccess access, ref Vector3 p)
	{
		SetLocalPositionDelegateField((nint)Unsafe.AsPointer(ref access), (nint)Unsafe.AsPointer(ref p));
	}

	public unsafe static void GetLocalRotation(ref TransformAccess access, out Quaternion r)
	{
		GetLocalRotationDelegateField((nint)Unsafe.AsPointer(ref access), (nint)Unsafe.AsPointer(ref r));
	}

	public unsafe static void SetLocalRotation(ref TransformAccess access, ref Quaternion r)
	{
		SetLocalRotationDelegateField((nint)Unsafe.AsPointer(ref access), (nint)Unsafe.AsPointer(ref r));
	}

	public unsafe static void SetLocalScale(ref TransformAccess access, ref Vector3 r)
	{
		SetLocalScaleDelegateField((nint)Unsafe.AsPointer(ref access), (nint)Unsafe.AsPointer(ref r));
	}

	public void CheckHierarchyValid()
	{
		if (!isValid)
		{
			throw new Il2CppSystem.NullReferenceException("The TransformAccess is not valid and points to an invalid hierarchy");
		}
	}

	public void MarkReadWrite()
	{
	}

	public void MarkReadOnly()
	{
	}

	public void CheckWriteAccess()
	{
	}
}
