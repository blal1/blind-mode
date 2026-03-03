using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.RenderGraphModule.Util;

public static class RenderGraphUtils : Il2CppSystem.Object
{
	public class CopyPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_isMSAA;

		private static readonly System.IntPtr NativeFieldInfoPtr_force2DForXR;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe bool isMSAA
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMSAA);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMSAA)) = value;
			}
		}

		public unsafe bool force2DForXR
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_force2DForXR);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_force2DForXR)) = value;
			}
		}

		static CopyPassData()
		{
			Il2CppClassPointerStore<CopyPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraphUtils>.NativeClassPtr, "CopyPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyPassData>.NativeClassPtr);
			NativeFieldInfoPtr_isMSAA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyPassData>.NativeClassPtr, "isMSAA");
			NativeFieldInfoPtr_force2DForXR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyPassData>.NativeClassPtr, "force2DForXR");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyPassData>.NativeClassPtr, 100667770);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CopyPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopyPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CopyPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[OriginalName("Unity.RenderPipelines.Core.Runtime.dll", "", "BlitFilterMode")]
	public enum BlitFilterMode
	{
		ClampNearest,
		ClampBilinear
	}

	public class BlitPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_source;

		private static readonly System.IntPtr NativeFieldInfoPtr_destination;

		private static readonly System.IntPtr NativeFieldInfoPtr_scale;

		private static readonly System.IntPtr NativeFieldInfoPtr_offset;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceSlice;

		private static readonly System.IntPtr NativeFieldInfoPtr_destinationSlice;

		private static readonly System.IntPtr NativeFieldInfoPtr_numSlices;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceMip;

		private static readonly System.IntPtr NativeFieldInfoPtr_destinationMip;

		private static readonly System.IntPtr NativeFieldInfoPtr_numMips;

		private static readonly System.IntPtr NativeFieldInfoPtr_filterMode;

		private static readonly System.IntPtr NativeFieldInfoPtr_isXR;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe TextureHandle source
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_source);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_source)) = value;
			}
		}

		public unsafe TextureHandle destination
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destination);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destination)) = value;
			}
		}

		public unsafe Vector2 scale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scale);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scale)) = value;
			}
		}

		public unsafe Vector2 offset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset)) = value;
			}
		}

		public unsafe int sourceSlice
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceSlice);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceSlice)) = value;
			}
		}

		public unsafe int destinationSlice
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationSlice);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationSlice)) = value;
			}
		}

		public unsafe int numSlices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numSlices);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numSlices)) = value;
			}
		}

		public unsafe int sourceMip
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceMip);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceMip)) = value;
			}
		}

		public unsafe int destinationMip
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationMip);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationMip)) = value;
			}
		}

		public unsafe int numMips
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numMips);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numMips)) = value;
			}
		}

		public unsafe BlitFilterMode filterMode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filterMode);
				return *(BlitFilterMode*)num;
			}
			set
			{
				*(BlitFilterMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filterMode)) = value;
			}
		}

		public unsafe bool isXR
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isXR);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isXR)) = value;
			}
		}

		static BlitPassData()
		{
			Il2CppClassPointerStore<BlitPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraphUtils>.NativeClassPtr, "BlitPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlitPassData>.NativeClassPtr);
			NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitPassData>.NativeClassPtr, "source");
			NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitPassData>.NativeClassPtr, "destination");
			NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitPassData>.NativeClassPtr, "scale");
			NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitPassData>.NativeClassPtr, "offset");
			NativeFieldInfoPtr_sourceSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitPassData>.NativeClassPtr, "sourceSlice");
			NativeFieldInfoPtr_destinationSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitPassData>.NativeClassPtr, "destinationSlice");
			NativeFieldInfoPtr_numSlices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitPassData>.NativeClassPtr, "numSlices");
			NativeFieldInfoPtr_sourceMip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitPassData>.NativeClassPtr, "sourceMip");
			NativeFieldInfoPtr_destinationMip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitPassData>.NativeClassPtr, "destinationMip");
			NativeFieldInfoPtr_numMips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitPassData>.NativeClassPtr, "numMips");
			NativeFieldInfoPtr_filterMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitPassData>.NativeClassPtr, "filterMode");
			NativeFieldInfoPtr_isXR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitPassData>.NativeClassPtr, "isXR");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlitPassData>.NativeClassPtr, 100667771);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlitPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlitPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public BlitPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[OriginalName("Unity.RenderPipelines.Core.Runtime.dll", "", "FullScreenGeometryType")]
	public enum FullScreenGeometryType
	{
		Mesh,
		ProceduralTriangle,
		ProceduralQuad
	}

	public sealed class BlitMaterialParameters : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_blitTextureProperty;

		private static readonly System.IntPtr NativeFieldInfoPtr_blitSliceProperty;

		private static readonly System.IntPtr NativeFieldInfoPtr_blitMipProperty;

		private static readonly System.IntPtr NativeFieldInfoPtr_blitScaleBias;

		private static readonly System.IntPtr NativeFieldInfoPtr_source;

		private static readonly System.IntPtr NativeFieldInfoPtr_destination;

		private static readonly System.IntPtr NativeFieldInfoPtr_scale;

		private static readonly System.IntPtr NativeFieldInfoPtr_offset;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceSlice;

		private static readonly System.IntPtr NativeFieldInfoPtr_destinationSlice;

		private static readonly System.IntPtr NativeFieldInfoPtr_numSlices;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceMip;

		private static readonly System.IntPtr NativeFieldInfoPtr_destinationMip;

		private static readonly System.IntPtr NativeFieldInfoPtr_numMips;

		private static readonly System.IntPtr NativeFieldInfoPtr_material;

		private static readonly System.IntPtr NativeFieldInfoPtr_shaderPass;

		private static readonly System.IntPtr NativeFieldInfoPtr_propertyBlock;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceTexturePropertyID;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceSlicePropertyID;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceMipPropertyID;

		private static readonly System.IntPtr NativeFieldInfoPtr_scaleBiasPropertyID;

		private static readonly System.IntPtr NativeFieldInfoPtr_geometry;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextureHandle_TextureHandle_Material_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextureHandle_TextureHandle_Vector2_Vector2_Material_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextureHandle_TextureHandle_Material_Int32_MaterialPropertyBlock_Int32_Int32_Int32_Int32_Int32_Int32_FullScreenGeometryType_Int32_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextureHandle_TextureHandle_Vector2_Vector2_Material_Int32_MaterialPropertyBlock_Int32_Int32_Int32_Int32_Int32_Int32_FullScreenGeometryType_Int32_Int32_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextureHandle_TextureHandle_Material_Int32_MaterialPropertyBlock_FullScreenGeometryType_Int32_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextureHandle_TextureHandle_Vector2_Vector2_Material_Int32_MaterialPropertyBlock_FullScreenGeometryType_Int32_Int32_Int32_Int32_0;

		public unsafe static int blitTextureProperty
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_blitTextureProperty, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_blitTextureProperty, (void*)(&value));
			}
		}

		public unsafe static int blitSliceProperty
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_blitSliceProperty, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_blitSliceProperty, (void*)(&value));
			}
		}

		public unsafe static int blitMipProperty
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_blitMipProperty, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_blitMipProperty, (void*)(&value));
			}
		}

		public unsafe static int blitScaleBias
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_blitScaleBias, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_blitScaleBias, (void*)(&value));
			}
		}

		public unsafe TextureHandle source
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_source);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_source)) = value;
			}
		}

		public unsafe TextureHandle destination
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destination);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destination)) = value;
			}
		}

		public unsafe Vector2 scale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scale);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scale)) = value;
			}
		}

		public unsafe Vector2 offset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset)) = value;
			}
		}

		public unsafe int sourceSlice
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceSlice);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceSlice)) = value;
			}
		}

		public unsafe int destinationSlice
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationSlice);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationSlice)) = value;
			}
		}

		public unsafe int numSlices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numSlices);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numSlices)) = value;
			}
		}

		public unsafe int sourceMip
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceMip);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceMip)) = value;
			}
		}

		public unsafe int destinationMip
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationMip);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationMip)) = value;
			}
		}

		public unsafe int numMips
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numMips);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numMips)) = value;
			}
		}

		public unsafe Material material
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_material);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_material)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int shaderPass
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shaderPass);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shaderPass)) = value;
			}
		}

		public unsafe MaterialPropertyBlock propertyBlock
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propertyBlock);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propertyBlock)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int sourceTexturePropertyID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexturePropertyID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexturePropertyID)) = value;
			}
		}

		public unsafe int sourceSlicePropertyID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceSlicePropertyID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceSlicePropertyID)) = value;
			}
		}

		public unsafe int sourceMipPropertyID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceMipPropertyID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceMipPropertyID)) = value;
			}
		}

		public unsafe int scaleBiasPropertyID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaleBiasPropertyID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaleBiasPropertyID)) = value;
			}
		}

		public unsafe FullScreenGeometryType geometry
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_geometry);
				return *(FullScreenGeometryType*)num;
			}
			set
			{
				*(FullScreenGeometryType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_geometry)) = value;
			}
		}

		static BlitMaterialParameters()
		{
			Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraphUtils>.NativeClassPtr, "BlitMaterialParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr);
			NativeFieldInfoPtr_blitTextureProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, "blitTextureProperty");
			NativeFieldInfoPtr_blitSliceProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, "blitSliceProperty");
			NativeFieldInfoPtr_blitMipProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, "blitMipProperty");
			NativeFieldInfoPtr_blitScaleBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, "blitScaleBias");
			NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, "source");
			NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, "destination");
			NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, "scale");
			NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, "offset");
			NativeFieldInfoPtr_sourceSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, "sourceSlice");
			NativeFieldInfoPtr_destinationSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, "destinationSlice");
			NativeFieldInfoPtr_numSlices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, "numSlices");
			NativeFieldInfoPtr_sourceMip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, "sourceMip");
			NativeFieldInfoPtr_destinationMip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, "destinationMip");
			NativeFieldInfoPtr_numMips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, "numMips");
			NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, "material");
			NativeFieldInfoPtr_shaderPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, "shaderPass");
			NativeFieldInfoPtr_propertyBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, "propertyBlock");
			NativeFieldInfoPtr_sourceTexturePropertyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, "sourceTexturePropertyID");
			NativeFieldInfoPtr_sourceSlicePropertyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, "sourceSlicePropertyID");
			NativeFieldInfoPtr_sourceMipPropertyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, "sourceMipPropertyID");
			NativeFieldInfoPtr_scaleBiasPropertyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, "scaleBiasPropertyID");
			NativeFieldInfoPtr_geometry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, "geometry");
			NativeMethodInfoPtr__ctor_Public_Void_TextureHandle_TextureHandle_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, 100667772);
			NativeMethodInfoPtr__ctor_Public_Void_TextureHandle_TextureHandle_Vector2_Vector2_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, 100667773);
			NativeMethodInfoPtr__ctor_Public_Void_TextureHandle_TextureHandle_Material_Int32_MaterialPropertyBlock_Int32_Int32_Int32_Int32_Int32_Int32_FullScreenGeometryType_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, 100667774);
			NativeMethodInfoPtr__ctor_Public_Void_TextureHandle_TextureHandle_Vector2_Vector2_Material_Int32_MaterialPropertyBlock_Int32_Int32_Int32_Int32_Int32_Int32_FullScreenGeometryType_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, 100667775);
			NativeMethodInfoPtr__ctor_Public_Void_TextureHandle_TextureHandle_Material_Int32_MaterialPropertyBlock_FullScreenGeometryType_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, 100667776);
			NativeMethodInfoPtr__ctor_Public_Void_TextureHandle_TextureHandle_Vector2_Vector2_Material_Int32_MaterialPropertyBlock_FullScreenGeometryType_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr, 100667777);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1061137, RefRangeEnd = 1061139, XrefRangeStart = 1061129, XrefRangeEnd = 1061137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlitMaterialParameters(TextureHandle source, TextureHandle destination, Material material, int shaderPass)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&source);
			*(TextureHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &shaderPass;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TextureHandle_TextureHandle_Material_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1061148, RefRangeEnd = 1061153, XrefRangeStart = 1061139, XrefRangeEnd = 1061148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlitMaterialParameters(TextureHandle source, TextureHandle destination, Vector2 scale, Vector2 offset, Material material, int shaderPass)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = (nint)(&source);
			*(TextureHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
			*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
			*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
			*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &shaderPass;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TextureHandle_TextureHandle_Vector2_Vector2_Material_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061153, XrefRangeEnd = 1061165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlitMaterialParameters(TextureHandle source, TextureHandle destination, Material material, int shaderPass, MaterialPropertyBlock mpb, int destinationSlice, int destinationMip, int numSlices = -1, int numMips = 1, int sourceSlice = -1, int sourceMip = -1, FullScreenGeometryType geometry = FullScreenGeometryType.Mesh, int sourceTexturePropertyID = -1, int sourceSlicePropertyID = -1, int sourceMipPropertyID = -1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[15];
			*ptr = (nint)(&source);
			*(TextureHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &shaderPass;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mpb);
			*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &destinationSlice;
			*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &destinationMip;
			*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &numSlices;
			*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &numMips;
			*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceSlice;
			*(int**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceMip;
			*(FullScreenGeometryType**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &geometry;
			*(int**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceTexturePropertyID;
			*(int**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceSlicePropertyID;
			*(int**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceMipPropertyID;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TextureHandle_TextureHandle_Material_Int32_MaterialPropertyBlock_Int32_Int32_Int32_Int32_Int32_Int32_FullScreenGeometryType_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061165, XrefRangeEnd = 1061170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlitMaterialParameters(TextureHandle source, TextureHandle destination, Vector2 scale, Vector2 offset, Material material, int shaderPass, MaterialPropertyBlock mpb, int destinationSlice, int destinationMip, int numSlices = -1, int numMips = 1, int sourceSlice = -1, int sourceMip = -1, FullScreenGeometryType geometry = FullScreenGeometryType.Mesh, int sourceTexturePropertyID = -1, int sourceSlicePropertyID = -1, int sourceMipPropertyID = -1, int scaleBiasPropertyID = -1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[18];
			*ptr = (nint)(&source);
			*(TextureHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
			*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
			*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
			*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &shaderPass;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mpb);
			*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &destinationSlice;
			*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &destinationMip;
			*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &numSlices;
			*(int**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &numMips;
			*(int**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceSlice;
			*(int**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceMip;
			*(FullScreenGeometryType**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &geometry;
			*(int**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceTexturePropertyID;
			*(int**)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceSlicePropertyID;
			*(int**)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceMipPropertyID;
			*(int**)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBiasPropertyID;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TextureHandle_TextureHandle_Vector2_Vector2_Material_Int32_MaterialPropertyBlock_Int32_Int32_Int32_Int32_Int32_Int32_FullScreenGeometryType_Int32_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1061182, RefRangeEnd = 1061183, XrefRangeStart = 1061170, XrefRangeEnd = 1061182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlitMaterialParameters(TextureHandle source, TextureHandle destination, Material material, int shaderPass, MaterialPropertyBlock mpb, FullScreenGeometryType geometry = FullScreenGeometryType.Mesh, int sourceTexturePropertyID = -1, int sourceSlicePropertyID = -1, int sourceMipPropertyID = -1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[9];
			*ptr = (nint)(&source);
			*(TextureHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &shaderPass;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mpb);
			*(FullScreenGeometryType**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &geometry;
			*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceTexturePropertyID;
			*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceSlicePropertyID;
			*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceMipPropertyID;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TextureHandle_TextureHandle_Material_Int32_MaterialPropertyBlock_FullScreenGeometryType_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061183, XrefRangeEnd = 1061188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlitMaterialParameters(TextureHandle source, TextureHandle destination, Vector2 scale, Vector2 offset, Material material, int shaderPass, MaterialPropertyBlock mpb, FullScreenGeometryType geometry = FullScreenGeometryType.Mesh, int sourceTexturePropertyID = -1, int sourceSlicePropertyID = -1, int sourceMipPropertyID = -1, int scaleBiasPropertyID = -1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[12];
			*ptr = (nint)(&source);
			*(TextureHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
			*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
			*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
			*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &shaderPass;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mpb);
			*(FullScreenGeometryType**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &geometry;
			*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceTexturePropertyID;
			*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceSlicePropertyID;
			*(int**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceMipPropertyID;
			*(int**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBiasPropertyID;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TextureHandle_TextureHandle_Vector2_Vector2_Material_Int32_MaterialPropertyBlock_FullScreenGeometryType_Int32_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public BlitMaterialParameters(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public BlitMaterialParameters()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlitMaterialParameters>.NativeClassPtr))
		{
		}
	}

	public class BlitMaterialPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_sourceTexturePropertyID;

		private static readonly System.IntPtr NativeFieldInfoPtr_source;

		private static readonly System.IntPtr NativeFieldInfoPtr_destination;

		private static readonly System.IntPtr NativeFieldInfoPtr_scale;

		private static readonly System.IntPtr NativeFieldInfoPtr_offset;

		private static readonly System.IntPtr NativeFieldInfoPtr_material;

		private static readonly System.IntPtr NativeFieldInfoPtr_shaderPass;

		private static readonly System.IntPtr NativeFieldInfoPtr_propertyBlock;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceSlice;

		private static readonly System.IntPtr NativeFieldInfoPtr_destinationSlice;

		private static readonly System.IntPtr NativeFieldInfoPtr_numSlices;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceMip;

		private static readonly System.IntPtr NativeFieldInfoPtr_destinationMip;

		private static readonly System.IntPtr NativeFieldInfoPtr_numMips;

		private static readonly System.IntPtr NativeFieldInfoPtr_geometry;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceSlicePropertyID;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceMipPropertyID;

		private static readonly System.IntPtr NativeFieldInfoPtr_scaleBiasPropertyID;

		private static readonly System.IntPtr NativeFieldInfoPtr_isXR;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int sourceTexturePropertyID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexturePropertyID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexturePropertyID)) = value;
			}
		}

		public unsafe TextureHandle source
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_source);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_source)) = value;
			}
		}

		public unsafe TextureHandle destination
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destination);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destination)) = value;
			}
		}

		public unsafe Vector2 scale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scale);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scale)) = value;
			}
		}

		public unsafe Vector2 offset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset)) = value;
			}
		}

		public unsafe Material material
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_material);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_material)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int shaderPass
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shaderPass);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shaderPass)) = value;
			}
		}

		public unsafe MaterialPropertyBlock propertyBlock
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propertyBlock);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propertyBlock)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int sourceSlice
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceSlice);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceSlice)) = value;
			}
		}

		public unsafe int destinationSlice
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationSlice);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationSlice)) = value;
			}
		}

		public unsafe int numSlices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numSlices);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numSlices)) = value;
			}
		}

		public unsafe int sourceMip
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceMip);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceMip)) = value;
			}
		}

		public unsafe int destinationMip
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationMip);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationMip)) = value;
			}
		}

		public unsafe int numMips
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numMips);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numMips)) = value;
			}
		}

		public unsafe FullScreenGeometryType geometry
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_geometry);
				return *(FullScreenGeometryType*)num;
			}
			set
			{
				*(FullScreenGeometryType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_geometry)) = value;
			}
		}

		public unsafe int sourceSlicePropertyID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceSlicePropertyID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceSlicePropertyID)) = value;
			}
		}

		public unsafe int sourceMipPropertyID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceMipPropertyID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceMipPropertyID)) = value;
			}
		}

		public unsafe int scaleBiasPropertyID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaleBiasPropertyID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaleBiasPropertyID)) = value;
			}
		}

		public unsafe bool isXR
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isXR);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isXR)) = value;
			}
		}

		static BlitMaterialPassData()
		{
			Il2CppClassPointerStore<BlitMaterialPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraphUtils>.NativeClassPtr, "BlitMaterialPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlitMaterialPassData>.NativeClassPtr);
			NativeFieldInfoPtr_sourceTexturePropertyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialPassData>.NativeClassPtr, "sourceTexturePropertyID");
			NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialPassData>.NativeClassPtr, "source");
			NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialPassData>.NativeClassPtr, "destination");
			NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialPassData>.NativeClassPtr, "scale");
			NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialPassData>.NativeClassPtr, "offset");
			NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialPassData>.NativeClassPtr, "material");
			NativeFieldInfoPtr_shaderPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialPassData>.NativeClassPtr, "shaderPass");
			NativeFieldInfoPtr_propertyBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialPassData>.NativeClassPtr, "propertyBlock");
			NativeFieldInfoPtr_sourceSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialPassData>.NativeClassPtr, "sourceSlice");
			NativeFieldInfoPtr_destinationSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialPassData>.NativeClassPtr, "destinationSlice");
			NativeFieldInfoPtr_numSlices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialPassData>.NativeClassPtr, "numSlices");
			NativeFieldInfoPtr_sourceMip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialPassData>.NativeClassPtr, "sourceMip");
			NativeFieldInfoPtr_destinationMip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialPassData>.NativeClassPtr, "destinationMip");
			NativeFieldInfoPtr_numMips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialPassData>.NativeClassPtr, "numMips");
			NativeFieldInfoPtr_geometry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialPassData>.NativeClassPtr, "geometry");
			NativeFieldInfoPtr_sourceSlicePropertyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialPassData>.NativeClassPtr, "sourceSlicePropertyID");
			NativeFieldInfoPtr_sourceMipPropertyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialPassData>.NativeClassPtr, "sourceMipPropertyID");
			NativeFieldInfoPtr_scaleBiasPropertyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialPassData>.NativeClassPtr, "scaleBiasPropertyID");
			NativeFieldInfoPtr_isXR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitMaterialPassData>.NativeClassPtr, "isXR");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlitMaterialPassData>.NativeClassPtr, 100667779);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlitMaterialPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlitMaterialPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public BlitMaterialPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__14_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__20_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddCopyPass_b__8_0_Internal_Void_CopyPassData_RasterGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddBlitPass_b__14_0_Internal_Void_BlitPassData_UnsafeGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddBlitPass_b__20_0_Internal_Void_BlitMaterialPassData_UnsafeGraphContext_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<CopyPassData, RasterGraphContext> __9__8_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<CopyPassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__8_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<BlitPassData, UnsafeGraphContext> __9__14_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<BlitPassData, UnsafeGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__14_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<BlitMaterialPassData, UnsafeGraphContext> __9__20_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<BlitMaterialPassData, UnsafeGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__20_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraphUtils>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__8_0");
			NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__14_0");
			NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__20_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667781);
			NativeMethodInfoPtr__AddCopyPass_b__8_0_Internal_Void_CopyPassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667782);
			NativeMethodInfoPtr__AddBlitPass_b__14_0_Internal_Void_BlitPassData_UnsafeGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667783);
			NativeMethodInfoPtr__AddBlitPass_b__20_0_Internal_Void_BlitMaterialPassData_UnsafeGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667784);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061188, XrefRangeEnd = 1061196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddCopyPass_b__8_0(CopyPassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddCopyPass_b__8_0_Internal_Void_CopyPassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061196, XrefRangeEnd = 1061200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddBlitPass_b__14_0(BlitPassData data, UnsafeGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddBlitPass_b__14_0_Internal_Void_BlitPassData_UnsafeGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061200, XrefRangeEnd = 1061204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddBlitPass_b__20_0(BlitMaterialPassData data, UnsafeGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddBlitPass_b__20_0_Internal_Void_BlitMaterialPassData_UnsafeGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_PropertyBlock;

	private static readonly System.IntPtr NativeFieldInfoPtr_DisableTexture2DXArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_BlitScaleBias;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanAddCopyPassMSAA_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanAddCopyPassMSAA_Public_Static_Boolean_byref_TextureDesc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsFramebufferFetchEmulationSupportedOnCurrentPlatform_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsFramebufferFetchEmulationMSAASupportedOnCurrentPlatform_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsFramebufferFetchSupportedOnCurrentPlatform_Public_Static_Boolean_RenderGraph_byref_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCopyPass_Public_Static_Void_RenderGraph_TextureHandle_TextureHandle_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCopyPass_Public_Static_Void_RenderGraph_TextureHandle_TextureHandle_Int32_Int32_Int32_Int32_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyRenderFunc_Private_Static_Void_CopyPassData_RasterGraphContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTextureXR_Internal_Static_Boolean_byref_TextureDesc_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBlitPass_Public_Static_Void_RenderGraph_TextureHandle_TextureHandle_Vector2_Vector2_Int32_Int32_Int32_Int32_Int32_Int32_BlitFilterMode_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitRenderFunc_Private_Static_Void_BlitPassData_UnsafeGraphContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBlitPass_Public_Static_Void_RenderGraph_BlitMaterialParameters_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitMaterialRenderFunc_Private_Static_Void_BlitMaterialPassData_UnsafeGraphContext_0;

	public unsafe static MaterialPropertyBlock s_PropertyBlock
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_PropertyBlock, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_PropertyBlock, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static string DisableTexture2DXArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DisableTexture2DXArray, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DisableTexture2DXArray, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static Vector4 s_BlitScaleBias
	{
		get
		{
			Unsafe.SkipInit(out Vector4 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_BlitScaleBias, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_BlitScaleBias, (void*)(&value));
		}
	}

	static RenderGraphUtils()
	{
		Il2CppClassPointerStore<RenderGraphUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule.Util", "RenderGraphUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphUtils>.NativeClassPtr);
		NativeFieldInfoPtr_s_PropertyBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphUtils>.NativeClassPtr, "s_PropertyBlock");
		NativeFieldInfoPtr_DisableTexture2DXArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphUtils>.NativeClassPtr, "DisableTexture2DXArray");
		NativeFieldInfoPtr_s_BlitScaleBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphUtils>.NativeClassPtr, "s_BlitScaleBias");
		NativeMethodInfoPtr_CanAddCopyPassMSAA_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphUtils>.NativeClassPtr, 100667756);
		NativeMethodInfoPtr_CanAddCopyPassMSAA_Public_Static_Boolean_byref_TextureDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphUtils>.NativeClassPtr, 100667757);
		NativeMethodInfoPtr_IsFramebufferFetchEmulationSupportedOnCurrentPlatform_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphUtils>.NativeClassPtr, 100667758);
		NativeMethodInfoPtr_IsFramebufferFetchEmulationMSAASupportedOnCurrentPlatform_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphUtils>.NativeClassPtr, 100667759);
		NativeMethodInfoPtr_IsFramebufferFetchSupportedOnCurrentPlatform_Public_Static_Boolean_RenderGraph_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphUtils>.NativeClassPtr, 100667760);
		NativeMethodInfoPtr_AddCopyPass_Public_Static_Void_RenderGraph_TextureHandle_TextureHandle_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphUtils>.NativeClassPtr, 100667761);
		NativeMethodInfoPtr_AddCopyPass_Public_Static_Void_RenderGraph_TextureHandle_TextureHandle_Int32_Int32_Int32_Int32_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphUtils>.NativeClassPtr, 100667762);
		NativeMethodInfoPtr_CopyRenderFunc_Private_Static_Void_CopyPassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphUtils>.NativeClassPtr, 100667763);
		NativeMethodInfoPtr_IsTextureXR_Internal_Static_Boolean_byref_TextureDesc_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphUtils>.NativeClassPtr, 100667764);
		NativeMethodInfoPtr_AddBlitPass_Public_Static_Void_RenderGraph_TextureHandle_TextureHandle_Vector2_Vector2_Int32_Int32_Int32_Int32_Int32_Int32_BlitFilterMode_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphUtils>.NativeClassPtr, 100667765);
		NativeMethodInfoPtr_BlitRenderFunc_Private_Static_Void_BlitPassData_UnsafeGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphUtils>.NativeClassPtr, 100667766);
		NativeMethodInfoPtr_AddBlitPass_Public_Static_Void_RenderGraph_BlitMaterialParameters_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphUtils>.NativeClassPtr, 100667767);
		NativeMethodInfoPtr_BlitMaterialRenderFunc_Private_Static_Void_BlitMaterialPassData_UnsafeGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphUtils>.NativeClassPtr, 100667768);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061204, XrefRangeEnd = 1061214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CanAddCopyPassMSAA()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanAddCopyPassMSAA_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061214, XrefRangeEnd = 1061224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CanAddCopyPassMSAA([In] ref TextureDesc sourceDesc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sourceDesc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanAddCopyPassMSAA_Public_Static_Boolean_byref_TextureDesc_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 61071, RefRangeEnd = 61098, XrefRangeStart = 61071, XrefRangeEnd = 61098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsFramebufferFetchEmulationSupportedOnCurrentPlatform()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsFramebufferFetchEmulationSupportedOnCurrentPlatform_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061224, XrefRangeEnd = 1061227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsFramebufferFetchEmulationMSAASupportedOnCurrentPlatform()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsFramebufferFetchEmulationMSAASupportedOnCurrentPlatform_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061227, XrefRangeEnd = 1061236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsFramebufferFetchSupportedOnCurrentPlatform(this RenderGraph graph, [In] ref TextureHandle tex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graph);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref tex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsFramebufferFetchSupportedOnCurrentPlatform_Public_Static_Boolean_RenderGraph_byref_TextureHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1061293, RefRangeEnd = 1061295, XrefRangeStart = 1061236, XrefRangeEnd = 1061293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddCopyPass(this RenderGraph graph, TextureHandle source, TextureHandle destination, string passName = "Copy Pass Utility", string file = "", int line = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graph);
		*(TextureHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &source;
		*(TextureHandle**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(passName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(file);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &line;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCopyPass_Public_Static_Void_RenderGraph_TextureHandle_TextureHandle_String_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061295, XrefRangeEnd = 1061299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddCopyPass(this RenderGraph graph, TextureHandle source, TextureHandle destination, int sourceSlice, int destinationSlice = 0, int sourceMip = 0, int destinationMip = 0, string passName = "Copy Pass Utility", string file = "", int line = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graph);
		*(TextureHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &source;
		*(TextureHandle**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceSlice;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &destinationSlice;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceMip;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &destinationMip;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(passName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(file);
		*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &line;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCopyPass_Public_Static_Void_RenderGraph_TextureHandle_TextureHandle_Int32_Int32_Int32_Int32_String_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061299, XrefRangeEnd = 1061304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyRenderFunc(CopyPassData data, RasterGraphContext rgContext)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rgContext));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyRenderFunc_Private_Static_Void_CopyPassData_RasterGraphContext_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1061318, RefRangeEnd = 1061320, XrefRangeStart = 1061304, XrefRangeEnd = 1061318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsTextureXR(ref TextureDesc destDesc, int sourceSlice, int destinationSlice, int numSlices, int numMips)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destDesc);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceSlice;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destinationSlice;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &numSlices;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &numMips;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTextureXR_Internal_Static_Boolean_byref_TextureDesc_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061320, XrefRangeEnd = 1061370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddBlitPass(this RenderGraph graph, TextureHandle source, TextureHandle destination, Vector2 scale, Vector2 offset, int sourceSlice = 0, int destinationSlice = 0, int numSlices = -1, int sourceMip = 0, int destinationMip = 0, int numMips = 1, BlitFilterMode filterMode = BlitFilterMode.ClampBilinear, string passName = "Blit Pass Utility", string file = "", int line = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[15];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graph);
		*(TextureHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &source;
		*(TextureHandle**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		*(Vector2**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceSlice;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &destinationSlice;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &numSlices;
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceMip;
		*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &destinationMip;
		*(int**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &numMips;
		*(BlitFilterMode**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterMode;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(passName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(file);
		*(int**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &line;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBlitPass_Public_Static_Void_RenderGraph_TextureHandle_TextureHandle_Vector2_Vector2_Int32_Int32_Int32_Int32_Int32_Int32_BlitFilterMode_String_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1061406, RefRangeEnd = 1061407, XrefRangeStart = 1061370, XrefRangeEnd = 1061406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitRenderFunc(BlitPassData data, UnsafeGraphContext context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitRenderFunc_Private_Static_Void_BlitPassData_UnsafeGraphContext_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1061471, RefRangeEnd = 1061474, XrefRangeStart = 1061407, XrefRangeEnd = 1061471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddBlitPass(this RenderGraph graph, BlitMaterialParameters blitParameters, string passName = "Blit Pass Utility w. Material", string file = "", int line = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)blitParameters));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(passName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(file);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &line;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBlitPass_Public_Static_Void_RenderGraph_BlitMaterialParameters_String_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1061548, RefRangeEnd = 1061549, XrefRangeStart = 1061474, XrefRangeEnd = 1061548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitMaterialRenderFunc(BlitMaterialPassData data, UnsafeGraphContext context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitMaterialRenderFunc_Private_Static_Void_BlitMaterialPassData_UnsafeGraphContext_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RenderGraphUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
