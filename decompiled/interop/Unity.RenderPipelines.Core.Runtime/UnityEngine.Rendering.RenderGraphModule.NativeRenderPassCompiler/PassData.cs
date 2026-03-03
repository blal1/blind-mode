using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[StructLayout(LayoutKind.Explicit)]
public struct PassData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_passId;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasFoveatedRasterization;

	private static readonly System.IntPtr NativeFieldInfoPtr_tag;

	private static readonly System.IntPtr NativeFieldInfoPtr_mergeState;

	private static readonly System.IntPtr NativeFieldInfoPtr_nativePassIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_nativeSubPassIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_numInputs;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstOutput;

	private static readonly System.IntPtr NativeFieldInfoPtr_numOutputs;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstFragment;

	private static readonly System.IntPtr NativeFieldInfoPtr_numFragments;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstFragmentInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_numFragmentInputs;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstRandomAccessResource;

	private static readonly System.IntPtr NativeFieldInfoPtr_numRandomAccessResources;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstCreate;

	private static readonly System.IntPtr NativeFieldInfoPtr_numCreated;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstDestroy;

	private static readonly System.IntPtr NativeFieldInfoPtr_numDestroyed;

	private static readonly System.IntPtr NativeFieldInfoPtr_fragmentInfoWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_fragmentInfoHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_fragmentInfoVolumeDepth;

	private static readonly System.IntPtr NativeFieldInfoPtr_fragmentInfoSamples;

	private static readonly System.IntPtr NativeFieldInfoPtr_waitOnGraphicsFencePassId;

	private static readonly System.IntPtr NativeFieldInfoPtr_asyncCompute;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasSideEffects;

	private static readonly System.IntPtr NativeFieldInfoPtr_culled;

	private static readonly System.IntPtr NativeFieldInfoPtr_beginNativeSubpass;

	private static readonly System.IntPtr NativeFieldInfoPtr_fragmentInfoValid;

	private static readonly System.IntPtr NativeFieldInfoPtr_fragmentInfoHasDepth;

	private static readonly System.IntPtr NativeFieldInfoPtr_insertGraphicsFence;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Name_CompilerContextData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_RenderGraphPass_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetAndInitialize_Public_Void_byref_RenderGraphPass_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Outputs_Public_ReadOnlySpan_1_PassOutputData_CompilerContextData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Inputs_Public_ReadOnlySpan_1_PassInputData_CompilerContextData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Fragments_Public_ReadOnlySpan_1_PassFragmentData_CompilerContextData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FragmentInputs_Public_ReadOnlySpan_1_PassFragmentData_CompilerContextData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FirstUsedResources_Public_ReadOnlySpan_1_ResourceHandle_CompilerContextData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RandomWriteTextures_Public_ReadOnlySpan_1_PassRandomWriteData_CompilerContextData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LastUsedResources_Public_ReadOnlySpan_1_ResourceHandle_CompilerContextData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupAndValidateFragmentInfo_Private_Void_ResourceHandle_CompilerContextData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFragment_Internal_Void_ResourceHandle_CompilerContextData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFragmentInput_Internal_Void_ResourceHandle_CompilerContextData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddRandomAccessResource_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFirstUse_Internal_Void_ResourceHandle_CompilerContextData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddLastUse_Internal_Void_ResourceHandle_CompilerContextData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsUsedAsFragment_Internal_Boolean_ResourceHandle_CompilerContextData_0;

	[FieldOffset(0)]
	public int passId;

	[FieldOffset(4)]
	public RenderGraphPassType type;

	[FieldOffset(8)]
	[MarshalAs(UnmanagedType.U1)]
	public bool hasFoveatedRasterization;

	[FieldOffset(12)]
	public int tag;

	[FieldOffset(16)]
	public PassMergeState mergeState;

	[FieldOffset(20)]
	public int nativePassIndex;

	[FieldOffset(24)]
	public int nativeSubPassIndex;

	[FieldOffset(28)]
	public int firstInput;

	[FieldOffset(32)]
	public int numInputs;

	[FieldOffset(36)]
	public int firstOutput;

	[FieldOffset(40)]
	public int numOutputs;

	[FieldOffset(44)]
	public int firstFragment;

	[FieldOffset(48)]
	public int numFragments;

	[FieldOffset(52)]
	public int firstFragmentInput;

	[FieldOffset(56)]
	public int numFragmentInputs;

	[FieldOffset(60)]
	public int firstRandomAccessResource;

	[FieldOffset(64)]
	public int numRandomAccessResources;

	[FieldOffset(68)]
	public int firstCreate;

	[FieldOffset(72)]
	public int numCreated;

	[FieldOffset(76)]
	public int firstDestroy;

	[FieldOffset(80)]
	public int numDestroyed;

	[FieldOffset(84)]
	public int fragmentInfoWidth;

	[FieldOffset(88)]
	public int fragmentInfoHeight;

	[FieldOffset(92)]
	public int fragmentInfoVolumeDepth;

	[FieldOffset(96)]
	public int fragmentInfoSamples;

	[FieldOffset(100)]
	public int waitOnGraphicsFencePassId;

	[FieldOffset(104)]
	[MarshalAs(UnmanagedType.U1)]
	public bool asyncCompute;

	[FieldOffset(105)]
	[MarshalAs(UnmanagedType.U1)]
	public bool hasSideEffects;

	[FieldOffset(106)]
	[MarshalAs(UnmanagedType.U1)]
	public bool culled;

	[FieldOffset(107)]
	[MarshalAs(UnmanagedType.U1)]
	public bool beginNativeSubpass;

	[FieldOffset(108)]
	[MarshalAs(UnmanagedType.U1)]
	public bool fragmentInfoValid;

	[FieldOffset(109)]
	[MarshalAs(UnmanagedType.U1)]
	public bool fragmentInfoHasDepth;

	[FieldOffset(110)]
	[MarshalAs(UnmanagedType.U1)]
	public bool insertGraphicsFence;

	static PassData()
	{
		Il2CppClassPointerStore<PassData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler", "PassData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassData>.NativeClassPtr);
		NativeFieldInfoPtr_passId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "passId");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "type");
		NativeFieldInfoPtr_hasFoveatedRasterization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "hasFoveatedRasterization");
		NativeFieldInfoPtr_tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "tag");
		NativeFieldInfoPtr_mergeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "mergeState");
		NativeFieldInfoPtr_nativePassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "nativePassIndex");
		NativeFieldInfoPtr_nativeSubPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "nativeSubPassIndex");
		NativeFieldInfoPtr_firstInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "firstInput");
		NativeFieldInfoPtr_numInputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "numInputs");
		NativeFieldInfoPtr_firstOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "firstOutput");
		NativeFieldInfoPtr_numOutputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "numOutputs");
		NativeFieldInfoPtr_firstFragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "firstFragment");
		NativeFieldInfoPtr_numFragments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "numFragments");
		NativeFieldInfoPtr_firstFragmentInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "firstFragmentInput");
		NativeFieldInfoPtr_numFragmentInputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "numFragmentInputs");
		NativeFieldInfoPtr_firstRandomAccessResource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "firstRandomAccessResource");
		NativeFieldInfoPtr_numRandomAccessResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "numRandomAccessResources");
		NativeFieldInfoPtr_firstCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "firstCreate");
		NativeFieldInfoPtr_numCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "numCreated");
		NativeFieldInfoPtr_firstDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "firstDestroy");
		NativeFieldInfoPtr_numDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "numDestroyed");
		NativeFieldInfoPtr_fragmentInfoWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "fragmentInfoWidth");
		NativeFieldInfoPtr_fragmentInfoHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "fragmentInfoHeight");
		NativeFieldInfoPtr_fragmentInfoVolumeDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "fragmentInfoVolumeDepth");
		NativeFieldInfoPtr_fragmentInfoSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "fragmentInfoSamples");
		NativeFieldInfoPtr_waitOnGraphicsFencePassId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "waitOnGraphicsFencePassId");
		NativeFieldInfoPtr_asyncCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "asyncCompute");
		NativeFieldInfoPtr_hasSideEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "hasSideEffects");
		NativeFieldInfoPtr_culled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "culled");
		NativeFieldInfoPtr_beginNativeSubpass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "beginNativeSubpass");
		NativeFieldInfoPtr_fragmentInfoValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "fragmentInfoValid");
		NativeFieldInfoPtr_fragmentInfoHasDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "fragmentInfoHasDepth");
		NativeFieldInfoPtr_insertGraphicsFence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "insertGraphicsFence");
		NativeMethodInfoPtr_GetName_Public_Name_CompilerContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassData>.NativeClassPtr, 100667859);
		NativeMethodInfoPtr__ctor_Public_Void_byref_RenderGraphPass_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassData>.NativeClassPtr, 100667860);
		NativeMethodInfoPtr_ResetAndInitialize_Public_Void_byref_RenderGraphPass_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassData>.NativeClassPtr, 100667861);
		NativeMethodInfoPtr_Outputs_Public_ReadOnlySpan_1_PassOutputData_CompilerContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassData>.NativeClassPtr, 100667862);
		NativeMethodInfoPtr_Inputs_Public_ReadOnlySpan_1_PassInputData_CompilerContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassData>.NativeClassPtr, 100667863);
		NativeMethodInfoPtr_Fragments_Public_ReadOnlySpan_1_PassFragmentData_CompilerContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassData>.NativeClassPtr, 100667864);
		NativeMethodInfoPtr_FragmentInputs_Public_ReadOnlySpan_1_PassFragmentData_CompilerContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassData>.NativeClassPtr, 100667865);
		NativeMethodInfoPtr_FirstUsedResources_Public_ReadOnlySpan_1_ResourceHandle_CompilerContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassData>.NativeClassPtr, 100667866);
		NativeMethodInfoPtr_RandomWriteTextures_Public_ReadOnlySpan_1_PassRandomWriteData_CompilerContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassData>.NativeClassPtr, 100667867);
		NativeMethodInfoPtr_LastUsedResources_Public_ReadOnlySpan_1_ResourceHandle_CompilerContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassData>.NativeClassPtr, 100667868);
		NativeMethodInfoPtr_SetupAndValidateFragmentInfo_Private_Void_ResourceHandle_CompilerContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassData>.NativeClassPtr, 100667869);
		NativeMethodInfoPtr_AddFragment_Internal_Void_ResourceHandle_CompilerContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassData>.NativeClassPtr, 100667870);
		NativeMethodInfoPtr_AddFragmentInput_Internal_Void_ResourceHandle_CompilerContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassData>.NativeClassPtr, 100667871);
		NativeMethodInfoPtr_AddRandomAccessResource_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassData>.NativeClassPtr, 100667872);
		NativeMethodInfoPtr_AddFirstUse_Internal_Void_ResourceHandle_CompilerContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassData>.NativeClassPtr, 100667873);
		NativeMethodInfoPtr_AddLastUse_Internal_Void_ResourceHandle_CompilerContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassData>.NativeClassPtr, 100667874);
		NativeMethodInfoPtr_IsUsedAsFragment_Internal_Boolean_ResourceHandle_CompilerContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassData>.NativeClassPtr, 100667875);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063365, XrefRangeEnd = 1063368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Name GetName(CompilerContextData ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetName_Public_Name_CompilerContextData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Name(pointer);
	}

	[CallerCount(0)]
	public unsafe PassData([In] ref RenderGraphPass pass, int passIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pass);
		*ptr = (nint)(&intPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &passIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_byref_RenderGraphPass_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		pass = ((intPtr4 == (System.IntPtr)0) ? null : new RenderGraphPass(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1063368, RefRangeEnd = 1063369, XrefRangeStart = 1063368, XrefRangeEnd = 1063368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetAndInitialize([In] ref RenderGraphPass pass, int passIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pass);
		*ptr = (nint)(&intPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &passIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetAndInitialize_Public_Void_byref_RenderGraphPass_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		pass = ((intPtr4 == (System.IntPtr)0) ? null : new RenderGraphPass(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063369, XrefRangeEnd = 1063374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ReadOnlySpan<PassOutputData> Outputs(CompilerContextData ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Outputs_Public_ReadOnlySpan_1_PassOutputData_CompilerContextData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ReadOnlySpan<PassOutputData>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063374, XrefRangeEnd = 1063379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ReadOnlySpan<PassInputData> Inputs(CompilerContextData ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Inputs_Public_ReadOnlySpan_1_PassInputData_CompilerContextData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ReadOnlySpan<PassInputData>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063379, XrefRangeEnd = 1063384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ReadOnlySpan<PassFragmentData> Fragments(CompilerContextData ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Fragments_Public_ReadOnlySpan_1_PassFragmentData_CompilerContextData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ReadOnlySpan<PassFragmentData>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063384, XrefRangeEnd = 1063389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ReadOnlySpan<PassFragmentData> FragmentInputs(CompilerContextData ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FragmentInputs_Public_ReadOnlySpan_1_PassFragmentData_CompilerContextData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ReadOnlySpan<PassFragmentData>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063389, XrefRangeEnd = 1063394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ReadOnlySpan<ResourceHandle> FirstUsedResources(CompilerContextData ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FirstUsedResources_Public_ReadOnlySpan_1_ResourceHandle_CompilerContextData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ReadOnlySpan<ResourceHandle>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1063399, RefRangeEnd = 1063400, XrefRangeStart = 1063394, XrefRangeEnd = 1063399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ReadOnlySpan<PassRandomWriteData> RandomWriteTextures(CompilerContextData ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RandomWriteTextures_Public_ReadOnlySpan_1_PassRandomWriteData_CompilerContextData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ReadOnlySpan<PassRandomWriteData>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063400, XrefRangeEnd = 1063405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ReadOnlySpan<ResourceHandle> LastUsedResources(CompilerContextData ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LastUsedResources_Public_ReadOnlySpan_1_ResourceHandle_CompilerContextData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ReadOnlySpan<ResourceHandle>(pointer);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1063414, RefRangeEnd = 1063419, XrefRangeStart = 1063405, XrefRangeEnd = 1063414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupAndValidateFragmentInfo(ResourceHandle h, CompilerContextData ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&h);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupAndValidateFragmentInfo_Private_Void_ResourceHandle_CompilerContextData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063419, XrefRangeEnd = 1063420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddFragment(ResourceHandle h, CompilerContextData ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&h);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFragment_Internal_Void_ResourceHandle_CompilerContextData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063420, XrefRangeEnd = 1063421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddFragmentInput(ResourceHandle h, CompilerContextData ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&h);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFragmentInput_Internal_Void_ResourceHandle_CompilerContextData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 876601, RefRangeEnd = 876602, XrefRangeStart = 876601, XrefRangeEnd = 876602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddRandomAccessResource()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddRandomAccessResource_Internal_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063421, XrefRangeEnd = 1063439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddFirstUse(ResourceHandle h, CompilerContextData ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&h);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFirstUse_Internal_Void_ResourceHandle_CompilerContextData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063439, XrefRangeEnd = 1063457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddLastUse(ResourceHandle h, CompilerContextData ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&h);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddLastUse_Internal_Void_ResourceHandle_CompilerContextData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063457, XrefRangeEnd = 1063475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsUsedAsFragment(ResourceHandle h, CompilerContextData ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&h);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUsedAsFragment_Internal_Boolean_ResourceHandle_CompilerContextData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PassData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
