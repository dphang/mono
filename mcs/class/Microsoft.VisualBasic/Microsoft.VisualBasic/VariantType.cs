//
// VariantType.cs
//
// Author:
//   Chris J Breisch (cjbreisch@altavista.net)
//
// (C) 2002 Chris J Breisch
//
namespace Microsoft.VisualBasic {
	public enum VariantType : int {
		Empty = 0,
		Null = 1,
		Short = 2,
		Integer = 3,
		Single = 4,
		Double = 5,
		Currency = 6,
		Date = 7,
		String = 8,
		Object = 9,
		Error = 10,
		Boolean = 11,
		Variant = 12,
		DataObject = 13,
		Decimal = 14,
		Byte = 17,
		Char = 18,
		Long = 20,
		UserDefinedType = 36,
		Array = 8192,
		ObjectArray = 8201
	};
}
