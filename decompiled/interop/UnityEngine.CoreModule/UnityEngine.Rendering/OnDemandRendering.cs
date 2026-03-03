using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public class OnDemandRendering : Il2CppSystem.Object
{
	private delegate float GetEffectiveRenderFrameRateDelegate();

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderFrameInterval;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderFrameInterval_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderFrameInterval_Internal_Static_Void_byref_Int32_0;

	private static readonly GetEffectiveRenderFrameRateDelegate GetEffectiveRenderFrameRateDelegateField;

	public unsafe static int m_RenderFrameInterval
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_RenderFrameInterval, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_RenderFrameInterval, (void*)(&value));
		}
	}

	public unsafe static int renderFrameInterval
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232544, XrefRangeEnd = 1232548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderFrameInterval_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_RenderFrameInterval = Il2CppSystem.Math.Max(1, value);
		}
	}

	public static bool willCurrentFrameRender => Time.frameCount % renderFrameInterval == 0;

	public static int effectiveRenderFrameRate
	{
		get
		{
			float num = GetEffectiveRenderFrameRate();
			if ((double)num <= 0.0)
			{
				return (int)num;
			}
			return (int)(num + 0.5f);
		}
	}

	static OnDemandRendering()
	{
		Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "OnDemandRendering");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr);
		NativeFieldInfoPtr_m_RenderFrameInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr, "m_RenderFrameInterval");
		NativeMethodInfoPtr_get_renderFrameInterval_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr, 100667745);
		NativeMethodInfoPtr_GetRenderFrameInterval_Internal_Static_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr, 100667746);
		GetEffectiveRenderFrameRateDelegateField = IL2CPP.ResolveICall<GetEffectiveRenderFrameRateDelegate>("UnityEngine.Rendering.OnDemandRendering::GetEffectiveRenderFrameRate");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232548, XrefRangeEnd = 1232555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetRenderFrameInterval(out int frameInterval)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref frameInterval);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderFrameInterval_Internal_Static_Void_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public OnDemandRendering(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static float GetEffectiveRenderFrameRate()
	{
		return GetEffectiveRenderFrameRateDelegateField();
	}
}
