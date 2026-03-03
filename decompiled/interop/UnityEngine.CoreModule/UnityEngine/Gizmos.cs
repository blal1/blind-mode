using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class Gizmos : Il2CppSystem.Object
{
	private delegate float get_probeSizeDelegate();

	private delegate void DrawLineStrip_InjectedDelegate(System.IntPtr points, bool looped);

	private delegate void DrawLineListInternal_InjectedDelegate(System.IntPtr points);

	private delegate void DrawWireSphere_InjectedDelegate([In] System.IntPtr center, float radius);

	private delegate void DrawSphere_InjectedDelegate([In] System.IntPtr center, float radius);

	private delegate void DrawWireCube_InjectedDelegate([In] System.IntPtr center, [In] System.IntPtr size);

	private delegate void DrawCube_InjectedDelegate([In] System.IntPtr center, [In] System.IntPtr size);

	private delegate void DrawMesh_InjectedDelegate(System.IntPtr mesh, int submeshIndex, [In] System.IntPtr position, [In] System.IntPtr rotation, [In] System.IntPtr scale);

	private delegate void DrawWireMesh_InjectedDelegate(System.IntPtr mesh, int submeshIndex, [In] System.IntPtr position, [In] System.IntPtr rotation, [In] System.IntPtr scale);

	private delegate void DrawGUITexture_InjectedDelegate([In] System.IntPtr screenRect, System.IntPtr texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, System.IntPtr mat);

	private delegate void get_color_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void get_matrix_InjectedDelegate([Out] System.IntPtr ret);

	private delegate System.IntPtr get_exposure_InjectedDelegate();

	private delegate void set_exposure_InjectedDelegate(System.IntPtr value);

	private delegate void DrawFrustum_InjectedDelegate([In] System.IntPtr center, float fov, float maxRange, float minRange, float aspect);

	private delegate float CalculateLOD_InjectedDelegate([In] System.IntPtr position, float radius);

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawIcon_Public_Static_Void_Vector3_String_Boolean_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_matrix_Public_Static_set_Void_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawIcon_Injected_Private_Static_Void_byref_Vector3_byref_ManagedSpanWrapper_Boolean_byref_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_matrix_Injected_Private_Static_Void_byref_Matrix4x4_0;

	private static readonly get_probeSizeDelegate get_probeSizeDelegateField;

	private static readonly DrawLineStrip_InjectedDelegate DrawLineStrip_InjectedDelegateField;

	private static readonly DrawLineListInternal_InjectedDelegate DrawLineListInternal_InjectedDelegateField;

	private static readonly DrawWireSphere_InjectedDelegate DrawWireSphere_InjectedDelegateField;

	private static readonly DrawSphere_InjectedDelegate DrawSphere_InjectedDelegateField;

	private static readonly DrawWireCube_InjectedDelegate DrawWireCube_InjectedDelegateField;

	private static readonly DrawCube_InjectedDelegate DrawCube_InjectedDelegateField;

	private static readonly DrawMesh_InjectedDelegate DrawMesh_InjectedDelegateField;

	private static readonly DrawWireMesh_InjectedDelegate DrawWireMesh_InjectedDelegateField;

	private static readonly DrawGUITexture_InjectedDelegate DrawGUITexture_InjectedDelegateField;

	private static readonly get_color_InjectedDelegate get_color_InjectedDelegateField;

	private static readonly get_matrix_InjectedDelegate get_matrix_InjectedDelegateField;

	private static readonly get_exposure_InjectedDelegate get_exposure_InjectedDelegateField;

	private static readonly set_exposure_InjectedDelegate set_exposure_InjectedDelegateField;

	private static readonly DrawFrustum_InjectedDelegate DrawFrustum_InjectedDelegateField;

	private static readonly CalculateLOD_InjectedDelegate CalculateLOD_InjectedDelegateField;

	public unsafe static Color color
	{
		get
		{
			get_color_Injected(out var ret);
			return ret;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1171914, RefRangeEnd = 1171916, XrefRangeStart = 1171912, XrefRangeEnd = 1171914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static Matrix4x4 matrix
	{
		get
		{
			get_matrix_Injected(out var ret);
			return ret;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1171918, RefRangeEnd = 1171919, XrefRangeStart = 1171916, XrefRangeEnd = 1171918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_matrix_Public_Static_set_Void_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public static Texture exposure
	{
		get
		{
			return Unmarshal.UnmarshalUnityObject<Texture>(get_exposure_Injected());
		}
		set
		{
			set_exposure_Injected(Object.MarshalledUnityObject.Marshal(value));
		}
	}

	public static float probeSize => get_probeSizeDelegateField();

	static Gizmos()
	{
		Il2CppClassPointerStore<Gizmos>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Gizmos");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gizmos>.NativeClassPtr);
		NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664272);
		NativeMethodInfoPtr_DrawIcon_Public_Static_Void_Vector3_String_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664273);
		NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664274);
		NativeMethodInfoPtr_set_matrix_Public_Static_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664275);
		NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664276);
		NativeMethodInfoPtr_DrawIcon_Injected_Private_Static_Void_byref_Vector3_byref_ManagedSpanWrapper_Boolean_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664277);
		NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664278);
		NativeMethodInfoPtr_set_matrix_Injected_Private_Static_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664279);
		get_probeSizeDelegateField = IL2CPP.ResolveICall<get_probeSizeDelegate>("UnityEngine.Gizmos::get_probeSize");
		DrawLineStrip_InjectedDelegateField = IL2CPP.ResolveICall<DrawLineStrip_InjectedDelegate>("UnityEngine.Gizmos::DrawLineStrip_Injected");
		DrawLineListInternal_InjectedDelegateField = IL2CPP.ResolveICall<DrawLineListInternal_InjectedDelegate>("UnityEngine.Gizmos::DrawLineListInternal_Injected");
		DrawWireSphere_InjectedDelegateField = IL2CPP.ResolveICall<DrawWireSphere_InjectedDelegate>("UnityEngine.Gizmos::DrawWireSphere_Injected");
		DrawSphere_InjectedDelegateField = IL2CPP.ResolveICall<DrawSphere_InjectedDelegate>("UnityEngine.Gizmos::DrawSphere_Injected");
		DrawWireCube_InjectedDelegateField = IL2CPP.ResolveICall<DrawWireCube_InjectedDelegate>("UnityEngine.Gizmos::DrawWireCube_Injected");
		DrawCube_InjectedDelegateField = IL2CPP.ResolveICall<DrawCube_InjectedDelegate>("UnityEngine.Gizmos::DrawCube_Injected");
		DrawMesh_InjectedDelegateField = IL2CPP.ResolveICall<DrawMesh_InjectedDelegate>("UnityEngine.Gizmos::DrawMesh_Injected");
		DrawWireMesh_InjectedDelegateField = IL2CPP.ResolveICall<DrawWireMesh_InjectedDelegate>("UnityEngine.Gizmos::DrawWireMesh_Injected");
		DrawGUITexture_InjectedDelegateField = IL2CPP.ResolveICall<DrawGUITexture_InjectedDelegate>("UnityEngine.Gizmos::DrawGUITexture_Injected");
		get_color_InjectedDelegateField = IL2CPP.ResolveICall<get_color_InjectedDelegate>("UnityEngine.Gizmos::get_color_Injected");
		get_matrix_InjectedDelegateField = IL2CPP.ResolveICall<get_matrix_InjectedDelegate>("UnityEngine.Gizmos::get_matrix_Injected");
		get_exposure_InjectedDelegateField = IL2CPP.ResolveICall<get_exposure_InjectedDelegate>("UnityEngine.Gizmos::get_exposure_Injected");
		set_exposure_InjectedDelegateField = IL2CPP.ResolveICall<set_exposure_InjectedDelegate>("UnityEngine.Gizmos::set_exposure_Injected");
		DrawFrustum_InjectedDelegateField = IL2CPP.ResolveICall<DrawFrustum_InjectedDelegate>("UnityEngine.Gizmos::DrawFrustum_Injected");
		CalculateLOD_InjectedDelegateField = IL2CPP.ResolveICall<CalculateLOD_InjectedDelegate>("UnityEngine.Gizmos::CalculateLOD_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1171895, RefRangeEnd = 1171896, XrefRangeStart = 1171893, XrefRangeEnd = 1171895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawLine(Vector3 from, Vector3 to)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&from);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1171910, RefRangeEnd = 1171912, XrefRangeStart = 1171896, XrefRangeEnd = 1171910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawIcon(Vector3 center, string name, bool allowScaling, Color tint)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&center);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowScaling;
		*(Color**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &tint;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawIcon_Public_Static_Void_Vector3_String_Boolean_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171919, XrefRangeEnd = 1171921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawLine_Injected([In] ref Vector3 from, [In] ref Vector3 to)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref from);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref to);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171921, XrefRangeEnd = 1171923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawIcon_Injected([In] ref Vector3 center, ref ManagedSpanWrapper name, bool allowScaling, [In] ref Color tint)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref center);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref name);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowScaling;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref tint);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawIcon_Injected_Private_Static_Void_byref_Vector3_byref_ManagedSpanWrapper_Boolean_byref_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171923, XrefRangeEnd = 1171925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_color_Injected([In] ref Color value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171925, XrefRangeEnd = 1171927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_matrix_Injected([In] ref Matrix4x4 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_matrix_Injected_Private_Static_Void_byref_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Gizmos(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static void DrawLineStrip(Il2CppSystem.ReadOnlySpan<Vector3> points, bool looped)
	{
		//IL_0009: Expected O, but got Ref
		//IL_0015: Expected O, but got Ref
		Il2CppSystem.ReadOnlySpan<Vector3> readOnlySpan = points;
		fixed (Vector3* begin = &((Il2CppSystem.ReadOnlySpan<Vector3>)(&readOnlySpan)).GetPinnableReference())
		{
			ManagedSpanWrapper points2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<Vector3>)(&readOnlySpan)).Length);
			DrawLineStrip_Injected(ref points2, looped);
		}
	}

	public unsafe static void DrawLineListInternal(Il2CppSystem.ReadOnlySpan<Vector3> points)
	{
		//IL_0009: Expected O, but got Ref
		//IL_0015: Expected O, but got Ref
		Il2CppSystem.ReadOnlySpan<Vector3> readOnlySpan = points;
		fixed (Vector3* begin = &((Il2CppSystem.ReadOnlySpan<Vector3>)(&readOnlySpan)).GetPinnableReference())
		{
			ManagedSpanWrapper points2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<Vector3>)(&readOnlySpan)).Length);
			DrawLineListInternal_Injected(ref points2);
		}
	}

	public unsafe static void DrawLineList(Il2CppSystem.ReadOnlySpan<Vector3> points)
	{
		//IL_0008: Expected O, but got Ref
		if (((uint)((Il2CppSystem.ReadOnlySpan<Vector3>)(&points)).Length & (true ? 1u : 0u)) != 0)
		{
			throw new UnityException("You cannot draw a line list from an odd number of points, with two points per line the number of points must be even");
		}
		DrawLineListInternal(points);
	}

	public static void DrawWireSphere(Vector3 center, float radius)
	{
		DrawWireSphere_Injected(ref center, radius);
	}

	public static void DrawSphere(Vector3 center, float radius)
	{
		DrawSphere_Injected(ref center, radius);
	}

	public static void DrawWireCube(Vector3 center, Vector3 size)
	{
		DrawWireCube_Injected(ref center, ref size);
	}

	public static void DrawCube(Vector3 center, Vector3 size)
	{
		DrawCube_Injected(ref center, ref size);
	}

	public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale)
	{
		DrawMesh_Injected(Object.MarshalledUnityObject.Marshal(mesh), submeshIndex, ref position, ref rotation, ref scale);
	}

	public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale)
	{
		DrawWireMesh_Injected(Object.MarshalledUnityObject.Marshal(mesh), submeshIndex, ref position, ref rotation, ref scale);
	}

	public static void DrawIcon(Vector3 center, string name, bool allowScaling)
	{
		DrawIcon(center, name, allowScaling, Color.white);
	}

	public static void DrawGUITexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat)
	{
		DrawGUITexture_Injected(ref screenRect, Object.MarshalledUnityObject.Marshal(texture), leftBorder, rightBorder, topBorder, bottomBorder, Object.MarshalledUnityObject.Marshal(mat));
	}

	public static void DrawFrustum(Vector3 center, float fov, float maxRange, float minRange, float aspect)
	{
		DrawFrustum_Injected(ref center, fov, maxRange, minRange, aspect);
	}

	public static float CalculateLOD(Vector3 position, float radius)
	{
		return CalculateLOD_Injected(ref position, radius);
	}

	public static void DrawRay(Ray r)
	{
		DrawLine(r.origin, r.origin + r.direction);
	}

	public static void DrawRay(Vector3 from, Vector3 direction)
	{
		DrawLine(from, from + direction);
	}

	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation)
	{
		Vector3 one = Vector3.one;
		DrawMesh(mesh, position, rotation, one);
	}

	public static void DrawMesh(Mesh mesh, Vector3 position)
	{
		Vector3 one = Vector3.one;
		Quaternion identity = Quaternion.identity;
		DrawMesh(mesh, position, identity, one);
	}

	public static void DrawMesh(Mesh mesh)
	{
		Vector3 one = Vector3.one;
		Quaternion identity = Quaternion.identity;
		Vector3 zero = Vector3.zero;
		DrawMesh(mesh, zero, identity, one);
	}

	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale)
	{
		DrawMesh(mesh, -1, position, rotation, scale);
	}

	public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation)
	{
		Vector3 one = Vector3.one;
		DrawMesh(mesh, submeshIndex, position, rotation, one);
	}

	public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position)
	{
		Vector3 one = Vector3.one;
		Quaternion identity = Quaternion.identity;
		DrawMesh(mesh, submeshIndex, position, identity, one);
	}

	public static void DrawMesh(Mesh mesh, int submeshIndex)
	{
		Vector3 one = Vector3.one;
		Quaternion identity = Quaternion.identity;
		Vector3 zero = Vector3.zero;
		DrawMesh(mesh, submeshIndex, zero, identity, one);
	}

	public static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation)
	{
		Vector3 one = Vector3.one;
		DrawWireMesh(mesh, position, rotation, one);
	}

	public static void DrawWireMesh(Mesh mesh, Vector3 position)
	{
		Vector3 one = Vector3.one;
		Quaternion identity = Quaternion.identity;
		DrawWireMesh(mesh, position, identity, one);
	}

	public static void DrawWireMesh(Mesh mesh)
	{
		Vector3 one = Vector3.one;
		Quaternion identity = Quaternion.identity;
		Vector3 zero = Vector3.zero;
		DrawWireMesh(mesh, zero, identity, one);
	}

	public static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale)
	{
		DrawWireMesh(mesh, -1, position, rotation, scale);
	}

	public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation)
	{
		Vector3 one = Vector3.one;
		DrawWireMesh(mesh, submeshIndex, position, rotation, one);
	}

	public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position)
	{
		Vector3 one = Vector3.one;
		Quaternion identity = Quaternion.identity;
		DrawWireMesh(mesh, submeshIndex, position, identity, one);
	}

	public static void DrawWireMesh(Mesh mesh, int submeshIndex)
	{
		Vector3 one = Vector3.one;
		Quaternion identity = Quaternion.identity;
		Vector3 zero = Vector3.zero;
		DrawWireMesh(mesh, submeshIndex, zero, identity, one);
	}

	public static void DrawIcon(Vector3 center, string name)
	{
		bool allowScaling = true;
		DrawIcon(center, name, allowScaling);
	}

	public static void DrawGUITexture(Rect screenRect, Texture texture)
	{
		Material mat = null;
		DrawGUITexture(screenRect, texture, mat);
	}

	public static void DrawGUITexture(Rect screenRect, Texture texture, Material mat)
	{
		DrawGUITexture(screenRect, texture, 0, 0, 0, 0, mat);
	}

	public static void DrawGUITexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
	{
		Material mat = null;
		DrawGUITexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat);
	}

	public unsafe static void DrawLineStrip_Injected(ref ManagedSpanWrapper points, bool looped)
	{
		DrawLineStrip_InjectedDelegateField((nint)Unsafe.AsPointer(ref points), looped);
	}

	public unsafe static void DrawLineListInternal_Injected(ref ManagedSpanWrapper points)
	{
		DrawLineListInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref points));
	}

	public unsafe static void DrawWireSphere_Injected([In] ref Vector3 center, float radius)
	{
		DrawWireSphere_InjectedDelegateField((nint)Unsafe.AsPointer(ref center), radius);
	}

	public unsafe static void DrawSphere_Injected([In] ref Vector3 center, float radius)
	{
		DrawSphere_InjectedDelegateField((nint)Unsafe.AsPointer(ref center), radius);
	}

	public unsafe static void DrawWireCube_Injected([In] ref Vector3 center, [In] ref Vector3 size)
	{
		DrawWireCube_InjectedDelegateField((nint)Unsafe.AsPointer(ref center), (nint)Unsafe.AsPointer(ref size));
	}

	public unsafe static void DrawCube_Injected([In] ref Vector3 center, [In] ref Vector3 size)
	{
		DrawCube_InjectedDelegateField((nint)Unsafe.AsPointer(ref center), (nint)Unsafe.AsPointer(ref size));
	}

	public unsafe static void DrawMesh_Injected(System.IntPtr mesh, int submeshIndex, [In] ref Vector3 position, [In] ref Quaternion rotation, [In] ref Vector3 scale)
	{
		DrawMesh_InjectedDelegateField(mesh, submeshIndex, (nint)Unsafe.AsPointer(ref position), (nint)Unsafe.AsPointer(ref rotation), (nint)Unsafe.AsPointer(ref scale));
	}

	public unsafe static void DrawWireMesh_Injected(System.IntPtr mesh, int submeshIndex, [In] ref Vector3 position, [In] ref Quaternion rotation, [In] ref Vector3 scale)
	{
		DrawWireMesh_InjectedDelegateField(mesh, submeshIndex, (nint)Unsafe.AsPointer(ref position), (nint)Unsafe.AsPointer(ref rotation), (nint)Unsafe.AsPointer(ref scale));
	}

	public unsafe static void DrawGUITexture_Injected([In] ref Rect screenRect, System.IntPtr texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, System.IntPtr mat)
	{
		DrawGUITexture_InjectedDelegateField((nint)Unsafe.AsPointer(ref screenRect), texture, leftBorder, rightBorder, topBorder, bottomBorder, mat);
	}

	public unsafe static void get_color_Injected(out Color ret)
	{
		get_color_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_matrix_Injected(out Matrix4x4 ret)
	{
		get_matrix_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public static System.IntPtr get_exposure_Injected()
	{
		return get_exposure_InjectedDelegateField();
	}

	public static void set_exposure_Injected(System.IntPtr value)
	{
		set_exposure_InjectedDelegateField(value);
	}

	public unsafe static void DrawFrustum_Injected([In] ref Vector3 center, float fov, float maxRange, float minRange, float aspect)
	{
		DrawFrustum_InjectedDelegateField((nint)Unsafe.AsPointer(ref center), fov, maxRange, minRange, aspect);
	}

	public unsafe static float CalculateLOD_Injected([In] ref Vector3 position, float radius)
	{
		return CalculateLOD_InjectedDelegateField((nint)Unsafe.AsPointer(ref position), radius);
	}
}
