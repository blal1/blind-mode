using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public sealed class GPUDrivenLODGroupData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_lodGroupID;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_fadeMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldSpaceReferencePoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldSpaceSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_renderersCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastLODIsBillboard;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceLODMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_invalidLODGroupID;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodRenderersCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodScreenRelativeTransitionHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodFadeTransitionWidth;

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

	public unsafe NativeArray<int> lodOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodOffset);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodOffset), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> lodCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodCount);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<LODFadeMode> fadeMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeMode);
			return new NativeArray<LODFadeMode>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<LODFadeMode>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeMode), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<LODFadeMode>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<Vector3> worldSpaceReferencePoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldSpaceReferencePoint);
			return new NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldSpaceReferencePoint), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<float> worldSpaceSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldSpaceSize);
			return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldSpaceSize), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<short> renderersCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderersCount);
			return new NativeArray<short>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<short>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderersCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<short>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<bool> lastLODIsBillboard
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastLODIsBillboard);
			return new NativeArray<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastLODIsBillboard), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<byte> forceLODMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceLODMask);
			return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceLODMask), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> invalidLODGroupID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invalidLODGroupID);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invalidLODGroupID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<short> lodRenderersCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodRenderersCount);
			return new NativeArray<short>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<short>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodRenderersCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<short>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<float> lodScreenRelativeTransitionHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodScreenRelativeTransitionHeight);
			return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodScreenRelativeTransitionHeight), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<float> lodFadeTransitionWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodFadeTransitionWidth);
			return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodFadeTransitionWidth), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static GPUDrivenLODGroupData()
	{
		Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "GPUDrivenLODGroupData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr);
		NativeFieldInfoPtr_lodGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, "lodGroupID");
		NativeFieldInfoPtr_lodOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, "lodOffset");
		NativeFieldInfoPtr_lodCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, "lodCount");
		NativeFieldInfoPtr_fadeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, "fadeMode");
		NativeFieldInfoPtr_worldSpaceReferencePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, "worldSpaceReferencePoint");
		NativeFieldInfoPtr_worldSpaceSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, "worldSpaceSize");
		NativeFieldInfoPtr_renderersCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, "renderersCount");
		NativeFieldInfoPtr_lastLODIsBillboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, "lastLODIsBillboard");
		NativeFieldInfoPtr_forceLODMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, "forceLODMask");
		NativeFieldInfoPtr_invalidLODGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, "invalidLODGroupID");
		NativeFieldInfoPtr_lodRenderersCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, "lodRenderersCount");
		NativeFieldInfoPtr_lodScreenRelativeTransitionHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, "lodScreenRelativeTransitionHeight");
		NativeFieldInfoPtr_lodFadeTransitionWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, "lodFadeTransitionWidth");
	}

	public GPUDrivenLODGroupData(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public GPUDrivenLODGroupData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr))
	{
	}
}
