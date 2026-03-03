using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.XR;

public sealed class MeshGenerationResult : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr__MeshId_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Mesh_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__MeshCollider_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Status_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Attributes_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Timestamp_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Position_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Rotation_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Scale_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MeshId_Public_get_MeshId_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Mesh_Public_get_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MeshCollider_Public_get_MeshCollider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Status_Public_get_MeshGenerationStatus_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Attributes_Public_get_MeshVertexAttributes_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Scale_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MeshGenerationResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	public unsafe MeshId _MeshId_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MeshId_k__BackingField);
			return *(MeshId*)num;
		}
		set
		{
			*(MeshId*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MeshId_k__BackingField)) = value;
		}
	}

	public unsafe Mesh _Mesh_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Mesh_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Mesh_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe MeshCollider _MeshCollider_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MeshCollider_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeshCollider>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MeshCollider_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe MeshGenerationStatus _Status_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Status_k__BackingField);
			return *(MeshGenerationStatus*)num;
		}
		set
		{
			*(MeshGenerationStatus*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Status_k__BackingField)) = value;
		}
	}

	public unsafe MeshVertexAttributes _Attributes_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Attributes_k__BackingField);
			return *(MeshVertexAttributes*)num;
		}
		set
		{
			*(MeshVertexAttributes*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Attributes_k__BackingField)) = value;
		}
	}

	public unsafe ulong _Timestamp_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Timestamp_k__BackingField);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Timestamp_k__BackingField)) = value;
		}
	}

	public unsafe Vector3 _Position_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Position_k__BackingField);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Position_k__BackingField)) = value;
		}
	}

	public unsafe Quaternion _Rotation_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Rotation_k__BackingField);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Rotation_k__BackingField)) = value;
		}
	}

	public unsafe Vector3 _Scale_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Scale_k__BackingField);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Scale_k__BackingField)) = value;
		}
	}

	public unsafe MeshId MeshId
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 732551, RefRangeEnd = 732556, XrefRangeStart = 732551, XrefRangeEnd = 732556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MeshId_Public_get_MeshId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(MeshId*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Mesh Mesh
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Mesh_Public_get_Mesh_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
		}
	}

	public unsafe MeshCollider MeshCollider
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MeshCollider_Public_get_MeshCollider_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeshCollider>(intPtr2) : null;
		}
	}

	public unsafe MeshGenerationStatus Status
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63233, RefRangeEnd = 63234, XrefRangeStart = 63233, XrefRangeEnd = 63234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Status_Public_get_MeshGenerationStatus_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(MeshGenerationStatus*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe MeshVertexAttributes Attributes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Attributes_Public_get_MeshVertexAttributes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(MeshVertexAttributes*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Vector3 Position
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Position_Public_get_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Quaternion Rotation
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Vector3 Scale
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Scale_Public_get_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public ulong Timestamp => _Timestamp_k__BackingField;

	static MeshGenerationResult()
	{
		Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "MeshGenerationResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr);
		NativeFieldInfoPtr__MeshId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, "<MeshId>k__BackingField");
		NativeFieldInfoPtr__Mesh_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, "<Mesh>k__BackingField");
		NativeFieldInfoPtr__MeshCollider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, "<MeshCollider>k__BackingField");
		NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, "<Status>k__BackingField");
		NativeFieldInfoPtr__Attributes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, "<Attributes>k__BackingField");
		NativeFieldInfoPtr__Timestamp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, "<Timestamp>k__BackingField");
		NativeFieldInfoPtr__Position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, "<Position>k__BackingField");
		NativeFieldInfoPtr__Rotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, "<Rotation>k__BackingField");
		NativeFieldInfoPtr__Scale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, "<Scale>k__BackingField");
		NativeMethodInfoPtr_get_MeshId_Public_get_MeshId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_get_Mesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_get_MeshCollider_Public_get_MeshCollider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663392);
		NativeMethodInfoPtr_get_Status_Public_get_MeshGenerationStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663393);
		NativeMethodInfoPtr_get_Attributes_Public_get_MeshVertexAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663394);
		NativeMethodInfoPtr_get_Position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663395);
		NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663396);
		NativeMethodInfoPtr_get_Scale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663397);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663398);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MeshGenerationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663399);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663400);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411288, XrefRangeEnd = 1411292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Equals(Il2CppSystem.Object obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1411299, RefRangeEnd = 1411300, XrefRangeStart = 1411292, XrefRangeEnd = 1411299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(MeshGenerationResult other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)other));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MeshGenerationResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411300, XrefRangeEnd = 1411317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public MeshGenerationResult(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public MeshGenerationResult()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr))
	{
	}

	public unsafe static bool operator ==(MeshGenerationResult lhs, MeshGenerationResult rhs)
	{
		//IL_0009: Expected O, but got Ref
		return ((MeshGenerationResult)(&lhs)).Equals(rhs);
	}

	public unsafe static bool operator !=(MeshGenerationResult lhs, MeshGenerationResult rhs)
	{
		//IL_0009: Expected O, but got Ref
		return !((MeshGenerationResult)(&lhs)).Equals(rhs);
	}
}
