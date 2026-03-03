using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine.U2D;

public class SpriteShapeRenderer : Renderer
{
	private delegate void get_color_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_color_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate SpriteMaskInteraction get_maskInteraction_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_maskInteraction_InjectedDelegate(IntPtr _unity_self, SpriteMaskInteraction value);

	private delegate void SetSegmentCount_InjectedDelegate(IntPtr _unity_self, int geomCount);

	private delegate void SetMeshDataCount_InjectedDelegate(IntPtr _unity_self, int vertexCount, int indexCount);

	private delegate void SetMeshChannelInfo_InjectedDelegate(IntPtr _unity_self, int vertexCount, int indexCount, int hotChannelMask);

	private delegate void GetDataInfo_InjectedDelegate(IntPtr _unity_self, SpriteShapeDataType arrayType, [Out] IntPtr ret);

	private delegate void GetChannelInfo_InjectedDelegate(IntPtr _unity_self, VertexAttribute channel, [Out] IntPtr ret);

	private delegate void SetLocalAABB_InjectedDelegate(IntPtr _unity_self, [In] IntPtr bounds);

	private delegate int GetSplineMeshCount_InjectedDelegate(IntPtr _unity_self);

	private static readonly get_color_InjectedDelegate get_color_InjectedDelegateField;

	private static readonly set_color_InjectedDelegate set_color_InjectedDelegateField;

	private static readonly get_maskInteraction_InjectedDelegate get_maskInteraction_InjectedDelegateField;

	private static readonly set_maskInteraction_InjectedDelegate set_maskInteraction_InjectedDelegateField;

	private static readonly SetSegmentCount_InjectedDelegate SetSegmentCount_InjectedDelegateField;

	private static readonly SetMeshDataCount_InjectedDelegate SetMeshDataCount_InjectedDelegateField;

	private static readonly SetMeshChannelInfo_InjectedDelegate SetMeshChannelInfo_InjectedDelegateField;

	private static readonly GetDataInfo_InjectedDelegate GetDataInfo_InjectedDelegateField;

	private static readonly GetChannelInfo_InjectedDelegate GetChannelInfo_InjectedDelegateField;

	private static readonly SetLocalAABB_InjectedDelegate SetLocalAABB_InjectedDelegateField;

	private static readonly GetSplineMeshCount_InjectedDelegate GetSplineMeshCount_InjectedDelegateField;

	public Color color
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_color_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_color_Injected(intPtr, ref value);
		}
	}

	public SpriteMaskInteraction maskInteraction
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maskInteraction_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maskInteraction_Injected(intPtr, value);
		}
	}

	static SpriteShapeRenderer()
	{
		Il2CppClassPointerStore<SpriteShapeRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SpriteShapeModule.dll", "UnityEngine.U2D", "SpriteShapeRenderer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteShapeRenderer>.NativeClassPtr);
		get_color_InjectedDelegateField = IL2CPP.ResolveICall<get_color_InjectedDelegate>("UnityEngine.U2D.SpriteShapeRenderer::get_color_Injected");
		set_color_InjectedDelegateField = IL2CPP.ResolveICall<set_color_InjectedDelegate>("UnityEngine.U2D.SpriteShapeRenderer::set_color_Injected");
		get_maskInteraction_InjectedDelegateField = IL2CPP.ResolveICall<get_maskInteraction_InjectedDelegate>("UnityEngine.U2D.SpriteShapeRenderer::get_maskInteraction_Injected");
		set_maskInteraction_InjectedDelegateField = IL2CPP.ResolveICall<set_maskInteraction_InjectedDelegate>("UnityEngine.U2D.SpriteShapeRenderer::set_maskInteraction_Injected");
		SetSegmentCount_InjectedDelegateField = IL2CPP.ResolveICall<SetSegmentCount_InjectedDelegate>("UnityEngine.U2D.SpriteShapeRenderer::SetSegmentCount_Injected");
		SetMeshDataCount_InjectedDelegateField = IL2CPP.ResolveICall<SetMeshDataCount_InjectedDelegate>("UnityEngine.U2D.SpriteShapeRenderer::SetMeshDataCount_Injected");
		SetMeshChannelInfo_InjectedDelegateField = IL2CPP.ResolveICall<SetMeshChannelInfo_InjectedDelegate>("UnityEngine.U2D.SpriteShapeRenderer::SetMeshChannelInfo_Injected");
		GetDataInfo_InjectedDelegateField = IL2CPP.ResolveICall<GetDataInfo_InjectedDelegate>("UnityEngine.U2D.SpriteShapeRenderer::GetDataInfo_Injected");
		GetChannelInfo_InjectedDelegateField = IL2CPP.ResolveICall<GetChannelInfo_InjectedDelegate>("UnityEngine.U2D.SpriteShapeRenderer::GetChannelInfo_Injected");
		SetLocalAABB_InjectedDelegateField = IL2CPP.ResolveICall<SetLocalAABB_InjectedDelegate>("UnityEngine.U2D.SpriteShapeRenderer::SetLocalAABB_Injected");
		GetSplineMeshCount_InjectedDelegateField = IL2CPP.ResolveICall<GetSplineMeshCount_InjectedDelegate>("UnityEngine.U2D.SpriteShapeRenderer::GetSplineMeshCount_Injected");
	}

	public SpriteShapeRenderer(IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe NativeArray<T> GetNativeDataArray<T>(SpriteShapeDataType dataType) where T : struct
	{
		SpriteChannelInfo dataInfo = GetDataInfo(dataType);
		return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>(dataInfo.buffer, dataInfo.count, Allocator.Invalid);
	}

	public unsafe NativeSlice<T> GetChannelDataArray<T>(SpriteShapeDataType dataType, VertexAttribute channel) where T : struct
	{
		SpriteChannelInfo channelInfo = GetChannelInfo(channel);
		byte* dataPointer = (byte*)channelInfo.buffer + channelInfo.offset;
		return NativeSliceUnsafeUtility.ConvertExistingDataToNativeSlice<T>(dataPointer, channelInfo.stride, channelInfo.count);
	}

	public void SetSegmentCount(int geomCount)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		SetSegmentCount_Injected(intPtr, geomCount);
	}

	public void SetMeshDataCount(int vertexCount, int indexCount)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		SetMeshDataCount_Injected(intPtr, vertexCount, indexCount);
	}

	public void SetMeshChannelInfo(int vertexCount, int indexCount, int hotChannelMask)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		SetMeshChannelInfo_Injected(intPtr, vertexCount, indexCount, hotChannelMask);
	}

	public SpriteChannelInfo GetDataInfo(SpriteShapeDataType arrayType)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		GetDataInfo_Injected(intPtr, arrayType, out var ret);
		return ret;
	}

	public SpriteChannelInfo GetChannelInfo(VertexAttribute channel)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		GetChannelInfo_Injected(intPtr, channel, out var ret);
		return ret;
	}

	public void SetLocalAABB(Bounds bounds)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		SetLocalAABB_Injected(intPtr, ref bounds);
	}

	public int GetSplineMeshCount()
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetSplineMeshCount_Injected(intPtr);
	}

	public NativeArray<Bounds> GetBounds()
	{
		return GetNativeDataArray<Bounds>(SpriteShapeDataType.BoundingBox);
	}

	public void GetChannels(int dataSize, out NativeArray<ushort> indices, out NativeSlice<Vector3> vertices, out NativeSlice<Vector2> texcoords)
	{
		SetMeshDataCount(dataSize, dataSize);
		indices = GetNativeDataArray<ushort>(SpriteShapeDataType.Index);
		vertices = GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelVertex, VertexAttribute.Position);
		texcoords = GetChannelDataArray<Vector2>(SpriteShapeDataType.ChannelTexCoord0, VertexAttribute.TexCoord0);
	}

	public void GetChannels(int dataSize, out NativeArray<ushort> indices, out NativeSlice<Vector3> vertices, out NativeSlice<Vector2> texcoords, out NativeSlice<Color32> colors)
	{
		SetMeshChannelInfo(dataSize, dataSize, 8);
		indices = GetNativeDataArray<ushort>(SpriteShapeDataType.Index);
		vertices = GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelVertex, VertexAttribute.Position);
		texcoords = GetChannelDataArray<Vector2>(SpriteShapeDataType.ChannelTexCoord0, VertexAttribute.TexCoord0);
		colors = GetChannelDataArray<Color32>(SpriteShapeDataType.ChannelColor, VertexAttribute.Color);
	}

	public void GetChannels(int dataSize, out NativeArray<ushort> indices, out NativeSlice<Vector3> vertices, out NativeSlice<Vector2> texcoords, out NativeSlice<Vector4> tangents)
	{
		SetMeshChannelInfo(dataSize, dataSize, 4);
		indices = GetNativeDataArray<ushort>(SpriteShapeDataType.Index);
		vertices = GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelVertex, VertexAttribute.Position);
		texcoords = GetChannelDataArray<Vector2>(SpriteShapeDataType.ChannelTexCoord0, VertexAttribute.TexCoord0);
		tangents = GetChannelDataArray<Vector4>(SpriteShapeDataType.ChannelTangent, VertexAttribute.Tangent);
	}

	public void GetChannels(int dataSize, out NativeArray<ushort> indices, out NativeSlice<Vector3> vertices, out NativeSlice<Vector2> texcoords, out NativeSlice<Color32> colors, out NativeSlice<Vector4> tangents)
	{
		SetMeshChannelInfo(dataSize, dataSize, 12);
		indices = GetNativeDataArray<ushort>(SpriteShapeDataType.Index);
		vertices = GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelVertex, VertexAttribute.Position);
		texcoords = GetChannelDataArray<Vector2>(SpriteShapeDataType.ChannelTexCoord0, VertexAttribute.TexCoord0);
		colors = GetChannelDataArray<Color32>(SpriteShapeDataType.ChannelColor, VertexAttribute.Color);
		tangents = GetChannelDataArray<Vector4>(SpriteShapeDataType.ChannelTangent, VertexAttribute.Tangent);
	}

	public void GetChannels(int dataSize, out NativeArray<ushort> indices, out NativeSlice<Vector3> vertices, out NativeSlice<Vector2> texcoords, out NativeSlice<Vector4> tangents, out NativeSlice<Vector3> normals)
	{
		SetMeshChannelInfo(dataSize, dataSize, 6);
		indices = GetNativeDataArray<ushort>(SpriteShapeDataType.Index);
		vertices = GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelVertex, VertexAttribute.Position);
		texcoords = GetChannelDataArray<Vector2>(SpriteShapeDataType.ChannelTexCoord0, VertexAttribute.TexCoord0);
		tangents = GetChannelDataArray<Vector4>(SpriteShapeDataType.ChannelTangent, VertexAttribute.Tangent);
		normals = GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelNormal, VertexAttribute.Normal);
	}

	public void GetChannels(int dataSize, out NativeArray<ushort> indices, out NativeSlice<Vector3> vertices, out NativeSlice<Vector2> texcoords, out NativeSlice<Color32> colors, out NativeSlice<Vector4> tangents, out NativeSlice<Vector3> normals)
	{
		SetMeshChannelInfo(dataSize, dataSize, 14);
		indices = GetNativeDataArray<ushort>(SpriteShapeDataType.Index);
		vertices = GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelVertex, VertexAttribute.Position);
		texcoords = GetChannelDataArray<Vector2>(SpriteShapeDataType.ChannelTexCoord0, VertexAttribute.TexCoord0);
		colors = GetChannelDataArray<Color32>(SpriteShapeDataType.ChannelColor, VertexAttribute.Color);
		tangents = GetChannelDataArray<Vector4>(SpriteShapeDataType.ChannelTangent, VertexAttribute.Tangent);
		normals = GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelNormal, VertexAttribute.Normal);
	}

	public unsafe static void get_color_Injected(IntPtr _unity_self, out Color ret)
	{
		get_color_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_color_Injected(IntPtr _unity_self, [In] ref Color value)
	{
		set_color_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static SpriteMaskInteraction get_maskInteraction_Injected(IntPtr _unity_self)
	{
		return get_maskInteraction_InjectedDelegateField(_unity_self);
	}

	public static void set_maskInteraction_Injected(IntPtr _unity_self, SpriteMaskInteraction value)
	{
		set_maskInteraction_InjectedDelegateField(_unity_self, value);
	}

	public static void SetSegmentCount_Injected(IntPtr _unity_self, int geomCount)
	{
		SetSegmentCount_InjectedDelegateField(_unity_self, geomCount);
	}

	public static void SetMeshDataCount_Injected(IntPtr _unity_self, int vertexCount, int indexCount)
	{
		SetMeshDataCount_InjectedDelegateField(_unity_self, vertexCount, indexCount);
	}

	public static void SetMeshChannelInfo_Injected(IntPtr _unity_self, int vertexCount, int indexCount, int hotChannelMask)
	{
		SetMeshChannelInfo_InjectedDelegateField(_unity_self, vertexCount, indexCount, hotChannelMask);
	}

	public unsafe static void GetDataInfo_Injected(IntPtr _unity_self, SpriteShapeDataType arrayType, out SpriteChannelInfo ret)
	{
		GetDataInfo_InjectedDelegateField(_unity_self, arrayType, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetChannelInfo_Injected(IntPtr _unity_self, VertexAttribute channel, out SpriteChannelInfo ret)
	{
		GetChannelInfo_InjectedDelegateField(_unity_self, channel, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void SetLocalAABB_Injected(IntPtr _unity_self, [In] ref Bounds bounds)
	{
		SetLocalAABB_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref bounds));
	}

	public static int GetSplineMeshCount_Injected(IntPtr _unity_self)
	{
		return GetSplineMeshCount_InjectedDelegateField(_unity_self);
	}
}
