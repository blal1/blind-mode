using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.InputSystem.Composites;

public class TwoModifiersComposite : InputBindingComposite
{
	[OriginalName("Unity.InputSystem.dll", "", "ModifiersOrder")]
	public enum ModifiersOrder
	{
		Default,
		Ordered,
		Unordered
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_modifier1;

	private static readonly System.IntPtr NativeFieldInfoPtr_modifier2;

	private static readonly System.IntPtr NativeFieldInfoPtr_binding;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideModifiersNeedToBePressedFirst;

	private static readonly System.IntPtr NativeFieldInfoPtr_modifiersOrder;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ValueSizeInBytes;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ValueType;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BindingIsButton;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_valueType_Public_Virtual_get_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_valueSizeInBytes_Public_Virtual_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateMagnitude_Public_Virtual_Single_byref_InputBindingCompositeContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValue_Public_Virtual_Void_byref_InputBindingCompositeContext_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModifiersArePressed_Private_Boolean_byref_InputBindingCompositeContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_byref_InputBindingCompositeContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueAsObject_Public_Virtual_Object_byref_InputBindingCompositeContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int modifier1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifier1);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifier1)) = value;
		}
	}

	public unsafe int modifier2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifier2);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifier2)) = value;
		}
	}

	public unsafe int binding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binding);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binding)) = value;
		}
	}

	public unsafe bool overrideModifiersNeedToBePressedFirst
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideModifiersNeedToBePressedFirst);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideModifiersNeedToBePressedFirst)) = value;
		}
	}

	public unsafe ModifiersOrder modifiersOrder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifiersOrder);
			return *(ModifiersOrder*)num;
		}
		set
		{
			*(ModifiersOrder*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifiersOrder)) = value;
		}
	}

	public unsafe int m_ValueSizeInBytes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ValueSizeInBytes);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ValueSizeInBytes)) = value;
		}
	}

	public unsafe Il2CppSystem.Type m_ValueType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ValueType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ValueType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_BindingIsButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BindingIsButton);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BindingIsButton)) = value;
		}
	}

	public unsafe override Il2CppSystem.Type valueType
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 42604, RefRangeEnd = 42610, XrefRangeStart = 42604, XrefRangeEnd = 42610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_valueType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
		}
	}

	public unsafe override int valueSizeInBytes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_valueSizeInBytes_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static TwoModifiersComposite()
	{
		Il2CppClassPointerStore<TwoModifiersComposite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Composites", "TwoModifiersComposite");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwoModifiersComposite>.NativeClassPtr);
		NativeFieldInfoPtr_modifier1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoModifiersComposite>.NativeClassPtr, "modifier1");
		NativeFieldInfoPtr_modifier2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoModifiersComposite>.NativeClassPtr, "modifier2");
		NativeFieldInfoPtr_binding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoModifiersComposite>.NativeClassPtr, "binding");
		NativeFieldInfoPtr_overrideModifiersNeedToBePressedFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoModifiersComposite>.NativeClassPtr, "overrideModifiersNeedToBePressedFirst");
		NativeFieldInfoPtr_modifiersOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoModifiersComposite>.NativeClassPtr, "modifiersOrder");
		NativeFieldInfoPtr_m_ValueSizeInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoModifiersComposite>.NativeClassPtr, "m_ValueSizeInBytes");
		NativeFieldInfoPtr_m_ValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoModifiersComposite>.NativeClassPtr, "m_ValueType");
		NativeFieldInfoPtr_m_BindingIsButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoModifiersComposite>.NativeClassPtr, "m_BindingIsButton");
		NativeMethodInfoPtr_get_valueType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoModifiersComposite>.NativeClassPtr, 100669129);
		NativeMethodInfoPtr_get_valueSizeInBytes_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoModifiersComposite>.NativeClassPtr, 100669130);
		NativeMethodInfoPtr_EvaluateMagnitude_Public_Virtual_Single_byref_InputBindingCompositeContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoModifiersComposite>.NativeClassPtr, 100669131);
		NativeMethodInfoPtr_ReadValue_Public_Virtual_Void_byref_InputBindingCompositeContext_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoModifiersComposite>.NativeClassPtr, 100669132);
		NativeMethodInfoPtr_ModifiersArePressed_Private_Boolean_byref_InputBindingCompositeContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoModifiersComposite>.NativeClassPtr, 100669133);
		NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_byref_InputBindingCompositeContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoModifiersComposite>.NativeClassPtr, 100669134);
		NativeMethodInfoPtr_ReadValueAsObject_Public_Virtual_Object_byref_InputBindingCompositeContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoModifiersComposite>.NativeClassPtr, 100669135);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoModifiersComposite>.NativeClassPtr, 100669136);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022253, XrefRangeEnd = 1022254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override float EvaluateMagnitude(ref InputBindingCompositeContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_EvaluateMagnitude_Public_Virtual_Single_byref_InputBindingCompositeContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022254, XrefRangeEnd = 1022258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = buffer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReadValue_Public_Virtual_Void_byref_InputBindingCompositeContext_ptr_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1022259, RefRangeEnd = 1022261, XrefRangeStart = 1022258, XrefRangeEnd = 1022259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ModifiersArePressed(ref InputBindingCompositeContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModifiersArePressed_Private_Boolean_byref_InputBindingCompositeContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022261, XrefRangeEnd = 1022266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void FinishSetup(ref InputBindingCompositeContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_byref_InputBindingCompositeContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022266, XrefRangeEnd = 1022269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Il2CppSystem.Object ReadValueAsObject(ref InputBindingCompositeContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReadValueAsObject_Public_Virtual_Object_byref_InputBindingCompositeContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TwoModifiersComposite()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwoModifiersComposite>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TwoModifiersComposite(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
