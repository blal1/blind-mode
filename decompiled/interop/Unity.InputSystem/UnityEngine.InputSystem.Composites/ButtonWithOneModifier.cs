using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.InputSystem.Composites;

public class ButtonWithOneModifier : InputBindingComposite<float>
{
	[OriginalName("Unity.InputSystem.dll", "", "ModifiersOrder")]
	public enum ModifiersOrder
	{
		Default,
		Ordered,
		Unordered
	}

	private static readonly IntPtr NativeFieldInfoPtr_modifier;

	private static readonly IntPtr NativeFieldInfoPtr_button;

	private static readonly IntPtr NativeFieldInfoPtr_overrideModifiersNeedToBePressedFirst;

	private static readonly IntPtr NativeFieldInfoPtr_modifiersOrder;

	private static readonly IntPtr NativeMethodInfoPtr_ReadValue_Public_Virtual_Single_byref_InputBindingCompositeContext_0;

	private static readonly IntPtr NativeMethodInfoPtr_ModifierIsPressed_Private_Boolean_byref_InputBindingCompositeContext_0;

	private static readonly IntPtr NativeMethodInfoPtr_EvaluateMagnitude_Public_Virtual_Single_byref_InputBindingCompositeContext_0;

	private static readonly IntPtr NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_byref_InputBindingCompositeContext_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int modifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifier);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifier)) = value;
		}
	}

	public unsafe int button
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_button);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_button)) = value;
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

	static ButtonWithOneModifier()
	{
		Il2CppClassPointerStore<ButtonWithOneModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Composites", "ButtonWithOneModifier");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonWithOneModifier>.NativeClassPtr);
		NativeFieldInfoPtr_modifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonWithOneModifier>.NativeClassPtr, "modifier");
		NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonWithOneModifier>.NativeClassPtr, "button");
		NativeFieldInfoPtr_overrideModifiersNeedToBePressedFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonWithOneModifier>.NativeClassPtr, "overrideModifiersNeedToBePressedFirst");
		NativeFieldInfoPtr_modifiersOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonWithOneModifier>.NativeClassPtr, "modifiersOrder");
		NativeMethodInfoPtr_ReadValue_Public_Virtual_Single_byref_InputBindingCompositeContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonWithOneModifier>.NativeClassPtr, 100669110);
		NativeMethodInfoPtr_ModifierIsPressed_Private_Boolean_byref_InputBindingCompositeContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonWithOneModifier>.NativeClassPtr, 100669111);
		NativeMethodInfoPtr_EvaluateMagnitude_Public_Virtual_Single_byref_InputBindingCompositeContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonWithOneModifier>.NativeClassPtr, 100669112);
		NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_byref_InputBindingCompositeContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonWithOneModifier>.NativeClassPtr, 100669113);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonWithOneModifier>.NativeClassPtr, 100669114);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022171, XrefRangeEnd = 1022175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override float ReadValue(ref InputBindingCompositeContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReadValue_Public_Virtual_Single_byref_InputBindingCompositeContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022175, XrefRangeEnd = 1022178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ModifierIsPressed(ref InputBindingCompositeContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModifierIsPressed_Private_Boolean_byref_InputBindingCompositeContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe override float EvaluateMagnitude(ref InputBindingCompositeContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_EvaluateMagnitude_Public_Virtual_Single_byref_InputBindingCompositeContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022178, XrefRangeEnd = 1022182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void FinishSetup(ref InputBindingCompositeContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_byref_InputBindingCompositeContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022182, XrefRangeEnd = 1022185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ButtonWithOneModifier()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonWithOneModifier>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ButtonWithOneModifier(IntPtr pointer)
		: base(pointer)
	{
	}
}
