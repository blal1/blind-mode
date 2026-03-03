using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public class ProbeSamplingDebugData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_update;

	private static readonly System.IntPtr NativeFieldInfoPtr_coordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceScreenCenterCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_camera;

	private static readonly System.IntPtr NativeFieldInfoPtr_shortcutPressed;

	private static readonly System.IntPtr NativeFieldInfoPtr_positionNormalBuffer;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ProbeSamplingDebugUpdate update
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_update);
			return *(ProbeSamplingDebugUpdate*)num;
		}
		set
		{
			*(ProbeSamplingDebugUpdate*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_update)) = value;
		}
	}

	public unsafe Vector2 coordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coordinates);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coordinates)) = value;
		}
	}

	public unsafe bool forceScreenCenterCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceScreenCenterCoordinates);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceScreenCenterCoordinates)) = value;
		}
	}

	public unsafe Camera camera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camera)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool shortcutPressed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shortcutPressed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shortcutPressed)) = value;
		}
	}

	public unsafe GraphicsBuffer positionNormalBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionNormalBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionNormalBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ProbeSamplingDebugData()
	{
		Il2CppClassPointerStore<ProbeSamplingDebugData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeSamplingDebugData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeSamplingDebugData>.NativeClassPtr);
		NativeFieldInfoPtr_update = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeSamplingDebugData>.NativeClassPtr, "update");
		NativeFieldInfoPtr_coordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeSamplingDebugData>.NativeClassPtr, "coordinates");
		NativeFieldInfoPtr_forceScreenCenterCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeSamplingDebugData>.NativeClassPtr, "forceScreenCenterCoordinates");
		NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeSamplingDebugData>.NativeClassPtr, "camera");
		NativeFieldInfoPtr_shortcutPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeSamplingDebugData>.NativeClassPtr, "shortcutPressed");
		NativeFieldInfoPtr_positionNormalBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeSamplingDebugData>.NativeClassPtr, "positionNormalBuffer");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeSamplingDebugData>.NativeClassPtr, 100665739);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043855, XrefRangeEnd = 1043856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProbeSamplingDebugData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeSamplingDebugData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ProbeSamplingDebugData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
