using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering;

public sealed class GPUPrefixSum : Il2CppSystem.ValueType
{
	public static class ShaderDefs : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_GroupSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_ArgsBufferStride;

		private static readonly System.IntPtr NativeFieldInfoPtr_ArgsBufferUpper;

		private static readonly System.IntPtr NativeFieldInfoPtr_ArgsBufferLower;

		private static readonly System.IntPtr NativeMethodInfoPtr_DivUpGroup_Public_Static_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AlignUpGroup_Public_Static_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CalculateTotalBufferSize_Public_Static_Void_Int32_byref_Int32_byref_Int32_0;

		public unsafe static int GroupSize
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GroupSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GroupSize, (void*)(&value));
			}
		}

		public unsafe static int ArgsBufferStride
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ArgsBufferStride, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ArgsBufferStride, (void*)(&value));
			}
		}

		public unsafe static int ArgsBufferUpper
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ArgsBufferUpper, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ArgsBufferUpper, (void*)(&value));
			}
		}

		public unsafe static int ArgsBufferLower
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ArgsBufferLower, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ArgsBufferLower, (void*)(&value));
			}
		}

		static ShaderDefs()
		{
			Il2CppClassPointerStore<ShaderDefs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUPrefixSum>.NativeClassPtr, "ShaderDefs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderDefs>.NativeClassPtr);
			NativeFieldInfoPtr_GroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDefs>.NativeClassPtr, "GroupSize");
			NativeFieldInfoPtr_ArgsBufferStride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDefs>.NativeClassPtr, "ArgsBufferStride");
			NativeFieldInfoPtr_ArgsBufferUpper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDefs>.NativeClassPtr, "ArgsBufferUpper");
			NativeFieldInfoPtr_ArgsBufferLower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDefs>.NativeClassPtr, "ArgsBufferLower");
			NativeMethodInfoPtr_DivUpGroup_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDefs>.NativeClassPtr, 100666689);
			NativeMethodInfoPtr_AlignUpGroup_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDefs>.NativeClassPtr, 100666690);
			NativeMethodInfoPtr_CalculateTotalBufferSize_Public_Static_Void_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDefs>.NativeClassPtr, 100666691);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1038048, RefRangeEnd = 1038050, XrefRangeStart = 1038048, XrefRangeEnd = 1038050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DivUpGroup(int value)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DivUpGroup_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe static int AlignUpGroup(int value)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AlignUpGroup_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe static void CalculateTotalBufferSize(int maxElementCount, out int totalSize, out int levelCounts)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&maxElementCount);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref totalSize);
			*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref levelCounts);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateTotalBufferSize_Public_Static_Void_Int32_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ShaderDefs(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct LevelOffsets
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_count;

		private static readonly System.IntPtr NativeFieldInfoPtr_offset;

		private static readonly System.IntPtr NativeFieldInfoPtr_parentOffset;

		[FieldOffset(0)]
		public uint count;

		[FieldOffset(4)]
		public uint offset;

		[FieldOffset(8)]
		public uint parentOffset;

		static LevelOffsets()
		{
			Il2CppClassPointerStore<LevelOffsets>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUPrefixSum>.NativeClassPtr, "LevelOffsets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LevelOffsets>.NativeClassPtr);
			NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelOffsets>.NativeClassPtr, "count");
			NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelOffsets>.NativeClassPtr, "offset");
			NativeFieldInfoPtr_parentOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelOffsets>.NativeClassPtr, "parentOffset");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LevelOffsets>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct RenderGraphResources
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_alignedElementCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxBufferCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxLevelCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_prefixBuffer0;

		private static readonly System.IntPtr NativeFieldInfoPtr_prefixBuffer1;

		private static readonly System.IntPtr NativeFieldInfoPtr_totalLevelCountBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_levelOffsetBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_indirectDispatchArgsBuffer;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_output_Public_get_BufferHandle_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_RenderGraphResources_Int32_RenderGraph_RenderGraphBuilder_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_Void_Int32_RenderGraph_RenderGraphBuilder_Boolean_0;

		[FieldOffset(0)]
		public int alignedElementCount;

		[FieldOffset(4)]
		public int maxBufferCount;

		[FieldOffset(8)]
		public int maxLevelCount;

		[FieldOffset(12)]
		public BufferHandle prefixBuffer0;

		[FieldOffset(24)]
		public BufferHandle prefixBuffer1;

		[FieldOffset(36)]
		public BufferHandle totalLevelCountBuffer;

		[FieldOffset(48)]
		public BufferHandle levelOffsetBuffer;

		[FieldOffset(60)]
		public BufferHandle indirectDispatchArgsBuffer;

		public unsafe BufferHandle output
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_output_Public_get_BufferHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(BufferHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static RenderGraphResources()
		{
			Il2CppClassPointerStore<RenderGraphResources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUPrefixSum>.NativeClassPtr, "RenderGraphResources");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphResources>.NativeClassPtr);
			NativeFieldInfoPtr_alignedElementCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResources>.NativeClassPtr, "alignedElementCount");
			NativeFieldInfoPtr_maxBufferCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResources>.NativeClassPtr, "maxBufferCount");
			NativeFieldInfoPtr_maxLevelCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResources>.NativeClassPtr, "maxLevelCount");
			NativeFieldInfoPtr_prefixBuffer0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResources>.NativeClassPtr, "prefixBuffer0");
			NativeFieldInfoPtr_prefixBuffer1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResources>.NativeClassPtr, "prefixBuffer1");
			NativeFieldInfoPtr_totalLevelCountBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResources>.NativeClassPtr, "totalLevelCountBuffer");
			NativeFieldInfoPtr_levelOffsetBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResources>.NativeClassPtr, "levelOffsetBuffer");
			NativeFieldInfoPtr_indirectDispatchArgsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResources>.NativeClassPtr, "indirectDispatchArgsBuffer");
			NativeMethodInfoPtr_get_output_Public_get_BufferHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResources>.NativeClassPtr, 100666692);
			NativeMethodInfoPtr_Create_Public_Static_RenderGraphResources_Int32_RenderGraph_RenderGraphBuilder_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResources>.NativeClassPtr, 100666693);
			NativeMethodInfoPtr_Initialize_Private_Void_Int32_RenderGraph_RenderGraphBuilder_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResources>.NativeClassPtr, 100666694);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052763, XrefRangeEnd = 1052764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderGraphResources Create(int newMaxElementCount, RenderGraph renderGraph, RenderGraphBuilder builder, bool outputIsTemp = false)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&newMaxElementCount);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)builder));
			*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputIsTemp;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_RenderGraphResources_Int32_RenderGraph_RenderGraphBuilder_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderGraphResources*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1052802, RefRangeEnd = 1052803, XrefRangeStart = 1052764, XrefRangeEnd = 1052802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(int newMaxElementCount, RenderGraph renderGraph, RenderGraphBuilder builder, bool outputIsTemp = false)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&newMaxElementCount);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)builder));
			*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputIsTemp;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Private_Void_Int32_RenderGraph_RenderGraphBuilder_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderGraphResources>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class SupportResources : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ownsResources;

		private static readonly System.IntPtr NativeFieldInfoPtr_alignedElementCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxBufferCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxLevelCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_prefixBuffer0;

		private static readonly System.IntPtr NativeFieldInfoPtr_prefixBuffer1;

		private static readonly System.IntPtr NativeFieldInfoPtr_totalLevelCountBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_levelOffsetBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_indirectDispatchArgsBuffer;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_output_Public_get_GraphicsBuffer_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_SupportResources_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_SupportResources_RenderGraphResources_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Resize_Internal_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_LoadFromShaderGraph_Private_Void_RenderGraphResources_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_GraphicsBuffer_0;

		public unsafe bool ownsResources
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownsResources);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownsResources)) = value;
			}
		}

		public unsafe int alignedElementCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alignedElementCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alignedElementCount)) = value;
			}
		}

		public unsafe int maxBufferCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxBufferCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxBufferCount)) = value;
			}
		}

		public unsafe int maxLevelCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLevelCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLevelCount)) = value;
			}
		}

		public unsafe GraphicsBuffer prefixBuffer0
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefixBuffer0);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefixBuffer0)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe GraphicsBuffer prefixBuffer1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefixBuffer1);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefixBuffer1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe GraphicsBuffer totalLevelCountBuffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalLevelCountBuffer);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalLevelCountBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe GraphicsBuffer levelOffsetBuffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_levelOffsetBuffer);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_levelOffsetBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe GraphicsBuffer indirectDispatchArgsBuffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indirectDispatchArgsBuffer);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indirectDispatchArgsBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe GraphicsBuffer output
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_output_Public_get_GraphicsBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr2) : null;
			}
		}

		static SupportResources()
		{
			Il2CppClassPointerStore<SupportResources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUPrefixSum>.NativeClassPtr, "SupportResources");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupportResources>.NativeClassPtr);
			NativeFieldInfoPtr_ownsResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, "ownsResources");
			NativeFieldInfoPtr_alignedElementCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, "alignedElementCount");
			NativeFieldInfoPtr_maxBufferCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, "maxBufferCount");
			NativeFieldInfoPtr_maxLevelCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, "maxLevelCount");
			NativeFieldInfoPtr_prefixBuffer0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, "prefixBuffer0");
			NativeFieldInfoPtr_prefixBuffer1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, "prefixBuffer1");
			NativeFieldInfoPtr_totalLevelCountBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, "totalLevelCountBuffer");
			NativeFieldInfoPtr_levelOffsetBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, "levelOffsetBuffer");
			NativeFieldInfoPtr_indirectDispatchArgsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, "indirectDispatchArgsBuffer");
			NativeMethodInfoPtr_get_output_Public_get_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, 100666695);
			NativeMethodInfoPtr_Create_Public_Static_SupportResources_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, 100666696);
			NativeMethodInfoPtr_Load_Public_Static_SupportResources_RenderGraphResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, 100666697);
			NativeMethodInfoPtr_Resize_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, 100666698);
			NativeMethodInfoPtr_LoadFromShaderGraph_Private_Void_RenderGraphResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, 100666699);
			NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, 100666700);
			NativeMethodInfoPtr_Method_Internal_Static_Void_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, 100666701);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052803, XrefRangeEnd = 1052804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SupportResources Create(int maxElementCount)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&maxElementCount);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_SupportResources_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new SupportResources(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052804, XrefRangeEnd = 1052805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SupportResources Load(RenderGraphResources shaderGraphResources)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&shaderGraphResources);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_SupportResources_RenderGraphResources_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new SupportResources(pointer);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1052837, RefRangeEnd = 1052838, XrefRangeStart = 1052805, XrefRangeEnd = 1052837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resize(int newMaxElementCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&newMaxElementCount);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Resize_Internal_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1052851, RefRangeEnd = 1052852, XrefRangeStart = 1052838, XrefRangeEnd = 1052851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadFromShaderGraph(RenderGraphResources shaderGraphResources)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&shaderGraphResources);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFromShaderGraph_Private_Void_RenderGraphResources_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1052857, RefRangeEnd = 1052858, XrefRangeStart = 1052852, XrefRangeEnd = 1052857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1052619, RefRangeEnd = 1052621, XrefRangeStart = 1052619, XrefRangeEnd = 1052621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_GraphicsBuffer_0(GraphicsBuffer resource)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resource);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Void_GraphicsBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public SupportResources(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public SupportResources()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupportResources>.NativeClassPtr))
		{
		}
	}

	public sealed class DirectArgs : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_exclusive;

		private static readonly System.IntPtr NativeFieldInfoPtr_inputCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_input;

		private static readonly System.IntPtr NativeFieldInfoPtr_supportResources;

		public unsafe bool exclusive
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exclusive);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exclusive)) = value;
			}
		}

		public unsafe int inputCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputCount)) = value;
			}
		}

		public unsafe GraphicsBuffer input
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_input);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_input)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe SupportResources supportResources
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportResources);
				return new SupportResources(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportResources), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static DirectArgs()
		{
			Il2CppClassPointerStore<DirectArgs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUPrefixSum>.NativeClassPtr, "DirectArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectArgs>.NativeClassPtr);
			NativeFieldInfoPtr_exclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectArgs>.NativeClassPtr, "exclusive");
			NativeFieldInfoPtr_inputCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectArgs>.NativeClassPtr, "inputCount");
			NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectArgs>.NativeClassPtr, "input");
			NativeFieldInfoPtr_supportResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectArgs>.NativeClassPtr, "supportResources");
		}

		public DirectArgs(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public DirectArgs()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirectArgs>.NativeClassPtr))
		{
		}
	}

	public sealed class IndirectDirectArgs : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_exclusive;

		private static readonly System.IntPtr NativeFieldInfoPtr_inputCountBufferByteOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_inputCountBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_input;

		private static readonly System.IntPtr NativeFieldInfoPtr_supportResources;

		public unsafe bool exclusive
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exclusive);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exclusive)) = value;
			}
		}

		public unsafe int inputCountBufferByteOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputCountBufferByteOffset);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputCountBufferByteOffset)) = value;
			}
		}

		public unsafe ComputeBuffer inputCountBuffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputCountBuffer);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputCountBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe GraphicsBuffer input
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_input);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_input)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe SupportResources supportResources
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportResources);
				return new SupportResources(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportResources), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static IndirectDirectArgs()
		{
			Il2CppClassPointerStore<IndirectDirectArgs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUPrefixSum>.NativeClassPtr, "IndirectDirectArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndirectDirectArgs>.NativeClassPtr);
			NativeFieldInfoPtr_exclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectDirectArgs>.NativeClassPtr, "exclusive");
			NativeFieldInfoPtr_inputCountBufferByteOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectDirectArgs>.NativeClassPtr, "inputCountBufferByteOffset");
			NativeFieldInfoPtr_inputCountBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectDirectArgs>.NativeClassPtr, "inputCountBuffer");
			NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectDirectArgs>.NativeClassPtr, "input");
			NativeFieldInfoPtr_supportResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectDirectArgs>.NativeClassPtr, "supportResources");
		}

		public IndirectDirectArgs(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public IndirectDirectArgs()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndirectDirectArgs>.NativeClassPtr))
		{
		}
	}

	public sealed class SystemResources : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_computeAsset;

		private static readonly System.IntPtr NativeFieldInfoPtr_kernelCalculateLevelDispatchArgsFromConst;

		private static readonly System.IntPtr NativeFieldInfoPtr_kernelCalculateLevelDispatchArgsFromBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_kernelPrefixSumOnGroup;

		private static readonly System.IntPtr NativeFieldInfoPtr_kernelPrefixSumOnGroupExclusive;

		private static readonly System.IntPtr NativeFieldInfoPtr_kernelPrefixSumNextInput;

		private static readonly System.IntPtr NativeFieldInfoPtr_kernelPrefixSumResolveParent;

		private static readonly System.IntPtr NativeFieldInfoPtr_kernelPrefixSumResolveParentExclusive;

		private static readonly System.IntPtr NativeMethodInfoPtr_LoadKernels_Internal_Void_0;

		public unsafe ComputeShader computeAsset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_computeAsset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_computeAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int kernelCalculateLevelDispatchArgsFromConst
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kernelCalculateLevelDispatchArgsFromConst);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kernelCalculateLevelDispatchArgsFromConst)) = value;
			}
		}

		public unsafe int kernelCalculateLevelDispatchArgsFromBuffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kernelCalculateLevelDispatchArgsFromBuffer);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kernelCalculateLevelDispatchArgsFromBuffer)) = value;
			}
		}

		public unsafe int kernelPrefixSumOnGroup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kernelPrefixSumOnGroup);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kernelPrefixSumOnGroup)) = value;
			}
		}

		public unsafe int kernelPrefixSumOnGroupExclusive
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kernelPrefixSumOnGroupExclusive);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kernelPrefixSumOnGroupExclusive)) = value;
			}
		}

		public unsafe int kernelPrefixSumNextInput
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kernelPrefixSumNextInput);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kernelPrefixSumNextInput)) = value;
			}
		}

		public unsafe int kernelPrefixSumResolveParent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kernelPrefixSumResolveParent);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kernelPrefixSumResolveParent)) = value;
			}
		}

		public unsafe int kernelPrefixSumResolveParentExclusive
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kernelPrefixSumResolveParentExclusive);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kernelPrefixSumResolveParentExclusive)) = value;
			}
		}

		static SystemResources()
		{
			Il2CppClassPointerStore<SystemResources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUPrefixSum>.NativeClassPtr, "SystemResources");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemResources>.NativeClassPtr);
			NativeFieldInfoPtr_computeAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemResources>.NativeClassPtr, "computeAsset");
			NativeFieldInfoPtr_kernelCalculateLevelDispatchArgsFromConst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemResources>.NativeClassPtr, "kernelCalculateLevelDispatchArgsFromConst");
			NativeFieldInfoPtr_kernelCalculateLevelDispatchArgsFromBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemResources>.NativeClassPtr, "kernelCalculateLevelDispatchArgsFromBuffer");
			NativeFieldInfoPtr_kernelPrefixSumOnGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemResources>.NativeClassPtr, "kernelPrefixSumOnGroup");
			NativeFieldInfoPtr_kernelPrefixSumOnGroupExclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemResources>.NativeClassPtr, "kernelPrefixSumOnGroupExclusive");
			NativeFieldInfoPtr_kernelPrefixSumNextInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemResources>.NativeClassPtr, "kernelPrefixSumNextInput");
			NativeFieldInfoPtr_kernelPrefixSumResolveParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemResources>.NativeClassPtr, "kernelPrefixSumResolveParent");
			NativeFieldInfoPtr_kernelPrefixSumResolveParentExclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemResources>.NativeClassPtr, "kernelPrefixSumResolveParentExclusive");
			NativeMethodInfoPtr_LoadKernels_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemResources>.NativeClassPtr, 100666702);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1052883, RefRangeEnd = 1052884, XrefRangeStart = 1052858, XrefRangeEnd = 1052883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadKernels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadKernels_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public SystemResources(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public SystemResources()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemResources>.NativeClassPtr))
		{
		}
	}

	public static class ShaderIDs : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__InputBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr__OutputBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr__InputCountBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr__TotalLevelsBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr__OutputTotalLevelsBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr__OutputDispatchLevelArgsBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr__LevelsOffsetsBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr__OutputLevelsOffsetsBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr__PrefixSumIntArgs;

		public unsafe static int _InputBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__InputBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__InputBuffer, (void*)(&value));
			}
		}

		public unsafe static int _OutputBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__OutputBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__OutputBuffer, (void*)(&value));
			}
		}

		public unsafe static int _InputCountBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__InputCountBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__InputCountBuffer, (void*)(&value));
			}
		}

		public unsafe static int _TotalLevelsBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__TotalLevelsBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__TotalLevelsBuffer, (void*)(&value));
			}
		}

		public unsafe static int _OutputTotalLevelsBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__OutputTotalLevelsBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__OutputTotalLevelsBuffer, (void*)(&value));
			}
		}

		public unsafe static int _OutputDispatchLevelArgsBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__OutputDispatchLevelArgsBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__OutputDispatchLevelArgsBuffer, (void*)(&value));
			}
		}

		public unsafe static int _LevelsOffsetsBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__LevelsOffsetsBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__LevelsOffsetsBuffer, (void*)(&value));
			}
		}

		public unsafe static int _OutputLevelsOffsetsBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__OutputLevelsOffsetsBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__OutputLevelsOffsetsBuffer, (void*)(&value));
			}
		}

		public unsafe static int _PrefixSumIntArgs
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__PrefixSumIntArgs, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__PrefixSumIntArgs, (void*)(&value));
			}
		}

		static ShaderIDs()
		{
			Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUPrefixSum>.NativeClassPtr, "ShaderIDs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr);
			NativeFieldInfoPtr__InputBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_InputBuffer");
			NativeFieldInfoPtr__OutputBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_OutputBuffer");
			NativeFieldInfoPtr__InputCountBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_InputCountBuffer");
			NativeFieldInfoPtr__TotalLevelsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_TotalLevelsBuffer");
			NativeFieldInfoPtr__OutputTotalLevelsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_OutputTotalLevelsBuffer");
			NativeFieldInfoPtr__OutputDispatchLevelArgsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_OutputDispatchLevelArgsBuffer");
			NativeFieldInfoPtr__LevelsOffsetsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_LevelsOffsetsBuffer");
			NativeFieldInfoPtr__OutputLevelsOffsetsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_OutputLevelsOffsetsBuffer");
			NativeFieldInfoPtr__PrefixSumIntArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_PrefixSumIntArgs");
		}

		public ShaderIDs(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_resources;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_SystemResources_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PackPrefixSumArgs_Private_Vector4_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCommonIndirect_Internal_Void_CommandBuffer_GraphicsBuffer_byref_SupportResources_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DispatchDirect_Public_Void_CommandBuffer_byref_DirectArgs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DispatchIndirect_Public_Void_CommandBuffer_byref_IndirectDirectArgs_0;

	public unsafe SystemResources resources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resources);
			return new SystemResources(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SystemResources>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resources), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SystemResources>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static GPUPrefixSum()
	{
		Il2CppClassPointerStore<GPUPrefixSum>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "GPUPrefixSum");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUPrefixSum>.NativeClassPtr);
		NativeFieldInfoPtr_resources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUPrefixSum>.NativeClassPtr, "resources");
		NativeMethodInfoPtr__ctor_Public_Void_SystemResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUPrefixSum>.NativeClassPtr, 100666684);
		NativeMethodInfoPtr_PackPrefixSumArgs_Private_Vector4_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUPrefixSum>.NativeClassPtr, 100666685);
		NativeMethodInfoPtr_ExecuteCommonIndirect_Internal_Void_CommandBuffer_GraphicsBuffer_byref_SupportResources_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUPrefixSum>.NativeClassPtr, 100666686);
		NativeMethodInfoPtr_DispatchDirect_Public_Void_CommandBuffer_byref_DirectArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUPrefixSum>.NativeClassPtr, 100666687);
		NativeMethodInfoPtr_DispatchIndirect_Public_Void_CommandBuffer_byref_IndirectDirectArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUPrefixSum>.NativeClassPtr, 100666688);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052884, XrefRangeEnd = 1052886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPUPrefixSum(SystemResources resources)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUPrefixSum>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)resources));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_SystemResources_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe Vector4 PackPrefixSumArgs(int a, int b, int c, int d)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &d;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PackPrefixSumArgs_Private_Vector4_Int32_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1052927, RefRangeEnd = 1052929, XrefRangeStart = 1052886, XrefRangeEnd = 1052927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteCommonIndirect(CommandBuffer cmdBuffer, GraphicsBuffer inputBuffer, [In] ref SupportResources supportResources, bool isExclusive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmdBuffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputBuffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)supportResources);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isExclusive;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteCommonIndirect_Internal_Void_CommandBuffer_GraphicsBuffer_byref_SupportResources_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052929, XrefRangeEnd = 1052942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DispatchDirect(CommandBuffer cmdBuffer, [In] ref DirectArgs arguments)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmdBuffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)arguments);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DispatchDirect_Public_Void_CommandBuffer_byref_DirectArgs_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052942, XrefRangeEnd = 1052957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DispatchIndirect(CommandBuffer cmdBuffer, [In] ref IndirectDirectArgs arguments)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmdBuffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)arguments);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DispatchIndirect_Public_Void_CommandBuffer_byref_IndirectDirectArgs_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GPUPrefixSum(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public GPUPrefixSum()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUPrefixSum>.NativeClassPtr))
	{
	}
}
