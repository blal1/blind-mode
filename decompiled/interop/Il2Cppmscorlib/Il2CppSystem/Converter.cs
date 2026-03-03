using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem;

public sealed class Converter<TInput, TOutput> : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TOutput_TInput_0;

	static Converter()
	{
		Il2CppClassPointerStore<Converter<TInput, TOutput>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Converter`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[2]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInput>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOutput>.NativeClassPtr))
		})).TypeHandle.value);
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter<TInput, TOutput>>.NativeClassPtr, 100664244);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_TOutput_TInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter<TInput, TOutput>>.NativeClassPtr, 100664245);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 718192, RefRangeEnd = 718194, XrefRangeStart = 718189, XrefRangeEnd = 718192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Converter(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Converter<TInput, TOutput>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual TOutput Invoke(TInput input)
	{
		//IL_004c->IL004f: Incompatible stack types: I vs Ref
		//IL_003f->IL004f: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref TInput reference;
		if (!typeof(TInput).IsValueType)
		{
			object obj = input;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref input;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_TOutput_TInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TOutput>(intPtr2, false, true);
	}

	public Converter(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator Converter<TInput, TOutput>(System.Func<TInput, TOutput> P_0)
	{
		return DelegateSupport.ConvertDelegate<Converter<TInput, TOutput>>((System.Delegate)P_0);
	}

	public static Converter<TInput, TOutput> operator +(Converter<TInput, TOutput> P_0, Converter<TInput, TOutput> P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<Converter<TInput, TOutput>>();
	}

	public static Converter<TInput, TOutput> operator -(Converter<TInput, TOutput> P_0, Converter<TInput, TOutput> P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<Converter<TInput, TOutput>>();
		}
		return (Converter<TInput, TOutput>)obj;
	}
}
