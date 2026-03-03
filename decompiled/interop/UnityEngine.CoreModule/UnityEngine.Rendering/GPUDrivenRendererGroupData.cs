using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public sealed class GPUDrivenRendererGroupData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_rendererGroupID;

	private static readonly System.IntPtr NativeFieldInfoPtr_localBounds;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightmapScaleOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameObjectLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_renderingLayerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodGroupID;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightmapIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_packedRendererData;

	private static readonly System.IntPtr NativeFieldInfoPtr_rendererPriority;

	private static readonly System.IntPtr NativeFieldInfoPtr_meshIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_subMeshStartIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialsOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialsCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_instancesOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_instancesCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_editorData;

	private static readonly System.IntPtr NativeFieldInfoPtr_invalidRendererGroupID;

	private static readonly System.IntPtr NativeFieldInfoPtr_localToWorldMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_prevLocalToWorldMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_rendererGroupIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_meshID;

	private static readonly System.IntPtr NativeFieldInfoPtr_subMeshCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_subMeshDescOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_subMeshDesc;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialID;

	private static readonly System.IntPtr NativeFieldInfoPtr_packedMaterialData;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialFilterFlags;

	public unsafe NativeArray<int> rendererGroupID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererGroupID);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererGroupID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<Bounds> localBounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localBounds);
			return new NativeArray<Bounds>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Bounds>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localBounds), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Bounds>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<Vector4> lightmapScaleOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightmapScaleOffset);
			return new NativeArray<Vector4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector4>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightmapScaleOffset), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector4>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> gameObjectLayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameObjectLayer);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameObjectLayer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<uint> renderingLayerMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderingLayerMask);
			return new NativeArray<uint>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderingLayerMask), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> lodGroupID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupID);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> lightmapIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightmapIndex);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightmapIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<GPUDrivenPackedRendererData> packedRendererData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_packedRendererData);
			return new NativeArray<GPUDrivenPackedRendererData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<GPUDrivenPackedRendererData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_packedRendererData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<GPUDrivenPackedRendererData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> rendererPriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererPriority);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererPriority), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> meshIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshIndex);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<short> subMeshStartIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subMeshStartIndex);
			return new NativeArray<short>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<short>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subMeshStartIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<short>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> materialsOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialsOffset);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialsOffset), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<short> materialsCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialsCount);
			return new NativeArray<short>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<short>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialsCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<short>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> instancesOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancesOffset);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancesOffset), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> instancesCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancesCount);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancesCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<GPUDrivenRendererEditorData> editorData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_editorData);
			return new NativeArray<GPUDrivenRendererEditorData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<GPUDrivenRendererEditorData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_editorData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<GPUDrivenRendererEditorData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> invalidRendererGroupID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invalidRendererGroupID);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invalidRendererGroupID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<Matrix4x4> localToWorldMatrix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localToWorldMatrix);
			return new NativeArray<Matrix4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localToWorldMatrix), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<Matrix4x4> prevLocalToWorldMatrix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevLocalToWorldMatrix);
			return new NativeArray<Matrix4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevLocalToWorldMatrix), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> rendererGroupIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererGroupIndex);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererGroupIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> meshID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshID);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<short> subMeshCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subMeshCount);
			return new NativeArray<short>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<short>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subMeshCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<short>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> subMeshDescOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subMeshDescOffset);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subMeshDescOffset), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<SubMeshDescriptor> subMeshDesc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subMeshDesc);
			return new NativeArray<SubMeshDescriptor>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<SubMeshDescriptor>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subMeshDesc), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<SubMeshDescriptor>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> materialIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialIndex);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> materialID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialID);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<GPUDrivenPackedMaterialData> packedMaterialData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_packedMaterialData);
			return new NativeArray<GPUDrivenPackedMaterialData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<GPUDrivenPackedMaterialData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_packedMaterialData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<GPUDrivenPackedMaterialData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> materialFilterFlags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialFilterFlags);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialFilterFlags), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static GPUDrivenRendererGroupData()
	{
		Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "GPUDrivenRendererGroupData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr);
		NativeFieldInfoPtr_rendererGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "rendererGroupID");
		NativeFieldInfoPtr_localBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "localBounds");
		NativeFieldInfoPtr_lightmapScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "lightmapScaleOffset");
		NativeFieldInfoPtr_gameObjectLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "gameObjectLayer");
		NativeFieldInfoPtr_renderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "renderingLayerMask");
		NativeFieldInfoPtr_lodGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "lodGroupID");
		NativeFieldInfoPtr_lightmapIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "lightmapIndex");
		NativeFieldInfoPtr_packedRendererData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "packedRendererData");
		NativeFieldInfoPtr_rendererPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "rendererPriority");
		NativeFieldInfoPtr_meshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "meshIndex");
		NativeFieldInfoPtr_subMeshStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "subMeshStartIndex");
		NativeFieldInfoPtr_materialsOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "materialsOffset");
		NativeFieldInfoPtr_materialsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "materialsCount");
		NativeFieldInfoPtr_instancesOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "instancesOffset");
		NativeFieldInfoPtr_instancesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "instancesCount");
		NativeFieldInfoPtr_editorData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "editorData");
		NativeFieldInfoPtr_invalidRendererGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "invalidRendererGroupID");
		NativeFieldInfoPtr_localToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "localToWorldMatrix");
		NativeFieldInfoPtr_prevLocalToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "prevLocalToWorldMatrix");
		NativeFieldInfoPtr_rendererGroupIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "rendererGroupIndex");
		NativeFieldInfoPtr_meshID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "meshID");
		NativeFieldInfoPtr_subMeshCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "subMeshCount");
		NativeFieldInfoPtr_subMeshDescOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "subMeshDescOffset");
		NativeFieldInfoPtr_subMeshDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "subMeshDesc");
		NativeFieldInfoPtr_materialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "materialIndex");
		NativeFieldInfoPtr_materialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "materialID");
		NativeFieldInfoPtr_packedMaterialData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "packedMaterialData");
		NativeFieldInfoPtr_materialFilterFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, "materialFilterFlags");
	}

	public GPUDrivenRendererGroupData(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public GPUDrivenRendererGroupData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr))
	{
	}
}
