using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Unity.Collections;

[Token(Token = "0x2000055")]
[GenerateTestsForBurstCompatibility]
public static class NativeSortExtension
{
	[Token(Token = "0x2000056")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
	public struct DefaultComparer<T> : IComparer<T> where T : IComparable<T>
	{
		[Token(Token = "0x6000155")]
		public int Compare(T x, T y)
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000145")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(DefaultComparer<int>)
	})]
	public unsafe static void Sort<T, U>(T* array, int length, U comp) where T : struct where U : IComparer<T>
	{
	}

	[Token(Token = "0x6000146")]
	[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(DefaultComparer<int>)
	})]
	public unsafe static SortJob<T, U> SortJob<T, U>(T* array, int length, U comp) where T : struct where U : IComparer<T>
	{
		return default(SortJob<T, U>);
	}

	[Token(Token = "0x6000147")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(DefaultComparer<int>)
	})]
	public unsafe static int BinarySearch<T, U>(T* ptr, int length, T value, U comp) where T : struct where U : IComparer<T>
	{
		return default(int);
	}

	[Token(Token = "0x6000148")]
	[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[] { typeof(int) })]
	public static SortJob<T, DefaultComparer<T>> SortJob<T>(this NativeArray<T> array) where T : struct, IComparable<T>
	{
		return default(SortJob<T, DefaultComparer<T>>);
	}

	[Token(Token = "0x6000149")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
	public static int BinarySearch<T>(this NativeArray<T> array, T value) where T : struct, IComparable<T>
	{
		return default(int);
	}

	[Token(Token = "0x600014A")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(DefaultComparer<int>)
	})]
	public static int BinarySearch<T, U>(this NativeArray<T> array, T value, U comp) where T : struct where U : IComparer<T>
	{
		return default(int);
	}

	[Token(Token = "0x600014B")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
	public static int BinarySearch<T>(this NativeArray<T>.ReadOnly array, T value) where T : struct, IComparable<T>
	{
		return default(int);
	}

	[Token(Token = "0x600014C")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(DefaultComparer<int>)
	})]
	public static int BinarySearch<T, U>(this NativeArray<T>.ReadOnly array, T value, U comp) where T : struct where U : IComparer<T>
	{
		return default(int);
	}

	[Token(Token = "0x600014D")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(DefaultComparer<int>)
	})]
	internal unsafe static void IntroSort<T, U>(void* array, int length, U comp) where T : struct where U : IComparer<T>
	{
	}

	[Token(Token = "0x600014E")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(DefaultComparer<int>)
	})]
	internal unsafe static void IntroSort_R<T, U>(void* array, int lo, int hi, int depth, U comp) where T : struct where U : IComparer<T>
	{
	}

	[Token(Token = "0x600014F")]
	private unsafe static void InsertionSort<T, U>(void* array, int lo, int hi, U comp) where T : struct where U : IComparer<T>
	{
	}

	[Token(Token = "0x6000150")]
	private unsafe static int Partition<T, U>(void* array, int lo, int hi, U comp) where T : struct where U : IComparer<T>
	{
		return default(int);
	}

	[Token(Token = "0x6000151")]
	private unsafe static void HeapSort<T, U>(void* array, int lo, int hi, U comp) where T : struct where U : IComparer<T>
	{
	}

	[Token(Token = "0x6000152")]
	private unsafe static void Heapify<T, U>(void* array, int i, int n, int lo, U comp) where T : struct where U : IComparer<T>
	{
	}

	[Token(Token = "0x6000153")]
	private unsafe static void Swap<T>(void* array, int lhs, int rhs) where T : struct
	{
	}

	[Token(Token = "0x6000154")]
	private unsafe static void SwapIfGreaterWithItems<T, U>(void* array, int lhs, int rhs, U comp) where T : struct where U : IComparer<T>
	{
	}
}
