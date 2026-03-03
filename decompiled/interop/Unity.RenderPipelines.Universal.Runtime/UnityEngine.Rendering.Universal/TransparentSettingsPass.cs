using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering.Universal;

public class TransparentSettingsPass : ScriptableRenderPass
{
	private static readonly IntPtr NativeFieldInfoPtr_m_shouldReceiveShadows;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

	private static readonly IntPtr NativeMethodInfoPtr_ExecutePass_Public_Static_Void_RasterCommandBuffer_0;

	public unsafe bool m_shouldReceiveShadows
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_shouldReceiveShadows);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_shouldReceiveShadows)) = value;
		}
	}

	static TransparentSettingsPass()
	{
		Il2CppClassPointerStore<TransparentSettingsPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "TransparentSettingsPass");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransparentSettingsPass>.NativeClassPtr);
		NativeFieldInfoPtr_m_shouldReceiveShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransparentSettingsPass>.NativeClassPtr, "m_shouldReceiveShadows");
		NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentSettingsPass>.NativeClassPtr, 100665131);
		NativeMethodInfoPtr_Setup_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentSettingsPass>.NativeClassPtr, 100665132);
		NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentSettingsPass>.NativeClassPtr, 100665133);
		NativeMethodInfoPtr_ExecutePass_Public_Static_Void_RasterCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentSettingsPass>.NativeClassPtr, 100665134);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1095630, RefRangeEnd = 1095631, XrefRangeStart = 1095619, XrefRangeEnd = 1095630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TransparentSettingsPass(RenderPassEvent evt, bool shadowReceiveSupported)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransparentSettingsPass>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&evt);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &shadowReceiveSupported;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1095631, RefRangeEnd = 1095632, XrefRangeStart = 1095631, XrefRangeEnd = 1095631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Setup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095632, XrefRangeEnd = 1095650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&context);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1095658, RefRangeEnd = 1095660, XrefRangeStart = 1095650, XrefRangeEnd = 1095658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ExecutePass(RasterCommandBuffer rasterCommandBuffer)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rasterCommandBuffer);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecutePass_Public_Static_Void_RasterCommandBuffer_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TransparentSettingsPass(IntPtr pointer)
		: base(pointer)
	{
	}
}
