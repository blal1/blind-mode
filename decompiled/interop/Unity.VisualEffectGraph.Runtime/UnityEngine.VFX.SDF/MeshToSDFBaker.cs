using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.VFX.SDF;

public class MeshToSDFBaker : Il2CppSystem.Object
{
	public static class ShaderProperties : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_indicesBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_verticesBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_vertexPositionOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_vertexStride;

		private static readonly System.IntPtr NativeFieldInfoPtr_indexStride;

		private static readonly System.IntPtr NativeFieldInfoPtr_coordFlipBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_verticesOutBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_aabbBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_worldToClip;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentAxis;

		private static readonly System.IntPtr NativeFieldInfoPtr_voxelsBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_rw_trianglesUV;

		private static readonly System.IntPtr NativeFieldInfoPtr_trianglesUV;

		private static readonly System.IntPtr NativeFieldInfoPtr_voxelsTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_voxelsTmpTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_rayMap;

		private static readonly System.IntPtr NativeFieldInfoPtr_rayMapTmp;

		private static readonly System.IntPtr NativeFieldInfoPtr_rw_rayMapTmp;

		private static readonly System.IntPtr NativeFieldInfoPtr_nTriangles;

		private static readonly System.IntPtr NativeFieldInfoPtr_minBoundsExtended;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxBoundsExtended;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxExtent;

		private static readonly System.IntPtr NativeFieldInfoPtr_upperBoundCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_counter;

		private static readonly System.IntPtr NativeFieldInfoPtr_dimX;

		private static readonly System.IntPtr NativeFieldInfoPtr_dimY;

		private static readonly System.IntPtr NativeFieldInfoPtr_dimZ;

		private static readonly System.IntPtr NativeFieldInfoPtr_size;

		private static readonly System.IntPtr NativeFieldInfoPtr_inputBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_inputCounter;

		private static readonly System.IntPtr NativeFieldInfoPtr_auxBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_resultBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_numElem;

		private static readonly System.IntPtr NativeFieldInfoPtr_exclusive;

		private static readonly System.IntPtr NativeFieldInfoPtr_dispatchWidth;

		private static readonly System.IntPtr NativeFieldInfoPtr_src;

		private static readonly System.IntPtr NativeFieldInfoPtr_dest;

		private static readonly System.IntPtr NativeFieldInfoPtr_signMap;

		private static readonly System.IntPtr NativeFieldInfoPtr_threshold;

		private static readonly System.IntPtr NativeFieldInfoPtr_signMapTmp;

		private static readonly System.IntPtr NativeFieldInfoPtr_normalizeFactor;

		private static readonly System.IntPtr NativeFieldInfoPtr_numNeighbours;

		private static readonly System.IntPtr NativeFieldInfoPtr_passId;

		private static readonly System.IntPtr NativeFieldInfoPtr_needNormalize;

		private static readonly System.IntPtr NativeFieldInfoPtr_offset;

		private static readonly System.IntPtr NativeFieldInfoPtr_offsetRayMap;

		private static readonly System.IntPtr NativeFieldInfoPtr_triangleIDs;

		private static readonly System.IntPtr NativeFieldInfoPtr_accumCounter;

		private static readonly System.IntPtr NativeFieldInfoPtr_distanceTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_sdfOffset;

		public unsafe static int indicesBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_indicesBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_indicesBuffer, (void*)(&value));
			}
		}

		public unsafe static int verticesBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_verticesBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_verticesBuffer, (void*)(&value));
			}
		}

		public unsafe static int vertexPositionOffset
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vertexPositionOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vertexPositionOffset, (void*)(&value));
			}
		}

		public unsafe static int vertexStride
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vertexStride, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vertexStride, (void*)(&value));
			}
		}

		public unsafe static int indexStride
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_indexStride, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_indexStride, (void*)(&value));
			}
		}

		public unsafe static int coordFlipBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_coordFlipBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_coordFlipBuffer, (void*)(&value));
			}
		}

		public unsafe static int verticesOutBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_verticesOutBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_verticesOutBuffer, (void*)(&value));
			}
		}

		public unsafe static int aabbBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_aabbBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_aabbBuffer, (void*)(&value));
			}
		}

		public unsafe static int worldToClip
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_worldToClip, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_worldToClip, (void*)(&value));
			}
		}

		public unsafe static int currentAxis
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_currentAxis, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_currentAxis, (void*)(&value));
			}
		}

		public unsafe static int voxelsBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_voxelsBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_voxelsBuffer, (void*)(&value));
			}
		}

		public unsafe static int rw_trianglesUV
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_rw_trianglesUV, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_rw_trianglesUV, (void*)(&value));
			}
		}

		public unsafe static int trianglesUV
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_trianglesUV, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_trianglesUV, (void*)(&value));
			}
		}

		public unsafe static int voxelsTexture
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_voxelsTexture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_voxelsTexture, (void*)(&value));
			}
		}

		public unsafe static int voxelsTmpTexture
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_voxelsTmpTexture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_voxelsTmpTexture, (void*)(&value));
			}
		}

		public unsafe static int rayMap
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_rayMap, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_rayMap, (void*)(&value));
			}
		}

		public unsafe static int rayMapTmp
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_rayMapTmp, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_rayMapTmp, (void*)(&value));
			}
		}

		public unsafe static int rw_rayMapTmp
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_rw_rayMapTmp, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_rw_rayMapTmp, (void*)(&value));
			}
		}

		public unsafe static int nTriangles
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nTriangles, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nTriangles, (void*)(&value));
			}
		}

		public unsafe static int minBoundsExtended
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_minBoundsExtended, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_minBoundsExtended, (void*)(&value));
			}
		}

		public unsafe static int maxBoundsExtended
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maxBoundsExtended, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maxBoundsExtended, (void*)(&value));
			}
		}

		public unsafe static int maxExtent
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maxExtent, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maxExtent, (void*)(&value));
			}
		}

		public unsafe static int upperBoundCount
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_upperBoundCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_upperBoundCount, (void*)(&value));
			}
		}

		public unsafe static int counter
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_counter, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_counter, (void*)(&value));
			}
		}

		public unsafe static int dimX
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dimX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dimX, (void*)(&value));
			}
		}

		public unsafe static int dimY
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dimY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dimY, (void*)(&value));
			}
		}

		public unsafe static int dimZ
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dimZ, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dimZ, (void*)(&value));
			}
		}

		public unsafe static int size
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_size, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_size, (void*)(&value));
			}
		}

		public unsafe static int inputBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inputBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inputBuffer, (void*)(&value));
			}
		}

		public unsafe static int inputCounter
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inputCounter, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inputCounter, (void*)(&value));
			}
		}

		public unsafe static int auxBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_auxBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_auxBuffer, (void*)(&value));
			}
		}

		public unsafe static int resultBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_resultBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_resultBuffer, (void*)(&value));
			}
		}

		public unsafe static int numElem
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_numElem, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_numElem, (void*)(&value));
			}
		}

		public unsafe static int exclusive
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_exclusive, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_exclusive, (void*)(&value));
			}
		}

		public unsafe static int dispatchWidth
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dispatchWidth, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dispatchWidth, (void*)(&value));
			}
		}

		public unsafe static int src
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_src, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_src, (void*)(&value));
			}
		}

		public unsafe static int dest
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dest, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dest, (void*)(&value));
			}
		}

		public unsafe static int signMap
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_signMap, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_signMap, (void*)(&value));
			}
		}

		public unsafe static int threshold
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_threshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_threshold, (void*)(&value));
			}
		}

		public unsafe static int signMapTmp
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_signMapTmp, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_signMapTmp, (void*)(&value));
			}
		}

		public unsafe static int normalizeFactor
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_normalizeFactor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_normalizeFactor, (void*)(&value));
			}
		}

		public unsafe static int numNeighbours
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_numNeighbours, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_numNeighbours, (void*)(&value));
			}
		}

		public unsafe static int passId
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_passId, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_passId, (void*)(&value));
			}
		}

		public unsafe static int needNormalize
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_needNormalize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_needNormalize, (void*)(&value));
			}
		}

		public unsafe static int offset
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_offset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_offset, (void*)(&value));
			}
		}

		public unsafe static int offsetRayMap
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_offsetRayMap, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_offsetRayMap, (void*)(&value));
			}
		}

		public unsafe static int triangleIDs
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_triangleIDs, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_triangleIDs, (void*)(&value));
			}
		}

		public unsafe static int accumCounter
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_accumCounter, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_accumCounter, (void*)(&value));
			}
		}

		public unsafe static int distanceTexture
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_distanceTexture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_distanceTexture, (void*)(&value));
			}
		}

		public unsafe static int sdfOffset
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sdfOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sdfOffset, (void*)(&value));
			}
		}

		static ShaderProperties()
		{
			Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "ShaderProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr);
			NativeFieldInfoPtr_indicesBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "indicesBuffer");
			NativeFieldInfoPtr_verticesBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "verticesBuffer");
			NativeFieldInfoPtr_vertexPositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "vertexPositionOffset");
			NativeFieldInfoPtr_vertexStride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "vertexStride");
			NativeFieldInfoPtr_indexStride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "indexStride");
			NativeFieldInfoPtr_coordFlipBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "coordFlipBuffer");
			NativeFieldInfoPtr_verticesOutBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "verticesOutBuffer");
			NativeFieldInfoPtr_aabbBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "aabbBuffer");
			NativeFieldInfoPtr_worldToClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "worldToClip");
			NativeFieldInfoPtr_currentAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "currentAxis");
			NativeFieldInfoPtr_voxelsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "voxelsBuffer");
			NativeFieldInfoPtr_rw_trianglesUV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "rw_trianglesUV");
			NativeFieldInfoPtr_trianglesUV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "trianglesUV");
			NativeFieldInfoPtr_voxelsTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "voxelsTexture");
			NativeFieldInfoPtr_voxelsTmpTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "voxelsTmpTexture");
			NativeFieldInfoPtr_rayMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "rayMap");
			NativeFieldInfoPtr_rayMapTmp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "rayMapTmp");
			NativeFieldInfoPtr_rw_rayMapTmp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "rw_rayMapTmp");
			NativeFieldInfoPtr_nTriangles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "nTriangles");
			NativeFieldInfoPtr_minBoundsExtended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "minBoundsExtended");
			NativeFieldInfoPtr_maxBoundsExtended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "maxBoundsExtended");
			NativeFieldInfoPtr_maxExtent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "maxExtent");
			NativeFieldInfoPtr_upperBoundCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "upperBoundCount");
			NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "counter");
			NativeFieldInfoPtr_dimX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "dimX");
			NativeFieldInfoPtr_dimY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "dimY");
			NativeFieldInfoPtr_dimZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "dimZ");
			NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "size");
			NativeFieldInfoPtr_inputBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "inputBuffer");
			NativeFieldInfoPtr_inputCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "inputCounter");
			NativeFieldInfoPtr_auxBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "auxBuffer");
			NativeFieldInfoPtr_resultBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "resultBuffer");
			NativeFieldInfoPtr_numElem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "numElem");
			NativeFieldInfoPtr_exclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "exclusive");
			NativeFieldInfoPtr_dispatchWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "dispatchWidth");
			NativeFieldInfoPtr_src = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "src");
			NativeFieldInfoPtr_dest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "dest");
			NativeFieldInfoPtr_signMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "signMap");
			NativeFieldInfoPtr_threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "threshold");
			NativeFieldInfoPtr_signMapTmp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "signMapTmp");
			NativeFieldInfoPtr_normalizeFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "normalizeFactor");
			NativeFieldInfoPtr_numNeighbours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "numNeighbours");
			NativeFieldInfoPtr_passId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "passId");
			NativeFieldInfoPtr_needNormalize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "needNormalize");
			NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "offset");
			NativeFieldInfoPtr_offsetRayMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "offsetRayMap");
			NativeFieldInfoPtr_triangleIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "triangleIDs");
			NativeFieldInfoPtr_accumCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "accumCounter");
			NativeFieldInfoPtr_distanceTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "distanceTexture");
			NativeFieldInfoPtr_sdfOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "sdfOffset");
		}

		public ShaderProperties(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class Kernels : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_inBucketSum;

		private static readonly System.IntPtr NativeFieldInfoPtr_blockSums;

		private static readonly System.IntPtr NativeFieldInfoPtr_finalSum;

		private static readonly System.IntPtr NativeFieldInfoPtr_toTextureNormalized;

		private static readonly System.IntPtr NativeFieldInfoPtr_copyTextures;

		private static readonly System.IntPtr NativeFieldInfoPtr_jfa;

		private static readonly System.IntPtr NativeFieldInfoPtr_distanceTransform;

		private static readonly System.IntPtr NativeFieldInfoPtr_copyBuffers;

		private static readonly System.IntPtr NativeFieldInfoPtr_generateRayMapLocal;

		private static readonly System.IntPtr NativeFieldInfoPtr_rayMapScanX;

		private static readonly System.IntPtr NativeFieldInfoPtr_rayMapScanY;

		private static readonly System.IntPtr NativeFieldInfoPtr_rayMapScanZ;

		private static readonly System.IntPtr NativeFieldInfoPtr_signPass6Rays;

		private static readonly System.IntPtr NativeFieldInfoPtr_signPassNeighbors;

		private static readonly System.IntPtr NativeFieldInfoPtr_toBlockSumBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_clearTexturesAndBuffers;

		private static readonly System.IntPtr NativeFieldInfoPtr_copyToBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_generateTrianglesUV;

		private static readonly System.IntPtr NativeFieldInfoPtr_conservativeRasterization;

		private static readonly System.IntPtr NativeFieldInfoPtr_chooseDirectionTriangleOnly;

		private static readonly System.IntPtr NativeFieldInfoPtr_surfaceClosing;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ComputeShader_0;

		public unsafe int inBucketSum
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inBucketSum);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inBucketSum)) = value;
			}
		}

		public unsafe int blockSums
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockSums);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockSums)) = value;
			}
		}

		public unsafe int finalSum
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalSum);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalSum)) = value;
			}
		}

		public unsafe int toTextureNormalized
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toTextureNormalized);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toTextureNormalized)) = value;
			}
		}

		public unsafe int copyTextures
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyTextures);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyTextures)) = value;
			}
		}

		public unsafe int jfa
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jfa);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jfa)) = value;
			}
		}

		public unsafe int distanceTransform
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceTransform);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceTransform)) = value;
			}
		}

		public unsafe int copyBuffers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyBuffers);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyBuffers)) = value;
			}
		}

		public unsafe int generateRayMapLocal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateRayMapLocal);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateRayMapLocal)) = value;
			}
		}

		public unsafe int rayMapScanX
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rayMapScanX);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rayMapScanX)) = value;
			}
		}

		public unsafe int rayMapScanY
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rayMapScanY);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rayMapScanY)) = value;
			}
		}

		public unsafe int rayMapScanZ
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rayMapScanZ);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rayMapScanZ)) = value;
			}
		}

		public unsafe int signPass6Rays
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_signPass6Rays);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_signPass6Rays)) = value;
			}
		}

		public unsafe int signPassNeighbors
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_signPassNeighbors);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_signPassNeighbors)) = value;
			}
		}

		public unsafe int toBlockSumBuffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toBlockSumBuffer);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toBlockSumBuffer)) = value;
			}
		}

		public unsafe int clearTexturesAndBuffers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearTexturesAndBuffers);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearTexturesAndBuffers)) = value;
			}
		}

		public unsafe int copyToBuffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyToBuffer);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyToBuffer)) = value;
			}
		}

		public unsafe int generateTrianglesUV
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateTrianglesUV);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateTrianglesUV)) = value;
			}
		}

		public unsafe int conservativeRasterization
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conservativeRasterization);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conservativeRasterization)) = value;
			}
		}

		public unsafe int chooseDirectionTriangleOnly
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chooseDirectionTriangleOnly);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chooseDirectionTriangleOnly)) = value;
			}
		}

		public unsafe int surfaceClosing
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surfaceClosing);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surfaceClosing)) = value;
			}
		}

		static Kernels()
		{
			Il2CppClassPointerStore<Kernels>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "Kernels");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Kernels>.NativeClassPtr);
			NativeFieldInfoPtr_inBucketSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Kernels>.NativeClassPtr, "inBucketSum");
			NativeFieldInfoPtr_blockSums = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Kernels>.NativeClassPtr, "blockSums");
			NativeFieldInfoPtr_finalSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Kernels>.NativeClassPtr, "finalSum");
			NativeFieldInfoPtr_toTextureNormalized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Kernels>.NativeClassPtr, "toTextureNormalized");
			NativeFieldInfoPtr_copyTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Kernels>.NativeClassPtr, "copyTextures");
			NativeFieldInfoPtr_jfa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Kernels>.NativeClassPtr, "jfa");
			NativeFieldInfoPtr_distanceTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Kernels>.NativeClassPtr, "distanceTransform");
			NativeFieldInfoPtr_copyBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Kernels>.NativeClassPtr, "copyBuffers");
			NativeFieldInfoPtr_generateRayMapLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Kernels>.NativeClassPtr, "generateRayMapLocal");
			NativeFieldInfoPtr_rayMapScanX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Kernels>.NativeClassPtr, "rayMapScanX");
			NativeFieldInfoPtr_rayMapScanY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Kernels>.NativeClassPtr, "rayMapScanY");
			NativeFieldInfoPtr_rayMapScanZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Kernels>.NativeClassPtr, "rayMapScanZ");
			NativeFieldInfoPtr_signPass6Rays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Kernels>.NativeClassPtr, "signPass6Rays");
			NativeFieldInfoPtr_signPassNeighbors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Kernels>.NativeClassPtr, "signPassNeighbors");
			NativeFieldInfoPtr_toBlockSumBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Kernels>.NativeClassPtr, "toBlockSumBuffer");
			NativeFieldInfoPtr_clearTexturesAndBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Kernels>.NativeClassPtr, "clearTexturesAndBuffers");
			NativeFieldInfoPtr_copyToBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Kernels>.NativeClassPtr, "copyToBuffer");
			NativeFieldInfoPtr_generateTrianglesUV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Kernels>.NativeClassPtr, "generateTrianglesUV");
			NativeFieldInfoPtr_conservativeRasterization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Kernels>.NativeClassPtr, "conservativeRasterization");
			NativeFieldInfoPtr_chooseDirectionTriangleOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Kernels>.NativeClassPtr, "chooseDirectionTriangleOnly");
			NativeFieldInfoPtr_surfaceClosing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Kernels>.NativeClassPtr, "surfaceClosing");
			NativeMethodInfoPtr__ctor_Internal_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernels>.NativeClassPtr, 100663529);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1144157, RefRangeEnd = 1144158, XrefRangeStart = 1144093, XrefRangeEnd = 1144157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Kernels(ComputeShader computeShader)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Kernels>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)computeShader);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public Kernels(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RayMaps;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SignMaps;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderTextureViews;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CounterBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AccumCounterBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TrianglesInVoxels;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TrianglesUV;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TmpBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AccumSumBlocks;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SumBlocksBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InSumBlocksBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SumBlocksAdditional;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IndicesBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_VerticesBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_VerticesOutBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CoordFlipBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AabbBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_VertexBufferOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ThreadGroupSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SignPassesCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InOutThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Material;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_WorldToClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProjMat;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ViewMat;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_nStepsJFA;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Kernels;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Mesh;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_textureVoxel;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_textureVoxelBis;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DistanceTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_bufferVoxel;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_computeShader;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_maxResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxExtent;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SdfOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_nTriangles;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SizeBox;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Center;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Cmd;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OwnsCommandBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsDisposed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Dimensions;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OffsetRayMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MinBoundsExtended;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxBoundsExtended;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RayMapUseCounter;

	private static readonly System.IntPtr NativeFieldInfoPtr_kMaxRecommandedGridSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_kMaxAbsoluteGridSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_kNbActualRT;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RuntimeResources;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SdfTexture_Public_get_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitMeshFromList_Private_Static_Mesh_List_1_Mesh_List_1_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitCommandBuffer_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalVoxelCount_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitSizeBox_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGridSize_Public_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActualBoxSize_Public_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Int32_Mesh_Int32_Single_Single_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Int32_List_1_Mesh_List_1_Matrix4x4_Int32_Single_Single_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reinit_Public_Void_Vector3_Vector3_Int32_Mesh_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reinit_Public_Void_Vector3_Vector3_Int32_List_1_Mesh_List_1_Matrix4x4_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetParameters_Private_Void_Vector3_Vector3_Int32_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadRuntimeResources_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitTextures_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCameras_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeOrthographicWorldToClip_Private_Matrix4x4_Vector3_Quaternion_Single_Single_Single_Single_byref_Matrix4x4_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_iDivUp_Private_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetThreadGroupsCount_Private_Vector2Int_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrefixSumCount_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SurfaceClosing_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureVoxelPrincipal_Private_RenderTexture_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureVoxelBis_Private_RenderTexture_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_JFA_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateRayMap_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRayMapPrincipal_Private_RenderTexture_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRayMapBis_Private_RenderTexture_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSignMapPrincipal_Private_RenderTexture_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSignMapBis_Private_RenderTexture_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SignPass_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BakeSDF_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitMeshBuffers_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FirstDraw_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SecondDraw_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildGeometry_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitGeometryBuffers_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitPrefixSumBuffers_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearRenderTexturesAndBuffers_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PerformDistanceTransformWinding_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseBuffersAndTextures_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateGraphicsBufferIfNeeded_Private_Void_byref_GraphicsBuffer_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseGraphicsBuffer_Private_Void_byref_GraphicsBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRenderTextureIfNeeded_Private_Void_byref_RenderTexture_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseRenderTexture_Private_Void_byref_RenderTexture_0;

	public unsafe Il2CppReferenceArray<RenderTexture> m_RayMaps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RayMaps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RenderTexture>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RayMaps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<RenderTexture> m_SignMaps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SignMaps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RenderTexture>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SignMaps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<RenderTexture> m_RenderTextureViews
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderTextureViews);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RenderTexture>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderTextureViews)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsBuffer m_CounterBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CounterBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CounterBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsBuffer m_AccumCounterBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AccumCounterBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AccumCounterBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsBuffer m_TrianglesInVoxels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TrianglesInVoxels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TrianglesInVoxels)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsBuffer m_TrianglesUV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TrianglesUV);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TrianglesUV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsBuffer m_TmpBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TmpBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TmpBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsBuffer m_AccumSumBlocks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AccumSumBlocks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AccumSumBlocks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsBuffer m_SumBlocksBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SumBlocksBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SumBlocksBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsBuffer m_InSumBlocksBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InSumBlocksBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InSumBlocksBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsBuffer m_SumBlocksAdditional
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SumBlocksAdditional);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SumBlocksAdditional)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsBuffer m_IndicesBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IndicesBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IndicesBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsBuffer m_VerticesBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VerticesBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VerticesBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsBuffer m_VerticesOutBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VerticesOutBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VerticesOutBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsBuffer m_CoordFlipBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CoordFlipBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CoordFlipBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsBuffer m_AabbBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AabbBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AabbBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_VertexBufferOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VertexBufferOffset);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VertexBufferOffset)) = value;
		}
	}

	public unsafe int m_ThreadGroupSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ThreadGroupSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ThreadGroupSize)) = value;
		}
	}

	public unsafe int m_SignPassesCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SignPassesCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SignPassesCount)) = value;
		}
	}

	public unsafe float m_InOutThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InOutThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InOutThreshold)) = value;
		}
	}

	public unsafe Il2CppReferenceArray<Material> m_Material
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Material);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Material)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Matrix4x4> m_WorldToClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WorldToClip);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WorldToClip)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Matrix4x4> m_ProjMat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProjMat);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProjMat)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Matrix4x4> m_ViewMat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ViewMat);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ViewMat)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_nStepsJFA
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_nStepsJFA);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_nStepsJFA)) = value;
		}
	}

	public unsafe Kernels m_Kernels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Kernels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Kernels>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Kernels)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Mesh m_Mesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Mesh);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Mesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderTexture m_textureVoxel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_textureVoxel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_textureVoxel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderTexture m_textureVoxelBis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_textureVoxelBis);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_textureVoxelBis)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderTexture m_DistanceTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DistanceTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DistanceTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsBuffer m_bufferVoxel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bufferVoxel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bufferVoxel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ComputeShader m_computeShader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_computeShader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_computeShader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_maxResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_maxResolution);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_maxResolution)) = value;
		}
	}

	public unsafe float m_MaxExtent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxExtent);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxExtent)) = value;
		}
	}

	public unsafe float m_SdfOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SdfOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SdfOffset)) = value;
		}
	}

	public unsafe int nTriangles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nTriangles);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nTriangles)) = value;
		}
	}

	public unsafe Vector3 m_SizeBox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SizeBox);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SizeBox)) = value;
		}
	}

	public unsafe Vector3 m_Center
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Center);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Center)) = value;
		}
	}

	public unsafe CommandBuffer m_Cmd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Cmd);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Cmd)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_OwnsCommandBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OwnsCommandBuffer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OwnsCommandBuffer)) = value;
		}
	}

	public unsafe bool m_IsDisposed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsDisposed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsDisposed)) = value;
		}
	}

	public unsafe Il2CppStructArray<int> m_Dimensions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Dimensions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Dimensions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> m_OffsetRayMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OffsetRayMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OffsetRayMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<float> m_MinBoundsExtended
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MinBoundsExtended);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MinBoundsExtended)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<float> m_MaxBoundsExtended
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxBoundsExtended);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxBoundsExtended)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_RayMapUseCounter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RayMapUseCounter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RayMapUseCounter)) = value;
		}
	}

	public unsafe static uint kMaxRecommandedGridSize
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMaxRecommandedGridSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMaxRecommandedGridSize, (void*)(&value));
		}
	}

	public unsafe static uint kMaxAbsoluteGridSize
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMaxAbsoluteGridSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMaxAbsoluteGridSize, (void*)(&value));
		}
	}

	public unsafe static int kNbActualRT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kNbActualRT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kNbActualRT, (void*)(&value));
		}
	}

	public unsafe VFXRuntimeResources m_RuntimeResources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RuntimeResources);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<VFXRuntimeResources>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RuntimeResources)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderTexture SdfTexture
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SdfTexture_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
		}
	}

	static MeshToSDFBaker()
	{
		Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.VisualEffectGraph.Runtime.dll", "UnityEngine.VFX.SDF", "MeshToSDFBaker");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr);
		NativeFieldInfoPtr_m_RayMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_RayMaps");
		NativeFieldInfoPtr_m_SignMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_SignMaps");
		NativeFieldInfoPtr_m_RenderTextureViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_RenderTextureViews");
		NativeFieldInfoPtr_m_CounterBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_CounterBuffer");
		NativeFieldInfoPtr_m_AccumCounterBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_AccumCounterBuffer");
		NativeFieldInfoPtr_m_TrianglesInVoxels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_TrianglesInVoxels");
		NativeFieldInfoPtr_m_TrianglesUV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_TrianglesUV");
		NativeFieldInfoPtr_m_TmpBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_TmpBuffer");
		NativeFieldInfoPtr_m_AccumSumBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_AccumSumBlocks");
		NativeFieldInfoPtr_m_SumBlocksBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_SumBlocksBuffer");
		NativeFieldInfoPtr_m_InSumBlocksBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_InSumBlocksBuffer");
		NativeFieldInfoPtr_m_SumBlocksAdditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_SumBlocksAdditional");
		NativeFieldInfoPtr_m_IndicesBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_IndicesBuffer");
		NativeFieldInfoPtr_m_VerticesBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_VerticesBuffer");
		NativeFieldInfoPtr_m_VerticesOutBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_VerticesOutBuffer");
		NativeFieldInfoPtr_m_CoordFlipBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_CoordFlipBuffer");
		NativeFieldInfoPtr_m_AabbBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_AabbBuffer");
		NativeFieldInfoPtr_m_VertexBufferOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_VertexBufferOffset");
		NativeFieldInfoPtr_m_ThreadGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_ThreadGroupSize");
		NativeFieldInfoPtr_m_SignPassesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_SignPassesCount");
		NativeFieldInfoPtr_m_InOutThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_InOutThreshold");
		NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_Material");
		NativeFieldInfoPtr_m_WorldToClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_WorldToClip");
		NativeFieldInfoPtr_m_ProjMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_ProjMat");
		NativeFieldInfoPtr_m_ViewMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_ViewMat");
		NativeFieldInfoPtr_m_nStepsJFA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_nStepsJFA");
		NativeFieldInfoPtr_m_Kernels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_Kernels");
		NativeFieldInfoPtr_m_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_Mesh");
		NativeFieldInfoPtr_m_textureVoxel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_textureVoxel");
		NativeFieldInfoPtr_m_textureVoxelBis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_textureVoxelBis");
		NativeFieldInfoPtr_m_DistanceTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_DistanceTexture");
		NativeFieldInfoPtr_m_bufferVoxel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_bufferVoxel");
		NativeFieldInfoPtr_m_computeShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_computeShader");
		NativeFieldInfoPtr_m_maxResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_maxResolution");
		NativeFieldInfoPtr_m_MaxExtent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_MaxExtent");
		NativeFieldInfoPtr_m_SdfOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_SdfOffset");
		NativeFieldInfoPtr_nTriangles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "nTriangles");
		NativeFieldInfoPtr_m_SizeBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_SizeBox");
		NativeFieldInfoPtr_m_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_Center");
		NativeFieldInfoPtr_m_Cmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_Cmd");
		NativeFieldInfoPtr_m_OwnsCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_OwnsCommandBuffer");
		NativeFieldInfoPtr_m_IsDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_IsDisposed");
		NativeFieldInfoPtr_m_Dimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_Dimensions");
		NativeFieldInfoPtr_m_OffsetRayMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_OffsetRayMap");
		NativeFieldInfoPtr_m_MinBoundsExtended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_MinBoundsExtended");
		NativeFieldInfoPtr_m_MaxBoundsExtended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_MaxBoundsExtended");
		NativeFieldInfoPtr_m_RayMapUseCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_RayMapUseCounter");
		NativeFieldInfoPtr_kMaxRecommandedGridSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "kMaxRecommandedGridSize");
		NativeFieldInfoPtr_kMaxAbsoluteGridSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "kMaxAbsoluteGridSize");
		NativeFieldInfoPtr_kNbActualRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "kNbActualRT");
		NativeFieldInfoPtr_m_RuntimeResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, "m_RuntimeResources");
		NativeMethodInfoPtr_get_SdfTexture_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663481);
		NativeMethodInfoPtr_InitMeshFromList_Private_Static_Mesh_List_1_Mesh_List_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663482);
		NativeMethodInfoPtr_InitCommandBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663483);
		NativeMethodInfoPtr_GetTotalVoxelCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663484);
		NativeMethodInfoPtr_InitSizeBox_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663485);
		NativeMethodInfoPtr_GetGridSize_Public_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663486);
		NativeMethodInfoPtr_GetActualBoxSize_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663487);
		NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Int32_Mesh_Int32_Single_Single_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663488);
		NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Int32_List_1_Mesh_List_1_Matrix4x4_Int32_Single_Single_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663489);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663490);
		NativeMethodInfoPtr_Reinit_Public_Void_Vector3_Vector3_Int32_Mesh_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663491);
		NativeMethodInfoPtr_Reinit_Public_Void_Vector3_Vector3_Int32_List_1_Mesh_List_1_Matrix4x4_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663492);
		NativeMethodInfoPtr_SetParameters_Private_Void_Vector3_Vector3_Int32_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663493);
		NativeMethodInfoPtr_LoadRuntimeResources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663494);
		NativeMethodInfoPtr_InitTextures_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663495);
		NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663496);
		NativeMethodInfoPtr_UpdateCameras_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663497);
		NativeMethodInfoPtr_ComputeOrthographicWorldToClip_Private_Matrix4x4_Vector3_Quaternion_Single_Single_Single_Single_byref_Matrix4x4_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663498);
		NativeMethodInfoPtr_iDivUp_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663499);
		NativeMethodInfoPtr_GetThreadGroupsCount_Private_Vector2Int_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663500);
		NativeMethodInfoPtr_PrefixSumCount_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663501);
		NativeMethodInfoPtr_SurfaceClosing_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663502);
		NativeMethodInfoPtr_GetTextureVoxelPrincipal_Private_RenderTexture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663503);
		NativeMethodInfoPtr_GetTextureVoxelBis_Private_RenderTexture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663504);
		NativeMethodInfoPtr_JFA_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663505);
		NativeMethodInfoPtr_GenerateRayMap_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663506);
		NativeMethodInfoPtr_GetRayMapPrincipal_Private_RenderTexture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663507);
		NativeMethodInfoPtr_GetRayMapBis_Private_RenderTexture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663508);
		NativeMethodInfoPtr_GetSignMapPrincipal_Private_RenderTexture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663509);
		NativeMethodInfoPtr_GetSignMapBis_Private_RenderTexture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663510);
		NativeMethodInfoPtr_SignPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663511);
		NativeMethodInfoPtr_BakeSDF_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663512);
		NativeMethodInfoPtr_InitMeshBuffers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663513);
		NativeMethodInfoPtr_FirstDraw_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663514);
		NativeMethodInfoPtr_SecondDraw_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663515);
		NativeMethodInfoPtr_BuildGeometry_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663516);
		NativeMethodInfoPtr_InitGeometryBuffers_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663517);
		NativeMethodInfoPtr_InitPrefixSumBuffers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663518);
		NativeMethodInfoPtr_ClearRenderTexturesAndBuffers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663519);
		NativeMethodInfoPtr_PerformDistanceTransformWinding_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663520);
		NativeMethodInfoPtr_ReleaseBuffersAndTextures_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663521);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663522);
		NativeMethodInfoPtr_CreateGraphicsBufferIfNeeded_Private_Void_byref_GraphicsBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663523);
		NativeMethodInfoPtr_ReleaseGraphicsBuffer_Private_Void_byref_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663524);
		NativeMethodInfoPtr_CreateRenderTextureIfNeeded_Private_Void_byref_RenderTexture_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663525);
		NativeMethodInfoPtr_ReleaseRenderTexture_Private_Void_byref_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr, 100663526);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1144191, RefRangeEnd = 1144193, XrefRangeStart = 1144158, XrefRangeEnd = 1144191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mesh InitMeshFromList(List<Mesh> meshes, List<Matrix4x4> transforms)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transforms);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitMeshFromList_Private_Static_Mesh_List_1_Mesh_List_1_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144193, XrefRangeEnd = 1144201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitCommandBuffer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitCommandBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe int GetTotalVoxelCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTotalVoxelCount_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1144230, RefRangeEnd = 1144231, XrefRangeStart = 1144201, XrefRangeEnd = 1144230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitSizeBox()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitSizeBox_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe Vector3Int GetGridSize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGridSize_Public_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3Int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe Vector3 GetActualBoxSize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActualBoxSize_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1144279, RefRangeEnd = 1144280, XrefRangeStart = 1144231, XrefRangeEnd = 1144279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MeshToSDFBaker(Vector3 sizeBox, Vector3 center, int maxRes, Mesh mesh, int signPassesCount = 1, float threshold = 0.5f, float sdfOffset = 0f, CommandBuffer cmd = null)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&sizeBox);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &center;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxRes;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &signPassesCount;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &threshold;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &sdfOffset;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Int32_Mesh_Int32_Single_Single_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144280, XrefRangeEnd = 1144285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MeshToSDFBaker(Vector3 sizeBox, Vector3 center, int maxRes, List<Mesh> meshes, List<Matrix4x4> transforms, int signPassesCount = 1, float threshold = 0.5f, float sdfOffset = 0f, CommandBuffer cmd = null)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshToSDFBaker>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&sizeBox);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &center;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxRes;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transforms);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &signPassesCount;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &threshold;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &sdfOffset;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Int32_List_1_Mesh_List_1_Matrix4x4_Int32_Single_Single_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144285, XrefRangeEnd = 1144294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144294, XrefRangeEnd = 1144302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reinit(Vector3 sizeBox, Vector3 center, int maxRes, Mesh mesh, int signPassesCount = 1, float threshold = 0.5f, float sdfOffset = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&sizeBox);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &center;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxRes;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &signPassesCount;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &threshold;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &sdfOffset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reinit_Public_Void_Vector3_Vector3_Int32_Mesh_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144302, XrefRangeEnd = 1144314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reinit(Vector3 sizeBox, Vector3 center, int maxRes, List<Mesh> meshes, List<Matrix4x4> transforms, int signPassesCount = 1, float threshold = 0.5f, float sdfOffset = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&sizeBox);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &center;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxRes;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transforms);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &signPassesCount;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &threshold;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &sdfOffset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reinit_Public_Void_Vector3_Vector3_Int32_List_1_Mesh_List_1_Matrix4x4_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetParameters(Vector3 sizeBox, Vector3 center, int maxRes, int signPassesCount, float threshold, float sdfOffset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&sizeBox);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &center;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxRes;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &signPassesCount;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &threshold;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &sdfOffset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetParameters_Private_Void_Vector3_Vector3_Int32_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144314, XrefRangeEnd = 1144332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadRuntimeResources()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadRuntimeResources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1144352, RefRangeEnd = 1144353, XrefRangeStart = 1144332, XrefRangeEnd = 1144352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitTextures()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitTextures_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1144420, RefRangeEnd = 1144423, XrefRangeStart = 1144353, XrefRangeEnd = 1144420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1144436, RefRangeEnd = 1144438, XrefRangeStart = 1144423, XrefRangeEnd = 1144436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCameras()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCameras_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1144443, RefRangeEnd = 1144446, XrefRangeStart = 1144438, XrefRangeEnd = 1144443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Matrix4x4 ComputeOrthographicWorldToClip(Vector3 pos, Quaternion rot, float width, float height, float near, float far, out Matrix4x4 proj, out Matrix4x4 view)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&pos);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rot;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &near;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &far;
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref proj);
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref view);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeOrthographicWorldToClip_Private_Matrix4x4_Vector3_Quaternion_Single_Single_Single_Single_byref_Matrix4x4_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int iDivUp(int a, int b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_iDivUp_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144446, XrefRangeEnd = 1144448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2Int GetThreadGroupsCount(int nbThreads, int threadCountPerGroup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nbThreads);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &threadCountPerGroup;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetThreadGroupsCount_Private_Vector2Int_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1144542, RefRangeEnd = 1144543, XrefRangeStart = 1144448, XrefRangeEnd = 1144542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrefixSumCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrefixSumCount_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1144562, RefRangeEnd = 1144563, XrefRangeStart = 1144543, XrefRangeEnd = 1144562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SurfaceClosing()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SurfaceClosing_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe RenderTexture GetTextureVoxelPrincipal(int step)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&step);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureVoxelPrincipal_Private_RenderTexture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe RenderTexture GetTextureVoxelBis(int step)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&step);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureVoxelBis_Private_RenderTexture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1144667, RefRangeEnd = 1144668, XrefRangeStart = 1144563, XrefRangeEnd = 1144667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void JFA()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JFA_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1144765, RefRangeEnd = 1144766, XrefRangeStart = 1144668, XrefRangeEnd = 1144765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateRayMap()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateRayMap_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe RenderTexture GetRayMapPrincipal(int step)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&step);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRayMapPrincipal_Private_RenderTexture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe RenderTexture GetRayMapBis(int step)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&step);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRayMapBis_Private_RenderTexture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe RenderTexture GetSignMapPrincipal(int step)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&step);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSignMapPrincipal_Private_RenderTexture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe RenderTexture GetSignMapBis(int step)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&step);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSignMapBis_Private_RenderTexture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1144820, RefRangeEnd = 1144821, XrefRangeStart = 1144766, XrefRangeEnd = 1144820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SignPass()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SignPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144821, XrefRangeEnd = 1144861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BakeSDF()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BakeSDF_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1144873, RefRangeEnd = 1144874, XrefRangeStart = 1144861, XrefRangeEnd = 1144873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitMeshBuffers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitMeshBuffers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1144914, RefRangeEnd = 1144915, XrefRangeStart = 1144874, XrefRangeEnd = 1144914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FirstDraw()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FirstDraw_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1144940, RefRangeEnd = 1144941, XrefRangeStart = 1144915, XrefRangeEnd = 1144940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SecondDraw()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SecondDraw_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1145026, RefRangeEnd = 1145027, XrefRangeStart = 1144941, XrefRangeEnd = 1145026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildGeometry()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildGeometry_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145027, XrefRangeEnd = 1145032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitGeometryBuffers(int upperBoundCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&upperBoundCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitGeometryBuffers_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1145055, RefRangeEnd = 1145057, XrefRangeStart = 1145032, XrefRangeEnd = 1145055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitPrefixSumBuffers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitPrefixSumBuffers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1145104, RefRangeEnd = 1145105, XrefRangeStart = 1145057, XrefRangeEnd = 1145104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearRenderTexturesAndBuffers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearRenderTexturesAndBuffers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1145147, RefRangeEnd = 1145148, XrefRangeStart = 1145105, XrefRangeEnd = 1145147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PerformDistanceTransformWinding()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PerformDistanceTransformWinding_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1145198, RefRangeEnd = 1145199, XrefRangeStart = 1145148, XrefRangeEnd = 1145198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReleaseBuffersAndTextures()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseBuffersAndTextures_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145199, XrefRangeEnd = 1145204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 1145213, RefRangeEnd = 1145232, XrefRangeStart = 1145204, XrefRangeEnd = 1145213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateGraphicsBufferIfNeeded(ref GraphicsBuffer gb, int length, int stride)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gb);
		*ptr = (nint)(&intPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &stride;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateGraphicsBufferIfNeeded_Private_Void_byref_GraphicsBuffer_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		gb = ((intPtr4 == (System.IntPtr)0) ? null : new GraphicsBuffer(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145232, XrefRangeEnd = 1145234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReleaseGraphicsBuffer(ref GraphicsBuffer gb)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gb);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseGraphicsBuffer_Private_Void_byref_GraphicsBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		gb = ((intPtr4 == (System.IntPtr)0) ? null : new GraphicsBuffer(intPtr4));
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1145249, RefRangeEnd = 1145256, XrefRangeStart = 1145234, XrefRangeEnd = 1145249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateRenderTextureIfNeeded(ref RenderTexture rt, RenderTextureDescriptor rtDesc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rt);
		*ptr = (nint)(&intPtr);
		*(RenderTextureDescriptor**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rtDesc;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRenderTextureIfNeeded_Private_Void_byref_RenderTexture_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		rt = ((intPtr4 == (System.IntPtr)0) ? null : new RenderTexture(intPtr4));
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1145273, RefRangeEnd = 1145280, XrefRangeStart = 1145256, XrefRangeEnd = 1145273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReleaseRenderTexture(ref RenderTexture rt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rt);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseRenderTexture_Private_Void_byref_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		rt = ((intPtr4 == (System.IntPtr)0) ? null : new RenderTexture(intPtr4));
	}

	public MeshToSDFBaker(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
