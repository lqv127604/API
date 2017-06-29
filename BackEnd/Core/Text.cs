using System.Text;

namespace Core
{
    public class Text
    {
        /// <summary>
        /// Chuyển CodeName từ Tiếng việt có dấu sang không dấu, khoảng trắng thành -
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string ToCodeName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "";
            }

            string[] charMap = new string[]
            {
                "aAeEoOuUiIdDyY-",
                "áàạảãâấầậẩẫăắằặẳẵ",
                "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
                "éèẹẻẽêếềệểễ",
                "ÉÈẸẺẼÊẾỀỆỂỄ",
                "óòọỏõôốồộổỗơớờợởỡ",
                "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
                "úùụủũưứừựửữ",
                "ÚÙỤỦŨƯỨỪỰỬỮ",
                "íìịỉĩ",
                "ÍÌỊỈĨ",
                "đ",
                "Đ",
                "ýỳỵỷỹ",
                "ÝỲỴỶỸ",
                " "
            };

            for (int i = 1; i < charMap.Length; i++)
            {
                for (int j = 0; j < charMap[i].Length; j++)
                    name = name.Replace(charMap[i][j], charMap[0][i - 1]);
            }
            return name;
        }

        /// <summary>
        /// Chuyển CodeName từ Unicode sang ASCII, tương tự như ToCodeName
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string StripUnicode(string text)
        {
            var bytes = Encoding.Convert(Encoding.Unicode, Encoding.ASCII, Encoding.Unicode.GetBytes(text));
            var chars = Encoding.ASCII.GetChars(bytes);
            var str = new string(chars);

            return str.Replace("?", "").Replace("  ", " ").Replace(" ", "-");
        }
    }
}