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
public struct PassBreakAudit
{
	private static readonly System.IntPtr NativeFieldInfoPtr_reason;

	private static readonly System.IntPtr NativeFieldInfoPtr_breakPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_BreakReasonMessages;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_PassBreakReason_Int32_0;

	[FieldOffset(0)]
	public PassBreakReason reason;

	[FieldOffset(4)]
	public int breakPass;

	public unsafe static Il2CppStringArray BreakReasonMessages
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BreakReasonMessages, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BreakReasonMessages, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static PassBreakAudit()
	{
		Il2CppClassPointerStore<PassBreakAudit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler", "PassBreakAudit");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassBreakAudit>.NativeClassPtr);
		NativeFieldInfoPtr_reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassBreakAudit>.NativeClassPtr, "reason");
		NativeFieldInfoPtr_breakPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassBreakAudit>.NativeClassPtr, "breakPass");
		NativeFieldInfoPtr_BreakReasonMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassBreakAudit>.NativeClassPtr, "BreakReasonMessages");
		NativeMethodInfoPtr__ctor_Public_Void_PassBreakReason_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassBreakAudit>.NativeClassPtr, 100667880);
	}

	[CallerCount(230)]
	[CachedScanResults(RefRangeStart = 409470, RefRangeEnd = 409700, XrefRangeStart = 409470, XrefRangeEnd = 409700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PassBreakAudit(PassBreakReason reason, int breakPass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reason);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &breakPass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_PassBreakReason_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PassBreakAudit>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
