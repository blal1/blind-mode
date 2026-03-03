using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering;

public sealed class ShaderDebugPrintManager : Il2CppSystem.Object
{
	public static class Profiling : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_BufferReadComplete;

		public unsafe static ProfilingSampler BufferReadComplete
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BufferReadComplete, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BufferReadComplete, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static Profiling()
		{
			Il2CppClassPointerStore<Profiling>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "Profiling");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Profiling>.NativeClassPtr);
			NativeFieldInfoPtr_BufferReadComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "BufferReadComplete");
		}

		public Profiling(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[OriginalName("Unity.RenderPipelines.Core.Runtime.dll", "", "DebugValueType")]
	public enum DebugValueType
	{
		TypeUint = 1,
		TypeInt,
		TypeFloat,
		TypeUint2,
		TypeInt2,
		TypeFloat2,
		TypeUint3,
		TypeInt3,
		TypeFloat3,
		TypeUint4,
		TypeInt4,
		TypeFloat4,
		TypeBool
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_FramesInFlight;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MaxBufferElements;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OutputBuffers;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ReadbackRequests;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BufferReadCompleteAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FrameCounter;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FrameCleared;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OutputLine;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OutputAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShaderPropertyIDInputMouse;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShaderPropertyIDInputFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_shaderDebugOutputData;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_TypeHasTag;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugValueTypeToElemSize_Private_Int32_DebugValueType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_ShaderDebugPrintManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetShaderDebugPrintInputConstants_Public_Void_CommandBuffer_ShaderDebugPrintInput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetShaderDebugPrintBindings_Public_Void_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearShaderDebugPrintBuffer_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BufferReadComplete_Private_Void_AsyncGPUReadbackRequest_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndFrame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrintImmediate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_outputLine_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_outputAction_Public_set_Void_Action_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DefaultOutput_Public_Void_String_0;

	public unsafe static ShaderDebugPrintManager s_Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShaderDebugPrintManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int k_FramesInFlight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_FramesInFlight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_FramesInFlight, (void*)(&value));
		}
	}

	public unsafe static int k_MaxBufferElements
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MaxBufferElements, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MaxBufferElements, (void*)(&value));
		}
	}

	public unsafe List<GraphicsBuffer> m_OutputBuffers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OutputBuffers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GraphicsBuffer>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OutputBuffers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<AsyncGPUReadbackRequest> m_ReadbackRequests
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReadbackRequests);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AsyncGPUReadbackRequest>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReadbackRequests)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Action<AsyncGPUReadbackRequest> m_BufferReadCompleteAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BufferReadCompleteAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<AsyncGPUReadbackRequest>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BufferReadCompleteAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_FrameCounter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FrameCounter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FrameCounter)) = value;
		}
	}

	public unsafe bool m_FrameCleared
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FrameCleared);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FrameCleared)) = value;
		}
	}

	public unsafe string m_OutputLine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OutputLine);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OutputLine)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Il2CppSystem.Action<string> m_OutputAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OutputAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OutputAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int m_ShaderPropertyIDInputMouse
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_ShaderPropertyIDInputMouse, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_ShaderPropertyIDInputMouse, (void*)(&value));
		}
	}

	public unsafe static int m_ShaderPropertyIDInputFrame
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_ShaderPropertyIDInputFrame, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_ShaderPropertyIDInputFrame, (void*)(&value));
		}
	}

	public unsafe static int m_shaderDebugOutputData
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_shaderDebugOutputData, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_shaderDebugOutputData, (void*)(&value));
		}
	}

	public unsafe static uint k_TypeHasTag
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_TypeHasTag, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_TypeHasTag, (void*)(&value));
		}
	}

	public unsafe static ShaderDebugPrintManager instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035898, XrefRangeEnd = 1035902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instance_Public_Static_get_ShaderDebugPrintManager_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShaderDebugPrintManager>(intPtr2) : null;
		}
	}

	public unsafe string outputLine
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50643, RefRangeEnd = 50644, XrefRangeStart = 50643, XrefRangeEnd = 50644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_outputLine_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe Il2CppSystem.Action<string> outputAction
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84623, RefRangeEnd = 84624, XrefRangeStart = 84623, XrefRangeEnd = 84624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_outputAction_Public_set_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static ShaderDebugPrintManager()
	{
		Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ShaderDebugPrintManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr);
		NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "s_Instance");
		NativeFieldInfoPtr_k_FramesInFlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "k_FramesInFlight");
		NativeFieldInfoPtr_k_MaxBufferElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "k_MaxBufferElements");
		NativeFieldInfoPtr_m_OutputBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "m_OutputBuffers");
		NativeFieldInfoPtr_m_ReadbackRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "m_ReadbackRequests");
		NativeFieldInfoPtr_m_BufferReadCompleteAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "m_BufferReadCompleteAction");
		NativeFieldInfoPtr_m_FrameCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "m_FrameCounter");
		NativeFieldInfoPtr_m_FrameCleared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "m_FrameCleared");
		NativeFieldInfoPtr_m_OutputLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "m_OutputLine");
		NativeFieldInfoPtr_m_OutputAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "m_OutputAction");
		NativeFieldInfoPtr_m_ShaderPropertyIDInputMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "m_ShaderPropertyIDInputMouse");
		NativeFieldInfoPtr_m_ShaderPropertyIDInputFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "m_ShaderPropertyIDInputFrame");
		NativeFieldInfoPtr_m_shaderDebugOutputData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "m_shaderDebugOutputData");
		NativeFieldInfoPtr_k_TypeHasTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "k_TypeHasTag");
		NativeMethodInfoPtr_DebugValueTypeToElemSize_Private_Int32_DebugValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, 100665117);
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, 100665118);
		NativeMethodInfoPtr_get_instance_Public_Static_get_ShaderDebugPrintManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, 100665119);
		NativeMethodInfoPtr_SetShaderDebugPrintInputConstants_Public_Void_CommandBuffer_ShaderDebugPrintInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, 100665120);
		NativeMethodInfoPtr_SetShaderDebugPrintBindings_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, 100665121);
		NativeMethodInfoPtr_ClearShaderDebugPrintBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, 100665122);
		NativeMethodInfoPtr_BufferReadComplete_Private_Void_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, 100665123);
		NativeMethodInfoPtr_EndFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, 100665124);
		NativeMethodInfoPtr_PrintImmediate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, 100665125);
		NativeMethodInfoPtr_get_outputLine_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, 100665126);
		NativeMethodInfoPtr_set_outputAction_Public_set_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, 100665127);
		NativeMethodInfoPtr_DefaultOutput_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, 100665128);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1035848, RefRangeEnd = 1035849, XrefRangeStart = 1035848, XrefRangeEnd = 1035848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int DebugValueTypeToElemSize(DebugValueType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugValueTypeToElemSize_Private_Int32_DebugValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1035897, RefRangeEnd = 1035898, XrefRangeStart = 1035849, XrefRangeEnd = 1035897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShaderDebugPrintManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035902, XrefRangeEnd = 1035929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetShaderDebugPrintInputConstants(CommandBuffer cmd, ShaderDebugPrintInput input)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(ShaderDebugPrintInput**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &input;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetShaderDebugPrintInputConstants_Public_Void_CommandBuffer_ShaderDebugPrintInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035929, XrefRangeEnd = 1035953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetShaderDebugPrintBindings(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetShaderDebugPrintBindings_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035953, XrefRangeEnd = 1035962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearShaderDebugPrintBuffer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearShaderDebugPrintBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035962, XrefRangeEnd = 1036146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BufferReadComplete(AsyncGPUReadbackRequest request)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&request);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BufferReadComplete_Private_Void_AsyncGPUReadbackRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036146, XrefRangeEnd = 1036153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036153, XrefRangeEnd = 1036158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrintImmediate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrintImmediate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036158, XrefRangeEnd = 1036162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DefaultOutput(string line)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(line);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DefaultOutput_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ShaderDebugPrintManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
