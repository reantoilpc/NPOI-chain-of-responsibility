using System;
using NPOI.SS.UserModel;

namespace src
{
    public static class XSSFRowExtension
    {
        public static ICell CreateCell<TEnum>(this IRow source, TEnum @enum) where TEnum : Enum
        {
            return source.CreateCell(Convert.ToInt32(@enum));
        }

        public static IRow CreateCellValue<TEnum>(this IRow source, TEnum @enum, string value) where TEnum : Enum
        {
            source.CreateCell(@enum).SetCellValue(value);
            return source;
        }

        public static IRow CreateCellValue<TEnum>(this IRow source, TEnum @enum, double value) where TEnum : Enum
        {
            source.CreateCell(@enum).SetCellValue(value);
            return source;
        }
    }
}