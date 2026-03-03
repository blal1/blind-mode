namespace UnityEngine.Assertions.Must;

public static class MustExtensions
{
	public static void MustBeTrue(bool value)
	{
		Assert.IsTrue(value);
	}

	public static void MustBeTrue(bool value, string message)
	{
		Assert.IsTrue(value, message);
	}

	public static void MustBeFalse(bool value)
	{
		Assert.IsFalse(value);
	}

	public static void MustBeFalse(bool value, string message)
	{
		Assert.IsFalse(value, message);
	}

	public static void MustBeApproximatelyEqual(float actual, float expected)
	{
		Assert.AreApproximatelyEqual(actual, expected);
	}

	public static void MustBeApproximatelyEqual(float actual, float expected, string message)
	{
		Assert.AreApproximatelyEqual(actual, expected, message);
	}

	public static void MustBeApproximatelyEqual(float actual, float expected, float tolerance)
	{
		Assert.AreApproximatelyEqual(actual, expected, tolerance);
	}

	public static void MustBeApproximatelyEqual(float actual, float expected, float tolerance, string message)
	{
		Assert.AreApproximatelyEqual(expected, actual, tolerance, message);
	}

	public static void MustNotBeApproximatelyEqual(float actual, float expected)
	{
		Assert.AreNotApproximatelyEqual(expected, actual);
	}

	public static void MustNotBeApproximatelyEqual(float actual, float expected, string message)
	{
		Assert.AreNotApproximatelyEqual(expected, actual, message);
	}

	public static void MustNotBeApproximatelyEqual(float actual, float expected, float tolerance)
	{
		Assert.AreNotApproximatelyEqual(expected, actual, tolerance);
	}

	public static void MustNotBeApproximatelyEqual(float actual, float expected, float tolerance, string message)
	{
		Assert.AreNotApproximatelyEqual(expected, actual, tolerance, message);
	}

	public static void MustBeEqual<T>(T actual, T expected)
	{
		Assert.AreEqual(actual, expected);
	}

	public static void MustBeEqual<T>(T actual, T expected, string message)
	{
		Assert.AreEqual(expected, actual, message);
	}

	public static void MustNotBeEqual<T>(T actual, T expected)
	{
		Assert.AreNotEqual(actual, expected);
	}

	public static void MustNotBeEqual<T>(T actual, T expected, string message)
	{
		Assert.AreNotEqual(expected, actual, message);
	}

	public static void MustBeNull<T>(T expected) where T : class
	{
		Assert.IsNull(expected);
	}

	public static void MustBeNull<T>(T expected, string message) where T : class
	{
		Assert.IsNull(expected, message);
	}

	public static void MustNotBeNull<T>(T expected) where T : class
	{
		Assert.IsNotNull(expected);
	}

	public static void MustNotBeNull<T>(T expected, string message) where T : class
	{
		Assert.IsNotNull(expected, message);
	}
}
