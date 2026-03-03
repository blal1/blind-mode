using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering;

public class ProbeVolume : MonoBehaviour
{
	[OriginalName("Unity.RenderPipelines.Core.Runtime.dll", "", "Mode")]
	public enum Mode
	{
		Global,
		Scene,
		Local
	}

	[OriginalName("Unity.RenderPipelines.Core.Runtime.dll", "", "Version")]
	public enum Version
	{
		Initial,
		LocalMode,
		InvertOverrideLevels,
		Count
	}

	private static readonly IntPtr NativeFieldInfoPtr_mode;

	private static readonly IntPtr NativeFieldInfoPtr_size;

	private static readonly IntPtr NativeFieldInfoPtr_overrideRendererFilters;

	private static readonly IntPtr NativeFieldInfoPtr_minRendererVolumeSize;

	private static readonly IntPtr NativeFieldInfoPtr_objectLayerMask;

	private static readonly IntPtr NativeFieldInfoPtr_lowestSubdivLevelOverride;

	private static readonly IntPtr NativeFieldInfoPtr_highestSubdivLevelOverride;

	private static readonly IntPtr NativeFieldInfoPtr_overridesSubdivLevels;

	private static readonly IntPtr NativeFieldInfoPtr_mightNeedRebaking;

	private static readonly IntPtr NativeFieldInfoPtr_cachedTransform;

	private static readonly IntPtr NativeFieldInfoPtr_cachedHashCode;

	private static readonly IntPtr NativeFieldInfoPtr_fillEmptySpaces;

	private static readonly IntPtr NativeFieldInfoPtr_version;

	private static readonly IntPtr NativeFieldInfoPtr_globalVolume;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Mode mode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode);
			return *(Mode*)num;
		}
		set
		{
			*(Mode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode)) = value;
		}
	}

	public unsafe Vector3 size
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size)) = value;
		}
	}

	public unsafe bool overrideRendererFilters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideRendererFilters);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideRendererFilters)) = value;
		}
	}

	public unsafe float minRendererVolumeSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minRendererVolumeSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minRendererVolumeSize)) = value;
		}
	}

	public unsafe LayerMask objectLayerMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectLayerMask);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectLayerMask)) = value;
		}
	}

	public unsafe int lowestSubdivLevelOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowestSubdivLevelOverride);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowestSubdivLevelOverride)) = value;
		}
	}

	public unsafe int highestSubdivLevelOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highestSubdivLevelOverride);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highestSubdivLevelOverride)) = value;
		}
	}

	public unsafe bool overridesSubdivLevels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overridesSubdivLevels);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overridesSubdivLevels)) = value;
		}
	}

	public unsafe bool mightNeedRebaking
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mightNeedRebaking);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mightNeedRebaking)) = value;
		}
	}

	public unsafe Matrix4x4 cachedTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedTransform);
			return *(Matrix4x4*)num;
		}
		set
		{
			*(Matrix4x4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedTransform)) = value;
		}
	}

	public unsafe int cachedHashCode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedHashCode);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedHashCode)) = value;
		}
	}

	public unsafe bool fillEmptySpaces
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fillEmptySpaces);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fillEmptySpaces)) = value;
		}
	}

	public unsafe Version version
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_version);
			return *(Version*)num;
		}
		set
		{
			*(Version*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_version)) = value;
		}
	}

	public unsafe bool globalVolume
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalVolume);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalVolume)) = value;
		}
	}

	static ProbeVolume()
	{
		Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeVolume");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr);
		NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "mode");
		NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "size");
		NativeFieldInfoPtr_overrideRendererFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "overrideRendererFilters");
		NativeFieldInfoPtr_minRendererVolumeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "minRendererVolumeSize");
		NativeFieldInfoPtr_objectLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "objectLayerMask");
		NativeFieldInfoPtr_lowestSubdivLevelOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "lowestSubdivLevelOverride");
		NativeFieldInfoPtr_highestSubdivLevelOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "highestSubdivLevelOverride");
		NativeFieldInfoPtr_overridesSubdivLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "overridesSubdivLevels");
		NativeFieldInfoPtr_mightNeedRebaking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "mightNeedRebaking");
		NativeFieldInfoPtr_cachedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "cachedTransform");
		NativeFieldInfoPtr_cachedHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "cachedHashCode");
		NativeFieldInfoPtr_fillEmptySpaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "fillEmptySpaces");
		NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "version");
		NativeFieldInfoPtr_globalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "globalVolume");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, 100665746);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, 100665747);
	}

	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043864, XrefRangeEnd = 1043866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProbeVolume()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ProbeVolume(IntPtr pointer)
		: base(pointer)
	{
	}
}
