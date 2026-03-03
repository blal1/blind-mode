using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public sealed class BatchCullingContext : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_cullingPlanes;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullingSplits;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodParameters;

	private static readonly System.IntPtr NativeFieldInfoPtr_localToWorldMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewType;

	private static readonly System.IntPtr NativeFieldInfoPtr_projectionType;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullingFlags;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewID;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullingLayerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_sceneCullingMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_splitExclusionMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_isOrthographic;

	private static readonly System.IntPtr NativeFieldInfoPtr_receiverPlaneOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_receiverPlaneCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_occlusionBuffer;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_NativeArray_1_Plane_NativeArray_1_CullingSplit_LODParameters_Matrix4x4_BatchCullingViewType_BatchCullingProjectionType_BatchCullingFlags_UInt64_UInt32_UInt64_Byte_Int32_Int32_IntPtr_0;

	public unsafe NativeArray<Plane> cullingPlanes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingPlanes);
			return new NativeArray<Plane>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Plane>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingPlanes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Plane>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<CullingSplit> cullingSplits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingSplits);
			return new NativeArray<CullingSplit>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<CullingSplit>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingSplits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<CullingSplit>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe LODParameters lodParameters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodParameters);
			return *(LODParameters*)num;
		}
		set
		{
			*(LODParameters*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodParameters)) = value;
		}
	}

	public unsafe Matrix4x4 localToWorldMatrix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localToWorldMatrix);
			return *(Matrix4x4*)num;
		}
		set
		{
			*(Matrix4x4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localToWorldMatrix)) = value;
		}
	}

	public unsafe BatchCullingViewType viewType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewType);
			return *(BatchCullingViewType*)num;
		}
		set
		{
			*(BatchCullingViewType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewType)) = value;
		}
	}

	public unsafe BatchCullingProjectionType projectionType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_projectionType);
			return *(BatchCullingProjectionType*)num;
		}
		set
		{
			*(BatchCullingProjectionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_projectionType)) = value;
		}
	}

	public unsafe BatchCullingFlags cullingFlags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingFlags);
			return *(BatchCullingFlags*)num;
		}
		set
		{
			*(BatchCullingFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingFlags)) = value;
		}
	}

	public unsafe BatchPackedCullingViewID viewID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewID);
			return *(BatchPackedCullingViewID*)num;
		}
		set
		{
			*(BatchPackedCullingViewID*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewID)) = value;
		}
	}

	public unsafe uint cullingLayerMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingLayerMask);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingLayerMask)) = value;
		}
	}

	public unsafe ulong sceneCullingMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneCullingMask);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneCullingMask)) = value;
		}
	}

	public unsafe ushort splitExclusionMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_splitExclusionMask);
			return *(ushort*)num;
		}
		set
		{
			*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_splitExclusionMask)) = value;
		}
	}

	public unsafe byte isOrthographic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOrthographic);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOrthographic)) = value;
		}
	}

	public unsafe int receiverPlaneOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiverPlaneOffset);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiverPlaneOffset)) = value;
		}
	}

	public unsafe int receiverPlaneCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiverPlaneCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiverPlaneCount)) = value;
		}
	}

	public unsafe System.IntPtr occlusionBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionBuffer);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionBuffer)) = value;
		}
	}

	static BatchCullingContext()
	{
		Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchCullingContext");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr);
		NativeFieldInfoPtr_cullingPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "cullingPlanes");
		NativeFieldInfoPtr_cullingSplits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "cullingSplits");
		NativeFieldInfoPtr_lodParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "lodParameters");
		NativeFieldInfoPtr_localToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "localToWorldMatrix");
		NativeFieldInfoPtr_viewType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "viewType");
		NativeFieldInfoPtr_projectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "projectionType");
		NativeFieldInfoPtr_cullingFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "cullingFlags");
		NativeFieldInfoPtr_viewID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "viewID");
		NativeFieldInfoPtr_cullingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "cullingLayerMask");
		NativeFieldInfoPtr_sceneCullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "sceneCullingMask");
		NativeFieldInfoPtr_splitExclusionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "splitExclusionMask");
		NativeFieldInfoPtr_isOrthographic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "isOrthographic");
		NativeFieldInfoPtr_receiverPlaneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "receiverPlaneOffset");
		NativeFieldInfoPtr_receiverPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "receiverPlaneCount");
		NativeFieldInfoPtr_occlusionBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "occlusionBuffer");
		NativeMethodInfoPtr__ctor_Internal_Void_NativeArray_1_Plane_NativeArray_1_CullingSplit_LODParameters_Matrix4x4_BatchCullingViewType_BatchCullingProjectionType_BatchCullingFlags_UInt64_UInt32_UInt64_Byte_Int32_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, 100668322);
	}

	[CallerCount(0)]
	public unsafe BatchCullingContext(NativeArray<Plane> inCullingPlanes, NativeArray<CullingSplit> inCullingSplits, LODParameters inLodParameters, Matrix4x4 inLocalToWorldMatrix, BatchCullingViewType inViewType, BatchCullingProjectionType inProjectionType, BatchCullingFlags inBatchCullingFlags, ulong inViewID, uint inCullingLayerMask, ulong inSceneCullingMask, byte inExclusionSplitMask, int inReceiverPlaneOffset, int inReceiverPlaneCount, System.IntPtr inOcclusionBuffer)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[14];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inCullingPlanes));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inCullingSplits));
		*(LODParameters**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inLodParameters;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &inLocalToWorldMatrix;
		*(BatchCullingViewType**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &inViewType;
		*(BatchCullingProjectionType**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &inProjectionType;
		*(BatchCullingFlags**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &inBatchCullingFlags;
		*(ulong**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &inViewID;
		*(uint**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &inCullingLayerMask;
		*(ulong**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &inSceneCullingMask;
		*(byte**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &inExclusionSplitMask;
		*(int**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &inReceiverPlaneOffset;
		*(int**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &inReceiverPlaneCount;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &inOcclusionBuffer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_NativeArray_1_Plane_NativeArray_1_CullingSplit_LODParameters_Matrix4x4_BatchCullingViewType_BatchCullingProjectionType_BatchCullingFlags_UInt64_UInt32_UInt64_Byte_Int32_Int32_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public BatchCullingContext(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public BatchCullingContext()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr))
	{
	}
}
