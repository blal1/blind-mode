using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class BillboardAsset : Object
{
	private delegate void Internal_CreateDelegate(System.IntPtr obj);

	private delegate float get_width_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_width_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_height_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_height_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_bottom_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_bottom_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate int get_imageCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_vertexCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_indexCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr get_material_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_material_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate void GetImageTexCoords_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void GetImageTexCoordsInternal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr list);

	private delegate void SetImageTexCoords_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr imageTexCoords);

	private delegate void SetImageTexCoordsInternalList_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr list);

	private delegate void GetVertices_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void GetVerticesInternal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr list);

	private delegate void SetVertices_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr vertices);

	private delegate void SetVerticesInternalList_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr list);

	private delegate void GetIndices_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void GetIndicesInternal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr list);

	private delegate void SetIndices_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr indices);

	private delegate void SetIndicesInternalList_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr list);

	private delegate void MakeMaterialProperties_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr properties, System.IntPtr camera);

	private static readonly Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<Internal_CreateDelegate>("UnityEngine.BillboardAsset::Internal_Create");

	private static readonly get_width_InjectedDelegate get_width_InjectedDelegateField = IL2CPP.ResolveICall<get_width_InjectedDelegate>("UnityEngine.BillboardAsset::get_width_Injected");

	private static readonly set_width_InjectedDelegate set_width_InjectedDelegateField = IL2CPP.ResolveICall<set_width_InjectedDelegate>("UnityEngine.BillboardAsset::set_width_Injected");

	private static readonly get_height_InjectedDelegate get_height_InjectedDelegateField = IL2CPP.ResolveICall<get_height_InjectedDelegate>("UnityEngine.BillboardAsset::get_height_Injected");

	private static readonly set_height_InjectedDelegate set_height_InjectedDelegateField = IL2CPP.ResolveICall<set_height_InjectedDelegate>("UnityEngine.BillboardAsset::set_height_Injected");

	private static readonly get_bottom_InjectedDelegate get_bottom_InjectedDelegateField = IL2CPP.ResolveICall<get_bottom_InjectedDelegate>("UnityEngine.BillboardAsset::get_bottom_Injected");

	private static readonly set_bottom_InjectedDelegate set_bottom_InjectedDelegateField = IL2CPP.ResolveICall<set_bottom_InjectedDelegate>("UnityEngine.BillboardAsset::set_bottom_Injected");

	private static readonly get_imageCount_InjectedDelegate get_imageCount_InjectedDelegateField = IL2CPP.ResolveICall<get_imageCount_InjectedDelegate>("UnityEngine.BillboardAsset::get_imageCount_Injected");

	private static readonly get_vertexCount_InjectedDelegate get_vertexCount_InjectedDelegateField = IL2CPP.ResolveICall<get_vertexCount_InjectedDelegate>("UnityEngine.BillboardAsset::get_vertexCount_Injected");

	private static readonly get_indexCount_InjectedDelegate get_indexCount_InjectedDelegateField = IL2CPP.ResolveICall<get_indexCount_InjectedDelegate>("UnityEngine.BillboardAsset::get_indexCount_Injected");

	private static readonly get_material_InjectedDelegate get_material_InjectedDelegateField = IL2CPP.ResolveICall<get_material_InjectedDelegate>("UnityEngine.BillboardAsset::get_material_Injected");

	private static readonly set_material_InjectedDelegate set_material_InjectedDelegateField = IL2CPP.ResolveICall<set_material_InjectedDelegate>("UnityEngine.BillboardAsset::set_material_Injected");

	private static readonly GetImageTexCoords_InjectedDelegate GetImageTexCoords_InjectedDelegateField = IL2CPP.ResolveICall<GetImageTexCoords_InjectedDelegate>("UnityEngine.BillboardAsset::GetImageTexCoords_Injected");

	private static readonly GetImageTexCoordsInternal_InjectedDelegate GetImageTexCoordsInternal_InjectedDelegateField = IL2CPP.ResolveICall<GetImageTexCoordsInternal_InjectedDelegate>("UnityEngine.BillboardAsset::GetImageTexCoordsInternal_Injected");

	private static readonly SetImageTexCoords_InjectedDelegate SetImageTexCoords_InjectedDelegateField = IL2CPP.ResolveICall<SetImageTexCoords_InjectedDelegate>("UnityEngine.BillboardAsset::SetImageTexCoords_Injected");

	private static readonly SetImageTexCoordsInternalList_InjectedDelegate SetImageTexCoordsInternalList_InjectedDelegateField = IL2CPP.ResolveICall<SetImageTexCoordsInternalList_InjectedDelegate>("UnityEngine.BillboardAsset::SetImageTexCoordsInternalList_Injected");

	private static readonly GetVertices_InjectedDelegate GetVertices_InjectedDelegateField = IL2CPP.ResolveICall<GetVertices_InjectedDelegate>("UnityEngine.BillboardAsset::GetVertices_Injected");

	private static readonly GetVerticesInternal_InjectedDelegate GetVerticesInternal_InjectedDelegateField = IL2CPP.ResolveICall<GetVerticesInternal_InjectedDelegate>("UnityEngine.BillboardAsset::GetVerticesInternal_Injected");

	private static readonly SetVertices_InjectedDelegate SetVertices_InjectedDelegateField = IL2CPP.ResolveICall<SetVertices_InjectedDelegate>("UnityEngine.BillboardAsset::SetVertices_Injected");

	private static readonly SetVerticesInternalList_InjectedDelegate SetVerticesInternalList_InjectedDelegateField = IL2CPP.ResolveICall<SetVerticesInternalList_InjectedDelegate>("UnityEngine.BillboardAsset::SetVerticesInternalList_Injected");

	private static readonly GetIndices_InjectedDelegate GetIndices_InjectedDelegateField = IL2CPP.ResolveICall<GetIndices_InjectedDelegate>("UnityEngine.BillboardAsset::GetIndices_Injected");

	private static readonly GetIndicesInternal_InjectedDelegate GetIndicesInternal_InjectedDelegateField = IL2CPP.ResolveICall<GetIndicesInternal_InjectedDelegate>("UnityEngine.BillboardAsset::GetIndicesInternal_Injected");

	private static readonly SetIndices_InjectedDelegate SetIndices_InjectedDelegateField = IL2CPP.ResolveICall<SetIndices_InjectedDelegate>("UnityEngine.BillboardAsset::SetIndices_Injected");

	private static readonly SetIndicesInternalList_InjectedDelegate SetIndicesInternalList_InjectedDelegateField = IL2CPP.ResolveICall<SetIndicesInternalList_InjectedDelegate>("UnityEngine.BillboardAsset::SetIndicesInternalList_Injected");

	private static readonly MakeMaterialProperties_InjectedDelegate MakeMaterialProperties_InjectedDelegateField = IL2CPP.ResolveICall<MakeMaterialProperties_InjectedDelegate>("UnityEngine.BillboardAsset::MakeMaterialProperties_Injected");

	public float width
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_width_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_width_Injected(intPtr, value);
		}
	}

	public float height
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_height_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_height_Injected(intPtr, value);
		}
	}

	public float bottom
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_bottom_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_bottom_Injected(intPtr, value);
		}
	}

	public int imageCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_imageCount_Injected(intPtr);
		}
	}

	public int vertexCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_vertexCount_Injected(intPtr);
		}
	}

	public int indexCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_indexCount_Injected(intPtr);
		}
	}

	public Material material
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Material>(get_material_Injected(intPtr));
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_material_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public static void Internal_Create(BillboardAsset obj)
	{
		Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
	}

	public void GetImageTexCoords(List<Vector4> imageTexCoords)
	{
		if (imageTexCoords == null)
		{
			throw new Il2CppSystem.ArgumentNullException("imageTexCoords");
		}
		GetImageTexCoordsInternal(imageTexCoords);
	}

	public unsafe Il2CppStructArray<Vector4> GetImageTexCoords()
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<Vector4> result;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetImageTexCoords_Injected(intPtr, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<Vector4> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<Vector4>*)(&array));
			result = array;
		}
		return result;
	}

	public void GetImageTexCoordsInternal(Il2CppSystem.Object list)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetImageTexCoordsInternal_Injected(intPtr, list);
	}

	public void SetImageTexCoords(List<Vector4> imageTexCoords)
	{
		if (imageTexCoords == null)
		{
			throw new Il2CppSystem.ArgumentNullException("imageTexCoords");
		}
		SetImageTexCoordsInternalList(imageTexCoords);
	}

	public unsafe void SetImageTexCoords(Il2CppStructArray<Vector4> imageTexCoords)
	{
		//IL_0027: Expected O, but got Ref
		//IL_002e: Expected O, but got Ref
		//IL_003a: Expected O, but got Ref
		if (imageTexCoords == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)imageTexCoords, "imageTexCoords");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<Vector4> span);
		((Il2CppSystem.Span<Vector4>)(&span))._002Ector((Il2CppArrayBase<Vector4>)(object)imageTexCoords);
		fixed (Vector4* begin = &((Il2CppSystem.Span<Vector4>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper imageTexCoords2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Vector4>)(&span)).Length);
			SetImageTexCoords_Injected(intPtr, ref imageTexCoords2);
		}
	}

	public void SetImageTexCoordsInternalList(Il2CppSystem.Object list)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetImageTexCoordsInternalList_Injected(intPtr, list);
	}

	public void GetVertices(List<Vector2> vertices)
	{
		if (vertices == null)
		{
			throw new Il2CppSystem.ArgumentNullException("vertices");
		}
		GetVerticesInternal(vertices);
	}

	public unsafe Il2CppStructArray<Vector2> GetVertices()
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<Vector2> result;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetVertices_Injected(intPtr, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<Vector2> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<Vector2>*)(&array));
			result = array;
		}
		return result;
	}

	public void GetVerticesInternal(Il2CppSystem.Object list)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetVerticesInternal_Injected(intPtr, list);
	}

	public void SetVertices(List<Vector2> vertices)
	{
		if (vertices == null)
		{
			throw new Il2CppSystem.ArgumentNullException("vertices");
		}
		SetVerticesInternalList(vertices);
	}

	public unsafe void SetVertices(Il2CppStructArray<Vector2> vertices)
	{
		//IL_0027: Expected O, but got Ref
		//IL_002e: Expected O, but got Ref
		//IL_003a: Expected O, but got Ref
		if (vertices == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)vertices, "vertices");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<Vector2> span);
		((Il2CppSystem.Span<Vector2>)(&span))._002Ector((Il2CppArrayBase<Vector2>)(object)vertices);
		fixed (Vector2* begin = &((Il2CppSystem.Span<Vector2>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper vertices2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Vector2>)(&span)).Length);
			SetVertices_Injected(intPtr, ref vertices2);
		}
	}

	public void SetVerticesInternalList(Il2CppSystem.Object list)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetVerticesInternalList_Injected(intPtr, list);
	}

	public void GetIndices(List<ushort> indices)
	{
		if (indices == null)
		{
			throw new Il2CppSystem.ArgumentNullException("indices");
		}
		GetIndicesInternal(indices);
	}

	public unsafe Il2CppStructArray<ushort> GetIndices()
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<ushort> result;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetIndices_Injected(intPtr, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<ushort> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<ushort>*)(&array));
			result = array;
		}
		return result;
	}

	public void GetIndicesInternal(Il2CppSystem.Object list)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetIndicesInternal_Injected(intPtr, list);
	}

	public void SetIndices(List<ushort> indices)
	{
		if (indices == null)
		{
			throw new Il2CppSystem.ArgumentNullException("indices");
		}
		SetIndicesInternalList(indices);
	}

	public unsafe void SetIndices(Il2CppStructArray<ushort> indices)
	{
		//IL_0027: Expected O, but got Ref
		//IL_002e: Expected O, but got Ref
		//IL_003a: Expected O, but got Ref
		if (indices == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)indices, "indices");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<ushort> span);
		((Il2CppSystem.Span<ushort>)(&span))._002Ector((Il2CppArrayBase<ushort>)(object)indices);
		fixed (ushort* begin = &((Il2CppSystem.Span<ushort>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper indices2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<ushort>)(&span)).Length);
			SetIndices_Injected(intPtr, ref indices2);
		}
	}

	public void SetIndicesInternalList(Il2CppSystem.Object list)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetIndicesInternalList_Injected(intPtr, list);
	}

	public void MakeMaterialProperties(MaterialPropertyBlock properties, Camera camera)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		MakeMaterialProperties_Injected(intPtr, (properties == null) ? ((System.IntPtr)0) : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties), MarshalledUnityObject.Marshal(camera));
	}

	public static float get_width_Injected(System.IntPtr _unity_self)
	{
		return get_width_InjectedDelegateField(_unity_self);
	}

	public static void set_width_Injected(System.IntPtr _unity_self, float value)
	{
		set_width_InjectedDelegateField(_unity_self, value);
	}

	public static float get_height_Injected(System.IntPtr _unity_self)
	{
		return get_height_InjectedDelegateField(_unity_self);
	}

	public static void set_height_Injected(System.IntPtr _unity_self, float value)
	{
		set_height_InjectedDelegateField(_unity_self, value);
	}

	public static float get_bottom_Injected(System.IntPtr _unity_self)
	{
		return get_bottom_InjectedDelegateField(_unity_self);
	}

	public static void set_bottom_Injected(System.IntPtr _unity_self, float value)
	{
		set_bottom_InjectedDelegateField(_unity_self, value);
	}

	public static int get_imageCount_Injected(System.IntPtr _unity_self)
	{
		return get_imageCount_InjectedDelegateField(_unity_self);
	}

	public static int get_vertexCount_Injected(System.IntPtr _unity_self)
	{
		return get_vertexCount_InjectedDelegateField(_unity_self);
	}

	public static int get_indexCount_Injected(System.IntPtr _unity_self)
	{
		return get_indexCount_InjectedDelegateField(_unity_self);
	}

	public static System.IntPtr get_material_Injected(System.IntPtr _unity_self)
	{
		return get_material_InjectedDelegateField(_unity_self);
	}

	public static void set_material_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_material_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void GetImageTexCoords_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		GetImageTexCoords_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static void GetImageTexCoordsInternal_Injected(System.IntPtr _unity_self, Il2CppSystem.Object list)
	{
		GetImageTexCoordsInternal_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
	}

	public unsafe static void SetImageTexCoords_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper imageTexCoords)
	{
		SetImageTexCoords_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref imageTexCoords));
	}

	public static void SetImageTexCoordsInternalList_Injected(System.IntPtr _unity_self, Il2CppSystem.Object list)
	{
		SetImageTexCoordsInternalList_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
	}

	public unsafe static void GetVertices_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		GetVertices_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static void GetVerticesInternal_Injected(System.IntPtr _unity_self, Il2CppSystem.Object list)
	{
		GetVerticesInternal_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
	}

	public unsafe static void SetVertices_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper vertices)
	{
		SetVertices_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref vertices));
	}

	public static void SetVerticesInternalList_Injected(System.IntPtr _unity_self, Il2CppSystem.Object list)
	{
		SetVerticesInternalList_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
	}

	public unsafe static void GetIndices_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		GetIndices_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static void GetIndicesInternal_Injected(System.IntPtr _unity_self, Il2CppSystem.Object list)
	{
		GetIndicesInternal_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
	}

	public unsafe static void SetIndices_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper indices)
	{
		SetIndices_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref indices));
	}

	public static void SetIndicesInternalList_Injected(System.IntPtr _unity_self, Il2CppSystem.Object list)
	{
		SetIndicesInternalList_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
	}

	public static void MakeMaterialProperties_Injected(System.IntPtr _unity_self, System.IntPtr properties, System.IntPtr camera)
	{
		MakeMaterialProperties_InjectedDelegateField(_unity_self, properties, camera);
	}
}
