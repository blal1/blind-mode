using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct InstanceNumInfo
{
	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.Rendering.InstanceNumInfo+<InstanceNums>e__FixedBuffer")]
	public struct _InstanceNums_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public int FixedElementField;

		static _InstanceNums_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_InstanceNums_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceNumInfo>.NativeClassPtr, "<InstanceNums>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_InstanceNums_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_InstanceNums_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_InstanceNums_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_InstanceNums;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitDefault_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInstanceNum_Public_Int32_InstanceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInstanceNumIncludingChildren_Public_Int32_InstanceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalInstanceNum_Public_Int32_0;

	[FieldOffset(0)]
	public _InstanceNums_e__FixedBuffer InstanceNums;

	static InstanceNumInfo()
	{
		Il2CppClassPointerStore<InstanceNumInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "InstanceNumInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceNumInfo>.NativeClassPtr);
		NativeFieldInfoPtr_InstanceNums = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceNumInfo>.NativeClassPtr, "InstanceNums");
		NativeMethodInfoPtr_InitDefault_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceNumInfo>.NativeClassPtr, 100663884);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceNumInfo>.NativeClassPtr, 100663885);
		NativeMethodInfoPtr_GetInstanceNum_Public_Int32_InstanceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceNumInfo>.NativeClassPtr, 100663886);
		NativeMethodInfoPtr_GetInstanceNumIncludingChildren_Public_Int32_InstanceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceNumInfo>.NativeClassPtr, 100663887);
		NativeMethodInfoPtr_GetTotalInstanceNum_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceNumInfo>.NativeClassPtr, 100663888);
	}

	[CallerCount(0)]
	public unsafe void InitDefault()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitDefault_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073597, RefRangeEnd = 1073598, XrefRangeStart = 1073597, XrefRangeEnd = 1073597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InstanceNumInfo(int meshRendererNum = 0, int speedTreeNum = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&meshRendererNum);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &speedTreeNum;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1023994, RefRangeEnd = 1023996, XrefRangeStart = 1023994, XrefRangeEnd = 1023996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetInstanceNum(InstanceType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInstanceNum_Public_Int32_InstanceType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1073620, RefRangeEnd = 1073622, XrefRangeStart = 1073598, XrefRangeEnd = 1073620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetInstanceNumIncludingChildren(InstanceType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInstanceNumIncludingChildren_Public_Int32_InstanceType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1073622, RefRangeEnd = 1073626, XrefRangeStart = 1073622, XrefRangeEnd = 1073622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetTotalInstanceNum()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTotalInstanceNum_Public_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InstanceNumInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
