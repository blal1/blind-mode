using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema;

public class ForwardAxis : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__topNode;

	private static readonly System.IntPtr NativeFieldInfoPtr__rootNode;

	private static readonly System.IntPtr NativeFieldInfoPtr__isAttribute;

	private static readonly System.IntPtr NativeFieldInfoPtr__isDss;

	private static readonly System.IntPtr NativeFieldInfoPtr__isSelfAxis;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RootNode_Internal_get_DoubleLinkAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TopNode_Internal_get_DoubleLinkAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAttribute_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDss_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSelfAxis_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DoubleLinkAxis_Boolean_0;

	public unsafe DoubleLinkAxis _topNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__topNode);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DoubleLinkAxis>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__topNode)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DoubleLinkAxis _rootNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rootNode);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DoubleLinkAxis>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rootNode)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool _isAttribute
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isAttribute);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isAttribute)) = value;
		}
	}

	public unsafe bool _isDss
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isDss);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isDss)) = value;
		}
	}

	public unsafe bool _isSelfAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isSelfAxis);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isSelfAxis)) = value;
		}
	}

	public unsafe DoubleLinkAxis RootNode
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RootNode_Internal_get_DoubleLinkAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DoubleLinkAxis>(intPtr2) : null;
		}
	}

	public unsafe DoubleLinkAxis TopNode
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TopNode_Internal_get_DoubleLinkAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DoubleLinkAxis>(intPtr2) : null;
		}
	}

	public unsafe bool IsAttribute
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsAttribute_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsDss
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsDss_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsSelfAxis
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsSelfAxis_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static ForwardAxis()
	{
		Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "ForwardAxis");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr);
		NativeFieldInfoPtr__topNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, "_topNode");
		NativeFieldInfoPtr__rootNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, "_rootNode");
		NativeFieldInfoPtr__isAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, "_isAttribute");
		NativeFieldInfoPtr__isDss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, "_isDss");
		NativeFieldInfoPtr__isSelfAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, "_isSelfAxis");
		NativeMethodInfoPtr_get_RootNode_Internal_get_DoubleLinkAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, 100665875);
		NativeMethodInfoPtr_get_TopNode_Internal_get_DoubleLinkAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, 100665876);
		NativeMethodInfoPtr_get_IsAttribute_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, 100665877);
		NativeMethodInfoPtr_get_IsDss_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, 100665878);
		NativeMethodInfoPtr_get_IsSelfAxis_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, 100665879);
		NativeMethodInfoPtr__ctor_Public_Void_DoubleLinkAxis_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, 100665880);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 920076, RefRangeEnd = 920077, XrefRangeStart = 920066, XrefRangeEnd = 920076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ForwardAxis(DoubleLinkAxis axis, bool isdesorself)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)axis);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isdesorself;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DoubleLinkAxis_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ForwardAxis(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
