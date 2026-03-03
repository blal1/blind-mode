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
public struct StoreAudit
{
	private static readonly System.IntPtr NativeFieldInfoPtr_StoreReasonMessages;

	private static readonly System.IntPtr NativeFieldInfoPtr_reason;

	private static readonly System.IntPtr NativeFieldInfoPtr_passId;

	private static readonly System.IntPtr NativeFieldInfoPtr_msaaReason;

	private static readonly System.IntPtr NativeFieldInfoPtr_msaaPassId;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_StoreReason_Int32_StoreReason_Int32_0;

	[FieldOffset(0)]
	public StoreReason reason;

	[FieldOffset(4)]
	public int passId;

	[FieldOffset(8)]
	public StoreReason msaaReason;

	[FieldOffset(12)]
	public int msaaPassId;

	public unsafe static Il2CppStringArray StoreReasonMessages
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_StoreReasonMessages, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_StoreReasonMessages, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static StoreAudit()
	{
		Il2CppClassPointerStore<StoreAudit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler", "StoreAudit");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoreAudit>.NativeClassPtr);
		NativeFieldInfoPtr_StoreReasonMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreAudit>.NativeClassPtr, "StoreReasonMessages");
		NativeFieldInfoPtr_reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreAudit>.NativeClassPtr, "reason");
		NativeFieldInfoPtr_passId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreAudit>.NativeClassPtr, "passId");
		NativeFieldInfoPtr_msaaReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreAudit>.NativeClassPtr, "msaaReason");
		NativeFieldInfoPtr_msaaPassId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreAudit>.NativeClassPtr, "msaaPassId");
		NativeMethodInfoPtr__ctor_Public_Void_StoreReason_Int32_StoreReason_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreAudit>.NativeClassPtr, 100667878);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 1023969, RefRangeEnd = 1023994, XrefRangeStart = 1023969, XrefRangeEnd = 1023994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StoreAudit(StoreReason setReason, int setPassId = -1, StoreReason setMsaaReason = StoreReason.NoMSAABuffer, int setMsaaPassId = -1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&setReason);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &setPassId;
		*(StoreReason**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &setMsaaReason;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &setMsaaPassId;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_StoreReason_Int32_StoreReason_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StoreAudit>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
