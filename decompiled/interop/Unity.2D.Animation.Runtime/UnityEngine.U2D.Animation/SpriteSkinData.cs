using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.U2D.Animation;

public sealed class SpriteSkinData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_vertices;

	private static readonly System.IntPtr NativeFieldInfoPtr_boneWeights;

	private static readonly System.IntPtr NativeFieldInfoPtr_bindPoses;

	private static readonly System.IntPtr NativeFieldInfoPtr_tangents;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasTangents;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteVertexStreamSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteVertexCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_tangentVertexOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_deformVerticesStartPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_transformId;

	private static readonly System.IntPtr NativeFieldInfoPtr_boneTransformId;

	public unsafe NativeCustomSlice<Vector3> vertices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertices);
			return new NativeCustomSlice<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeCustomSlice<Vector3>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeCustomSlice<Vector3>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeCustomSlice<BoneWeight> boneWeights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boneWeights);
			return new NativeCustomSlice<BoneWeight>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeCustomSlice<BoneWeight>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boneWeights), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeCustomSlice<BoneWeight>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeCustomSlice<Matrix4x4> bindPoses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bindPoses);
			return new NativeCustomSlice<Matrix4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeCustomSlice<Matrix4x4>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bindPoses), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeCustomSlice<Matrix4x4>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeCustomSlice<Vector4> tangents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tangents);
			return new NativeCustomSlice<Vector4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeCustomSlice<Vector4>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tangents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeCustomSlice<Vector4>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool hasTangents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasTangents);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasTangents)) = value;
		}
	}

	public unsafe int spriteVertexStreamSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteVertexStreamSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteVertexStreamSize)) = value;
		}
	}

	public unsafe int spriteVertexCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteVertexCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteVertexCount)) = value;
		}
	}

	public unsafe int tangentVertexOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tangentVertexOffset);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tangentVertexOffset)) = value;
		}
	}

	public unsafe int deformVerticesStartPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deformVerticesStartPos);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deformVerticesStartPos)) = value;
		}
	}

	public unsafe int transformId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transformId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transformId)) = value;
		}
	}

	public unsafe NativeCustomSlice<int> boneTransformId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boneTransformId);
			return new NativeCustomSlice<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeCustomSlice<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boneTransformId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeCustomSlice<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static SpriteSkinData()
	{
		Il2CppClassPointerStore<SpriteSkinData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.2D.Animation.Runtime.dll", "UnityEngine.U2D.Animation", "SpriteSkinData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteSkinData>.NativeClassPtr);
		NativeFieldInfoPtr_vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkinData>.NativeClassPtr, "vertices");
		NativeFieldInfoPtr_boneWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkinData>.NativeClassPtr, "boneWeights");
		NativeFieldInfoPtr_bindPoses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkinData>.NativeClassPtr, "bindPoses");
		NativeFieldInfoPtr_tangents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkinData>.NativeClassPtr, "tangents");
		NativeFieldInfoPtr_hasTangents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkinData>.NativeClassPtr, "hasTangents");
		NativeFieldInfoPtr_spriteVertexStreamSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkinData>.NativeClassPtr, "spriteVertexStreamSize");
		NativeFieldInfoPtr_spriteVertexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkinData>.NativeClassPtr, "spriteVertexCount");
		NativeFieldInfoPtr_tangentVertexOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkinData>.NativeClassPtr, "tangentVertexOffset");
		NativeFieldInfoPtr_deformVerticesStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkinData>.NativeClassPtr, "deformVerticesStartPos");
		NativeFieldInfoPtr_transformId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkinData>.NativeClassPtr, "transformId");
		NativeFieldInfoPtr_boneTransformId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkinData>.NativeClassPtr, "boneTransformId");
	}

	public SpriteSkinData(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public SpriteSkinData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteSkinData>.NativeClassPtr))
	{
	}
}
