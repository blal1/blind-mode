using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml;

public class SecureStringHasher : Object
{
	public sealed class HashCodeOfStringDelegate : MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_String_Int32_Int64_0;

		static HashCodeOfStringDelegate()
		{
			Il2CppClassPointerStore<HashCodeOfStringDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, "HashCodeOfStringDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashCodeOfStringDelegate>.NativeClassPtr, 100663395);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_String_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashCodeOfStringDelegate>.NativeClassPtr, 100663396);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901583, XrefRangeEnd = 901587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashCodeOfStringDelegate(Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashCodeOfStringDelegate>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual int Invoke(string s, int sLen, long additionalEntropy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sLen;
			*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &additionalEntropy;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_String_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public HashCodeOfStringDelegate(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator HashCodeOfStringDelegate(System.Func<string, int, long, int> P_0)
		{
			return DelegateSupport.ConvertDelegate<HashCodeOfStringDelegate>((System.Delegate)P_0);
		}

		public static HashCodeOfStringDelegate operator +(HashCodeOfStringDelegate P_0, HashCodeOfStringDelegate P_1)
		{
			return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<HashCodeOfStringDelegate>();
		}

		public static HashCodeOfStringDelegate operator -(HashCodeOfStringDelegate P_0, HashCodeOfStringDelegate P_1)
		{
			object obj = Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<HashCodeOfStringDelegate>();
			}
			return (HashCodeOfStringDelegate)obj;
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_hashCodeDelegate;

	private static readonly System.IntPtr NativeFieldInfoPtr_hashCodeRandomizer;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCodeOfString_Private_Static_Int32_String_Int32_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCodeDelegate_Private_Static_HashCodeOfStringDelegate_0;

	public unsafe static HashCodeOfStringDelegate hashCodeDelegate
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hashCodeDelegate, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashCodeOfStringDelegate>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hashCodeDelegate, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int hashCodeRandomizer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hashCodeRandomizer);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hashCodeRandomizer)) = value;
		}
	}

	static SecureStringHasher()
	{
		Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "SecureStringHasher");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr);
		NativeFieldInfoPtr_hashCodeDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, "hashCodeDelegate");
		NativeFieldInfoPtr_hashCodeRandomizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, "hashCodeRandomizer");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, 100663392);
		NativeMethodInfoPtr_GetHashCodeOfString_Private_Static_Int32_String_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, 100663393);
		NativeMethodInfoPtr_GetHashCodeDelegate_Private_Static_HashCodeOfStringDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, 100663394);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901587, XrefRangeEnd = 901589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SecureStringHasher()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901589, XrefRangeEnd = 901590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(string x, string y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(y);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901590, XrefRangeEnd = 901597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual int GetHashCode(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901597, XrefRangeEnd = 901599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetHashCodeOfString(string key, int sLen, long additionalEntropy)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sLen;
		*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &additionalEntropy;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCodeOfString_Private_Static_Int32_String_Int32_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 901617, RefRangeEnd = 901618, XrefRangeStart = 901599, XrefRangeEnd = 901617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HashCodeOfStringDelegate GetHashCodeDelegate()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCodeDelegate_Private_Static_HashCodeOfStringDelegate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashCodeOfStringDelegate>(intPtr2) : null;
	}

	public SecureStringHasher(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
