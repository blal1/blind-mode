using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[StructLayout(LayoutKind.Explicit)]
public struct LoadAudit
{
	private static readonly System.IntPtr NativeFieldInfoPtr_LoadReasonMessages;

	private static readonly System.IntPtr NativeFieldInfoPtr_reason;

	private static readonly System.IntPtr NativeFieldInfoPtr_passId;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_LoadReason_Int32_0;

	[FieldOffset(0)]
	public LoadReason reason;

	[FieldOffset(4)]
	public int passId;

	public unsafe static Il2CppStringArray LoadReasonMessages
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LoadReasonMessages, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LoadReasonMessages, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static LoadAudit()
	{
		Il2CppClassPointerStore<LoadAudit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler", "LoadAudit");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadAudit>.NativeClassPtr);
		NativeFieldInfoPtr_LoadReasonMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAudit>.NativeClassPtr, "LoadReasonMessages");
		NativeFieldInfoPtr_reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAudit>.NativeClassPtr, "reason");
		NativeFieldInfoPtr_passId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAudit>.NativeClassPtr, "passId");
		NativeMethodInfoPtr__ctor_Public_Void_LoadReason_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAudit>.NativeClassPtr, 100667876);
	}

	[CallerCount(230)]
	[CachedScanResults(RefRangeStart = 409470, RefRangeEnd = 409700, XrefRangeStart = 409470, XrefRangeEnd = 409700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LoadAudit(LoadReason setReason, int setPassId = -1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&setReason);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &setPassId;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_LoadReason_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LoadAudit>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
