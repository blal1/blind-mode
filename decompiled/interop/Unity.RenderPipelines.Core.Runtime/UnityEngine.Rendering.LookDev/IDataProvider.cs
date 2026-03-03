using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.LookDev;

public class IDataProvider : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_FirstInitScene_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateSky_Public_Abstract_Virtual_New_Void_Camera_Sky_StageRuntimeInterface_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_supportedDebugModes_Public_Abstract_Virtual_New_get_IEnumerable_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateDebugMode_Public_Abstract_Virtual_New_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetShadowMask_Public_Abstract_Virtual_New_Void_byref_RenderTexture_StageRuntimeInterface_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnBeginRendering_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnEndRendering_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0;

	private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0;

	public unsafe virtual IEnumerable<string> supportedDebugModes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_supportedDebugModes_Public_Abstract_Virtual_New_get_IEnumerable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
		}
	}

	static IDataProvider()
	{
		Il2CppClassPointerStore<IDataProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.LookDev", "IDataProvider");
		NativeMethodInfoPtr_FirstInitScene_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDataProvider>.NativeClassPtr, 100667910);
		NativeMethodInfoPtr_UpdateSky_Public_Abstract_Virtual_New_Void_Camera_Sky_StageRuntimeInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDataProvider>.NativeClassPtr, 100667911);
		NativeMethodInfoPtr_get_supportedDebugModes_Public_Abstract_Virtual_New_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDataProvider>.NativeClassPtr, 100667912);
		NativeMethodInfoPtr_UpdateDebugMode_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDataProvider>.NativeClassPtr, 100667913);
		NativeMethodInfoPtr_GetShadowMask_Public_Abstract_Virtual_New_Void_byref_RenderTexture_StageRuntimeInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDataProvider>.NativeClassPtr, 100667914);
		NativeMethodInfoPtr_OnBeginRendering_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDataProvider>.NativeClassPtr, 100667915);
		NativeMethodInfoPtr_OnEndRendering_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDataProvider>.NativeClassPtr, 100667916);
		NativeMethodInfoPtr_Cleanup_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDataProvider>.NativeClassPtr, 100667917);
	}

	[CallerCount(0)]
	public unsafe virtual void FirstInitScene(StageRuntimeInterface stage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stage);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FirstInitScene_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void UpdateSky(Camera camera, Sky sky, StageRuntimeInterface stage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sky));
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stage);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UpdateSky_Public_Abstract_Virtual_New_Void_Camera_Sky_StageRuntimeInterface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void UpdateDebugMode(int debugIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&debugIndex);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UpdateDebugMode_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void GetShadowMask(ref RenderTexture output, StageRuntimeInterface stage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
		*ptr = (nint)(&intPtr);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stage);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetShadowMask_Public_Abstract_Virtual_New_Void_byref_RenderTexture_StageRuntimeInterface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr4 = intPtr;
		output = ((intPtr4 == (IntPtr)0) ? null : new RenderTexture(intPtr4));
	}

	[CallerCount(0)]
	public unsafe virtual void OnBeginRendering(StageRuntimeInterface stage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stage);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnBeginRendering_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void OnEndRendering(StageRuntimeInterface stage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stage);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnEndRendering_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void Cleanup(StageRuntimeInterface SRI)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)SRI);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Cleanup_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IDataProvider(IntPtr pointer)
		: base(pointer)
	{
	}
}
