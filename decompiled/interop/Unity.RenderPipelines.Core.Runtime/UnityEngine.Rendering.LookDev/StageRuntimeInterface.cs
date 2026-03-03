using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.LookDev;

public class StageRuntimeInterface : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_AddGameObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GetCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GetSunLight;

	private static readonly System.IntPtr NativeFieldInfoPtr_SRPData;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_2_Boolean_GameObject_Func_1_Camera_Func_1_Light_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddGameObject_Public_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_camera_Public_get_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sunLight_Public_get_Light_0;

	public unsafe Il2CppSystem.Func<bool, GameObject> m_AddGameObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AddGameObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool, GameObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AddGameObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Func<Camera> m_GetCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GetCamera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Camera>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GetCamera)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Func<Light> m_GetSunLight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GetSunLight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Light>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GetSunLight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Object SRPData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SRPData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SRPData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Camera camera
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_camera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
		}
	}

	public unsafe Light sunLight
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sunLight_Public_get_Light_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
		}
	}

	static StageRuntimeInterface()
	{
		Il2CppClassPointerStore<StageRuntimeInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.LookDev", "StageRuntimeInterface");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StageRuntimeInterface>.NativeClassPtr);
		NativeFieldInfoPtr_m_AddGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageRuntimeInterface>.NativeClassPtr, "m_AddGameObject");
		NativeFieldInfoPtr_m_GetCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageRuntimeInterface>.NativeClassPtr, "m_GetCamera");
		NativeFieldInfoPtr_m_GetSunLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageRuntimeInterface>.NativeClassPtr, "m_GetSunLight");
		NativeFieldInfoPtr_SRPData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageRuntimeInterface>.NativeClassPtr, "SRPData");
		NativeMethodInfoPtr__ctor_Public_Void_Func_2_Boolean_GameObject_Func_1_Camera_Func_1_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageRuntimeInterface>.NativeClassPtr, 100667918);
		NativeMethodInfoPtr_AddGameObject_Public_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageRuntimeInterface>.NativeClassPtr, 100667919);
		NativeMethodInfoPtr_get_camera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageRuntimeInterface>.NativeClassPtr, 100667920);
		NativeMethodInfoPtr_get_sunLight_Public_get_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageRuntimeInterface>.NativeClassPtr, 100667921);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 469798, RefRangeEnd = 469803, XrefRangeStart = 469798, XrefRangeEnd = 469803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StageRuntimeInterface(Il2CppSystem.Func<bool, GameObject> AddGameObject, Il2CppSystem.Func<Camera> GetCamera, Il2CppSystem.Func<Light> GetSunLight)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StageRuntimeInterface>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)AddGameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)GetCamera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)GetSunLight);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Func_2_Boolean_GameObject_Func_1_Camera_Func_1_Light_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe GameObject AddGameObject(bool persistent = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&persistent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddGameObject_Public_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
	}

	public StageRuntimeInterface(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
