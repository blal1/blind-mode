using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public sealed class GL : Il2CppSystem.Object
{
	private delegate void VerticesDelegate(System.IntPtr v, System.IntPtr coords, System.IntPtr colors, int length);

	private delegate void MultiTexCoord3Delegate(int unit, float x, float y, float z);

	private delegate void set_wireframeDelegate(bool value);

	private delegate bool get_sRGBWriteDelegate();

	private delegate void set_sRGBWriteDelegate(bool value);

	private delegate bool get_invertCullingDelegate();

	private delegate void set_invertCullingDelegate(bool value);

	private delegate void FlushDelegate();

	private delegate void RenderTargetBarrierDelegate();

	private delegate void IssuePluginEventDelegate(int eventID);

	private delegate void SetRevertBackfacingDelegate(bool revertBackFaces);

	private delegate void LoadIdentityDelegate();

	private delegate void LoadPixelMatrixDelegate();

	private delegate void InvalidateStateDelegate();

	private delegate void GLIssuePluginEventDelegate(System.IntPtr callback, int eventID);

	private delegate void GetWorldViewMatrix_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void MultMatrix_InjectedDelegate([In] System.IntPtr m);

	private delegate void ClearWithSkybox_InjectedDelegate(bool clearDepth, System.IntPtr camera);

	private static readonly System.IntPtr NativeMethodInfoPtr_Vertex3_Public_Static_Void_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TexCoord3_Public_Static_Void_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TexCoord2_Public_Static_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImmediateColor_Private_Static_Void_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Color_Public_Static_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_wireframe_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetViewMatrix_Private_Static_Void_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_modelview_Public_Static_set_Void_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PushMatrix_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopMatrix_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadOrtho_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadProjectionMatrix_Public_Static_Void_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GLLoadPixelMatrixScript_Private_Static_Void_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadPixelMatrix_Public_Static_Void_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Begin_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_End_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GLClear_Private_Static_Void_Boolean_Boolean_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Viewport_Public_Static_Void_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetViewMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGPUProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_Boolean_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GLClear_Injected_Private_Static_Void_Boolean_Boolean_byref_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Viewport_Injected_Private_Static_Void_byref_Rect_0;

	public const int TRIANGLES = 4;

	public const int TRIANGLE_STRIP = 5;

	public const int QUADS = 7;

	public const int LINES = 1;

	public const int LINE_STRIP = 2;

	private static readonly VerticesDelegate VerticesDelegateField;

	private static readonly MultiTexCoord3Delegate MultiTexCoord3DelegateField;

	private static readonly set_wireframeDelegate set_wireframeDelegateField;

	private static readonly get_sRGBWriteDelegate get_sRGBWriteDelegateField;

	private static readonly set_sRGBWriteDelegate set_sRGBWriteDelegateField;

	private static readonly get_invertCullingDelegate get_invertCullingDelegateField;

	private static readonly set_invertCullingDelegate set_invertCullingDelegateField;

	private static readonly FlushDelegate FlushDelegateField;

	private static readonly RenderTargetBarrierDelegate RenderTargetBarrierDelegateField;

	private static readonly IssuePluginEventDelegate IssuePluginEventDelegateField;

	private static readonly SetRevertBackfacingDelegate SetRevertBackfacingDelegateField;

	private static readonly LoadIdentityDelegate LoadIdentityDelegateField;

	private static readonly LoadPixelMatrixDelegate LoadPixelMatrixDelegateField;

	private static readonly InvalidateStateDelegate InvalidateStateDelegateField;

	private static readonly GLIssuePluginEventDelegate GLIssuePluginEventDelegateField;

	private static readonly GetWorldViewMatrix_InjectedDelegate GetWorldViewMatrix_InjectedDelegateField;

	private static readonly MultMatrix_InjectedDelegate MultMatrix_InjectedDelegateField;

	private static readonly ClearWithSkybox_InjectedDelegate ClearWithSkybox_InjectedDelegateField;

	public unsafe static bool wireframe
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1173191, RefRangeEnd = 1173194, XrefRangeStart = 1173189, XrefRangeEnd = 1173191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wireframe_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_wireframeDelegateField(value);
		}
	}

	public unsafe static Matrix4x4 modelview
	{
		get
		{
			return GetWorldViewMatrix();
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1173198, RefRangeEnd = 1173201, XrefRangeStart = 1173196, XrefRangeEnd = 1173198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_modelview_Public_Static_set_Void_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public static bool sRGBWrite
	{
		get
		{
			return get_sRGBWriteDelegateField();
		}
		set
		{
			set_sRGBWriteDelegateField(value);
		}
	}

	public static bool invertCulling
	{
		get
		{
			return get_invertCullingDelegateField();
		}
		set
		{
			set_invertCullingDelegateField(value);
		}
	}

	static GL()
	{
		Il2CppClassPointerStore<GL>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "GL");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GL>.NativeClassPtr);
		NativeMethodInfoPtr_Vertex3_Public_Static_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664399);
		NativeMethodInfoPtr_TexCoord3_Public_Static_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664400);
		NativeMethodInfoPtr_TexCoord2_Public_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664401);
		NativeMethodInfoPtr_ImmediateColor_Private_Static_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664402);
		NativeMethodInfoPtr_Color_Public_Static_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664403);
		NativeMethodInfoPtr_get_wireframe_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664404);
		NativeMethodInfoPtr_SetViewMatrix_Private_Static_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664405);
		NativeMethodInfoPtr_set_modelview_Public_Static_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664406);
		NativeMethodInfoPtr_PushMatrix_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664407);
		NativeMethodInfoPtr_PopMatrix_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664408);
		NativeMethodInfoPtr_LoadOrtho_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664409);
		NativeMethodInfoPtr_LoadProjectionMatrix_Public_Static_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664410);
		NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664411);
		NativeMethodInfoPtr_GLLoadPixelMatrixScript_Private_Static_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664412);
		NativeMethodInfoPtr_LoadPixelMatrix_Public_Static_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664413);
		NativeMethodInfoPtr_Begin_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664414);
		NativeMethodInfoPtr_End_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664415);
		NativeMethodInfoPtr_GLClear_Private_Static_Void_Boolean_Boolean_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664416);
		NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664417);
		NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664418);
		NativeMethodInfoPtr_Viewport_Public_Static_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664419);
		NativeMethodInfoPtr_SetViewMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664420);
		NativeMethodInfoPtr_LoadProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664421);
		NativeMethodInfoPtr_GetGPUProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_Boolean_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664422);
		NativeMethodInfoPtr_GLClear_Injected_Private_Static_Void_Boolean_Boolean_byref_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664423);
		NativeMethodInfoPtr_Viewport_Injected_Private_Static_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664424);
		VerticesDelegateField = IL2CPP.ResolveICall<VerticesDelegate>("UnityEngine.GL::Vertices");
		MultiTexCoord3DelegateField = IL2CPP.ResolveICall<MultiTexCoord3Delegate>("UnityEngine.GL::MultiTexCoord3");
		set_wireframeDelegateField = IL2CPP.ResolveICall<set_wireframeDelegate>("UnityEngine.GL::set_wireframe");
		get_sRGBWriteDelegateField = IL2CPP.ResolveICall<get_sRGBWriteDelegate>("UnityEngine.GL::get_sRGBWrite");
		set_sRGBWriteDelegateField = IL2CPP.ResolveICall<set_sRGBWriteDelegate>("UnityEngine.GL::set_sRGBWrite");
		get_invertCullingDelegateField = IL2CPP.ResolveICall<get_invertCullingDelegate>("UnityEngine.GL::get_invertCulling");
		set_invertCullingDelegateField = IL2CPP.ResolveICall<set_invertCullingDelegate>("UnityEngine.GL::set_invertCulling");
		FlushDelegateField = IL2CPP.ResolveICall<FlushDelegate>("UnityEngine.GL::Flush");
		RenderTargetBarrierDelegateField = IL2CPP.ResolveICall<RenderTargetBarrierDelegate>("UnityEngine.GL::RenderTargetBarrier");
		IssuePluginEventDelegateField = IL2CPP.ResolveICall<IssuePluginEventDelegate>("UnityEngine.GL::IssuePluginEvent");
		SetRevertBackfacingDelegateField = IL2CPP.ResolveICall<SetRevertBackfacingDelegate>("UnityEngine.GL::SetRevertBackfacing");
		LoadIdentityDelegateField = IL2CPP.ResolveICall<LoadIdentityDelegate>("UnityEngine.GL::LoadIdentity");
		LoadPixelMatrixDelegateField = IL2CPP.ResolveICall<LoadPixelMatrixDelegate>("UnityEngine.GL::LoadPixelMatrix");
		InvalidateStateDelegateField = IL2CPP.ResolveICall<InvalidateStateDelegate>("UnityEngine.GL::InvalidateState");
		GLIssuePluginEventDelegateField = IL2CPP.ResolveICall<GLIssuePluginEventDelegate>("UnityEngine.GL::GLIssuePluginEvent");
		GetWorldViewMatrix_InjectedDelegateField = IL2CPP.ResolveICall<GetWorldViewMatrix_InjectedDelegate>("UnityEngine.GL::GetWorldViewMatrix_Injected");
		MultMatrix_InjectedDelegateField = IL2CPP.ResolveICall<MultMatrix_InjectedDelegate>("UnityEngine.GL::MultMatrix_Injected");
		ClearWithSkybox_InjectedDelegateField = IL2CPP.ResolveICall<ClearWithSkybox_InjectedDelegate>("UnityEngine.GL::ClearWithSkybox_Injected");
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1173161, RefRangeEnd = 1173169, XrefRangeStart = 1173159, XrefRangeEnd = 1173161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Vertex3(float x, float y, float z)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Vertex3_Public_Static_Void_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1173171, RefRangeEnd = 1173175, XrefRangeStart = 1173169, XrefRangeEnd = 1173171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TexCoord3(float x, float y, float z)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TexCoord3_Public_Static_Void_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1173177, RefRangeEnd = 1173181, XrefRangeStart = 1173175, XrefRangeEnd = 1173177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TexCoord2(float x, float y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TexCoord2_Public_Static_Void_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173181, XrefRangeEnd = 1173183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ImmediateColor(float r, float g, float b, float a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&r);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &g;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImmediateColor_Private_Static_Void_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1173185, RefRangeEnd = 1173189, XrefRangeStart = 1173183, XrefRangeEnd = 1173185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Color(Color c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Color_Public_Static_Void_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173194, XrefRangeEnd = 1173196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetViewMatrix(Matrix4x4 m)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&m);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetViewMatrix_Private_Static_Void_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173203, RefRangeEnd = 1173204, XrefRangeStart = 1173201, XrefRangeEnd = 1173203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PushMatrix()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PushMatrix_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173206, RefRangeEnd = 1173207, XrefRangeStart = 1173204, XrefRangeEnd = 1173206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PopMatrix()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopMatrix_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173209, RefRangeEnd = 1173210, XrefRangeStart = 1173207, XrefRangeEnd = 1173209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadOrtho()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadOrtho_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1173212, RefRangeEnd = 1173214, XrefRangeStart = 1173210, XrefRangeEnd = 1173212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadProjectionMatrix(Matrix4x4 mat)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mat);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadProjectionMatrix_Public_Static_Void_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 1173216, RefRangeEnd = 1173244, XrefRangeStart = 1173214, XrefRangeEnd = 1173216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&proj);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderIntoTexture;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173246, RefRangeEnd = 1173247, XrefRangeStart = 1173244, XrefRangeEnd = 1173246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&left);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bottom;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &top;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GLLoadPixelMatrixScript_Private_Static_Void_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173246, RefRangeEnd = 1173247, XrefRangeStart = 1173246, XrefRangeEnd = 1173247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadPixelMatrix(float left, float right, float bottom, float top)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&left);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bottom;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &top;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadPixelMatrix_Public_Static_Void_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1173249, RefRangeEnd = 1173251, XrefRangeStart = 1173247, XrefRangeEnd = 1173249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Begin(int mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Begin_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1173253, RefRangeEnd = 1173255, XrefRangeStart = 1173251, XrefRangeEnd = 1173253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void End()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_End_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173255, XrefRangeEnd = 1173257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&clearDepth);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearColor;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &backgroundColor;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GLClear_Private_Static_Void_Boolean_Boolean_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173259, RefRangeEnd = 1173260, XrefRangeStart = 1173257, XrefRangeEnd = 1173259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Clear(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&clearDepth);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearColor;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &backgroundColor;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1173262, RefRangeEnd = 1173265, XrefRangeStart = 1173260, XrefRangeEnd = 1173262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Clear(bool clearDepth, bool clearColor, Color backgroundColor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clearDepth);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearColor;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &backgroundColor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1173267, RefRangeEnd = 1173269, XrefRangeStart = 1173265, XrefRangeEnd = 1173267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Viewport(Rect pixelRect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pixelRect);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Viewport_Public_Static_Void_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173269, XrefRangeEnd = 1173271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetViewMatrix_Injected([In] ref Matrix4x4 m)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref m);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetViewMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173271, XrefRangeEnd = 1173273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadProjectionMatrix_Injected([In] ref Matrix4x4 mat)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref mat);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173273, XrefRangeEnd = 1173275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetGPUProjectionMatrix_Injected([In] ref Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref proj);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderIntoTexture;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGPUProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_Boolean_byref_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173275, XrefRangeEnd = 1173277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GLClear_Injected(bool clearDepth, bool clearColor, [In] ref Color backgroundColor, float depth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&clearDepth);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearColor;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref backgroundColor);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GLClear_Injected_Private_Static_Void_Boolean_Boolean_byref_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173277, XrefRangeEnd = 1173279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Viewport_Injected([In] ref Rect pixelRect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref pixelRect);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Viewport_Injected_Private_Static_Void_byref_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GL(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void Vertex(Vector3 v)
	{
		Vertex3(v.x, v.y, v.z);
	}

	public unsafe static void Vertices(Vector3* v, Vector3* coords, Vector4* colors, int length)
	{
		VerticesDelegateField((nint)v, (nint)coords, (nint)colors, length);
	}

	public static void TexCoord(Vector3 v)
	{
		TexCoord3(v.x, v.y, v.z);
	}

	public static void MultiTexCoord3(int unit, float x, float y, float z)
	{
		MultiTexCoord3DelegateField(unit, x, y, z);
	}

	public static void MultiTexCoord(int unit, Vector3 v)
	{
		MultiTexCoord3(unit, v.x, v.y, v.z);
	}

	public static void MultiTexCoord2(int unit, float x, float y)
	{
		MultiTexCoord3(unit, x, y, 0f);
	}

	public static void Flush()
	{
		FlushDelegateField();
	}

	public static void RenderTargetBarrier()
	{
		RenderTargetBarrierDelegateField();
	}

	public static Matrix4x4 GetWorldViewMatrix()
	{
		GetWorldViewMatrix_Injected(out var ret);
		return ret;
	}

	public static void MultMatrix(Matrix4x4 m)
	{
		MultMatrix_Injected(ref m);
	}

	public static void IssuePluginEvent(int eventID)
	{
		IssuePluginEventDelegateField(eventID);
	}

	public static void SetRevertBackfacing(bool revertBackFaces)
	{
		SetRevertBackfacingDelegateField(revertBackFaces);
	}

	public static void LoadIdentity()
	{
		LoadIdentityDelegateField();
	}

	public static void LoadPixelMatrix()
	{
		LoadPixelMatrixDelegateField();
	}

	public static void InvalidateState()
	{
		InvalidateStateDelegateField();
	}

	public static void GLIssuePluginEvent(System.IntPtr callback, int eventID)
	{
		GLIssuePluginEventDelegateField(callback, eventID);
	}

	public static void IssuePluginEvent(System.IntPtr callback, int eventID)
	{
		if (callback == Il2CppSystem.IntPtr.Zero)
		{
			throw new Il2CppSystem.ArgumentException("Null callback specified.", "callback");
		}
		GLIssuePluginEvent(callback, eventID);
	}

	public static void ClearWithSkybox(bool clearDepth, Camera camera)
	{
		ClearWithSkybox_Injected(clearDepth, Object.MarshalledUnityObject.Marshal(camera));
	}

	public unsafe static void GetWorldViewMatrix_Injected(out Matrix4x4 ret)
	{
		GetWorldViewMatrix_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void MultMatrix_Injected([In] ref Matrix4x4 m)
	{
		MultMatrix_InjectedDelegateField((nint)Unsafe.AsPointer(ref m));
	}

	public static void ClearWithSkybox_Injected(bool clearDepth, System.IntPtr camera)
	{
		ClearWithSkybox_InjectedDelegateField(clearDepth, camera);
	}
}
